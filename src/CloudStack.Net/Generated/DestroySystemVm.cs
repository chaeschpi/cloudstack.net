using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DestroySystemVmRequest : APIRequest
    {
        public DestroySystemVmRequest() : base("destroySystemVm") {}

        /// <summary>
        /// The ID of the system virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Destroyes a system virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DestroySystemVm(DestroySystemVmRequest request);
        Task<AsyncJobResponse> DestroySystemVmAsync(DestroySystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DestroySystemVm(DestroySystemVmRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DestroySystemVmAsync(DestroySystemVmRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
