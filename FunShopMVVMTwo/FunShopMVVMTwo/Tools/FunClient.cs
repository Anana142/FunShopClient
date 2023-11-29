using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FunShopMVVMTwo.Tools
{
    public class FunClient
    {
        private static HttpClient httpClient;

        public static HttpClient instance
        {
            get
            {
                if (httpClient == null)
                {
                    httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri("https://localhost:7209/api/");
                }
                return httpClient;

            }
            set { httpClient = value; }
        }
    }
}
