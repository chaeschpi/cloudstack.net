using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CancelStorageMaintenanceRequest : APIRequest
    {
        public CancelStorageMaintenanceRequest() : base("cancelStorageMaintenance") {}

        /// <summary>
        /// the primary storage ID
        /// </summary>
        public Guid Id { get; set; }

    }
    /// <summary>
    /// Cancels maintenance for primary storage
    /// </summary>
    /// <summary>
    /// Cancels maintenance for primary storage
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        StoragePoolResponse CancelStorageMaintenance(CancelStorageMaintenanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public StoragePoolResponse CancelStorageMaintenance(CancelStorageMaintenanceRequest request) => _proxy.Request<StoragePoolResponse>(request);
    }
}