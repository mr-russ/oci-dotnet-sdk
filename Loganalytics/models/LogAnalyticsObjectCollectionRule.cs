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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// The configuration details of an Object Storage based collection rule.
    /// 
    /// </summary>
    public class LogAnalyticsObjectCollectionRule 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of this rule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A unique name to the rule. The name must be unique, within the tenancy, and cannot be changed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A string that describes the details of the rule. It does not have to be unique, and can be changed.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment to which this rule belongs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Object Storage namespace.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsNamespace is required.")]
        [JsonProperty(PropertyName = "osNamespace")]
        public string OsNamespace { get; set; }
        
        /// <value>
        /// Name of the Object Storage bucket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsBucketName is required.")]
        [JsonProperty(PropertyName = "osBucketName")]
        public string OsBucketName { get; set; }
        
        /// <value>
        /// The type of log collection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CollectionType is required.")]
        [JsonProperty(PropertyName = "collectionType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ObjectCollectionRuleCollectionTypes> CollectionType { get; set; }
        
        /// <value>
        /// The oldest time of the file in the bucket to consider for collection.
        /// Accepted values are: BEGINNING or CURRENT_TIME or RFC3339 formatted datetime string.
        /// Use this for HISTORIC or HISTORIC_LIVE collection types. When collectionType is LIVE, specifying pollSince value other than CURRENT_TIME will result in error.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PollSince is required.")]
        [JsonProperty(PropertyName = "pollSince")]
        public string PollSince { get; set; }
        
        /// <value>
        /// The newest time of the file in the bucket to consider for collection.
        /// Accepted values are: CURRENT_TIME or RFC3339 formatted datetime string.
        /// Use this for HISTORIC collection type. When collectionType is LIVE or HISTORIC_LIVE, specifying pollTill will result in error.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "pollTill")]
        public string PollTill { get; set; }
        
        /// <value>
        /// Logging Analytics Log group OCID to associate the processed logs with.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogGroupId is required.")]
        [JsonProperty(PropertyName = "logGroupId")]
        public string LogGroupId { get; set; }
        
        /// <value>
        /// Name of the Logging Analytics Source to use for the processing.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogSourceName is required.")]
        [JsonProperty(PropertyName = "logSourceName")]
        public string LogSourceName { get; set; }
        
        /// <value>
        /// Logging Analytics entity OCID to associate the processed logs with.
        /// </value>
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }
        
        /// <value>
        /// An optional character encoding to aid in detecting the character encoding of the contents of the objects while processing.
        /// It is recommended to set this value as ISO_8859_1 when configuring content of the objects having more numeric characters,
        /// and very few alphabets.
        /// For e.g. this applies when configuring VCN Flow Logs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "charEncoding")]
        public string CharEncoding { get; set; }
        
        /// <value>
        /// Timezone to be used when processing log entries whose timestamps do not include an explicit timezone. 
        /// When this property is not specified, the timezone of the entity specified is used. 
        /// If the entity is also not specified or do not have a valid timezone then UTC is used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }
        
        /// <value>
        /// The logSet to be associated with the processed logs. The logSet feature can be used by customers with high volume of data 
        /// and this feature has to be enabled for a given tenancy prior to its usage.
        /// When logSetExtRegex value is provided, it will take precedence over this logSet value and logSet will be computed dynamically 
        /// using logSetKey and logSetExtRegex.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logSet")]
        public string LogSet { get; set; }
        
        /// <value>
        /// An optional parameter to indicate from where the logSet to be extracted using logSetExtRegex. Default value is OBJECT_PATH (e.g. /n/<namespace>/b/<bucketname>/o/<objectname>).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logSetKey")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LogSetKeyTypes> LogSetKey { get; set; }
        
        /// <value>
        /// The regex to be applied against given logSetKey. Regex has to be in string escaped format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logSetExtRegex")]
        public string LogSetExtRegex { get; set; }
        
        /// <value>
        /// Use this to override some property values which are defined at bucket level to the scope of object.
        /// Supported propeties for override are: logSourceName, charEncoding, entityId.
        /// Supported matchType for override are \"contains\".
        /// 
        /// </value>
        [JsonProperty(PropertyName = "overrides")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PropertyOverride>> Overrides { get; set; }
        
        /// <value>
        /// The current state of the rule.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ObjectCollectionRuleLifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// A detailed status of the life cycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The time when this rule was created. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time when this rule was last updated. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Whether or not this rule is currently enabled.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabled is required.")]
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// When the filters are provided, only the objects matching the filters are picked up for processing.
        /// The matchType supported is exact match and accommodates wildcard \"*\".
        /// For more information on filters, see [Event Filters](https://docs.oracle.com/en-us/iaas/Content/Events/Concepts/filterevents.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "objectNameFilters")]
        public System.Collections.Generic.List<string> ObjectNameFilters { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
    }
}
