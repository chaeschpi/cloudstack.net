using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SamlSsoRequest : APIRequest
    {
        public SamlSsoRequest() : base("samlSso") {}

        /// <summary>
        /// Identity Provider Entity ID
        /// </summary>
        public string IdpId {
            get { return GetParameterValue<string>(nameof(IdpId).ToLower()); }
            set { SetParameterValue(nameof(IdpId).ToLower(), value); }
        }

    }
    /// <summary>
    /// SP initiated SAML Single Sign On
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        LoginCmdResponse SamlSso(SamlSsoRequest request);
        Task<LoginCmdResponse> SamlSsoAsync(SamlSsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public LoginCmdResponse SamlSso(SamlSsoRequest request) => Proxy.Request<LoginCmdResponse>(request);
        public Task<LoginCmdResponse> SamlSsoAsync(SamlSsoRequest request) => Proxy.RequestAsync<LoginCmdResponse>(request);
    }
}
