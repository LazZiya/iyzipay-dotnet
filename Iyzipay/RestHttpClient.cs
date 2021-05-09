using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Iyzipay
{
    public class RestHttpClient
    {
        private static readonly HttpClient HttpClient;
        static RestHttpClient()
        {
#if !NETSTANDARD
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
#endif
            
            HttpClient = new HttpClient();
        }

        public static RestHttpClient Create()
        {
            return new RestHttpClient();
        }

        private async Task<T> ReadResponseMessageAsync<T>(HttpResponseMessage httpResponseMessage)
        {
            var content = await httpResponseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        // sync
        public T Get<T>(String url)
        {
            HttpResponseMessage httpResponseMessage = HttpClient.GetAsync(url).Result; 
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }
        
        // Async
        public async Task<T> GetAsync<T>(String url)
        {
            HttpResponseMessage httpResponseMessage = await HttpClient.GetAsync(url);
            return await ReadResponseMessageAsync<T>(httpResponseMessage);
        }
        
        // sync
        public T Get<T>(String url, Dictionary<string,string> headers)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get, 
                RequestUri = new Uri(url)
            };
            
            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }
            
            HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result; 
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }
        
        // Async
        public async Task<T> GetAsync<T>(String url, Dictionary<string,string> headers)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get, 
                RequestUri = new Uri(url)
            };
            
            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }
            
            HttpResponseMessage httpResponseMessage = await HttpClient.SendAsync(requestMessage);
            return await ReadResponseMessageAsync<T>(httpResponseMessage);
        }

        // sync
        public T Post<T>(String url, Dictionary<string,string> headers, BaseRequest request)
        { 
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post, 
                RequestUri = new Uri(url), 
                Content = JsonBuilder.ToJsonString(request)
            };

            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }
        
        // Async
        public async Task<T> PostAsync<T>(String url, Dictionary<string,string> headers, BaseRequest request)
        { 
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post, 
                RequestUri = new Uri(url), 
                Content = JsonBuilder.ToJsonString(request)
            };

            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            HttpResponseMessage httpResponseMessage = await HttpClient.SendAsync(requestMessage);
            return await ReadResponseMessageAsync<T>(httpResponseMessage);
        }

        // sync
        public T Delete<T>(String url, Dictionary<string, string> headers, BaseRequest request)
        { 
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url),
                Content = JsonBuilder.ToJsonString(request)
            };

            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result; 
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }
        
        // Async
        public async Task<T> DeleteAsync<T>(String url, Dictionary<string, string> headers, BaseRequest request)
        { 
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url),
                Content = JsonBuilder.ToJsonString(request)
            };

            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            HttpResponseMessage httpResponseMessage = await HttpClient.SendAsync(requestMessage);
            return await ReadResponseMessageAsync<T>(httpResponseMessage);
        }

        // sync
        public T Put<T>(String url, Dictionary<string, string> headers, BaseRequest request)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Put, 
                RequestUri = new Uri(url), 
                Content = JsonBuilder.ToJsonString(request)
            };

            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            HttpResponseMessage httpResponseMessage = HttpClient.SendAsync(requestMessage).Result; 
            return JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
        }
        
        // Async
        public async Task<T> PutAsync<T>(String url, Dictionary<string, string> headers, BaseRequest request)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Put, 
                RequestUri = new Uri(url), 
                Content = JsonBuilder.ToJsonString(request)
            };

            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            HttpResponseMessage httpResponseMessage = await HttpClient.SendAsync(requestMessage);
            return await ReadResponseMessageAsync<T>(httpResponseMessage);
        }
    }
}
