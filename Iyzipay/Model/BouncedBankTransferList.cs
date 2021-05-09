using System.Collections.Generic;
using Newtonsoft.Json;
using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BouncedBankTransferList : IyzipayResource
    {
        [JsonProperty(PropertyName = "bouncedRows")]
        public List<BankTransfer> BankTransfers { get; set; }

        // sync
        public static BouncedBankTransferList Retrieve(RetrieveTransactionsRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BouncedBankTransferList>(options.BaseUrl + "/reporting/settlement/bounced", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<BouncedBankTransferList> RetrieveAsync(RetrieveTransactionsRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<BouncedBankTransferList>(options.BaseUrl + "/reporting/settlement/bounced", GetHttpHeaders(request, options), request);
        }
    }
}
