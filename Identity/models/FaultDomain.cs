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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// A Fault Domain is a logical grouping of hardware and infrastructure within an Availability Domain that can become
    /// unavailable in its entirety either due to hardware failure such as Top-of-rack (TOR) switch failure or due to
    /// planned software maintenance such as security updates that reboot your instances.
    /// 
    /// </summary>
    public class FaultDomain 
    {
        
        /// <value>
        /// The name of the Fault Domain.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The OCID of the Fault Domain.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment. Currently only tenancy (root) compartment can be provided.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The name of the availabilityDomain where the Fault Domain belongs.
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
    }
}
