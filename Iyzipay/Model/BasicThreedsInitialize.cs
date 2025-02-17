﻿using Iyzipay.Request;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicThreedsInitialize : IyzipayResource
    {
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        // sync
        public static BasicThreedsInitialize Create(CreateBasicPaymentRequest request, Options options)
        {
            BasicThreedsInitialize response = RestHttpClient.Create().Post<BasicThreedsInitialize>(options.BaseUrl + "/payment/3dsecure/initialize/basic", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
        
        // Async
        public static async Task<BasicThreedsInitialize> CreateAsync(CreateBasicPaymentRequest request, Options options)
        {
            BasicThreedsInitialize response = await RestHttpClient.Create().PostAsync<BasicThreedsInitialize>(options.BaseUrl + "/payment/3dsecure/initialize/basic", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
