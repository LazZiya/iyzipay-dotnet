using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Refund : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String PaymentTransactionId { get; set; }
        public String Price { get; set; }
        public String Currency { get; set; }
        public String ConnectorName { get; set; }
        public String AuthCode { get; set; }
        public String HostReference { get; set; }

        // sync
        public static Refund Create(CreateRefundRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Refund>(options.BaseUrl + "/payment/refund", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<Refund> CreateAsync(CreateRefundRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<Refund>(options.BaseUrl + "/payment/refund", GetHttpHeaders(request, options), request);
        }

        // sync
        public static Refund CreateAmountBasedRefundRequest(CreateAmountBasedRefundRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Refund>(options.BaseUrl + "/v2/payment/refund", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<Refund> CreateAmountBasedRefundRequestAsync(CreateAmountBasedRefundRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<Refund>(options.BaseUrl + "/v2/payment/refund", GetHttpHeaders(request, options), request);
        }

    }
}
