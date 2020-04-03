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
    public class RecordingMetadataResponse 
    {
        public RecordingMetadataResponse() { }

        public RecordingMetadataResponse(string applicationId = null,
            string accountId = null,
            string callId = null,
            string recordingId = null,
            string to = null,
            string from = null,
            string duration = null,
            Models.DirectionEnum? direction = null,
            int? channels = null,
            long? startTime = null,
            long? endTime = null,
            Models.FileFormatEnum? fileFormat = null,
            Models.StatusEnum? status = null,
            string mediaUrl = null,
            Models.Transcription transcription = null)
        {
            ApplicationId = applicationId;
            AccountId = accountId;
            CallId = callId;
            RecordingId = recordingId;
            To = to;
            From = from;
            Duration = duration;
            Direction = direction;
            Channels = channels;
            StartTime = startTime;
            EndTime = endTime;
            FileFormat = fileFormat;
            Status = status;
            MediaUrl = mediaUrl;
            Transcription = transcription;
        }

        /// <summary>
        /// Getter for applicationId
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Getter for accountId
        /// </summary>
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Getter for callId
        /// </summary>
        [JsonProperty("callId")]
        public string CallId { get; set; }

        /// <summary>
        /// Getter for recordingId
        /// </summary>
        [JsonProperty("recordingId")]
        public string RecordingId { get; set; }

        /// <summary>
        /// Getter for to
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }

        /// <summary>
        /// Getter for from
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }

        /// <summary>
        /// Format is ISO-8601
        /// </summary>
        [JsonProperty("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Getter for direction
        /// </summary>
        [JsonProperty("direction", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.DirectionEnum? Direction { get; set; }

        /// <summary>
        /// Getter for channels
        /// </summary>
        [JsonProperty("channels")]
        public int? Channels { get; set; }

        /// <summary>
        /// Getter for startTime
        /// </summary>
        [JsonProperty("startTime")]
        public long? StartTime { get; set; }

        /// <summary>
        /// Getter for endTime
        /// </summary>
        [JsonProperty("endTime")]
        public long? EndTime { get; set; }

        /// <summary>
        /// Getter for fileFormat
        /// </summary>
        [JsonProperty("fileFormat", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.FileFormatEnum? FileFormat { get; set; }

        /// <summary>
        /// Getter for status
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.StatusEnum? Status { get; set; }

        /// <summary>
        /// Getter for mediaUrl
        /// </summary>
        [JsonProperty("mediaUrl")]
        public string MediaUrl { get; set; }

        /// <summary>
        /// Getter for transcription
        /// </summary>
        [JsonProperty("transcription")]
        public Models.Transcription Transcription { get; set; }

    }
}