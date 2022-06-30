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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The platform configuration of a bare metal instance that uses the BM.Standard.E3.128 shape (the AMD Rome platform).
    /// 
    /// </summary>
    public class AmdRomeBmPlatformConfig : PlatformConfig
    {
                ///
        /// <value>
        /// The number of NUMA nodes per socket (NPS).
        /// 
        /// </value>
        ///
        public enum NumaNodesPerSocketEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NPS0")]
            Nps0,
            [EnumMember(Value = "NPS1")]
            Nps1,
            [EnumMember(Value = "NPS2")]
            Nps2,
            [EnumMember(Value = "NPS4")]
            Nps4
        };

        /// <value>
        /// The number of NUMA nodes per socket (NPS).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "numaNodesPerSocket")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NumaNodesPerSocketEnum> NumaNodesPerSocket { get; set; }
        
        /// <value>
        /// Whether symmetric multithreading is enabled on the instance. Symmetric multithreading is also
        /// called simultaneous multithreading (SMT) or Intel Hyper-Threading.
        /// <br/>
        /// Intel and AMD processors have two hardware execution threads per core (OCPU). SMT permits multiple
        /// independent threads of execution, to better use the resources and increase the efficiency
        /// of the CPU. When multithreading is disabled, only one thread is permitted to run on each core, which
        /// can provide higher or more predictable performance for some workloads.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSymmetricMultiThreadingEnabled")]
        public System.Nullable<bool> IsSymmetricMultiThreadingEnabled { get; set; }
        
        /// <value>
        /// Whether the Access Control Service is enabled on the instance. When enabled,
        /// the platform can enforce PCIe device isolation, required for VFIO device pass-through.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAccessControlServiceEnabled")]
        public System.Nullable<bool> IsAccessControlServiceEnabled { get; set; }
        
        /// <value>
        /// Whether virtualization instructions are available. For example, Secure Virtual Machine for AMD shapes
        /// or VT-x for Intel shapes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "areVirtualInstructionsEnabled")]
        public System.Nullable<bool> AreVirtualInstructionsEnabled { get; set; }
        
        /// <value>
        /// Whether the input-output memory management unit is enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isInputOutputMemoryManagementUnitEnabled")]
        public System.Nullable<bool> IsInputOutputMemoryManagementUnitEnabled { get; set; }
        
        /// <value>
        /// The percentage of cores enabled. Value must be a multiple of 25%. If the requested percentage
        /// results in a fractional number of cores, the system rounds up the number of cores across processors
        /// and provisions an instance with a whole number of cores.
        /// <br/>
        /// If the applications that you run on the instance use a core-based licensing model and need fewer cores
        /// than the full size of the shape, you can disable cores to reduce your licensing costs. The instance
        /// itself is billed for the full shape, regardless of whether all cores are enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "percentageOfCoresEnabled")]
        public System.Nullable<int> PercentageOfCoresEnabled { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "AMD_ROME_BM";
    }
}
