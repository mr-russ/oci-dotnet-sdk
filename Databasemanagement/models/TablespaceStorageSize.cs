/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// Storage size.
    /// </summary>
    public class TablespaceStorageSize 
    {
        
        /// <value>
        /// Storage size number in bytes, kilobytes, megabytes, gigabytes, or terabytes.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Size is required.")]
        [JsonProperty(PropertyName = "size")]
        public System.Nullable<decimal> Size { get; set; }
                ///
        /// <value>
        /// Storage size unit: bytes, kilobytes, megabytes, gigabytes, or terabytes.
        /// 
        /// </value>
        ///
        public enum UnitEnum {
            [EnumMember(Value = "BYTES")]
            Bytes,
            [EnumMember(Value = "KILOBYTES")]
            Kilobytes,
            [EnumMember(Value = "MEGABYTES")]
            Megabytes,
            [EnumMember(Value = "GIGABYTES")]
            Gigabytes,
            [EnumMember(Value = "TERABYTES")]
            Terabytes
        };

        /// <value>
        /// Storage size unit: bytes, kilobytes, megabytes, gigabytes, or terabytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UnitEnum> Unit { get; set; }
        
    }
}
