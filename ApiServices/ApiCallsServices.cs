
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Api_Integrated_Test
{
    public class ApiCallsServices
    {
        HttpClient client;// = new HttpClient();
        string basePath = "https://apimanager.iraneit.com/BimeApiManager";
        string baseLogString = "ApiManager";
        int timeOut = 30;

        public ApiCallsServices(string basePath)
        {

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            // Pass the handler to httpclient(from you are calling api)
            client = new HttpClient(clientHandler);
            client.BaseAddress = new Uri(basePath);
            client.Timeout = TimeSpan.FromSeconds(timeOut);           
        }

        public ApiCallsServices()
        {
            client.BaseAddress = new Uri(basePath);
            client.Timeout = TimeSpan.FromSeconds(timeOut);

        }

        public async Task ApimanagerAppLogin(string AppName = "CIIRegCargoPorposal", string Secret = "aA@12345")
        {
            client.DefaultRequestHeaders.Remove("appToken");
            client.DefaultRequestHeaders.Remove("appToken");
            client.DefaultRequestHeaders.Remove("UserName");
            client.DefaultRequestHeaders.Remove("Password");
            client.DefaultRequestHeaders.Remove("appname");
            client.DefaultRequestHeaders.Remove("secret");
            client.DefaultRequestHeaders.Remove("authenticationToken");
            client.DefaultRequestHeaders.Remove("ContractId");
            client.DefaultRequestHeaders.Remove("CorpId");
            client.DefaultRequestHeaders.Remove("Location");
            //////////////////////
            AthenticationData.appTokenFlag = false;
           
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("appname", AppName);
            client.DefaultRequestHeaders.Add("secret", Secret);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                response = client.PostAsync("api/EITAuthentication/GetAppToken", null).GetAwaiter().GetResult();
                AthenticationData.appToken = response.Headers.GetValues("appToken").First();
                AthenticationData.appTokenFlag = true;
            }
            catch (Exception e)
            {
              
            }
               
           
        }
        public async Task ApimanagerClientLogin(string UserName = "CIICargoUser", string Password = "C11C@rg0123")
        {
            client.DefaultRequestHeaders.Remove("appToken");
            client.DefaultRequestHeaders.Remove("appToken");
            client.DefaultRequestHeaders.Remove("UserName");
            client.DefaultRequestHeaders.Remove("Password");
            client.DefaultRequestHeaders.Remove("appname");
            client.DefaultRequestHeaders.Remove("secret");
            client.DefaultRequestHeaders.Remove("authenticationToken");
            client.DefaultRequestHeaders.Remove("ContractId");
            client.DefaultRequestHeaders.Remove("CorpId");
            client.DefaultRequestHeaders.Remove("Location");

            //////////
            AthenticationData.authenticationTokenFlag = false;
            
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("UserName", UserName);
            client.DefaultRequestHeaders.Add("Password", Password);
            client.DefaultRequestHeaders.Add("appToken", AthenticationData.appToken);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                response = client.PostAsync("api/EITAuthentication/Login", null).GetAwaiter().GetResult();

                AthenticationData.authenticationToken = response.Headers.GetValues("authenticationToken").First();
                AthenticationData.authenticationTokenFlag = true;
            }
            catch (Exception e)
            {
                
            }
        }

        public HttpResponseMessage CargoPaliciesCall(string ContractId, string CorpId, string Location , string JsonInput)
        {
            
            client.DefaultRequestHeaders.Remove("appToken");
            client.DefaultRequestHeaders.Remove("UserName");
            client.DefaultRequestHeaders.Remove("Password");
            client.DefaultRequestHeaders.Remove("appname");
            client.DefaultRequestHeaders.Remove("secret");
            client.DefaultRequestHeaders.Remove("authenticationToken");
            client.DefaultRequestHeaders.Remove("ContractId");
            client.DefaultRequestHeaders.Remove("CorpId");
            client.DefaultRequestHeaders.Remove("Location");

            ////////////////
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("authenticationToken", AthenticationData.authenticationToken);
            client.DefaultRequestHeaders.Add("ContractId", ContractId);
            client.DefaultRequestHeaders.Add("CorpId", CorpId);
            client.DefaultRequestHeaders.Add("Location", Location);
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                var content = new StringContent(JsonInput, Encoding.UTF8, "application/json");

                response = client.PostAsync("Api/BimeApi/v2.0/cargo/cii/cargo-proposals",content).GetAwaiter().GetResult();

            }
            catch
            {
                response = new HttpResponseMessage(HttpStatusCode.RequestTimeout);
            }
            return response;
            ////////LOg All Response Headers
        }

    }
}
