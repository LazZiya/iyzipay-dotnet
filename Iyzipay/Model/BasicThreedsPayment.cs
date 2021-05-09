using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicThreedsPayment : BasicPaymentResource
    {
        // sync
        public static BasicThreedsPayment Create(CreateThreedsPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicThreedsPayment>(options.BaseUrl + "/payment/3dsecure/auth/basic", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<BasicThreedsPayment> CreateAsync(CreateThreedsPaymentRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<BasicThreedsPayment>(options.BaseUrl + "/payment/3dsecure/auth/basic", GetHttpHeaders(request, options), request);
        }
    }
}
