using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CrossBookingFromSubMerchant : IyzipayResource
    {
        // sync
        public static CrossBookingFromSubMerchant Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CrossBookingFromSubMerchant>(options.BaseUrl + "/crossbooking/receive", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<CrossBookingFromSubMerchant> CreateAsync(CreateCrossBookingRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<CrossBookingFromSubMerchant>(options.BaseUrl + "/crossbooking/receive", GetHttpHeaders(request, options), request);
        }
    }
}
