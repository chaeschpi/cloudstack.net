using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateTemplateRequest : APIRequest
    {
        public CreateTemplateRequest() : base("createTemplate") {}

        /// <summary>
        /// the display text of the template. This is usually used for display purposes.
        /// </summary>
        public string DisplayText {
            get { return GetParameterValue<string>(nameof(DisplayText).ToLower()); }
            set { SetParameterValue(nameof(DisplayText).ToLower(), value); }
        }

        /// <summary>
        /// the name of the template
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the OS Type that best represents the OS of this template.
        /// </summary>
        public Guid OsTypeId {
            get { return GetParameterValue<Guid>(nameof(OsTypeId).ToLower()); }
            set { SetParameterValue(nameof(OsTypeId).ToLower(), value); }
        }

        /// <summary>
        /// 32 or 64 bit
        /// </summary>
        public int? Bits {
            get { return GetParameterValue<int?>(nameof(Bits).ToLower()); }
            set { SetParameterValue(nameof(Bits).ToLower(), value); }
        }

        /// <summary>
        /// Template details in key/value pairs using format details[i].keyname=keyvalue. Example: details[0].hypervisortoolsversion=xenserver61
        /// </summary>
        public IList<IDictionary<string, object>> Details {
            get { return GetList<IDictionary<string, object>>(nameof(Details).ToLower()); }
            set { SetParameterValue(nameof(Details).ToLower(), value); }
        }

        /// <summary>
        /// true if template contains XS/VMWare tools inorder to support dynamic scaling of VM cpu/memory
        /// </summary>
        public bool? IsDynamicallyScalable {
            get { return GetParameterValue<bool?>(nameof(IsDynamicallyScalable).ToLower()); }
            set { SetParameterValue(nameof(IsDynamicallyScalable).ToLower(), value); }
        }

        /// <summary>
        /// true if this template is a featured template, false otherwise
        /// </summary>
        public bool? Isfeatured {
            get { return GetParameterValue<bool?>(nameof(Isfeatured).ToLower()); }
            set { SetParameterValue(nameof(Isfeatured).ToLower(), value); }
        }

        /// <summary>
        /// true if this template is a public template, false otherwise
        /// </summary>
        public bool? Ispublic {
            get { return GetParameterValue<bool?>(nameof(Ispublic).ToLower()); }
            set { SetParameterValue(nameof(Ispublic).ToLower(), value); }
        }

        /// <summary>
        /// true if the template supports the password reset feature; default is false
        /// </summary>
        public bool? PasswordEnabled {
            get { return GetParameterValue<bool?>(nameof(PasswordEnabled).ToLower()); }
            set { SetParameterValue(nameof(PasswordEnabled).ToLower(), value); }
        }

        /// <summary>
        /// create template for the project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// true if the template requres HVM, false otherwise
        /// </summary>
        public bool? RequiresHvm {
            get { return GetParameterValue<bool?>(nameof(RequiresHvm).ToLower()); }
            set { SetParameterValue(nameof(RequiresHvm).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the snapshot the template is being created from. Either this parameter, or volumeId has to be passed in
        /// </summary>
        public Guid? SnapshotId {
            get { return GetParameterValue<Guid?>(nameof(SnapshotId).ToLower()); }
            set { SetParameterValue(nameof(SnapshotId).ToLower(), value); }
        }

        /// <summary>
        /// the tag for this template.
        /// </summary>
        public string TemplateTag {
            get { return GetParameterValue<string>(nameof(TemplateTag).ToLower()); }
            set { SetParameterValue(nameof(TemplateTag).ToLower(), value); }
        }

        /// <summary>
        /// Optional, only for baremetal hypervisor. The directory name where template stored on CIFS server
        /// </summary>
        public string Url {
            get { return GetParameterValue<string>(nameof(Url).ToLower()); }
            set { SetParameterValue(nameof(Url).ToLower(), value); }
        }

        /// <summary>
        /// Optional, VM ID. If this presents, it is going to create a baremetal template for VM this ID refers to. This is only for VM whose hypervisor type is BareMetal
        /// </summary>
        public Guid? Virtualmachineid {
            get { return GetParameterValue<Guid?>(nameof(Virtualmachineid).ToLower()); }
            set { SetParameterValue(nameof(Virtualmachineid).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the disk volume the template is being created from. Either this parameter, or snapshotId has to be passed in
        /// </summary>
        public Guid? VolumeId {
            get { return GetParameterValue<Guid?>(nameof(VolumeId).ToLower()); }
            set { SetParameterValue(nameof(VolumeId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates a template of a virtual machine. The virtual machine must be in a STOPPED state. A template created from this command is automatically designated as a private template visible to the account that created it.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateTemplate(CreateTemplateRequest request);
        Task<AsyncJobResponse> CreateTemplateAsync(CreateTemplateRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateTemplate(CreateTemplateRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateTemplateAsync(CreateTemplateRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
