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
    public class Tag 
    {
        public Tag() { }

        public Tag(string key = null,
            string mValue = null)
        {
            Key = key;
            MValue = mValue;
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("value")]
        public string MValue { get; set; }

    }
} 