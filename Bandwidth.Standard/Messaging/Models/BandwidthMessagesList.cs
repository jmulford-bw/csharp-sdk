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

namespace Bandwidth.Standard.Messaging.Models
{
    public class BandwidthMessagesList 
    {
        public BandwidthMessagesList() { }

        public BandwidthMessagesList(int? totalCount = null,
            Models.PageInfo pageInfo = null,
            List<Models.BandwidthMessageItem> messages = null)
        {
            TotalCount = totalCount;
            PageInfo = pageInfo;
            Messages = messages;
        }

        /// <summary>
        /// Total number of messages matched by the search
        /// </summary>
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Getter for pageInfo
        /// </summary>
        [JsonProperty("pageInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PageInfo PageInfo { get; set; }

        /// <summary>
        /// Getter for messages
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BandwidthMessageItem> Messages { get; set; }

    }
}