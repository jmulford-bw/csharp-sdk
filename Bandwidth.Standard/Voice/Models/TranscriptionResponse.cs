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
    public class TranscriptionResponse 
    {
        public TranscriptionResponse() { }

        public TranscriptionResponse(List<Models.Transcript> transcripts = null)
        {
            Transcripts = transcripts;
        }

        /// <summary>
        /// Getter for transcripts
        /// </summary>
        [JsonProperty("transcripts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Transcript> Transcripts { get; set; }

    }
}