using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Bkm : PaymentResource
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }     

        // sync
        public static Bkm Retrieve(RetrieveBkmRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Bkm>(options.BaseUrl + "/payment/bkm/auth/detail", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<Bkm> RetrieveAsync(RetrieveBkmRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<Bkm>(options.BaseUrl + "/payment/bkm/auth/detail", GetHttpHeaders(request, options), request);
        }
    }
}
