using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PayWithIyzicoInitialize : PayWithIyzicoInitializeResource
    {
        // sync
        public static PayWithIyzicoInitialize Create(CreatePayWithIyzicoInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PayWithIyzicoInitialize>(options.BaseUrl + "/payment/pay-with-iyzico/initialize", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<PayWithIyzicoInitialize> CreateAsync(CreatePayWithIyzicoInitializeRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<PayWithIyzicoInitialize>(options.BaseUrl + "/payment/pay-with-iyzico/initialize", GetHttpHeaders(request, options), request);
        }
    }
}
