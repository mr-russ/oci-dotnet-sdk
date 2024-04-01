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


namespace Oci.EmailService.Models
{
    /// <summary>
    /// Tenancy level customer email configuration details.
    /// </summary>
    public class Configuration 
    {
        
        /// <value>
        /// The root compartment [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) (same as the tenancy OCID)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Endpoint used to submit emails via the HTTP email submission API
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HttpSubmitEndpoint is required.")]
        [JsonProperty(PropertyName = "httpSubmitEndpoint")]
        public string HttpSubmitEndpoint { get; set; }
        
        /// <value>
        /// Endpoint used to submit emails via the standard SMTP submission protocol. Note that TLS 1.2 and standard SMTP authentication is required for submission.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SmtpSubmitEndpoint is required.")]
        [JsonProperty(PropertyName = "smtpSubmitEndpoint")]
        public string SmtpSubmitEndpoint { get; set; }
        
    }
}
