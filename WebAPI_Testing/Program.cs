using System;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Testing.Models;
using WebAPI_Testing.Models.Smartlock;

namespace WebAPI_Testing
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Authorization.ApiToken = "4c9f06a8fec13b54f8e40a1221f90de9057c29fdff59ac58c6f25c85ed08fc3d47d543a7631d4b92";

            var smartlocks = await Api.Smartlock.GetSmartlocksAsync();

            var smartlock = smartlocks.ToList().FirstOrDefault();

        }
    }
}
