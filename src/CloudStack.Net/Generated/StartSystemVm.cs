using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class StartSystemVmRequest : APIRequest
    {
        public StartSystemVmRequest() : base("startSystemVm") {}

        /// <summary>
        /// The ID of the system virtual machine
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Starts a system virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse StartSystemVm(StartSystemVmRequest request);
        Task<AsyncJobResponse> StartSystemVmAsync(StartSystemVmRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse StartSystemVm(StartSystemVmRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> StartSystemVmAsync(StartSystemVmRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
