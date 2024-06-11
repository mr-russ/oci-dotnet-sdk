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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Summary information on impacted resource in resource profile.
    /// </summary>
    public class ResourceProfileImpactedResourceSummary 
    {
        
        /// <value>
        /// Unique identifier for impacted resource
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Resource profile ID associated with the impacted resource
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceProfileId is required.")]
        [JsonProperty(PropertyName = "resourceProfileId")]
        public string ResourceProfileId { get; set; }
        
        /// <value>
        /// Problem ID associated with the impacted resource
        /// </value>
        [JsonProperty(PropertyName = "problemId")]
        public string ProblemId { get; set; }
        
        /// <value>
        /// Compartment ID for impacted resource
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Impacted resource ID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Impacted resource name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceName is required.")]
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// Impacted resource type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// Sighting type for impacted resource
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SightingType is required.")]
        [JsonProperty(PropertyName = "sightingType")]
        public string SightingType { get; set; }
        
        /// <value>
        /// Display name of the sighting type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SightingTypeDisplayName is required.")]
        [JsonProperty(PropertyName = "sightingTypeDisplayName")]
        public string SightingTypeDisplayName { get; set; }
        
        /// <value>
        /// Region for impacted resource
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Region is required.")]
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// Time when the impacted resource is identified for the resource profile.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIdentified is required.")]
        [JsonProperty(PropertyName = "timeIdentified")]
        public System.Nullable<System.DateTime> TimeIdentified { get; set; }
        
        /// <value>
        /// Time the activities were first detected.
        /// </value>
        [JsonProperty(PropertyName = "timeFirstDetected")]
        public System.Nullable<System.DateTime> TimeFirstDetected { get; set; }
        
        /// <value>
        /// Time the activities were last detected. Same as timeIdentified.
        /// </value>
        [JsonProperty(PropertyName = "timeLastDetected")]
        public System.Nullable<System.DateTime> TimeLastDetected { get; set; }
        
        /// <value>
        /// Time the activities were first performed.
        /// </value>
        [JsonProperty(PropertyName = "timeFirstOccurred")]
        public System.Nullable<System.DateTime> TimeFirstOccurred { get; set; }
        
        /// <value>
        /// Time the activities were last performed.
        /// </value>
        [JsonProperty(PropertyName = "timeLastOccurred")]
        public System.Nullable<System.DateTime> TimeLastOccurred { get; set; }
        
    }
}
