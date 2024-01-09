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


namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// Request for ICMP6 Application used on the firewall policy rules.
    /// </summary>
    public class CreateIcmp6ApplicationDetails : CreateApplicationDetails
    {
        
        /// <value>
        /// The value of the ICMP6 message Type field as defined by [RFC 4443](https://www.rfc-editor.org/rfc/rfc4443.html#section-2.1).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IcmpType is required.")]
        [JsonProperty(PropertyName = "icmpType")]
        public System.Nullable<int> IcmpType { get; set; }
        
        /// <value>
        /// The value of the ICMP6 message Code (subtype) field as defined by [RFC 4443](https://www.rfc-editor.org/rfc/rfc4443.html#section-2.1).
        /// </value>
        [JsonProperty(PropertyName = "icmpCode")]
        public System.Nullable<int> IcmpCode { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "ICMP_V6";
    }
}
