using System;
using System.Threading.Tasks;
using Iyzipay.Request.V2.Subscription;

namespace Iyzipay.Model.V2.Subscription
{
    public class Customer : IyzipayResourceV2
    {
        // sync
        public static ResponseData<CustomerResource> Create(CreateCustomerRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/customers";
            return RestHttpClientV2.Create().Post<ResponseData<CustomerResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // Async
        public static async Task<ResponseData<CustomerResource>> CreateAsync(CreateCustomerRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/customers";
            return await RestHttpClientV2.Create().PostAsync<ResponseData<CustomerResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // sync
        public static ResponseData<CustomerResource> Update(UpdateCustomerRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/customers/{request.CustomerReferenceCode}";
            return RestHttpClientV2.Create().Post<ResponseData<CustomerResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // Async
        public static async Task<ResponseData<CustomerResource>> UpdateAsync(UpdateCustomerRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/customers/{request.CustomerReferenceCode}";
            return await RestHttpClientV2.Create().PostAsync<ResponseData<CustomerResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // sync
        public static ResponseData<CustomerResource> Retrieve(RetrieveCustomerRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/customers/{request.CustomerReferenceCode}";
            return RestHttpClientV2.Create().Get<ResponseData<CustomerResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        // Async
        public static async Task<ResponseData<CustomerResource>> RetrieveAsync(RetrieveCustomerRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/customers/{request.CustomerReferenceCode}";
            return await RestHttpClientV2.Create().GetAsync<ResponseData<CustomerResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        // sync
        public static ResponsePagingData<CustomerResource> RetrieveAll(PagingRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/customers{GetQueryParams(request)}";
            return RestHttpClientV2.Create().Get<ResponsePagingData<CustomerResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        // Async
        public static async Task<ResponsePagingData<CustomerResource>> RetrieveAllAsync(PagingRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/customers{GetQueryParams(request)}";
            return await RestHttpClientV2.Create().GetAsync<ResponsePagingData<CustomerResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
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