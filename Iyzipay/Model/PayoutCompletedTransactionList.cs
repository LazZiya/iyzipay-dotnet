using Iyzipay.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class PayoutCompletedTransactionList : IyzipayResource
    {
        public List<PayoutCompletedTransaction> PayoutCompletedTransactions { get; set; }

        // sync
        public static PayoutCompletedTransactionList Retrieve(RetrieveTransactionsRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PayoutCompletedTransactionList>(options.BaseUrl + "/reporting/settlement/payoutcompleted", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<PayoutCompletedTransactionList> RetrieveAsync(RetrieveTransactionsRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<PayoutCompletedTransactionList>(options.BaseUrl + "/reporting/settlement/payoutcompleted", GetHttpHeaders(request, options), request);
        }
    }
}
