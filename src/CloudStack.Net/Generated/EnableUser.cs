using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class EnableUserRequest : APIRequest
    {
        public EnableUserRequest() : base("enableUser") {}

        /// <summary>
        /// Enables user by user ID.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Enables a user account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        UserResponse EnableUser(EnableUserRequest request);
        Task<UserResponse> EnableUserAsync(EnableUserRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public UserResponse EnableUser(EnableUserRequest request) => Proxy.Request<UserResponse>(request);
        public Task<UserResponse> EnableUserAsync(EnableUserRequest request) => Proxy.RequestAsync<UserResponse>(request);
    }
}
