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
    /// Specifies details within the VCN.
    /// </summary>
    public class VcnDrgAttachmentNetworkDetails : DrgAttachmentNetworkDetails
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route table the DRG attachment is using.
        /// <br/>
        /// For information about why you would associate a route table with a DRG attachment, see:
        /// <br/>
        ///   * [Transit Routing: Access to Multiple VCNs in Same Region](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/transitrouting.htm)
        ///   * [Transit Routing: Private Access to Oracle Services](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/transitroutingoracleservices.htm)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routeTableId")]
        public string RouteTableId { get; set; }
                ///
        /// <value>
        /// Indicates whether the VCN CIDRs or the individual subnet CIDRs are imported from the attachment.
        /// Routes from the VCN ingress route table are always imported.
        /// 
        /// </value>
        ///
        public enum VcnRouteTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "VCN_CIDRS")]
            VcnCidrs,
            [EnumMember(Value = "SUBNET_CIDRS")]
            SubnetCidrs
        };

        /// <value>
        /// Indicates whether the VCN CIDRs or the individual subnet CIDRs are imported from the attachment.
        /// Routes from the VCN ingress route table are always imported.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vcnRouteType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<VcnRouteTypeEnum> VcnRouteType { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "VCN";
    }
}
