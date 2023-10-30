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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// An asynchronous work request.
    /// </summary>
    public class WorkRequest 
    {
                ///
        /// <value>
        /// The resources that are affected by the work request.
        /// </value>
        ///
        public enum OperationTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENABLE_DATA_SAFE_CONFIGURATION")]
            EnableDataSafeConfiguration,
            [EnumMember(Value = "CREATE_PRIVATE_ENDPOINT")]
            CreatePrivateEndpoint,
            [EnumMember(Value = "UPDATE_PRIVATE_ENDPOINT")]
            UpdatePrivateEndpoint,
            [EnumMember(Value = "DELETE_PRIVATE_ENDPOINT")]
            DeletePrivateEndpoint,
            [EnumMember(Value = "CHANGE_PRIVATE_ENDPOINT_COMPARTMENT")]
            ChangePrivateEndpointCompartment,
            [EnumMember(Value = "CREATE_ONPREM_CONNECTOR")]
            CreateOnpremConnector,
            [EnumMember(Value = "UPDATE_ONPREM_CONNECTOR")]
            UpdateOnpremConnector,
            [EnumMember(Value = "DELETE_ONPREM_CONNECTOR")]
            DeleteOnpremConnector,
            [EnumMember(Value = "UPDATE_ONPREM_CONNECTOR_WALLET")]
            UpdateOnpremConnectorWallet,
            [EnumMember(Value = "CHANGE_ONPREM_CONNECTOR_COMPARTMENT")]
            ChangeOnpremConnectorCompartment,
            [EnumMember(Value = "CREATE_TARGET_DATABASE")]
            CreateTargetDatabase,
            [EnumMember(Value = "UPDATE_TARGET_DATABASE")]
            UpdateTargetDatabase,
            [EnumMember(Value = "ACTIVATE_TARGET_DATABASE")]
            ActivateTargetDatabase,
            [EnumMember(Value = "DEACTIVATE_TARGET_DATABASE")]
            DeactivateTargetDatabase,
            [EnumMember(Value = "DELETE_TARGET_DATABASE")]
            DeleteTargetDatabase,
            [EnumMember(Value = "CHANGE_TARGET_DATABASE_COMPARTMENT")]
            ChangeTargetDatabaseCompartment,
            [EnumMember(Value = "PROVISION_POLICY")]
            ProvisionPolicy,
            [EnumMember(Value = "RETRIEVE_POLICY")]
            RetrievePolicy,
            [EnumMember(Value = "UPDATE_POLICY")]
            UpdatePolicy,
            [EnumMember(Value = "CHANGE_POLICY_COMPARTMENT")]
            ChangePolicyCompartment,
            [EnumMember(Value = "CREATE_USER_ASSESSMENT")]
            CreateUserAssessment,
            [EnumMember(Value = "ASSESS_USER_ASSESSMENT")]
            AssessUserAssessment,
            [EnumMember(Value = "CREATE_SNAPSHOT_USER_ASSESSMENT")]
            CreateSnapshotUserAssessment,
            [EnumMember(Value = "CREATE_SCHEDULE_USER_ASSESSMENT")]
            CreateScheduleUserAssessment,
            [EnumMember(Value = "COMPARE_WITH_BASELINE_USER_ASSESSMENT")]
            CompareWithBaselineUserAssessment,
            [EnumMember(Value = "DELETE_USER_ASSESSMENT")]
            DeleteUserAssessment,
            [EnumMember(Value = "UPDATE_USER_ASSESSMENT")]
            UpdateUserAssessment,
            [EnumMember(Value = "CHANGE_USER_ASSESSMENT_COMPARTMENT")]
            ChangeUserAssessmentCompartment,
            [EnumMember(Value = "SET_USER_ASSESSMENT_BASELINE")]
            SetUserAssessmentBaseline,
            [EnumMember(Value = "UNSET_USER_ASSESSMENT_BASELINE")]
            UnsetUserAssessmentBaseline,
            [EnumMember(Value = "GENERATE_USER_ASSESSMENT_REPORT")]
            GenerateUserAssessmentReport,
            [EnumMember(Value = "CREATE_SECURITY_ASSESSMENT")]
            CreateSecurityAssessment,
            [EnumMember(Value = "CREATE_SECURITY_ASSESSMENT_NOW")]
            CreateSecurityAssessmentNow,
            [EnumMember(Value = "ASSESS_SECURITY_ASSESSMENT")]
            AssessSecurityAssessment,
            [EnumMember(Value = "CREATE_SNAPSHOT_SECURITY_ASSESSMENT")]
            CreateSnapshotSecurityAssessment,
            [EnumMember(Value = "CREATE_SCHEDULE_SECURITY_ASSESSMENT")]
            CreateScheduleSecurityAssessment,
            [EnumMember(Value = "COMPARE_WITH_BASELINE_SECURITY_ASSESSMENT")]
            CompareWithBaselineSecurityAssessment,
            [EnumMember(Value = "DELETE_SECURITY_ASSESSMENT")]
            DeleteSecurityAssessment,
            [EnumMember(Value = "UPDATE_SECURITY_ASSESSMENT")]
            UpdateSecurityAssessment,
            [EnumMember(Value = "CHANGE_SECURITY_ASSESSMENT_COMPARTMENT")]
            ChangeSecurityAssessmentCompartment,
            [EnumMember(Value = "SET_SECURITY_ASSESSMENT_BASELINE")]
            SetSecurityAssessmentBaseline,
            [EnumMember(Value = "UNSET_SECURITY_ASSESSMENT_BASELINE")]
            UnsetSecurityAssessmentBaseline,
            [EnumMember(Value = "GENERATE_SECURITY_ASSESSMENT_REPORT")]
            GenerateSecurityAssessmentReport,
            [EnumMember(Value = "CREATE_AUDIT_PROFILE")]
            CreateAuditProfile,
            [EnumMember(Value = "CALCULATE_VOLUME")]
            CalculateVolume,
            [EnumMember(Value = "CALCULATE_COLLECTED_VOLUME")]
            CalculateCollectedVolume,
            [EnumMember(Value = "CREATE_DB_SECURITY_CONFIG")]
            CreateDbSecurityConfig,
            [EnumMember(Value = "REFRESH_DB_SECURITY_CONFIG")]
            RefreshDbSecurityConfig,
            [EnumMember(Value = "UPDATE_DB_SECURITY_CONFIG")]
            UpdateDbSecurityConfig,
            [EnumMember(Value = "CHANGE_DB_SECURITY_CONFIG_COMPARTMENT")]
            ChangeDbSecurityConfigCompartment,
            [EnumMember(Value = "GENERATE_FIREWALL_POLICY")]
            GenerateFirewallPolicy,
            [EnumMember(Value = "UPDATE_FIREWALL_POLICY")]
            UpdateFirewallPolicy,
            [EnumMember(Value = "CHANGE_FIREWALL_POLICY_COMPARTMENT")]
            ChangeFirewallPolicyCompartment,
            [EnumMember(Value = "DELETE_FIREWALL_POLICY")]
            DeleteFirewallPolicy,
            [EnumMember(Value = "CREATE_SQL_COLLECTION")]
            CreateSqlCollection,
            [EnumMember(Value = "UPDATE_SQL_COLLECTION")]
            UpdateSqlCollection,
            [EnumMember(Value = "START_SQL_COLLECTION")]
            StartSqlCollection,
            [EnumMember(Value = "STOP_SQL_COLLECTION")]
            StopSqlCollection,
            [EnumMember(Value = "DELETE_SQL_COLLECTION")]
            DeleteSqlCollection,
            [EnumMember(Value = "CHANGE_SQL_COLLECTION_COMPARTMENT")]
            ChangeSqlCollectionCompartment,
            [EnumMember(Value = "REFRESH_SQL_COLLECTION_LOG_INSIGHTS")]
            RefreshSqlCollectionLogInsights,
            [EnumMember(Value = "PURGE_SQL_COLLECTION_LOGS")]
            PurgeSqlCollectionLogs,
            [EnumMember(Value = "UPDATE_SECURITY_POLICY")]
            UpdateSecurityPolicy,
            [EnumMember(Value = "CHANGE_SECURITY_POLICY_COMPARTMENT")]
            ChangeSecurityPolicyCompartment,
            [EnumMember(Value = "UPDATE_SECURITY_POLICY_DEPLOYMENT")]
            UpdateSecurityPolicyDeployment,
            [EnumMember(Value = "CHANGE_SECURITY_POLICY_DEPLOYMENT_COMPARTMENT")]
            ChangeSecurityPolicyDeploymentCompartment,
            [EnumMember(Value = "AUDIT_TRAIL")]
            AuditTrail,
            [EnumMember(Value = "DELETE_AUDIT_TRAIL")]
            DeleteAuditTrail,
            [EnumMember(Value = "DISCOVER_AUDIT_TRAILS")]
            DiscoverAuditTrails,
            [EnumMember(Value = "UPDATE_AUDIT_TRAIL")]
            UpdateAuditTrail,
            [EnumMember(Value = "UPDATE_AUDIT_PROFILE")]
            UpdateAuditProfile,
            [EnumMember(Value = "AUDIT_CHANGE_COMPARTMENT")]
            AuditChangeCompartment,
            [EnumMember(Value = "CREATE_REPORT_DEFINITION")]
            CreateReportDefinition,
            [EnumMember(Value = "UPDATE_REPORT_DEFINITION")]
            UpdateReportDefinition,
            [EnumMember(Value = "CHANGE_REPORT_DEFINITION_COMPARTMENT")]
            ChangeReportDefinitionCompartment,
            [EnumMember(Value = "DELETE_REPORT_DEFINITION")]
            DeleteReportDefinition,
            [EnumMember(Value = "GENERATE_REPORT")]
            GenerateReport,
            [EnumMember(Value = "CHANGE_REPORT_COMPARTMENT")]
            ChangeReportCompartment,
            [EnumMember(Value = "DELETE_ARCHIVE_RETRIEVAL")]
            DeleteArchiveRetrieval,
            [EnumMember(Value = "CREATE_ARCHIVE_RETRIEVAL")]
            CreateArchiveRetrieval,
            [EnumMember(Value = "UPDATE_ARCHIVE_RETRIEVAL")]
            UpdateArchiveRetrieval,
            [EnumMember(Value = "CHANGE_ARCHIVE_RETRIEVAL_COMPARTMENT")]
            ChangeArchiveRetrievalCompartment,
            [EnumMember(Value = "UPDATE_ALERT")]
            UpdateAlert,
            [EnumMember(Value = "TARGET_ALERT_POLICY_ASSOCIATION")]
            TargetAlertPolicyAssociation,
            [EnumMember(Value = "CREATE_SENSITIVE_DATA_MODEL")]
            CreateSensitiveDataModel,
            [EnumMember(Value = "UPDATE_SENSITIVE_DATA_MODEL")]
            UpdateSensitiveDataModel,
            [EnumMember(Value = "DELETE_SENSITIVE_DATA_MODEL")]
            DeleteSensitiveDataModel,
            [EnumMember(Value = "UPLOAD_SENSITIVE_DATA_MODEL")]
            UploadSensitiveDataModel,
            [EnumMember(Value = "GENERATE_SENSITIVE_DATA_MODEL_FOR_DOWNLOAD")]
            GenerateSensitiveDataModelForDownload,
            [EnumMember(Value = "CREATE_SENSITIVE_COLUMN")]
            CreateSensitiveColumn,
            [EnumMember(Value = "UPDATE_SENSITIVE_COLUMN")]
            UpdateSensitiveColumn,
            [EnumMember(Value = "PATCH_SENSITIVE_COLUMNS")]
            PatchSensitiveColumns,
            [EnumMember(Value = "CREATE_DISCOVERY_JOB")]
            CreateDiscoveryJob,
            [EnumMember(Value = "DELETE_DISCOVERY_JOB")]
            DeleteDiscoveryJob,
            [EnumMember(Value = "PATCH_DISCOVERY_JOB_RESULT")]
            PatchDiscoveryJobResult,
            [EnumMember(Value = "APPLY_DISCOVERY_JOB_RESULT")]
            ApplyDiscoveryJobResult,
            [EnumMember(Value = "GENERATE_DISCOVERY_REPORT")]
            GenerateDiscoveryReport,
            [EnumMember(Value = "CREATE_SENSITIVE_TYPE")]
            CreateSensitiveType,
            [EnumMember(Value = "UPDATE_SENSITIVE_TYPE")]
            UpdateSensitiveType,
            [EnumMember(Value = "CREATE_MASKING_POLICY")]
            CreateMaskingPolicy,
            [EnumMember(Value = "UPDATE_MASKING_POLICY")]
            UpdateMaskingPolicy,
            [EnumMember(Value = "DELETE_MASKING_POLICY")]
            DeleteMaskingPolicy,
            [EnumMember(Value = "UPLOAD_MASKING_POLICY")]
            UploadMaskingPolicy,
            [EnumMember(Value = "GENERATE_MASKING_POLICY_FOR_DOWNLOAD")]
            GenerateMaskingPolicyForDownload,
            [EnumMember(Value = "CREATE_MASKING_COLUMN")]
            CreateMaskingColumn,
            [EnumMember(Value = "UPDATE_MASKING_COLUMN")]
            UpdateMaskingColumn,
            [EnumMember(Value = "PATCH_MASKING_COLUMNS")]
            PatchMaskingColumns,
            [EnumMember(Value = "GENERATE_MASKING_REPORT")]
            GenerateMaskingReport,
            [EnumMember(Value = "CREATE_LIBRARY_MASKING_FORMAT")]
            CreateLibraryMaskingFormat,
            [EnumMember(Value = "UPDATE_LIBRARY_MASKING_FORMAT")]
            UpdateLibraryMaskingFormat,
            [EnumMember(Value = "ADD_COLUMNS_FROM_SDM")]
            AddColumnsFromSdm,
            [EnumMember(Value = "MASKING_JOB")]
            MaskingJob,
            [EnumMember(Value = "CREATE_DIFFERENCE")]
            CreateDifference,
            [EnumMember(Value = "DELETE_DIFFERENCE")]
            DeleteDifference,
            [EnumMember(Value = "UPDATE_DIFFERENCE")]
            UpdateDifference,
            [EnumMember(Value = "PATCH_DIFFERENCE")]
            PatchDifference,
            [EnumMember(Value = "APPLY_DIFFERENCE")]
            ApplyDifference,
            [EnumMember(Value = "CREATE_SCHEDULE")]
            CreateSchedule,
            [EnumMember(Value = "REMOVE_SCHEDULE_REPORT")]
            RemoveScheduleReport,
            [EnumMember(Value = "UPDATE_ALL_ALERT")]
            UpdateAllAlert,
            [EnumMember(Value = "PATCH_TARGET_ALERT_POLICY_ASSOCIATION")]
            PatchTargetAlertPolicyAssociation
        };

        /// <value>
        /// The resources that are affected by the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationType is required.")]
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperationTypeEnum> OperationType { get; set; }
                ///
        /// <value>
        /// The current status of the work request.
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
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "CANCELED")]
            Canceled,
            [EnumMember(Value = "SUSPENDING")]
            Suspending,
            [EnumMember(Value = "SUSPENDED")]
            Suspended
        };

        /// <value>
        /// The current status of the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The OCID of the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the work request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The resources that are affected by this work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Resources is required.")]
        [JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.List<WorkRequestResource> Resources { get; set; }
        
        /// <value>
        /// Progress of the work request in percentage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PercentComplete is required.")]
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<float> PercentComplete { get; set; }
        
        /// <value>
        /// The date and time the work request was accepted, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeAccepted is required.")]
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
        
        /// <value>
        /// The date and time the work request transitioned from ACCEPTED to IN_PROGRESS, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time the work request reached a terminal state, either FAILED or SUCCEEDED. Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
    }
}
