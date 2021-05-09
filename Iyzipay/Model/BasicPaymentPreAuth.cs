using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicPaymentPreAuth : BasicPaymentResource
    {
        // sync
        public static BasicPaymentPreAuth Create(CreateBasicPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BasicPaymentPreAuth>(options.BaseUrl + "/payment/preauth/basic", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<BasicPaymentPreAuth> CreateAsync(CreateBasicPaymentRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<BasicPaymentPreAuth>(options.BaseUrl + "/payment/preauth/basic", GetHttpHeaders(request, options), request);
        }
    }
}
