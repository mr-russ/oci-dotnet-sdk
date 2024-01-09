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
    /// Details of the access request approval.
    /// </summary>
    public class ApproveAccessRequestDetails 
    {
        
        /// <value>
        /// Comment by the approver during approval.
        /// </value>
        [JsonProperty(PropertyName = "approverComment")]
        public string ApproverComment { get; set; }
        
        /// <value>
        /// Specifies the type of auditing to be enabled. There are two levels of auditing: command-level and keystroke-level. 
        /// By default, auditing is enabled at the command level i.e., each command issued by the operator is audited. When keystroke-level is chosen, 
        /// in addition to command level logging, key strokes are also logged.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "auditType")]
        public System.Collections.Generic.List<string> AuditType { get; set; }
        
        /// <value>
        /// Message that needs to be displayed to the Ops User.
        /// </value>
        [JsonProperty(PropertyName = "additionalMessage")]
        public string AdditionalMessage { get; set; }
        
        /// <value>
        /// The time when access request is scheduled to be approved in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeOfUserCreation")]
        public System.Nullable<System.DateTime> TimeOfUserCreation { get; set; }
        
    }
}
