using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class PrepareTemplateRequest : APIRequest
    {
        public PrepareTemplateRequest() : base("prepareTemplate") {}

        /// <summary>
        /// template ID of the template to be prepared in primary storage(s).
        /// </summary>
        public Guid TemplateId {
            get { return GetParameterValue<Guid>(nameof(TemplateId).ToLower()); }
            set { SetParameterValue(nameof(TemplateId).ToLower(), value); }
        }

        /// <summary>
        /// zone ID of the template to be prepared in primary storage(s).
        /// </summary>
        public Guid ZoneId {
            get { return GetParameterValue<Guid>(nameof(ZoneId).ToLower()); }
            set { SetParameterValue(nameof(ZoneId).ToLower(), value); }
        }

        /// <summary>
        /// storage pool ID of the primary storage pool to which the template should be prepared. If it is not provided the template is prepared on all the available primary storage pools.
        /// </summary>
        public Guid? StorageId {
            get { return GetParameterValue<Guid?>(nameof(StorageId).ToLower()); }
            set { SetParameterValue(nameof(StorageId).ToLower(), value); }
        }

    }
    /// <summary>
    /// load template into primary storage
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        TemplateResponse PrepareTemplate(PrepareTemplateRequest request);
        Task<TemplateResponse> PrepareTemplateAsync(PrepareTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public TemplateResponse PrepareTemplate(PrepareTemplateRequest request) => Proxy.Request<TemplateResponse>(request);
        public Task<TemplateResponse> PrepareTemplateAsync(PrepareTemplateRequest request) => Proxy.RequestAsync<TemplateResponse>(request);
    }
}
