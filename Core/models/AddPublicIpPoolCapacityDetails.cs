/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
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
    /// The data to add capacity to a public ip pool
    /// </summary>
    public class AddPublicIpPoolCapacityDetails 
    {
        
        /// <value>
        /// The OCID of the Byoip Range Id object to whch the cidr block belongs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ByoipRangeId is required.")]
        [JsonProperty(PropertyName = "byoipRangeId")]
        public string ByoipRangeId { get; set; }

        /// <value>
        /// The CIDR IP address range to be added to the Public Ip Pool
        /// Example: 10.0.1.0/24
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CidrBlock is required.")]
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }
    }
}
