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
    /// LogAnalyticsSourceLabelCondition
    /// </summary>
    public class LogAnalyticsSourceLabelCondition 
    {
        
        /// <value>
        /// String representation of the label condition. This supports specifying multiple condition blocks at various nested levels.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "conditionString")]
        public string ConditionString { get; set; }
        
        [JsonProperty(PropertyName = "conditionBlock")]
        public ConditionBlock ConditionBlock { get; set; }
        
        /// <value>
        /// The message.
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the label condition is visible.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isVisible")]
        public System.Nullable<bool> IsVisible { get; set; }
        
        /// <value>
        /// The block condition field.
        /// </value>
        [JsonProperty(PropertyName = "blockConditionField")]
        public string BlockConditionField { get; set; }
        
        /// <value>
        /// The block condition operator.
        /// </value>
        [JsonProperty(PropertyName = "blockConditionOperator")]
        public string BlockConditionOperator { get; set; }
        
        /// <value>
        /// The block condition value.
        /// </value>
        [JsonProperty(PropertyName = "blockConditionValue")]
        public string BlockConditionValue { get; set; }
        
        /// <value>
        /// The condition value.
        /// </value>
        [JsonProperty(PropertyName = "labelConditionValue")]
        public string LabelConditionValue { get; set; }
        
        /// <value>
        /// A list of condition values.
        /// </value>
        [JsonProperty(PropertyName = "labelConditionValues")]
        public System.Collections.Generic.List<string> LabelConditionValues { get; set; }
        
        /// <value>
        /// The content example.
        /// </value>
        [JsonProperty(PropertyName = "contentExample")]
        public string ContentExample { get; set; }
        
        /// <value>
        /// A flag inidcating whether or not the condition is enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// The internal field name.
        /// </value>
        [JsonProperty(PropertyName = "fieldName")]
        public string FieldName { get; set; }
        
        /// <value>
        /// The unique identifier of the condition.
        /// </value>
        [JsonProperty(PropertyName = "labelConditionId")]
        public System.Nullable<long> LabelConditionId { get; set; }
        
        /// <value>
        /// The system flag.  A value of false denotes a custom, or user
        /// defined object.  A value of true denotes a built in object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }
        
        /// <value>
        /// The condition operator.
        /// </value>
        [JsonProperty(PropertyName = "labelConditionOperator")]
        public string LabelConditionOperator { get; set; }
        
        /// <value>
        /// The unique identifier of the source.
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public System.Nullable<long> SourceId { get; set; }
        
        /// <value>
        /// The label display name.
        /// </value>
        [JsonProperty(PropertyName = "labelDisplayName")]
        public string LabelDisplayName { get; set; }
        
        /// <value>
        /// The label storage field.
        /// </value>
        [JsonProperty(PropertyName = "storageField")]
        public string StorageField { get; set; }
        
        /// <value>
        /// The label name.
        /// </value>
        [JsonProperty(PropertyName = "labelName")]
        public string LabelName { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the inline label exists in the database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isInlineLabelExistingInDatabase")]
        public System.Nullable<bool> IsInlineLabelExistingInDatabase { get; set; }
        
    }
}
