using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CheckoutFormInitialize : CheckoutFormInitializeResource
    {
        // sync
        public static CheckoutFormInitialize Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CheckoutFormInitialize>(options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/auth/ecom", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<CheckoutFormInitialize> CreateAsync(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<CheckoutFormInitialize>(options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/auth/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
