using System;
using System.Threading.Tasks;
using Iyzipay.Request;

namespace Iyzipay.Model.V2.Iyzilink
{
    public class IyziLink : IyzipayResourceV2
    {
        private static string V2_IYZILINK_PRODUCTS = "/v2/iyzilink/products";
        
        // sync
        public static ResponseData<IyziLinkSave> Create(IyziLinkSaveRequest request, Options options)
        {
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + GetQueryParams(request);
            return RestHttpClientV2.Create().Post<ResponseData<IyziLinkSave>>(uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // Async
        public static async Task<ResponseData<IyziLinkSave>> CreateAsync(IyziLinkSaveRequest request, Options options)
        {
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + GetQueryParams(request);
            return await RestHttpClientV2.Create().PostAsync<ResponseData<IyziLinkSave>>(uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // sync
        public static ResponseData<IyziLinkSave> Update(string token, IyziLinkSaveRequest request, Options options)
        {
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + "/" + token + GetQueryParams(request);
            return RestHttpClientV2.Create().Put<ResponseData<IyziLinkSave>>(uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // Async
        public static async Task<ResponseData<IyziLinkSave>> UpdateAsync(string token, IyziLinkSaveRequest request, Options options)
        {
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + "/" + token + GetQueryParams(request);
            return await RestHttpClientV2.Create().PutAsync<ResponseData<IyziLinkSave>>(uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // sync
        public static ResponsePagingData<IyziLinkItem> RetrieveAll(PagingRequest request, Options options)
        {
            string queryParams = GetQueryParams(request);
            string iyzilinkQueryParam = "productType=IYZILINK";
            
            queryParams = String.IsNullOrEmpty(queryParams)
                ? "?" + iyzilinkQueryParam
                : queryParams + "&" + iyzilinkQueryParam;
            
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + queryParams;
            return RestHttpClientV2.Create().Get<ResponsePagingData<IyziLinkItem>>(uri, GetHttpHeadersWithUrlParams(request,uri ,options));
        }
        
        // Async
        public static async Task<ResponsePagingData<IyziLinkItem>> RetrieveAllAsync(PagingRequest request, Options options)
        {
            string queryParams = GetQueryParams(request);
            string iyzilinkQueryParam = "productType=IYZILINK";
            
            queryParams = String.IsNullOrEmpty(queryParams)
                ? "?" + iyzilinkQueryParam
                : queryParams + "&" + iyzilinkQueryParam;
            
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + queryParams;
            return await RestHttpClientV2.Create().GetAsync<ResponsePagingData<IyziLinkItem>>(uri, GetHttpHeadersWithUrlParams(request,uri ,options));
        }
        
        // sync
        public static ResponseData<IyziLinkItem> Retrieve(string token, BaseRequestV2 request, Options options)
        {
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + "/" + token + GetQueryParams(request);
            return RestHttpClientV2.Create().Get<ResponseData<IyziLinkItem>>(uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        // Async
        public static async Task<ResponseData<IyziLinkItem>> RetrieveAsync(string token, BaseRequestV2 request, Options options)
        {
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + "/" + token + GetQueryParams(request);
            return await RestHttpClientV2.Create().GetAsync<ResponseData<IyziLinkItem>>(uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        // sync
        public static IyzipayResourceV2 Delete(string token, BaseRequestV2 request, Options options)
        {
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + "/" + token + GetQueryParams(request);
            return RestHttpClientV2.Create().Delete<IyzipayResourceV2>(uri, GetHttpHeadersWithRequestBody(request, uri ,options),request);
        }
        
        // Async
        public static async Task<IyzipayResourceV2> DeleteAsync(string token, BaseRequestV2 request, Options options)
        {
            string uri = options.BaseUrl + V2_IYZILINK_PRODUCTS + "/" + token + GetQueryParams(request);
            return await RestHttpClientV2.Create().DeleteAsync<IyzipayResourceV2>(uri, GetHttpHeadersWithRequestBody(request, uri ,options),request);
        }
        
        private static string GetQueryParams(BaseRequestV2 request) {
            if (request == null) {
                return "";
            }

            string queryParams = "?conversationId=" + request.ConversationId;

            if (!String.IsNullOrEmpty(request.Locale)) {
                queryParams += "&locale=" + request.Locale;
            }

            if (!(request is PagingRequest pagingRequest)) return queryParams;
            
            if (pagingRequest.Page != null) {
                queryParams += "&page=" + pagingRequest.Page;
            }

            if (pagingRequest.Count != null) {
                queryParams += "&count=" + pagingRequest.Count;
            }
            return queryParams;
        }
    }
}