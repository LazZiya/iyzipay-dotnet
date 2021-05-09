using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using System.Threading.Tasks;

namespace Iyzipay
{
    class RestHttpClientV2
    {
        private static readonly HttpClient HttpClient;
        static RestHttpClientV2()
        {
#if !NETSTANDARD
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
#endif
            
            HttpClient = new HttpClient();
        }

        public static RestHttpClientV2 Create()
        {
            return new RestHttpClientV2();
        }

        private async Task<T> ReadResponseMessageAsync<T>(HttpResponseMessage httpResponseMessage) where T : IyzipayResourceV2
        {
            var content = await httpResponseMessage.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<T>(content);
            response.AppendWithHttpResponseHeaders(httpResponseMessage);
            return response;
        }

        // sync
        public T Get<T>(String url, Dictionary<string, string> headers) where T : IyzipayResourceV2
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
            var response = JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
            response.AppendWithHttpResponseHeaders(httpResponseMessage);
            return response;
        }
        
        // Async
        public async Task<T> GetAsync<T>(String url, Dictionary<string, string> headers) where T : IyzipayResourceV2
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
        public T Post<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
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
            var response = JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
            response.AppendWithHttpResponseHeaders(httpResponseMessage);
            return response;
        }
        
        // Async
        public async Task<T> PostAsync<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
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
        public T Put<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
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
            var response = JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
            response.AppendWithHttpResponseHeaders(httpResponseMessage);
            return response;
        }
        
        // Async
        public async Task<T> PutAsync<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
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
        
        // sync
        public T Delete<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
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
            var response = JsonConvert.DeserializeObject<T>(httpResponseMessage.Content.ReadAsStringAsync().Result);
            response.AppendWithHttpResponseHeaders(httpResponseMessage);
            return response;
        }
        
        // Async
        public async Task<T> DeleteAsync<T>(String url, Dictionary<string, string> headers, BaseRequestV2 request) where T : IyzipayResourceV2
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
    }
}
