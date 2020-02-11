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


namespace Bandwidth.Standard.Voice.Models
{
    public class ApiCallStateResponse 
    {
        public ApiCallStateResponse() { }

        public ApiCallStateResponse(string callId = null,
            string parentCallId = null,
            string applicationId = null,
            string accountId = null,
            string to = null,
            string mFrom = null,
            string direction = null,
            Models.StateEnum? state = null,
            DateTime? startTime = null,
            DateTime? answerTime = null,
            DateTime? endTime = null,
            Models.DisconnectCauseEnum? disconnectCause = null,
            string errorMessage = null,
            string errorId = null,
            DateTime? lastUpdate = null)
        {
            CallId = callId;
            ParentCallId = parentCallId;
            ApplicationId = applicationId;
            AccountId = accountId;
            To = to;
            MFrom = mFrom;
            Direction = direction;
            State = state;
            StartTime = startTime;
            AnswerTime = answerTime;
            EndTime = endTime;
            DisconnectCause = disconnectCause;
            ErrorMessage = errorMessage;
            ErrorId = errorId;
            LastUpdate = lastUpdate;
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("callId")]
        public string CallId { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("parentCallId")]
        public string ParentCallId { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("from")]
        public string MFrom { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("state", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.StateEnum? State { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("answerTime")]
        public DateTime? AnswerTime { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("disconnectCause", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.DisconnectCauseEnum? DisconnectCause { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("errorId")]
        public string ErrorId { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastUpdate")]
        public DateTime? LastUpdate { get; set; }

    }
} 