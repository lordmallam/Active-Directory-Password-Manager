using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADPasswordManager.Models;

namespace ADPasswordManager.DataProvider
{
    public interface ILawyerDataProvider
    {

        Task<IEnumerable<Lawyers>> GetLawyers();

        Task<Lawyers> GetLawyer(string Username);
    }
}
