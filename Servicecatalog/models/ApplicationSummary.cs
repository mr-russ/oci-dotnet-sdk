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


namespace Oci.ServicecatalogService.Models
{
    /// <summary>
    /// The model for summary of an application in service catalog.
    /// </summary>
    public class ApplicationSummary 
    {
        
        /// <value>
        /// Identifier of the application from a service catalog.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityId is required.")]
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }
        
        /// <value>
        /// The type of an application in the service catalog.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityType is required.")]
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }
        
        /// <value>
        /// The name that service catalog should use to display this application.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Indicates whether the application is featured.
        /// </value>
        [JsonProperty(PropertyName = "isFeatured")]
        public System.Nullable<bool> IsFeatured { get; set; }
        
        [JsonProperty(PropertyName = "publisher")]
        public PublisherSummary Publisher { get; set; }
        
        /// <value>
        /// A short description of the application.
        /// </value>
        [JsonProperty(PropertyName = "shortDescription")]
        public string ShortDescription { get; set; }
        
        [JsonProperty(PropertyName = "logo")]
        public UploadData Logo { get; set; }
        
        /// <value>
        /// Summary of the pricing types available across all packages in the application.
        /// </value>
        [JsonProperty(PropertyName = "pricingType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PricingTypeEnum> PricingType { get; set; }
        
        /// <value>
        /// The type of the packages withing the application.
        /// </value>
        [JsonProperty(PropertyName = "packageType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PackageTypeEnum> PackageType { get; set; }
        
    }
}
