using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace SematimeGlue
{
    public class SematimeGlue
    {
        private string _baseUrl = "https://apis.sematime.com/v1/";
        private string _token;
        private string _accountId;

        public SematimeGlue()
        {
        }

        public SematimeGlue(string token, string accountId)
        {
            
            _token = token;
            _accountId = accountId;
        }
        public bool SendMessage(string message, string recipients, out string responseStatus, out string responseMessage)
        {
            try
            {
                var obj = new JObject
                {
                    ["text"] = message,
                    ["recipients"] = recipients
                };
                var respose = PostRequest(obj);
                var resp = respose.Split('~');
                responseStatus = respose[0].ToString();
                responseMessage = respose[1].ToString();
                return true;
            }
            catch (Exception e)
            {
                responseStatus = "-1";
                responseMessage = e.Message;
                return false;
            }
        }

        private string PostRequest(JObject data)
        {
            var client = new RestClient($"{_baseUrl}{_accountId}");
            var request = new RestRequest("/messages/single", Method.POST);

            request.AddParameter("text/xml", data.ToString(), ParameterType.RequestBody);
            request.AddHeader("AuthToken", _token);
            request.AddHeader("ContentType","application/json");

            IRestResponse response = client.Execute(request);
            var content = $"{response.StatusCode}~{response.Content}";
            return content;
        }
    }
}
