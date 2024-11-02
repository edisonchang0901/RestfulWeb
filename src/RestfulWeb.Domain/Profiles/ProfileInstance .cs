using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulWeb.Domain.Profiles
{
    public static class ProfileInstance
    {
        public const string RDS_CONNECTIONSRINGS_KEY = "AccountMain";
        public static string RDS_ConnectionStrings { get; set; } = string.Empty;
    }
}
