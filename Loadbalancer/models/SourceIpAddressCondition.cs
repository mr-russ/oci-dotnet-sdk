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
    /// <summary>
    /// A rule condition that checks client source IP against specified IP address or address range.
    /// 
    /// </summary>
    public class SourceIpAddressCondition : RuleCondition
    {
        
        /// <value>
        /// An IPv4 or IPv6 address range that the source IP address of an incoming packet must match.
        /// <br/>
        /// The service accepts only classless inter-domain routing (CIDR) format (x.x.x.x/y or x:x::x/y) strings.
        /// <br/>
        /// Specify 0.0.0.0/0 or ::/0 to match all incoming traffic.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttributeValue is required.")]
        [JsonProperty(PropertyName = "attributeValue")]
        public string AttributeValue { get; set; }
        
        [JsonProperty(PropertyName = "attributeName")]
        private readonly string attributeName = "SOURCE_IP_ADDRESS";
    }
}
