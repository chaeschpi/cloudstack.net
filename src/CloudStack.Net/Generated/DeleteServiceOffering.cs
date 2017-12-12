using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteServiceOfferingRequest : APIRequest
    {
        public DeleteServiceOfferingRequest() : base("deleteServiceOffering") {}

        /// <summary>
        /// the ID of the service offering
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a service offering.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteServiceOffering(DeleteServiceOfferingRequest request);
        Task<SuccessResponse> DeleteServiceOfferingAsync(DeleteServiceOfferingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteServiceOffering(DeleteServiceOfferingRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteServiceOfferingAsync(DeleteServiceOfferingRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
