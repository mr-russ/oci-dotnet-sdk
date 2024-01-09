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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// Information regarding cluster's credential rotation.
    /// </summary>
    public class CredentialRotationStatus 
    {
        
        /// <value>
        /// The time by which retirement of old credentials should start.
        /// </value>
        [JsonProperty(PropertyName = "timeAutoCompletionScheduled")]
        public System.Nullable<System.DateTime> TimeAutoCompletionScheduled { get; set; }
                ///
        /// <value>
        /// Credential rotation status of a kubernetes cluster
        /// IN_PROGRESS: Issuing new credentials to kubernetes cluster control plane and worker nodes or retiring old credentials from kubernetes cluster control plane and worker nodes.
        /// WAITING: Waiting for customer to invoke the complete rotation action or the automcatic complete rotation action.
        /// COMPLETED: New credentials are functional on kuberentes cluster.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "WAITING")]
            Waiting,
            [EnumMember(Value = "COMPLETED")]
            Completed
        };

        /// <value>
        /// Credential rotation status of a kubernetes cluster
        /// IN_PROGRESS: Issuing new credentials to kubernetes cluster control plane and worker nodes or retiring old credentials from kubernetes cluster control plane and worker nodes.
        /// WAITING: Waiting for customer to invoke the complete rotation action or the automcatic complete rotation action.
        /// COMPLETED: New credentials are functional on kuberentes cluster.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
                ///
        /// <value>
        /// Details of a kuberenetes cluster credential rotation status:
        /// ISSUING_NEW_CREDENTIALS: Credential rotation is in progress. Starting to issue new credentials to kubernetes cluster control plane and worker nodes.
        /// NEW_CREDENTIALS_ISSUED: New credentials are added. At this stage cluster has both old and new credentials and is awaiting old credentials retirement.
        /// RETIRING_OLD_CREDENTIALS: Retirement of old credentials is in progress. Starting to remove old credentials from kubernetes cluster control plane and worker nodes.
        /// COMPLETED: Credential rotation is complete. Old credentials are retired.
        /// 
        /// </value>
        ///
        public enum StatusDetailsEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ISSUING_NEW_CREDENTIALS")]
            IssuingNewCredentials,
            [EnumMember(Value = "NEW_CREDENTIALS_ISSUED")]
            NewCredentialsIssued,
            [EnumMember(Value = "RETIRING_OLD_CREDENTIALS")]
            RetiringOldCredentials,
            [EnumMember(Value = "COMPLETED")]
            Completed
        };

        /// <value>
        /// Details of a kuberenetes cluster credential rotation status:
        /// ISSUING_NEW_CREDENTIALS: Credential rotation is in progress. Starting to issue new credentials to kubernetes cluster control plane and worker nodes.
        /// NEW_CREDENTIALS_ISSUED: New credentials are added. At this stage cluster has both old and new credentials and is awaiting old credentials retirement.
        /// RETIRING_OLD_CREDENTIALS: Retirement of old credentials is in progress. Starting to remove old credentials from kubernetes cluster control plane and worker nodes.
        /// COMPLETED: Credential rotation is complete. Old credentials are retired.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StatusDetails is required.")]
        [JsonProperty(PropertyName = "statusDetails")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusDetailsEnum> StatusDetails { get; set; }
        
    }
}
