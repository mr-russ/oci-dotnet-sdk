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


namespace Oci.OnesubscriptionService.Models
{
    /// <summary>
    /// Address location.
    /// 
    /// </summary>
    public class InvoicingLocation 
    {
        
        /// <value>
        /// Address first line.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }
        
        /// <value>
        /// Address second line.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }
        
        /// <value>
        /// Postal code.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }
        
        /// <value>
        /// City.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        
        /// <value>
        /// Country.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        
        /// <value>
        /// Region.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// TCA Location identifier.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tcaLocationId")]
        public System.Nullable<long> TcaLocationId { get; set; }
        
    }
}
