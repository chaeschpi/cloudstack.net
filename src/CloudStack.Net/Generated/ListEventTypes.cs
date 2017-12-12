using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListEventTypesRequest : APIRequest
    {
        public ListEventTypesRequest() : base("listEventTypes") {}

    }
    /// <summary>
    /// List Event Types
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        EventTypeResponse ListEventTypes(ListEventTypesRequest request);
        Task<EventTypeResponse> ListEventTypesAsync(ListEventTypesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public EventTypeResponse ListEventTypes(ListEventTypesRequest request) => Proxy.Request<EventTypeResponse>(request);
        public Task<EventTypeResponse> ListEventTypesAsync(ListEventTypesRequest request) => Proxy.RequestAsync<EventTypeResponse>(request);
    }
}
