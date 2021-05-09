using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Payment : PaymentResource
    {
        // sync
        public static Payment Create(CreatePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Payment>(options.BaseUrl + "/payment/auth", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<Payment> CreateAsync(CreatePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<Payment>(options.BaseUrl + "/payment/auth", GetHttpHeaders(request, options), request);
        }

        // sync
        public static Payment Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Payment>(options.BaseUrl + "/payment/detail", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<Payment> RetrieveAsync(RetrievePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<Payment>(options.BaseUrl + "/payment/detail", GetHttpHeaders(request, options), request);
        }
    }
}
