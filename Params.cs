using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADPasswordManager
{
    public class Params
    {
        public const String ADPath = "LDAP://52.178.29.245/DC=legalmail,DC=test";
        public const String ADContainer = "DC=legalmail,DC=test";
        public const String ADAdmin = "legalmail\\isaac";
        public const String ADPassword = "P@$$w0rd1";
        public const String ADServer = "52.178.29.245";
        public const String ADDomain = "legalmail.test";
        public const String sqlConnectionString = "Data Source=52.166.197.173;" +
            "Initial Catalog=NJCLegalMail;Integrated Security=False;User ID=testlogin;" +
            "Password=Word_pass1;MultipleActiveResultSets=True;Connect Timeout=30;" +
            "Application Name=EntityFramework";
    }
}
