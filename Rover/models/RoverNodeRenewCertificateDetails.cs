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


namespace Oci.RoverService.Models
{
    /// <summary>
    /// The information required to renew a certificate for a roverNode.
    /// </summary>
    public class RoverNodeRenewCertificateDetails 
    {
        
        /// <value>
        /// The certificate signing request (in PEM format), max size 10240.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Csr is required.")]
        [JsonProperty(PropertyName = "csr")]
        public string Csr { get; set; }
        
        /// <value>
        /// Time when the renewed certificate's validity will end.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCertValidityEnd is required.")]
        [JsonProperty(PropertyName = "timeCertValidityEnd")]
        public System.Nullable<System.DateTime> TimeCertValidityEnd { get; set; }
        
    }
}
