using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RestoreVirtualMachineRequest : APIRequest
    {
        public RestoreVirtualMachineRequest() : base("restoreVirtualMachine") {}

        /// <summary>
        /// Virtual Machine ID
        /// </summary>
        public Guid Virtualmachineid {
            get { return GetParameterValue<Guid>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// an optional template Id to restore vm from the new template. This can be an ISO id in case of restore vm deployed using ISO
        /// </summary>
        public Guid? TemplateId {
            get { return GetParameterValue<Guid?>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Restore a VM to original template/ISO or new template/ISO
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RestoreVirtualMachine(RestoreVirtualMachineRequest request);
        Task<AsyncJobResponse> RestoreVirtualMachineAsync(RestoreVirtualMachineRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RestoreVirtualMachine(RestoreVirtualMachineRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RestoreVirtualMachineAsync(RestoreVirtualMachineRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
