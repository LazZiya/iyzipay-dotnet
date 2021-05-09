using Iyzipay.Request;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class ThreedsInitializePreAuth : IyzipayResource
    {
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        // sync
        public static ThreedsInitializePreAuth Create(CreatePaymentRequest request, Options options)
        {
            ThreedsInitializePreAuth response = RestHttpClient.Create().Post<ThreedsInitializePreAuth>(options.BaseUrl + "/payment/3dsecure/initialize/preauth", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
        
        // Async
        public static async Task<ThreedsInitializePreAuth> CreateAsync(CreatePaymentRequest request, Options options)
        {
            ThreedsInitializePreAuth response = await RestHttpClient.Create().PostAsync<ThreedsInitializePreAuth>(options.BaseUrl + "/payment/3dsecure/initialize/preauth", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
