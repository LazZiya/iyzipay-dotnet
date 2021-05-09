using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CrossBookingToSubMerchant : IyzipayResource
    {
        // sync
        public static CrossBookingToSubMerchant Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CrossBookingToSubMerchant>(options.BaseUrl + "/crossbooking/send", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<CrossBookingToSubMerchant> CreateAsync(CreateCrossBookingRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<CrossBookingToSubMerchant>(options.BaseUrl + "/crossbooking/send", GetHttpHeaders(request, options), request);
        }
    }
}
