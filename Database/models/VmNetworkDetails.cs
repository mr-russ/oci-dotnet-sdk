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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of the client or backup networks in an Exadata VM cluster network. Applies to Exadata Cloud@Customer instances only.
    /// 
    /// </summary>
    public class VmNetworkDetails 
    {
        
        /// <value>
        /// The network VLAN ID.
        /// </value>
        [JsonProperty(PropertyName = "vlanId")]
        public string VlanId { get; set; }
                ///
        /// <value>
        /// The network type.
        /// </value>
        ///
        public enum NetworkTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CLIENT")]
            Client,
            [EnumMember(Value = "BACKUP")]
            Backup,
            [EnumMember(Value = "DISASTER_RECOVERY")]
            DisasterRecovery
        };

        /// <value>
        /// The network type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NetworkType is required.")]
        [JsonProperty(PropertyName = "networkType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NetworkTypeEnum> NetworkType { get; set; }
        
        /// <value>
        /// The network netmask.
        /// </value>
        [JsonProperty(PropertyName = "netmask")]
        public string Netmask { get; set; }
        
        /// <value>
        /// The network gateway.
        /// </value>
        [JsonProperty(PropertyName = "gateway")]
        public string Gateway { get; set; }
        
        /// <value>
        /// The network domain name.
        /// </value>
        [JsonProperty(PropertyName = "domainName")]
        public string DomainName { get; set; }
        
        /// <value>
        /// The list of node details.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Nodes is required.")]
        [JsonProperty(PropertyName = "nodes")]
        public System.Collections.Generic.List<NodeDetails> Nodes { get; set; }
        
    }
}
