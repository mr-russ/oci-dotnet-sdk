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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// An object defining the OCID of the Secret held in Vault that represent the MACsec key.
    /// </summary>
    public class UpdateMacsecKey 
    {
        
        /// <value>
        /// Secret [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) containing the Connectivity Association Key Name (CKN) of this MACsec key.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectivityAssociationNameSecretId is required.")]
        [JsonProperty(PropertyName = "connectivityAssociationNameSecretId")]
        public string ConnectivityAssociationNameSecretId { get; set; }
        
        /// <value>
        /// The secret version of the connectivity association name secret in Vault.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectivityAssociationNameSecretVersion is required.")]
        [JsonProperty(PropertyName = "connectivityAssociationNameSecretVersion")]
        public System.Nullable<long> ConnectivityAssociationNameSecretVersion { get; set; }
        
        /// <value>
        /// Secret [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) containing the Connectivity Association Key (CAK) of this MACsec key.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectivityAssociationKeySecretId is required.")]
        [JsonProperty(PropertyName = "connectivityAssociationKeySecretId")]
        public string ConnectivityAssociationKeySecretId { get; set; }
        
        /// <value>
        /// The secret version of the connectivityAssociationKey secret in Vault.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectivityAssociationKeySecretVersion is required.")]
        [JsonProperty(PropertyName = "connectivityAssociationKeySecretVersion")]
        public System.Nullable<long> ConnectivityAssociationKeySecretVersion { get; set; }
        
    }
}
