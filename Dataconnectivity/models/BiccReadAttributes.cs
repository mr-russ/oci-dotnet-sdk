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


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// Properties to configure reading from an Oracle Database.
    /// </summary>
    public class BiccReadAttributes : AbstractReadAttribute
    {
        
        /// <value>
        /// The fetch size for reading.
        /// </value>
        [JsonProperty(PropertyName = "fetchSize")]
        public System.Nullable<int> FetchSize { get; set; }
                ///
        /// <value>
        /// Extraction Strategy - FULL|INCREMENTAL
        /// </value>
        ///
        public enum ExtractStrategyEnum {
            [EnumMember(Value = "FULL")]
            Full,
            [EnumMember(Value = "INCREMENTAL")]
            Incremental
        };

        /// <value>
        /// Extraction Strategy - FULL|INCREMENTAL
        /// </value>
        [JsonProperty(PropertyName = "extractStrategy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ExtractStrategyEnum> ExtractStrategy { get; set; }
        
        [JsonProperty(PropertyName = "externalStorage")]
        public ExternalStorage ExternalStorage { get; set; }
        
        /// <value>
        /// Date from where extract should start.
        /// </value>
        [JsonProperty(PropertyName = "initialExtractDate")]
        public System.Nullable<System.DateTime> InitialExtractDate { get; set; }
        
        /// <value>
        /// Date last extracted
        /// </value>
        [JsonProperty(PropertyName = "lastExtractDate")]
        public System.Nullable<System.DateTime> LastExtractDate { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "BICC_READ_ATTRIBUTE";
    }
}
