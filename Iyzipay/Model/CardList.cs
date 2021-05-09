using Iyzipay.Request;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CardList : IyzipayResource
    {
        public String CardUserKey { get; set; }
        public List<Card> CardDetails { get; set; }

        // sync
        public static CardList Retrieve(RetrieveCardListRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CardList>(options.BaseUrl + "/cardstorage/cards", GetHttpHeaders(request, options), request);
        }
        
        // Async
        public static async Task<CardList> RetrieveAsync(RetrieveCardListRequest request, Options options)
        {
            return await RestHttpClient.Create().PostAsync<CardList>(options.BaseUrl + "/cardstorage/cards", GetHttpHeaders(request, options), request);
        }
    }
}
