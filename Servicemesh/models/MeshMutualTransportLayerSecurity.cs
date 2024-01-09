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


namespace Oci.ServicemeshService.Models
{
    /// <summary>
    /// Sets a minimum level of mTLS authentication for all virtual services within the mesh.
    /// </summary>
    public class MeshMutualTransportLayerSecurity 
    {
        
        /// <value>
        /// DISABLED: No minimum virtual services within this mesh can use any mTLS authentication mode.
        /// PERMISSIVE: Virtual services within this mesh can use either PERMISSIVE or STRICT modes.
        /// STRICT: All virtual services within this mesh must use STRICT mode.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Minimum is required.")]
        [JsonProperty(PropertyName = "minimum")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MutualTransportLayerSecurity.ModeEnum> Minimum { get; set; }
        
    }
}
