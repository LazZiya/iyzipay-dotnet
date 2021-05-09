using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicPayment : BasicPaymentResource
    {
        // sync
        public static BasicPayment Create(CreateBasicPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicPayment>(options.BaseUrl + "/payment/auth/basic", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<BasicPayment> CreateAsync(CreateBasicPaymentRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<BasicPayment>(options.BaseUrl + "/payment/auth/basic", GetHttpHeaders(request, options), request);
        }
    }
}
