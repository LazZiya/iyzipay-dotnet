using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CheckoutFormInitializePreAuth : CheckoutFormInitializeResource
    {
        // sync
        public static CheckoutFormInitializePreAuth Create(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CheckoutFormInitializePreAuth>(options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/preauth/ecom", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<CheckoutFormInitializePreAuth> CreateAsync(CreateCheckoutFormInitializeRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<CheckoutFormInitializePreAuth>(options.BaseUrl + "/payment/iyzipos/checkoutform/initialize/preauth/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
