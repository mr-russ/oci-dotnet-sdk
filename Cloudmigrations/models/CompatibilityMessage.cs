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


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Information about shape compatibility with the client's current resource configuration.
    /// </summary>
    public class CompatibilityMessage 
    {
                ///
        /// <value>
        /// Severity level of the compatibility issue.
        /// </value>
        ///
        public enum SeverityEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "INFO")]
            Info
        };

        /// <value>
        /// Severity level of the compatibility issue.
        /// </value>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SeverityEnum> Severity { get; set; }
                ///
        /// <value>
        /// Name of the compatibility issue.
        /// </value>
        ///
        public enum NameEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NOT_ENOUGH_DATA")]
            NotEnoughData,
            [EnumMember(Value = "INVALID_DATA")]
            InvalidData,
            [EnumMember(Value = "CPU_COMPATIBILITY_WARNING")]
            CpuCompatibilityWarning,
            [EnumMember(Value = "CPU_METRIC_INFO")]
            CpuMetricInfo,
            [EnumMember(Value = "MEMORY_COMPATIBILITY_WARNING")]
            MemoryCompatibilityWarning,
            [EnumMember(Value = "MEMORY_METRIC_INFO")]
            MemoryMetricInfo,
            [EnumMember(Value = "VNICS_COMPATIBILITY_WARNING")]
            VnicsCompatibilityWarning,
            [EnumMember(Value = "BANDWIDTH_COMPATIBILITY_WARNING")]
            BandwidthCompatibilityWarning,
            [EnumMember(Value = "GPU_COMPATIBILITY_WARNING")]
            GpuCompatibilityWarning,
            [EnumMember(Value = "OS_WARNING")]
            OsWarning
        };

        /// <value>
        /// Name of the compatibility issue.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NameEnum> Name { get; set; }
        
        /// <value>
        /// Detailed description of the compatibility issue.
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
    }
}
