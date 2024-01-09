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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// The information about the Compute Instance host to be analyzed.
    /// </summary>
    public class CreateMacsManagedCloudHostInsightDetails : CreateHostInsightDetails
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Compute Instance
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeId is required.")]
        [JsonProperty(PropertyName = "computeId")]
        public string ComputeId { get; set; }
        
        [JsonProperty(PropertyName = "entitySource")]
        private readonly string entitySource = "MACS_MANAGED_CLOUD_HOST";
    }
}
