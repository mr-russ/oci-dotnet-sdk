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


namespace Oci.OperatoraccesscontrolService.Models
{
    /// <summary>
    /// Operator Access Control enables you to grant, audit, or revoke the access Oracle has to your Exadata Cloud@Customer infrastructure, and obtain audit reports of all actions taken by a human operator, in a near real-time manner.
    /// 
    /// </summary>
    public class OperatorControl 
    {
        
        /// <value>
        /// The OCID of the operator control.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Name of the operator control. The name must be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperatorControlName is required.")]
        [JsonProperty(PropertyName = "operatorControlName")]
        public string OperatorControlName { get; set; }
        
        /// <value>
        /// Description of operator control.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// List of users who can approve an access request associated with a target resource under the governance of this operator control.
        /// </value>
        [JsonProperty(PropertyName = "approversList")]
        public System.Collections.Generic.List<string> ApproversList { get; set; }
        
        /// <value>
        /// List of user groups who can approve an access request associated with a target resource under the governance of this operator control.
        /// </value>
        [JsonProperty(PropertyName = "approverGroupsList")]
        public System.Collections.Generic.List<string> ApproverGroupsList { get; set; }
        
        /// <value>
        /// List of pre-approved operator actions. Access requests associated with a resource governed by this operator control will be
        /// automatically approved if the access request only contain operator actions in the pre-approved list.       
        /// 
        /// </value>
        [JsonProperty(PropertyName = "preApprovedOpActionList")]
        public System.Collections.Generic.List<string> PreApprovedOpActionList { get; set; }
        
        /// <value>
        /// List of operator actions that need explicit approval. Any operator action not in the pre-approved list will require explicit
        /// approval. Access requests associated with a resource governed by this operator control will be
        /// require explicit approval if the access request contains any operator action in this list. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "approvalRequiredOpActionList")]
        public System.Collections.Generic.List<string> ApprovalRequiredOpActionList { get; set; }
        
        /// <value>
        /// Whether all the operator actions have been pre-approved. If yes, all access requests associated with a resource governed by this operator control 
        /// will be auto-approved.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isFullyPreApproved")]
        public System.Nullable<bool> IsFullyPreApproved { get; set; }
        
        /// <value>
        /// List of emailId.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "emailIdList")]
        public System.Collections.Generic.List<string> EmailIdList { get; set; }
        
        /// <value>
        /// resourceType for which the OperatorControl is applicable
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceTypes> ResourceType { get; set; }
        
        /// <value>
        /// System message that would be displayed to the operator users on accessing the target resource under the governance of this operator control.
        /// </value>
        [JsonProperty(PropertyName = "systemMessage")]
        public string SystemMessage { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the operator control.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The current lifecycle state of the operator control.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperatorControlLifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// Time when the operator control was created expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format. Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeOfCreation")]
        public System.Nullable<System.DateTime> TimeOfCreation { get; set; }
        
        /// <value>
        /// Time when the operator control was last modified expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format. Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeOfModification")]
        public System.Nullable<System.DateTime> TimeOfModification { get; set; }
        
        /// <value>
        /// Time when deleted expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)timestamp format. Example: '2020-05-22T21:10:29.600Z'.Note a deleted operator control still stays in the system, so that you can still audit operator actions associated with access requestsraised on target resources governed by the deleted operator control.
        /// </value>
        [JsonProperty(PropertyName = "timeOfDeletion")]
        public System.Nullable<System.DateTime> TimeOfDeletion { get; set; }
        
        /// <value>
        /// Description associated with the latest modification of the operator control.
        /// </value>
        [JsonProperty(PropertyName = "lastModifiedInfo")]
        public string LastModifiedInfo { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
