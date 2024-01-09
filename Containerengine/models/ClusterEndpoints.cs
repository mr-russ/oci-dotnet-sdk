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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The properties that define endpoints for a cluster.
    /// </summary>
    public class ClusterEndpoints 
    {
        
        /// <value>
        /// The non-native networking Kubernetes API server endpoint.
        /// </value>
        [JsonProperty(PropertyName = "kubernetes")]
        public string Kubernetes { get; set; }
        
        /// <value>
        /// The public native networking Kubernetes API server endpoint, if one was requested.
        /// </value>
        [JsonProperty(PropertyName = "publicEndpoint")]
        public string PublicEndpoint { get; set; }
        
        /// <value>
        /// The private native networking Kubernetes API server endpoint.
        /// </value>
        [JsonProperty(PropertyName = "privateEndpoint")]
        public string PrivateEndpoint { get; set; }
        
        /// <value>
        /// The FQDN assigned to the Kubernetes API private endpoint.
        /// Example: 'https://yourVcnHostnameEndpoint'
        /// </value>
        [JsonProperty(PropertyName = "vcnHostnameEndpoint")]
        public string VcnHostnameEndpoint { get; set; }
        
    }
}
