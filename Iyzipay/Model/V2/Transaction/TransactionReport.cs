using System;
using System.Threading.Tasks;
using Iyzipay.Request.V2;

namespace Iyzipay.Model.V2.Transaction
{
    public class TransactionReport : TransactionReportResource
    {
        // sync
        public static TransactionReport Retrieve(RetrieveTransactionReportRequest request, Options options)
        {
            String url = options.BaseUrl
                + "/v2/reporting/payment/transactions?transactionDate="
                + request.TransactionDate
                + "&page="
                + request.Page;
            return RestHttpClientV2.Create().Get<TransactionReport>(url, GetHttpHeadersWithUrlParams(request, url, options));
        }
        
        // Async
        public static async Task<TransactionReport> RetrieveAsync(RetrieveTransactionReportRequest request, Options options)
        {
            String url = options.BaseUrl
                + "/v2/reporting/payment/transactions?transactionDate="
                + request.TransactionDate
                + "&page="
                + request.Page;
            return await RestHttpClientV2.Create().GetAsync<TransactionReport>(url, GetHttpHeadersWithUrlParams(request, url, options));
        }
    }
}
