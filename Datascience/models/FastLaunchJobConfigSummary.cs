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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// The shape config to launch a fast launch capable job instance
    /// </summary>
    public class FastLaunchJobConfigSummary 
    {
        
        /// <value>
        /// The name of the fast launch job config
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The name of the fast launch job shape.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeName is required.")]
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }
        
        /// <value>
        /// The number of cores associated with this fast launch job shape.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CoreCount is required.")]
        [JsonProperty(PropertyName = "coreCount")]
        public System.Nullable<int> CoreCount { get; set; }
        
        /// <value>
        /// The number of cores associated with this fast launch job shape.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MemoryInGBs is required.")]
        [JsonProperty(PropertyName = "memoryInGBs")]
        public System.Nullable<int> MemoryInGBs { get; set; }
                ///
        /// <value>
        /// The family that the compute shape belongs to.
        /// 
        /// </value>
        ///
        public enum ShapeSeriesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AMD_ROME")]
            AmdRome,
            [EnumMember(Value = "INTEL_SKYLAKE")]
            IntelSkylake,
            [EnumMember(Value = "NVIDIA_GPU")]
            NvidiaGpu,
            [EnumMember(Value = "LEGACY")]
            Legacy
        };

        /// <value>
        /// The family that the compute shape belongs to.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeSeries is required.")]
        [JsonProperty(PropertyName = "shapeSeries")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ShapeSeriesEnum> ShapeSeries { get; set; }
                ///
        /// <value>
        /// The managed egress support
        /// 
        /// </value>
        ///
        public enum ManagedEgressSupportEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "REQUIRED")]
            Required,
            [EnumMember(Value = "SUPPORTED")]
            Supported,
            [EnumMember(Value = "UNSUPPORTED")]
            Unsupported
        };

        /// <value>
        /// The managed egress support
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedEgressSupport is required.")]
        [JsonProperty(PropertyName = "managedEgressSupport")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ManagedEgressSupportEnum> ManagedEgressSupport { get; set; }
        
    }
}
