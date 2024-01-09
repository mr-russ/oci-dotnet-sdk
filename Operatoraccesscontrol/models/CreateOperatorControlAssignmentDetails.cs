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


namespace Oci.OperatoraccesscontrolService.Models
{
    /// <summary>
    /// Details of the Operator Control assignment. An Operator Control Assignment identifies the target resource that is placed under the governance of an Operator Control. 
    /// Creating an Operator Control Assignment Assignment with a time duration ensures that human accesses to the target resource will be governed by Operator Control for the duration specified.
    /// 
    /// </summary>
    public class CreateOperatorControlAssignmentDetails 
    {
        
        /// <value>
        /// The OCID of the operator control that is being assigned to a target resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperatorControlId is required.")]
        [JsonProperty(PropertyName = "operatorControlId")]
        public string OperatorControlId { get; set; }
        
        /// <value>
        /// The OCID of the target resource being brought under the governance of the operator control.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Name of the target resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceName is required.")]
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// Type of the target resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ResourceTypes> ResourceType { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the target resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceCompartmentId is required.")]
        [JsonProperty(PropertyName = "resourceCompartmentId")]
        public string ResourceCompartmentId { get; set; }
        
        /// <value>
        /// The time at which the target resource will be brought under the governance of the operator control in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format. Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeAssignmentFrom")]
        public System.Nullable<System.DateTime> TimeAssignmentFrom { get; set; }
        
        /// <value>
        /// The time at which the target resource will leave the governance of the operator control in [RFC 3339](https://tools.ietf.org/html/rfc3339)timestamp format.Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeAssignmentTo")]
        public System.Nullable<System.DateTime> TimeAssignmentTo { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the operator control assignment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// If set, then the target resource is always governed by the operator control.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnforcedAlways is required.")]
        [JsonProperty(PropertyName = "isEnforcedAlways")]
        public System.Nullable<bool> IsEnforcedAlways { get; set; }
        
        /// <value>
        /// Comment about the assignment of the operator control to this target resource.
        /// </value>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        
        /// <value>
        /// If set, then the audit logs will be forwarded to the relevant remote logging server
        /// </value>
        [JsonProperty(PropertyName = "isLogForwarded")]
        public System.Nullable<bool> IsLogForwarded { get; set; }
        
        /// <value>
        /// The address of the remote syslog server where the audit logs will be forwarded to. Address in host or IP format.
        /// </value>
        [JsonProperty(PropertyName = "remoteSyslogServerAddress")]
        public string RemoteSyslogServerAddress { get; set; }
        
        /// <value>
        /// The listening port of the remote syslog server. The port range is 0 - 65535. Only TCP supported.
        /// </value>
        [JsonProperty(PropertyName = "remoteSyslogServerPort")]
        public System.Nullable<int> RemoteSyslogServerPort { get; set; }
        
        /// <value>
        /// The CA certificate of the remote syslog server. Identity of the remote syslog server will be asserted based on this certificate.
        /// </value>
        [JsonProperty(PropertyName = "remoteSyslogServerCACert")]
        public string RemoteSyslogServerCACert { get; set; }
        
        /// <value>
        /// The boolean if true would autoApprove during maintenance.
        /// </value>
        [JsonProperty(PropertyName = "isAutoApproveDuringMaintenance")]
        public System.Nullable<bool> IsAutoApproveDuringMaintenance { get; set; }
        
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
