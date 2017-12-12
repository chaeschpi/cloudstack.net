using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DetachIsoRequest : APIRequest
    {
        public DetachIsoRequest() : base("detachIso") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId {
            get { return GetParameterValue<Guid>(nameof(VirtualMachineId).ToLower()); }
            set { SetParameterValue(nameof(VirtualMachineId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Detaches any ISO file (if any) currently attached to a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DetachIso(DetachIsoRequest request);
        Task<AsyncJobResponse> DetachIsoAsync(DetachIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DetachIso(DetachIsoRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DetachIsoAsync(DetachIsoRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
