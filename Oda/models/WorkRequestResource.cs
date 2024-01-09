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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// A resource created or operated on by a work request.
    /// </summary>
    public class WorkRequestResource 
    {
                ///
        /// <value>
        /// The action to take against the resource.
        /// </value>
        ///
        public enum ResourceActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATE")]
            Create,
            [EnumMember(Value = "UPDATE")]
            Update,
            [EnumMember(Value = "DELETE")]
            Delete,
            [EnumMember(Value = "PURGE")]
            Purge,
            [EnumMember(Value = "RECOVER")]
            Recover,
            [EnumMember(Value = "STOP")]
            Stop,
            [EnumMember(Value = "START")]
            Start,
            [EnumMember(Value = "CHANGE_COMPARTMENT")]
            ChangeCompartment,
            [EnumMember(Value = "CHANGE_CUST_ENC_KEY")]
            ChangeCustEncKey,
            [EnumMember(Value = "DEACT_CUST_ENC_KEY")]
            DeactCustEncKey,
            [EnumMember(Value = "CREATE_ASSOCIATION")]
            CreateAssociation,
            [EnumMember(Value = "DELETE_ASSOCIATION")]
            DeleteAssociation,
            [EnumMember(Value = "UPDATE_ENTITLEMENTS_FOR_CACCT")]
            UpdateEntitlementsForCacct,
            [EnumMember(Value = "CREATE_ODA_INSTANCE_ATTACHMENT")]
            CreateOdaInstanceAttachment,
            [EnumMember(Value = "UPDATE_ODA_INSTANCE_ATTACHMENT")]
            UpdateOdaInstanceAttachment,
            [EnumMember(Value = "DELETE_ODA_INSTANCE_ATTACHMENT")]
            DeleteOdaInstanceAttachment,
            [EnumMember(Value = "CREATE_IMPORTED_PACKAGE")]
            CreateImportedPackage,
            [EnumMember(Value = "UPDATE_IMPORTED_PACKAGE")]
            UpdateImportedPackage,
            [EnumMember(Value = "DELETE_IMPORTED_PACKAGE")]
            DeleteImportedPackage,
            [EnumMember(Value = "EXPORT")]
            Export
        };

        /// <value>
        /// The action to take against the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceAction is required.")]
        [JsonProperty(PropertyName = "resourceAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceActionEnum> ResourceAction { get; set; }
        
        /// <value>
        /// The resource type that the work request affects.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// The identifier of the resource that is the subject of the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
                ///
        /// <value>
        /// The current state of the work request. The `SUCCEEDED`, `FAILED`, AND `CANCELED` states
        /// correspond to the action being performed.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// The current state of the work request. The `SUCCEEDED`, `FAILED`, AND `CANCELED` states
        /// correspond to the action being performed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// Short message providing more detail for the current status. For example, if an operation fails
        /// this may include information about the reason for the failure and a possible resolution.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "statusMessage")]
        public string StatusMessage { get; set; }
        
        /// <value>
        /// The URI path that the user can do a GET on to access the resource metadata.
        /// </value>
        [JsonProperty(PropertyName = "resourceUri")]
        public string ResourceUri { get; set; }
        
    }
}
