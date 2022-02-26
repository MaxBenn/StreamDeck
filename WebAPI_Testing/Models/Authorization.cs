using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_Testing.Models
{
    public static class Authorization
    {
        private static string _apiToken;

        public static string ApiToken
        {
            get { return _apiToken; }
            set { _apiToken = value; }
        }


    }
}
