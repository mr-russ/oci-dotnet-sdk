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


namespace Oci.ComputecloudatcustomerService.Models
{
    /// <summary>
    /// Routing information for peer nodes using the Border Gateway Protocol (BGP).
    /// 
    /// </summary>
    public class PeerInformation 
    {
        
        /// <value>
        /// The Autonomous System Number (ASN) of the peer network.
        /// </value>
        [JsonProperty(PropertyName = "asn")]
        public System.Nullable<int> Asn { get; set; }
        
        /// <value>
        /// Neighbor Border Gateway Protocal (BGP) IP address.
        /// The IP address usually refers to the customer data center router.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }
        
    }
}
