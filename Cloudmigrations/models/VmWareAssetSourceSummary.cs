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


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Description of an asset source.
    /// </summary>
    public class VmWareAssetSourceSummary : AssetSourceSummary
    {
        
        /// <value>
        /// Endpoint for VMware asset discovery and replication in the form of ```https://<host>:<port>/sdk```
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcenterEndpoint is required.")]
        [JsonProperty(PropertyName = "vcenterEndpoint")]
        public string VcenterEndpoint { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "VMWARE";
    }
}
