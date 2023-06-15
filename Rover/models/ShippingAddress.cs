/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// Shipping address for rover devices.
    /// </summary>
    public class ShippingAddress 
    {
        
        /// <value>
        /// Addressee in shipping address.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Addressee is required.")]
        [JsonProperty(PropertyName = "addressee")]
        public string Addressee { get; set; }
        
        /// <value>
        /// CareOf for shipping address.
        /// </value>
        [JsonProperty(PropertyName = "careOf")]
        public string CareOf { get; set; }
        
        /// <value>
        /// Address line 1.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Address1 is required.")]
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }
        
        /// <value>
        /// Address line 2.
        /// </value>
        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }
        
        /// <value>
        /// Address line 3.
        /// </value>
        [JsonProperty(PropertyName = "address3")]
        public string Address3 { get; set; }
        
        /// <value>
        /// Address line 4.
        /// </value>
        [JsonProperty(PropertyName = "address4")]
        public string Address4 { get; set; }
        
        /// <value>
        /// city or locality for shipping address.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CityOrLocality is required.")]
        [JsonProperty(PropertyName = "cityOrLocality")]
        public string CityOrLocality { get; set; }
        
        /// <value>
        /// state or region for shipping address.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StateOrRegion is required.")]
        [JsonProperty(PropertyName = "stateOrRegion")]
        public string StateOrRegion { get; set; }
        
        /// <value>
        /// zipcode for shipping address.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Zipcode is required.")]
        [JsonProperty(PropertyName = "zipcode")]
        public string Zipcode { get; set; }
        
        /// <value>
        /// country for shipping address.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Country is required.")]
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        
        /// <value>
        /// recipient phone number.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PhoneNumber is required.")]
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }
        
        /// <value>
        /// recipient email address.
        /// </value>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        
    }
}
