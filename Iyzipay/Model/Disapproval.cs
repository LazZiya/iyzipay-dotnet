using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Disapproval : IyzipayResource
    {
        public String PaymentTransactionId { get; set; }

        // sync
        public static Disapproval Create(CreateApprovalRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Disapproval>(options.BaseUrl + "/payment/iyzipos/item/disapprove", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<Disapproval> CreateAsync(CreateApprovalRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<Disapproval>(options.BaseUrl + "/payment/iyzipos/item/disapprove", GetHttpHeaders(request, options), request);
        }
    }
}
