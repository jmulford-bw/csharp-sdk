/*
 * Bandwidth.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Bandwidth.Standard;
using Bandwidth.Standard.Utilities;

namespace Bandwidth.Standard.Voice.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum FileFormatEnum
    {
        Mp3,
        Wav,
    }

    /// <summary>
    /// Helper for the enum type FileFormatEnum
    /// </summary>
    public static class FileFormatEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "mp3", "wav" };

        /// <summary>
        /// Converts a FileFormatEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The FileFormatEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(FileFormatEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case FileFormatEnum.Mp3:
                case FileFormatEnum.Wav:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of FileFormatEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of FileFormatEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<FileFormatEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into FileFormatEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed FileFormatEnum value</returns>
        public static FileFormatEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type FileFormatEnum", value));

            return (FileFormatEnum) index;
        }
    }
} 