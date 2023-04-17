/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// A description of the work request's status.
    /// </summary>
    public class WorkRequestSummary 
    {
        
        /// <value>
        /// The identifier of the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The identifier of the compartment that contains the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The identifier of the Digital Assistant instance to which this work request pertains.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OdaInstanceId is required.")]
        [JsonProperty(PropertyName = "odaInstanceId")]
        public string OdaInstanceId { get; set; }
        
        /// <value>
        /// The identifier of the resource to which this work request pertains.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
                ///
        /// <value>
        /// The type of the operation that's associated with the work request.
        /// </value>
        ///
        public enum RequestActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATE_ODA_INSTANCE")]
            CreateOdaInstance,
            [EnumMember(Value = "UPGRADE_ODA_INSTANCE")]
            UpgradeOdaInstance,
            [EnumMember(Value = "DELETE_ODA_INSTANCE")]
            DeleteOdaInstance,
            [EnumMember(Value = "PURGE_ODA_INSTANCE")]
            PurgeOdaInstance,
            [EnumMember(Value = "RECOVER_ODA_INSTANCE")]
            RecoverOdaInstance,
            [EnumMember(Value = "STOP_ODA_INSTANCE")]
            StopOdaInstance,
            [EnumMember(Value = "START_ODA_INSTANCE")]
            StartOdaInstance,
            [EnumMember(Value = "CHANGE_ODA_INSTANCE_COMPARTMENT")]
            ChangeOdaInstanceCompartment,
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
            [EnumMember(Value = "LOOKUP_ODA_INSTANCES_FOR_CACCT")]
            LookupOdaInstancesForCacct,
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
            [EnumMember(Value = "IMPORT_BOT")]
            ImportBot,
            [EnumMember(Value = "CREATE_SKILL")]
            CreateSkill,
            [EnumMember(Value = "CLONE_SKILL")]
            CloneSkill,
            [EnumMember(Value = "EXTEND_SKILL")]
            ExtendSkill,
            [EnumMember(Value = "VERSION_SKILL")]
            VersionSkill,
            [EnumMember(Value = "EXPORT_SKILL")]
            ExportSkill,
            [EnumMember(Value = "CREATE_DIGITAL_ASSISTANT")]
            CreateDigitalAssistant,
            [EnumMember(Value = "CLONE_DIGITAL_ASSISTANT")]
            CloneDigitalAssistant,
            [EnumMember(Value = "EXTEND_DIGITAL_ASSISTANT")]
            ExtendDigitalAssistant,
            [EnumMember(Value = "VERSION_DIGITAL_ASSISTANT")]
            VersionDigitalAssistant,
            [EnumMember(Value = "EXPORT_DIGITAL_ASSISTANT")]
            ExportDigitalAssistant,
            [EnumMember(Value = "CREATE_ODA_PRIVATE_ENDPOINT")]
            CreateOdaPrivateEndpoint,
            [EnumMember(Value = "DELETE_ODA_PRIVATE_ENDPOINT")]
            DeleteOdaPrivateEndpoint,
            [EnumMember(Value = "UPDATE_ODA_PRIVATE_ENDPOINT")]
            UpdateOdaPrivateEndpoint,
            [EnumMember(Value = "CHANGE_ODA_PRIVATE_ENDPOINT_COMPARTMENT")]
            ChangeOdaPrivateEndpointCompartment,
            [EnumMember(Value = "CREATE_ODA_PRIVATE_ENDPOINT_SCAN_PROXY")]
            CreateOdaPrivateEndpointScanProxy,
            [EnumMember(Value = "DELETE_ODA_PRIVATE_ENDPOINT_SCAN_PROXY")]
            DeleteOdaPrivateEndpointScanProxy,
            [EnumMember(Value = "CREATE_ODA_PRIVATE_ENDPOINT_ATTACHMENT")]
            CreateOdaPrivateEndpointAttachment,
            [EnumMember(Value = "DELETE_ODA_PRIVATE_ENDPOINT_ATTACHMENT")]
            DeleteOdaPrivateEndpointAttachment
        };

        /// <value>
        /// The type of the operation that's associated with the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RequestAction is required.")]
        [JsonProperty(PropertyName = "requestAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RequestActionEnum> RequestAction { get; set; }
                ///
        /// <value>
        /// The status of current work request.
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
        /// The status of current work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The resources that this work request affects.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Resources is required.")]
        [JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.List<WorkRequestResource> Resources { get; set; }
        
    }
}
