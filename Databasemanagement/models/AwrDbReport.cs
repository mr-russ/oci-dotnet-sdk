/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The result of the AWR report.
    /// </summary>
    public class AwrDbReport : AwrQueryResult
    {
        
        /// <value>
        /// The content of the report.
        /// </value>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
                ///
        /// <value>
        /// The format of the report.
        /// </value>
        ///
        public enum FormatEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "HTML")]
            Html,
            [EnumMember(Value = "TEXT")]
            Text,
            [EnumMember(Value = "XML")]
            Xml
        };

        /// <value>
        /// The format of the report.
        /// </value>
        [JsonProperty(PropertyName = "format")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<FormatEnum> Format { get; set; }
        
        [JsonProperty(PropertyName = "awrResultType")]
        private readonly string awrResultType = "AWRDB_DB_REPORT";
    }
}
