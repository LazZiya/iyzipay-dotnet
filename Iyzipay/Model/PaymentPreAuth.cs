using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PaymentPreAuth : PaymentResource
    {
        // sync
        public static PaymentPreAuth Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PaymentPreAuth>(options.BaseUrl + "/payment/preauth", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<PaymentPreAuth> CreateAsync(CreatePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<PaymentPreAuth>(options.BaseUrl + "/payment/preauth", GetHttpHeaders(request, options), request);
        }

        // sync
        public static PaymentPreAuth Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PaymentPreAuth>(options.BaseUrl + "/payment/detail", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<PaymentPreAuth> RetrieveAsync(RetrievePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<PaymentPreAuth>(options.BaseUrl + "/payment/detail", GetHttpHeaders(request, options), request);
        }
    }
}
