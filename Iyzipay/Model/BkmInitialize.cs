using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BkmInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }
        public String Token { get; set; }
        
        // sync
        public static BkmInitialize Create(CreateBkmInitializeRequest request, Options options)
        {
            BkmInitialize response = RestHttpClient.Create().Post<BkmInitialize>(options.BaseUrl + "/payment/bkm/initialize", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
        
        // Async
        public static async Task<BkmInitialize> CreateAsync(CreateBkmInitializeRequest request, Options options)
        {
            BkmInitialize response = await RestHttpClient.Create().PostAsync<BkmInitialize>(options.BaseUrl + "/payment/bkm/initialize", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
