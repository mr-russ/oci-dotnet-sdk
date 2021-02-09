/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Summary of an entity attribute.
    /// </summary>
    public class AttributeSummary 
    {
        
        /// <value>
        /// Unique attribute key that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detailed description of the attribute.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The unique key of the parent entity.
        /// </value>
        [JsonProperty(PropertyName = "entityKey")]
        public string EntityKey { get; set; }
        
        /// <value>
        /// Unique external key of this attribute in the external source system.
        /// </value>
        [JsonProperty(PropertyName = "externalKey")]
        public string ExternalKey { get; set; }
        
        /// <value>
        /// Max allowed length of the attribute value.
        /// </value>
        [JsonProperty(PropertyName = "length")]
        public System.Nullable<long> Length { get; set; }
        
        /// <value>
        /// Precision of the attribute value usually applies to float data type.
        /// </value>
        [JsonProperty(PropertyName = "precision")]
        public System.Nullable<int> Precision { get; set; }
        
        /// <value>
        /// Scale of the attribute value usually applies to float data type.
        /// </value>
        [JsonProperty(PropertyName = "scale")]
        public System.Nullable<int> Scale { get; set; }
        
        /// <value>
        /// Property that identifies if this attribute can be assigned null values.
        /// </value>
        [JsonProperty(PropertyName = "isNullable")]
        public System.Nullable<bool> IsNullable { get; set; }
        
        /// <value>
        /// URI to the attribute instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
        /// <value>
        /// State of the attribute.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the attribute was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Data type of the attribute as defined in the external source system.
        /// </value>
        [JsonProperty(PropertyName = "externalDataType")]
        public string ExternalDataType { get; set; }
        
        /// <value>
        /// The minimum count for the number of instances of a given type stored in this collection type attribute,applicable if this attribute is a complex type.
        /// </value>
        [JsonProperty(PropertyName = "minCollectionCount")]
        public System.Nullable<int> MinCollectionCount { get; set; }
        
        /// <value>
        /// The maximum count for the number of instances of a given type stored in this collection type attribute,applicable if this attribute is a complex type.
        /// For type specifications in systems that specify only \"capacity\" without upper or lower bound , this property can also be used to just mean \"capacity\".
        /// Some examples are Varray size in Oracle , Occurs Clause in Cobol , capacity in XmlSchemaObjectCollection , maxOccurs in  Xml , maxItems in Json
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxCollectionCount")]
        public System.Nullable<int> MaxCollectionCount { get; set; }
        
        /// <value>
        /// Entity key that represents the datatype of this attribute , applicable if this attribute is a complex type.
        /// </value>
        [JsonProperty(PropertyName = "datatypeEntityKey")]
        public string DatatypeEntityKey { get; set; }
        
        /// <value>
        /// External entity key that represents the datatype of this attribute , applicable if this attribute is a complex type.
        /// </value>
        [JsonProperty(PropertyName = "externalDatatypeEntityKey")]
        public string ExternalDatatypeEntityKey { get; set; }
        
        /// <value>
        /// Attribute key that represents the parent attribute of this attribute , applicable if the parent attribute is of complex datatype.
        /// </value>
        [JsonProperty(PropertyName = "parentAttributeKey")]
        public string ParentAttributeKey { get; set; }
        
        /// <value>
        /// External attribute key that represents the parent attribute  of this attribute , applicable if the parent attribute is of complex type.
        /// </value>
        [JsonProperty(PropertyName = "externalParentAttributeKey")]
        public string ExternalParentAttributeKey { get; set; }
        
        /// <value>
        /// Full path of the attribute.
        /// </value>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <value>
        /// Rule types associated with attribute.
        /// </value>
        [JsonProperty(PropertyName = "associatedRuleTypes", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<RuleType> AssociatedRuleTypes { get; set; }
        
    }
}
