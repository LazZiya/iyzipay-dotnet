using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PayWithIyzico : PaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }      

        // sync
        public static PayWithIyzico Retrieve(RetrievePayWithIyzicoRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PayWithIyzico>(options.BaseUrl + "/payment/iyzipos/checkoutform/auth/ecom/detail", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<PayWithIyzico> RetrieveAsync(RetrievePayWithIyzicoRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<PayWithIyzico>(options.BaseUrl + "/payment/iyzipos/checkoutform/auth/ecom/detail", GetHttpHeaders(request, options), request);
        }
    }
}
