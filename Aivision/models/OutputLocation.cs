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


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// OCI Object Storage Location.
    /// </summary>
    public class OutputLocation 
    {
        
        /// <value>
        /// Object Storage namespace.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceName is required.")]
        [JsonProperty(PropertyName = "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// Object Storage bucket name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BucketName is required.")]
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// Object Storage folder name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Prefix is required.")]
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }
        
    }
}
