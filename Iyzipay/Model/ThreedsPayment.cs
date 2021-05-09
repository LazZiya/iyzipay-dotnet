using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class ThreedsPayment : PaymentResource
    {
        // sync
        public static ThreedsPayment Create(CreateThreedsPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ThreedsPayment>(options.BaseUrl + "/payment/3dsecure/auth", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<ThreedsPayment> CreateAsync(CreateThreedsPaymentRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<ThreedsPayment>(options.BaseUrl + "/payment/3dsecure/auth", GetHttpHeaders(request, options), request);
        }

        // sync
        public static ThreedsPayment Retrieve(RetrievePaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<ThreedsPayment>(options.BaseUrl + "/payment/detail", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<ThreedsPayment> RetrieveAsync(RetrievePaymentRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<ThreedsPayment>(options.BaseUrl + "/payment/detail", GetHttpHeaders(request, options), request);
        }
    }
}
