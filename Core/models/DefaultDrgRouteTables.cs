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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The default DRG route table for this DRG. Each network type
    /// has a default DRG route table.
    /// <br/>
    /// You can update a network type to use a different DRG route table, but
    /// each network type must have a default DRG route table. You cannot delete
    /// a default DRG route table.
    /// 
    /// </summary>
    public class DefaultDrgRouteTables 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the default DRG route table to be assigned to DRG attachments
        /// of type VCN on creation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vcn")]
        public string Vcn { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the default DRG route table assigned to DRG attachments
        /// of type IPSEC_TUNNEL on creation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipsecTunnel")]
        public string IpsecTunnel { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the default DRG route table to be assigned to DRG attachments
        /// of type VIRTUAL_CIRCUIT on creation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "virtualCircuit")]
        public string VirtualCircuit { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the default DRG route table to be assigned to DRG attachments
        /// of type REMOTE_PEERING_CONNECTION on creation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "remotePeeringConnection")]
        public string RemotePeeringConnection { get; set; }
        
    }
}
