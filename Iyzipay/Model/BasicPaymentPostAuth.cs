using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicPaymentPostAuth : BasicPaymentResource
    {        
        // sync
        public static BasicPaymentPostAuth Create(CreatePaymentPostAuthRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicPaymentPostAuth>(options.BaseUrl + "/payment/postauth/basic", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<BasicPaymentPostAuth> CreateAsync(CreatePaymentPostAuthRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<BasicPaymentPostAuth>(options.BaseUrl + "/payment/postauth/basic", GetHttpHeaders(request, options), request);
        }
    }
}
