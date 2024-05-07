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


namespace Oci.LoadbalancerService.Models
{
    
    public class ReservedIP 
    {
        
        /// <value>
        /// Ocid of the Reserved IP/Public Ip created with VCN.
        /// <br/>
        /// Reserved IPs are IPs which already registered using VCN API.
        /// <br/>
        /// Create a reserved Public IP and then while creating the load balancer pass the ocid of the reserved IP in this
        /// field reservedIp to attach the Ip to Load balancer. Load balancer will be configured to listen to traffic on this IP.
        /// <br/>
        /// Reserved IPs will not be deleted when the Load balancer is deleted. They will be unattached from the Load balancer.
        /// <br/>
        /// Example: &quot;ocid1.publicip.oc1.phx.unique_ID&quot;
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
    }
}
