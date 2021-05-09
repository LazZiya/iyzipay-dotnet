using System;
using System.Threading.Tasks;
using Iyzipay.Request.V2;

namespace Iyzipay.Model.V2.Transaction
{
    public class TransactionDetail : TransactionDetailResource
    {
        // sync
        public static TransactionDetail Retrieve(RetrieveTransactionDetailRequest request, Options options)
        {
            String url = options.BaseUrl
                + "/v2/reporting/payment/details?paymentConversationId="
                + request.PaymentConversationId;
            return RestHttpClientV2.Create().Get<TransactionDetail>(url, GetHttpHeadersWithUrlParams(request, url, options));
        }
        
        // Async
        public static async Task<TransactionDetail> RetrieveAsync(RetrieveTransactionDetailRequest request, Options options)
        {
            String url = options.BaseUrl
                + "/v2/reporting/payment/details?paymentConversationId="
                + request.PaymentConversationId;
            return await RestHttpClientV2.Create().GetAsync<TransactionDetail>(url, GetHttpHeadersWithUrlParams(request, url, options));
        }
    }
}
