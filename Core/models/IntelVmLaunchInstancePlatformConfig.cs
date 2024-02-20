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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The platform configuration used when launching a virtual machine instance with the Intel platform.
    /// 
    /// </summary>
    public class IntelVmLaunchInstancePlatformConfig : LaunchInstancePlatformConfig
    {
        
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
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "INTEL_VM";
    }
}
