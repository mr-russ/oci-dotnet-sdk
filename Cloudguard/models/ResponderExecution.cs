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
    /// Responder Execution Object.
    /// </summary>
    public class ResponderExecution 
    {
        
        /// <value>
        /// The unique identifier of the responder execution
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Responder Rule id for the responder execution
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResponderRuleId is required.")]
        [JsonProperty(PropertyName = "responderRuleId")]
        public string ResponderRuleId { get; set; }
        
        /// <value>
        /// Rule Type for the responder execution
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResponderRuleType is required.")]
        [JsonProperty(PropertyName = "responderRuleType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResponderType> ResponderRuleType { get; set; }
        
        /// <value>
        /// Rule name for the responder execution
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResponderRuleName is required.")]
        [JsonProperty(PropertyName = "responderRuleName")]
        public string ResponderRuleName { get; set; }
        
        /// <value>
        /// Problem id associated with the responder execution
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProblemId is required.")]
        [JsonProperty(PropertyName = "problemId")]
        public string ProblemId { get; set; }
        
        /// <value>
        /// region where the problem is found
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Region is required.")]
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// targetId of the problem for the responder execution
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetId is required.")]
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// compartment id of the responder execution for the problem
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// resource type of the problem for the responder execution
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// resource name of the problem for the responder execution. TODO-DOC link to resource definition doc
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceName is required.")]
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// The date and time the responder execution was created. Format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the responder execution was updated. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCompleted")]
        public System.Nullable<System.DateTime> TimeCompleted { get; set; }
        
        /// <value>
        /// current execution status of the responder
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResponderExecutionStatus is required.")]
        [JsonProperty(PropertyName = "responderExecutionStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResponderExecutionStates> ResponderExecutionStatus { get; set; }
        
        /// <value>
        /// execution mode of the responder
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResponderExecutionMode is required.")]
        [JsonProperty(PropertyName = "responderExecutionMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResponderExecutionModes> ResponderExecutionMode { get; set; }
        
        /// <value>
        /// Message about the responder execution.
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        [JsonProperty(PropertyName = "responderRuleExecutionDetails")]
        public ResponderRuleExecutionDetails ResponderRuleExecutionDetails { get; set; }
        
    }
}
