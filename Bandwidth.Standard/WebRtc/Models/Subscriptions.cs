/*
 * Bandwidth.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Bandwidth.Standard;
using Bandwidth.Standard.Utilities;

namespace Bandwidth.Standard.WebRtc.Models
{
    public class Subscriptions 
    {
        public Subscriptions() { }

        public Subscriptions(string sessionId,
            List<Models.ParticipantSubscription> participants = null)
        {
            SessionId = sessionId;
            Participants = participants;
        }

        /// <summary>
        /// Session the subscriptions are associated with
        /// If this is the only field, the subscriber will be subscribed to all participants in the session (including any participants that are later added to the session)
        /// </summary>
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// Subset of participants to subscribe to in the session. Optional.
        /// </summary>
        [JsonProperty("participants", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ParticipantSubscription> Participants { get; set; }

    }
}