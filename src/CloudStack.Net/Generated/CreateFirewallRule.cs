using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateFirewallRuleRequest : APIRequest
    {
        public CreateFirewallRuleRequest() : base("createFirewallRule") {}

        /// <summary>
        /// the IP address id of the port forwarding rule
        /// </summary>
        public Guid IpAddressId {
            get { return GetParameterValue<Guid>(nameof(IpAddressId).ToLower()); }
            set { SetParameterValue(nameof(IpAddressId).ToLower(), value); }
        }

        /// <summary>
        /// the protocol for the firewall rule. Valid values are TCP/UDP/ICMP.
        /// </summary>
        public string Protocol {
            get { return GetParameterValue<string>(nameof(Protocol).ToLower()); }
            set { SetParameterValue(nameof(Protocol).ToLower(), value); }
        }

        /// <summary>
        /// the CIDR list to forward traffic from
        /// </summary>
        public IList<string> Cidrlist {
            get { return GetList<string>(nameof(Cidrlist).ToLower()); }
            set { SetParameterValue(nameof(Cidrlist).ToLower(), value); }
        }

        /// <summary>
        /// the ending port of firewall rule
        /// </summary>
        public int? Endport {
            get { return GetParameterValue<int?>(nameof(Endport).ToLower()); }
            set { SetParameterValue(nameof(Endport).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// error code for this icmp message
        /// </summary>
        public int? IcmpCode {
            get { return GetParameterValue<int?>(nameof(IcmpCode).ToLower()); }
            set { SetParameterValue(nameof(IcmpCode).ToLower(), value); }
        }

        /// <summary>
        /// type of the ICMP message being sent
        /// </summary>
        public int? IcmpType {
            get { return GetParameterValue<int?>(nameof(IcmpType).ToLower()); }
            set { SetParameterValue(nameof(IcmpType).ToLower(), value); }
        }

        /// <summary>
        /// the starting port of firewall rule
        /// </summary>
        public int? Startport {
            get { return GetParameterValue<int?>(nameof(Startport).ToLower()); }
            set { SetParameterValue(nameof(Startport).ToLower(), value); }
        }

        /// <summary>
        /// type of firewallrule: system/user
        /// </summary>
        public string Type {
            get { return GetParameterValue<string>(nameof(Type).ToLower()); }
            set { SetParameterValue(nameof(Type).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a firewall rule for a given IP address
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateFirewallRule(CreateFirewallRuleRequest request);
        Task<AsyncJobResponse> CreateFirewallRuleAsync(CreateFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateFirewallRule(CreateFirewallRuleRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateFirewallRuleAsync(CreateFirewallRuleRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
