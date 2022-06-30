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


namespace Oci.BlockchainService.Models
{
    /// <summary>
    /// A Peer details
    /// </summary>
    public class Peer 
    {
        
        /// <value>
        /// peer identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeerKey is required.")]
        [JsonProperty(PropertyName = "peerKey")]
        public string PeerKey { get; set; }
        
        /// <value>
        /// Peer role
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Role is required.")]
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PeerRole.RoleEnum> Role { get; set; }
        
        /// <value>
        /// peer alias
        /// </value>
        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }
        
        [JsonProperty(PropertyName = "ocpuAllocationParam")]
        public OcpuAllocationNumberParam OcpuAllocationParam { get; set; }
        
        /// <value>
        /// Host on which the Peer exists
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Host is required.")]
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// Availability Domain of peer
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ad is required.")]
        [JsonProperty(PropertyName = "ad")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AvailabilityDomain.AdsEnum> Ad { get; set; }
                ///
        /// <value>
        /// The current state of the peer.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the peer.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
    }
}
