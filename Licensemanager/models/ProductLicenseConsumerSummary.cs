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


namespace Oci.LicensemanagerService.Models
{
    /// <summary>
    /// Details of a resource that is consuming a particular product license.
    /// 
    /// </summary>
    public class ProductLicenseConsumerSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// The display name of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceName is required.")]
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// The resource product name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProductName is required.")]
        [JsonProperty(PropertyName = "productName")]
        public string ProductName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment that contains the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceCompartmentId is required.")]
        [JsonProperty(PropertyName = "resourceCompartmentId")]
        public string ResourceCompartmentId { get; set; }
        
        /// <value>
        /// The display name of the compartment that contains the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceCompartmentName is required.")]
        [JsonProperty(PropertyName = "resourceCompartmentName")]
        public string ResourceCompartmentName { get; set; }
        
        /// <value>
        /// The unit type for the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceUnitType is required.")]
        [JsonProperty(PropertyName = "resourceUnitType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceUnit> ResourceUnitType { get; set; }
        
        /// <value>
        /// Number of units of the resource
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceUnitCount is required.")]
        [JsonProperty(PropertyName = "resourceUnitCount")]
        public System.Double ResourceUnitCount { get; set; }
        
        /// <value>
        /// The product license unit.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LicenseUnitType is required.")]
        [JsonProperty(PropertyName = "licenseUnitType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LicenseUnit> LicenseUnitType { get; set; }
        
        /// <value>
        /// Number of license units consumed by the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LicenseUnitsConsumed is required.")]
        [JsonProperty(PropertyName = "licenseUnitsConsumed")]
        public System.Double LicenseUnitsConsumed { get; set; }
        
        /// <value>
        /// Specifies if the base license is available.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsBaseLicenseAvailable is required.")]
        [JsonProperty(PropertyName = "isBaseLicenseAvailable")]
        public System.Nullable<bool> IsBaseLicenseAvailable { get; set; }
        
        /// <value>
        /// Specifies if all options are available.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AreAllOptionsAvailable is required.")]
        [JsonProperty(PropertyName = "areAllOptionsAvailable")]
        public System.Nullable<bool> AreAllOptionsAvailable { get; set; }
        
        /// <value>
        /// Collection of missing product licenses.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MissingProducts is required.")]
        [JsonProperty(PropertyName = "missingProducts")]
        public System.Collections.Generic.List<Product> MissingProducts { get; set; }
        
    }
}
