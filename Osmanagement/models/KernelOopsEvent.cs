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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// Information about a Kernel Oops.
    /// </summary>
    public class KernelOopsEvent : Event
    {
        
        /// <value>
        /// reason of the crash
        /// </value>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
        
        /// <value>
        /// First occurrence time of the event
        /// </value>
        [JsonProperty(PropertyName = "timeFirstOccurred")]
        public System.Nullable<System.DateTime> TimeFirstOccurred { get; set; }
        
        [JsonProperty(PropertyName = "vmcore")]
        public KernelVmCoreInformation Vmcore { get; set; }
        
        [JsonProperty(PropertyName = "content")]
        public EventContent Content { get; set; }
        
        [JsonProperty(PropertyName = "system")]
        public CrashEventSystemInformation System { get; set; }
        
        [JsonProperty(PropertyName = "eventType")]
        private readonly string eventType = "KERNEL_OOPS";
    }
}
