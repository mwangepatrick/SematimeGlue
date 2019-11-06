using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string _token = "121313212313132";
            string _accountId = "21321321321321";
            SematimeGlue.SematimeGlue semaGlue = new SematimeGlue.SematimeGlue(_token,_accountId);
            semaGlue.SendMessage($"Best Solution Providers Yet.", "0711000000", out string responseCode, out string responseMessage);
        }
    }
}
