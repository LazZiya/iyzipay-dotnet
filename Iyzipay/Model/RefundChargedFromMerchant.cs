using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class RefundChargedFromMerchant : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String PaymentTransactionId { get; set; }
        public String Price { get; set; }
        public String AuthCode { get; set; }
        public String HostReference { get; set; }

        // sync
        public static RefundChargedFromMerchant Create(CreateRefundRequest request, Options options)
        {
            return RestHttpClient.Create().Post<RefundChargedFromMerchant>(options.BaseUrl + "/payment/iyzipos/refund/merchant/charge", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<RefundChargedFromMerchant> CreateAsync(CreateRefundRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<RefundChargedFromMerchant>(options.BaseUrl + "/payment/iyzipos/refund/merchant/charge", GetHttpHeaders(request, options), request);
        }
    }
}
