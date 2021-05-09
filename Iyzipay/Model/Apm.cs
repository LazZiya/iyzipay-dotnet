using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Apm : ApmResource
    {
        // sync
        public static Apm Create(CreateApmInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Apm>(options.BaseUrl + "/payment/apm/initialize", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<Apm> CreateAsync(CreateApmInitializeRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<Apm>(options.BaseUrl + "/payment/apm/initialize", GetHttpHeaders(request, options), request);
        }

        // sync
        public static Apm Retrieve(RetrieveApmRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Apm>(options.BaseUrl + "/payment/apm/retrieve", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<Apm> RetrieveAsync(RetrieveApmRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<Apm>(options.BaseUrl + "/payment/apm/retrieve", GetHttpHeaders(request, options), request);
        }
    }
}
