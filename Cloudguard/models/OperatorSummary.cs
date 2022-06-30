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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Summary of Operator
    /// </summary>
    public class OperatorSummary 
    {
        
        /// <value>
        /// name of the operand
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// display name of the operand
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// data type of operand
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Datatype is required.")]
        [JsonProperty(PropertyName = "datatype")]
        public string Datatype { get; set; }
        
        /// <value>
        /// operand list type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedListtype is required.")]
        [JsonProperty(PropertyName = "managedListtype")]
        public string ManagedListtype { get; set; }
        
        /// <value>
        /// Filter type can be config filter or condition filter
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FilterType is required.")]
        [JsonProperty(PropertyName = "filterType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ConditionFilterType> FilterType { get; set; }
        
        /// <value>
        /// List of parameters
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Operators is required.")]
        [JsonProperty(PropertyName = "operators")]
        public System.Collections.Generic.List<ConditionOperator> Operators { get; set; }
        
        /// <value>
        /// configuration value type list for multilist data type
        /// </value>
        [JsonProperty(PropertyName = "multiListTypes")]
        public System.Collections.Generic.List<string> MultiListTypes { get; set; }
        
    }
}
