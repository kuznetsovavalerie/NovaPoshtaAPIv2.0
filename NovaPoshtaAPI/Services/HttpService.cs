using Newtonsoft.Json;
using NovaPoshtaAPI.HttpModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshtaAPI.Services
{
    internal class HttpService
    {
        private string _apiKey;
        private string _host = "https://api.novaposhta.ua";

        // json or xml possible
        private string _format = "json";
        private string _apiVersion = "v2.0";

        public HttpService(string apiKey)
        {
            this._apiKey = apiKey;
        }
                
        public async Task<T> GetData<T>(string path, BaseSearchRequest request) where T : BaseSearchResponse
        {
            request.apiKey = this._apiKey;
            var json = JsonConvert.SerializeObject(request);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var url = $"{this._host}/{this._apiVersion}/{this._format}/{path}";

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, stringContent);
                var responseString = await response.Content.ReadAsStringAsync();
                var serialized = JsonConvert.DeserializeObject<T>(responseString);

                if (!serialized.success)
                {
                    throw new Exception(serialized.errors[0]);
                }

                return serialized;
            }
        }
    }
}
