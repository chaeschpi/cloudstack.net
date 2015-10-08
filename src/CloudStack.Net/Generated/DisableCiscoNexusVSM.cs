using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableCiscoNexusVSMRequest : APIRequest
    {
        public DisableCiscoNexusVSMRequest() : base("disableCiscoNexusVSM") {}

        /// <summary>
        /// Id of the Cisco Nexus 1000v VSM device to be deleted
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// disable a Cisco Nexus VSM device
    /// </summary>
    /// <summary>
    /// disable a Cisco Nexus VSM device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        CiscoNexusVSMResponse DisableCiscoNexusVSM(DisableCiscoNexusVSMRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public CiscoNexusVSMResponse DisableCiscoNexusVSM(DisableCiscoNexusVSMRequest request) => _proxy.Request<CiscoNexusVSMResponse>(request);
    }
}