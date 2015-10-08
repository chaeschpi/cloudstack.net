using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteStaticRouteRequest : APIRequest
    {
        public DeleteStaticRouteRequest() : base("deleteStaticRoute") {}

        /// <summary>
        /// the ID of the static route
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Deletes a static route
    /// </summary>
    /// <summary>
    /// Deletes a static route
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteStaticRoute(DeleteStaticRouteRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteStaticRoute(DeleteStaticRouteRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}