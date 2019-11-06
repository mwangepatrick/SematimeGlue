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
            string _token = "123115473f5546b4a6efdb64439fcae7";
            string _accountId = "1523894892893";
            SematimeGlue.SematimeGlue semaGlue = new SematimeGlue.SematimeGlue(_token,_accountId);
            semaGlue.SendMessage($"Best Solution Providers Yet.", "0711328001,0705814626", out string responseCode, out string responseMessage);
        }
    }
}
