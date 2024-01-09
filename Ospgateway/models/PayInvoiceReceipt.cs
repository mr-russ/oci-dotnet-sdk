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


namespace Oci.OspgatewayService.Models
{
    /// <summary>
    /// Invoice payment action response
    /// </summary>
    public class PayInvoiceReceipt 
    {
        
        /// <value>
        /// Url of the Payment Service
        /// </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        /// <value>
        /// Payment header id
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HeaderId is required.")]
        [JsonProperty(PropertyName = "headerId")]
        public string HeaderId { get; set; }
        
        /// <value>
        /// Token created for Payment Service
        /// </value>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
        
    }
}
