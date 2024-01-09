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
    /// The secondary VNIC object for the placement configuration for an instance pool.
    /// </summary>
    public class InstancePoolPlacementSecondaryVnicSubnet 
    {
        
        /// <value>
        /// The display name of the VNIC. This is also used to match against the instance configuration defined
        /// secondary VNIC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Whether to allocate an IPv6 address at instance and VNIC creation from an IPv6 enabled
        /// subnet. Default: False. When provided you may optionally provide an IPv6 prefix
        /// (`ipv6SubnetCidr`) of your choice to assign the IPv6 address from. If `ipv6SubnetCidr`
        /// is not provided then an IPv6 prefix is chosen
        /// for you.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAssignIpv6Ip")]
        public System.Nullable<bool> IsAssignIpv6Ip { get; set; }
        
        /// <value>
        /// A list of IPv6 prefix ranges from which the VNIC should be assigned an IPv6 address.
        /// You can provide only the prefix ranges and OCI will select an available
        /// address from the range. You can optionally choose to leave the prefix range empty
        /// and instead provide the specific IPv6 address that should be used from within that range.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipv6AddressIpv6SubnetCidrPairDetails")]
        public System.Collections.Generic.List<InstancePoolPlacementIpv6AddressIpv6SubnetCidrDetails> Ipv6AddressIpv6SubnetCidrPairDetails { get; set; }
        
        /// <value>
        /// The subnet [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for the secondary VNIC.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
    }
}
