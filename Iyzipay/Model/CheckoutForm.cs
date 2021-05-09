using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CheckoutForm : PaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }      

        // sync
        public static CheckoutForm Retrieve(RetrieveCheckoutFormRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CheckoutForm>(options.BaseUrl + "/payment/iyzipos/checkoutform/auth/ecom/detail", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<CheckoutForm> RetrieveAsync(RetrieveCheckoutFormRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<CheckoutForm>(options.BaseUrl + "/payment/iyzipos/checkoutform/auth/ecom/detail", GetHttpHeaders(request, options), request);
        }
    }
}
