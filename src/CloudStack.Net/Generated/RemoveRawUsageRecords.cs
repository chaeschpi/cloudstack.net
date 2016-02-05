using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveRawUsageRecordsRequest : APIRequest
    {
        public RemoveRawUsageRecordsRequest() : base("removeRawUsageRecords") {}

        /// <summary>
        /// Specify the number of days (greater than zero) to remove records that are older than those number of days from today. For example, specifying 10 would result in removing all the records created before 10 days from today
        /// </summary>
        public int Interval {
            get { return (int) Parameters[nameof(Interval).ToLower()]; }
            set { Parameters[nameof(Interval).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Safely removes raw records from cloud_usage table
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse RemoveRawUsageRecords(RemoveRawUsageRecordsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse RemoveRawUsageRecords(RemoveRawUsageRecordsRequest request) => _proxy.Request<SuccessResponse>(request);
    }
}
