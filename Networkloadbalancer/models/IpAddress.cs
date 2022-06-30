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


namespace Oci.NetworkloadbalancerService.Models
{
    /// <summary>
    /// A load balancer IP address.
    /// </summary>
    public class IpAddress 
    {
        
        /// <value>
        /// An IP address.
        /// <br/>
        /// Example: 192.168.0.3
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IpAddressProp is required.")]
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddressProp { get; set; }
        
        /// <value>
        /// Whether the IP address is public or private.
        /// <br/>
        /// If \"true\", then the IP address is public and accessible from the internet.
        /// <br/>
        /// If \"false\", then the IP address is private and accessible only from within the associated virtual cloud network.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPublic")]
        public System.Nullable<bool> IsPublic { get; set; }
        
        /// <value>
        /// IP version associated with this IP address.
        /// </value>
        [JsonProperty(PropertyName = "ipVersion")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<IpVersion> IpVersion { get; set; }
        
        [JsonProperty(PropertyName = "reservedIp")]
        public ReservedIP ReservedIp { get; set; }
        
    }
}
