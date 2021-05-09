using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Approval : IyzipayResource
    {
        public String PaymentTransactionId { get; set; }

        // sync
        public static Approval Create(CreateApprovalRequest request, Options options)
        {
            return  RestHttpClient.Create().Post<Approval>(options.BaseUrl + "/payment/iyzipos/item/approve", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<Approval> CreateAsync(CreateApprovalRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<Approval>(options.BaseUrl + "/payment/iyzipos/item/approve", GetHttpHeaders(request, options), request);
        }
    }
}
