using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Threading.Tasks;
using ADPasswordManager.DataProvider;
using ADPasswordManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADPasswordManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private ILawyerDataProvider lawyerDataProvider;

        public AccountController(ILawyerDataProvider lawyerDataProvider)
        {
            this.lawyerDataProvider = lawyerDataProvider;
        }


        [HttpPost("changepassword/{username}/{password}/{oldpassword}/{ac}")]
        public async Task<IActionResult> PostChangePasswordAsync(string username, string password, string oldpassword, string ac)
        {
            var response = new PasswordResponse();
            try
            {
                var lawyer = await lawyerDataProvider.GetLawyer(username);

                if (lawyer == null)
                {
                    response.Error = true;
                    response.Message = "Could not find a Lawyer with Username: " + username;
                    return BadRequest(response);
                }

                if (lawyer.ActivationCode != ac)
                {
                    response.Error = true;
                    response.Message = "Invalid token for user: " + username;
                    return BadRequest(response);
                }

                using (var context = new PrincipalContext(ContextType.Domain))
                {
                    using (var user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, username))
                    {
                        user.ChangePassword(oldpassword, password);
                        user.Save();
                        response.Success = true;
                        response.Message = "Password changed successfully.";
                        return Ok(response);
                    }
                }
            }
            catch (Exception e)
            {
                response.Error = true;
                response.Message = e.Message;
                response.StackTrace = e.StackTrace;
                return BadRequest(response);
            }
        }

        [HttpPost("resetpassword/{username}/{password}/{otp}")]
        public async Task<IActionResult> PostResetPasswordAsync(string username, string password, string otp)
        {
            var response = new PasswordResponse();
            try
            {
                var lawyer = await lawyerDataProvider.GetLawyer(username);

                if (lawyer == null)
                {
                    response.Error = true;
                    response.Message = "Could not find a Lawyer with Username: " + username;
                    return BadRequest(response);
                }

                if (lawyer.Otp != otp)
                {
                    response.Error = true;
                    response.Message = "Invalid reset token for user: " + username;
                    return BadRequest(response);
                }

                using (var context = new PrincipalContext(ContextType.Domain))
                {
                    using (var user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, username))
                    {
                        user.SetPassword(password);
                        user.Save();
                        response.Success = true;
                        response.Message = "Password reset successfully.";
                        return Ok(response);
                    }
                }
            }
            catch (Exception e)
            {
                response.Error = true;
                response.Message = e.Message;
                response.StackTrace = e.StackTrace;
                return BadRequest(response);
            }
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Lawyers>> GetAllLawyers()
        {
            return await this.lawyerDataProvider.GetLawyers();
        }


        //Remove before deploy to production
        [HttpGet("{Username}")]
        public async Task<Lawyers> GetLawyerByUsername(string Username)
        {
            return await this.lawyerDataProvider.GetLawyer(Username);
        }
    }
}