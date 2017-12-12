using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseHostReservationRequest : APIRequest
    {
        public ReleaseHostReservationRequest() : base("releaseHostReservation") {}

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Releases host reservation.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReleaseHostReservation(ReleaseHostReservationRequest request);
        Task<AsyncJobResponse> ReleaseHostReservationAsync(ReleaseHostReservationRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReleaseHostReservation(ReleaseHostReservationRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ReleaseHostReservationAsync(ReleaseHostReservationRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
