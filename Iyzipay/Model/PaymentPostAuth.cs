using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PaymentPostAuth : PaymentResource
    {        
        // sync
        public static PaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PaymentPostAuth>(options.BaseUrl + "/payment/postauth", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<PaymentPostAuth> CreateAsync(CreatePaymentPostAuthRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<PaymentPostAuth>(options.BaseUrl + "/payment/postauth", GetHttpHeaders(request, options), request);
        }
    }
}
