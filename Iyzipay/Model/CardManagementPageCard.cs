using System.Collections.Generic;
using System.Threading.Tasks;
using Iyzipay.Request;

namespace Iyzipay.Model
{
    public class CardManagementPageCard : IyzipayResource
    {
        private string ExternalId { get; set; }
        private string CardUserKey { get; set; }
        private List<Card> CardDetails { get; set; }
        
        // sync
        public static CardManagementPageCard Retrieve(RetrieveCardManagementPageCardRequest request, Options options)
        {
            return RestHttpClient.Create().Get<CardManagementPageCard>(PrepareRetrieveCardManagementPageCardRequest(request,options),GetHttpHeaders(request,options));
        }
        
        // Async
        public static async Task<CardManagementPageCard> RetrieveAsync(RetrieveCardManagementPageCardRequest request, Options options)
        {
            return await RestHttpClient.Create().GetAsync<CardManagementPageCard>(PrepareRetrieveCardManagementPageCardRequest(request,options),GetHttpHeaders(request,options));
        }

        private static string PrepareRetrieveCardManagementPageCardRequest(RetrieveCardManagementPageCardRequest request, Options options)
        {
            return $"{options.BaseUrl}/v1/card-management/pages/{request.PageToken}/cards?locale={request.Locale}&conversationId={request.ConversationId}";
        }
    }
}