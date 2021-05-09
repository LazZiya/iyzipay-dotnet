using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class ApiTest : IyzipayResource
    {
        // sync
        public static IyzipayResource Retrieve(Options options)
        {
            return RestHttpClient.Create().Get<IyzipayResource>(options.BaseUrl + "/payment/test");
        }
        
        // Async
        public static async Task<IyzipayResource> RetrieveAsync(Options options)
        {
            return await RestHttpClient.Create().GetAsync<IyzipayResource>(options.BaseUrl + "/payment/test");
        }
    }
}
