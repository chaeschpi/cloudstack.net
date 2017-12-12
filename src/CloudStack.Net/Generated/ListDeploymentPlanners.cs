using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDeploymentPlannersRequest : APIListRequest
    {
        public ListDeploymentPlannersRequest() : base("listDeploymentPlanners") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all DeploymentPlanners available.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DeploymentPlannersResponse> ListDeploymentPlanners(ListDeploymentPlannersRequest request);
        Task<ListResponse<DeploymentPlannersResponse>> ListDeploymentPlannersAsync(ListDeploymentPlannersRequest request);
        ListResponse<DeploymentPlannersResponse> ListDeploymentPlannersAllPages(ListDeploymentPlannersRequest request);
        Task<ListResponse<DeploymentPlannersResponse>> ListDeploymentPlannersAllPagesAsync(ListDeploymentPlannersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DeploymentPlannersResponse> ListDeploymentPlanners(ListDeploymentPlannersRequest request) => Proxy.Request<ListResponse<DeploymentPlannersResponse>>(request);
        public Task<ListResponse<DeploymentPlannersResponse>> ListDeploymentPlannersAsync(ListDeploymentPlannersRequest request) => Proxy.RequestAsync<ListResponse<DeploymentPlannersResponse>>(request);
        public ListResponse<DeploymentPlannersResponse> ListDeploymentPlannersAllPages(ListDeploymentPlannersRequest request) => Proxy.RequestAllPages<DeploymentPlannersResponse>(request);
        public Task<ListResponse<DeploymentPlannersResponse>> ListDeploymentPlannersAllPagesAsync(ListDeploymentPlannersRequest request) => Proxy.RequestAllPagesAsync<DeploymentPlannersResponse>(request);
    }
}
