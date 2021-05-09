using Iyzipay.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class InstallmentInfo : IyzipayResource
    {
        public List<InstallmentDetail> InstallmentDetails { get; set; }

        // sync
        public static InstallmentInfo Retrieve(RetrieveInstallmentInfoRequest request, Options options)
        {
            return RestHttpClient.Create().Post<InstallmentInfo>(options.BaseUrl + "/payment/iyzipos/installment", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<InstallmentInfo> RetrieveAsync(RetrieveInstallmentInfoRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<InstallmentInfo>(options.BaseUrl + "/payment/iyzipos/installment", GetHttpHeaders(request, options), request);
        }
    }
}
