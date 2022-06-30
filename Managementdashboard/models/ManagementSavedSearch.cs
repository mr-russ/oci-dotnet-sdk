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


namespace Oci.ManagementdashboardService.Models
{
    /// <summary>
    /// Properties of a saved search.
    /// </summary>
    public class ManagementSavedSearch 
    {
        
        /// <value>
        /// ID of the saved search.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Display name of the saved search.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// ID of the service (for example log-analytics) that owns the saved search. Each service has a unique ID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderId is required.")]
        [JsonProperty(PropertyName = "providerId")]
        public string ProviderId { get; set; }
        
        /// <value>
        /// Version of the service that owns this saved search.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderVersion is required.")]
        [JsonProperty(PropertyName = "providerVersion")]
        public string ProviderVersion { get; set; }
        
        /// <value>
        /// Name of the service (for example, Logging Analytics) that owns the saved search.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderName is required.")]
        [JsonProperty(PropertyName = "providerName")]
        public string ProviderName { get; set; }
        
        /// <value>
        /// OCID of the compartment in which the saved search resides.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Determines whether the saved search is an Out-of-the-Box (OOB) saved search. Note that OOB saved searches are only provided by Oracle and cannot be modified.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsOobSavedSearch is required.")]
        [JsonProperty(PropertyName = "isOobSavedSearch")]
        public System.Nullable<bool> IsOobSavedSearch { get; set; }
        
        /// <value>
        /// Description of the saved search.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// JSON that contains internationalization options.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Nls is required.")]
        [JsonProperty(PropertyName = "nls")]
        public System.Object Nls { get; set; }
        
        /// <value>
        /// Determines how the saved search is displayed in a dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SavedSearchTypes> Type { get; set; }
        
        /// <value>
        /// JSON that contains user interface options.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UiConfig is required.")]
        [JsonProperty(PropertyName = "uiConfig")]
        public System.Object UiConfig { get; set; }
        
        /// <value>
        /// Array of JSON that contain data source options.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataConfig is required.")]
        [JsonProperty(PropertyName = "dataConfig")]
        public System.Collections.Generic.List<System.Object> DataConfig { get; set; }
        
        /// <value>
        /// User who created the saved search.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreatedBy is required.")]
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// User who updated the saved search.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdatedBy is required.")]
        [JsonProperty(PropertyName = "updatedBy")]
        public string UpdatedBy { get; set; }
        
        /// <value>
        /// Date and time the saved search was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Date and time the saved search was updated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Screen image of the saved search.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScreenImage is required.")]
        [JsonProperty(PropertyName = "screenImage")]
        public string ScreenImage { get; set; }
        
        /// <value>
        /// Version of the metadata.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetadataVersion is required.")]
        [JsonProperty(PropertyName = "metadataVersion")]
        public string MetadataVersion { get; set; }
        
        /// <value>
        /// Reference to the HTML file of the widget.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WidgetTemplate is required.")]
        [JsonProperty(PropertyName = "widgetTemplate")]
        public string WidgetTemplate { get; set; }
        
        /// <value>
        /// Reference to the view model of the widget.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WidgetVM is required.")]
        [JsonProperty(PropertyName = "widgetVM")]
        public string WidgetVM { get; set; }
        
        /// <value>
        /// State of dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// Defines parameters for the saved search.
        /// </value>
        [JsonProperty(PropertyName = "parametersConfig")]
        public System.Collections.Generic.List<System.Object> ParametersConfig { get; set; }
        
        /// <value>
        /// Drill-down configuration to define the destination of a drill-down action.
        /// </value>
        [JsonProperty(PropertyName = "drilldownConfig")]
        public System.Collections.Generic.List<System.Object> DrilldownConfig { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
