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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The Database service supports the creation of database software images for use in creating and patching DB systems and databases.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you are not authorized, talk to an administrator. If you are an administrator who needs to write policies to give users access, see [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// For information about access control and compartments, see [Overview of the Identity Service](https://docs.cloud.oracle.com/Content/Identity/Concepts/overview.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class DatabaseSoftwareImageSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the database software image.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The database version with which the database software image is to be built.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseVersion is required.")]
        [JsonProperty(PropertyName = "databaseVersion")]
        public string DatabaseVersion { get; set; }
        
        /// <value>
        /// The user-friendly name for the database software image. The name does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The current state of the database software image.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "UPDATING")]
            Updating
        };

        /// <value>
        /// The current state of the database software image.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Detailed message for the lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The date and time the database software image was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// The type of software image. Can be grid or database.
        /// </value>
        ///
        public enum ImageTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "GRID_IMAGE")]
            GridImage,
            [EnumMember(Value = "DATABASE_IMAGE")]
            DatabaseImage
        };

        /// <value>
        /// The type of software image. Can be grid or database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImageType is required.")]
        [JsonProperty(PropertyName = "imageType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ImageTypeEnum> ImageType { get; set; }
                ///
        /// <value>
        /// To what shape the image is meant for.
        /// </value>
        ///
        public enum ImageShapeFamilyEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "VM_BM_SHAPE")]
            VmBmShape,
            [EnumMember(Value = "EXADATA_SHAPE")]
            ExadataShape,
            [EnumMember(Value = "EXACC_SHAPE")]
            ExaccShape,
            [EnumMember(Value = "EXADBXS_SHAPE")]
            ExadbxsShape
        };

        /// <value>
        /// To what shape the image is meant for.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImageShapeFamily is required.")]
        [JsonProperty(PropertyName = "imageShapeFamily")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ImageShapeFamilyEnum> ImageShapeFamily { get; set; }
        
        /// <value>
        /// The PSU or PBP or Release Updates. To get a list of supported versions, use the {@link #listDbVersions(ListDbVersionsRequest) listDbVersions} operation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PatchSet is required.")]
        [JsonProperty(PropertyName = "patchSet")]
        public string PatchSet { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// List of one-off patches for Database Homes.
        /// </value>
        [JsonProperty(PropertyName = "databaseSoftwareImageIncludedPatches")]
        public System.Collections.Generic.List<string> DatabaseSoftwareImageIncludedPatches { get; set; }
        
        /// <value>
        /// The patches included in the image and the version of the image.
        /// </value>
        [JsonProperty(PropertyName = "includedPatchesSummary")]
        public string IncludedPatchesSummary { get; set; }
        
        /// <value>
        /// List of one-off patches for Database Homes.
        /// </value>
        [JsonProperty(PropertyName = "databaseSoftwareImageOneOffPatches")]
        public System.Collections.Generic.List<string> DatabaseSoftwareImageOneOffPatches { get; set; }
        
        /// <value>
        /// The output from the OPatch lsInventory command, which is passed as a string.
        /// </value>
        [JsonProperty(PropertyName = "lsInventory")]
        public string LsInventory { get; set; }
        
        /// <value>
        /// True if this Database software image is supported for Upgrade.
        /// </value>
        [JsonProperty(PropertyName = "isUpgradeSupported")]
        public System.Nullable<bool> IsUpgradeSupported { get; set; }
        
    }
}
