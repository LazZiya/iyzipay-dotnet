using System;
using System.Threading.Tasks;
using Iyzipay.Request.V2.Subscription;

namespace Iyzipay.Model.V2.Subscription
{
    public class Plan : IyzipayResourceV2
    {
        // sync
        public static ResponseData<PlanResource> Create(CreatePlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/products/{request.ProductReferenceCode}/pricing-plans";
            return RestHttpClientV2.Create().Post<ResponseData<PlanResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // Async
        public static async Task<ResponseData<PlanResource>> CreateAsync(CreatePlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/products/{request.ProductReferenceCode}/pricing-plans";
            return await RestHttpClientV2.Create().PostAsync<ResponseData<PlanResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // sync
        public static ResponseData<PlanResource> Update(UpdatePlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/pricing-plans/{request.PricingPlanReferenceCode}";
            return RestHttpClientV2.Create().Post<ResponseData<PlanResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // Async
        public static async Task<ResponseData<PlanResource>> UpdateAsync(UpdatePlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/pricing-plans/{request.PricingPlanReferenceCode}";
            return await RestHttpClientV2.Create().PostAsync<ResponseData<PlanResource>>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // sync
        public static IyzipayResourceV2 Delete(DeletePlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/pricing-plans/{request.PricingPlanReferenceCode}";
            return RestHttpClientV2.Create().Delete<IyzipayResourceV2>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // Async
        public static async Task<IyzipayResourceV2> DeleteAsync(DeletePlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/pricing-plans/{request.PricingPlanReferenceCode}";
            return await RestHttpClientV2.Create().DeleteAsync<IyzipayResourceV2>( uri, GetHttpHeadersWithRequestBody(request, uri ,options), request);
        }
        
        // sync
        public static ResponseData<PlanResource> Retrieve(RetrievePlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/pricing-plans/{request.PricingPlanReferenceCode}";
            return RestHttpClientV2.Create().Get<ResponseData<PlanResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        // Async
        public static async Task<ResponseData<PlanResource>> RetrieveAsync(RetrievePlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/pricing-plans/{request.PricingPlanReferenceCode}";
            return await RestHttpClientV2.Create().GetAsync<ResponseData<PlanResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        // sync
        public static ResponsePagingData<PlanResource> RetrieveAll(RetrieveAllPlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/products/{request.ProductReferenceCode}/pricing-plans{GetQueryParams(request)}";
            return RestHttpClientV2.Create().Get<ResponsePagingData<PlanResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
        }
        
        // Async
        public static async Task<ResponsePagingData<PlanResource>> RetrieveAllAsync(RetrieveAllPlanRequest request, Options options)
        {
            string uri = $"{options.BaseUrl}/v2/subscription/products/{request.ProductReferenceCode}/pricing-plans{GetQueryParams(request)}";
            return await RestHttpClientV2.Create().GetAsync<ResponsePagingData<PlanResource>>( uri, GetHttpHeadersWithUrlParams(request, uri ,options));
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