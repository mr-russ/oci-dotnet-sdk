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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The summary of information about the database user. It includes details such as user type, account status,
    /// last login time, user creation time, authentication type, user profile, and time and date of the last password change.
    /// It also contains the user category derived from these user details, as well as granted privileges.
    /// 
    /// </summary>
    public class UserSummary 
    {
        
        /// <value>
        /// The unique user key. This is a system-generated identifier. Use ListUsers to get the user key for a user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The database user name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserName is required.")]
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
                ///
        /// <value>
        /// The user category based on the privileges and other details of the user.
        /// </value>
        ///
        public enum UserCategoryEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CRITICAL")]
            Critical,
            [EnumMember(Value = "HIGH")]
            High,
            [EnumMember(Value = "MEDIUM")]
            Medium,
            [EnumMember(Value = "LOW")]
            Low
        };

        /// <value>
        /// The user category based on the privileges and other details of the user.
        /// </value>
        [JsonProperty(PropertyName = "userCategory")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UserCategoryEnum> UserCategory { get; set; }
                ///
        /// <value>
        /// The user account status.
        /// </value>
        ///
        public enum AccountStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OPEN")]
            Open,
            [EnumMember(Value = "LOCKED")]
            Locked,
            [EnumMember(Value = "EXPIRED")]
            Expired,
            [EnumMember(Value = "EXPIRED_AND_LOCKED")]
            ExpiredAndLocked,
            [EnumMember(Value = "NONE")]
            None
        };

        /// <value>
        /// The user account status.
        /// </value>
        [JsonProperty(PropertyName = "accountStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AccountStatusEnum> AccountStatus { get; set; }
        
        /// <value>
        /// The OCID of the target database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetId is required.")]
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The date and time when the user last logged in, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeLastLogin")]
        public System.Nullable<System.DateTime> TimeLastLogin { get; set; }
        
        /// <value>
        /// The date and time when the user was created in the database, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeUserCreated")]
        public System.Nullable<System.DateTime> TimeUserCreated { get; set; }
                ///
        /// <value>
        /// The user authentication method.
        /// </value>
        ///
        public enum AuthenticationTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PASSWORD")]
            Password,
            [EnumMember(Value = "NONE")]
            None
        };

        /// <value>
        /// The user authentication method.
        /// </value>
        [JsonProperty(PropertyName = "authenticationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AuthenticationTypeEnum> AuthenticationType { get; set; }
        
        /// <value>
        /// The user profile name.
        /// </value>
        [JsonProperty(PropertyName = "userProfile")]
        public string UserProfile { get; set; }
        
        /// <value>
        /// The date and time when the user password was last changed, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timePasswordChanged")]
        public System.Nullable<System.DateTime> TimePasswordChanged { get; set; }
                ///
        ///
        public enum UserTypesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ADMIN_PRIVILEGED")]
            AdminPrivileged,
            [EnumMember(Value = "APPLICATION")]
            Application,
            [EnumMember(Value = "PRIVILEGED")]
            Privileged,
            [EnumMember(Value = "SCHEMA")]
            Schema,
            [EnumMember(Value = "NON_PRIVILEGED")]
            NonPrivileged
        };

        /// <value>
        /// The user type, which can be a combination of the following:
        /// <br/>
        /// 'Admin Privileged': The user has administrative privileges.
        /// 'Application': The user is an Oracle E-Business Suite Applications (EBS) or Fusion Applications (FA) user.
        /// 'Privileged': The user is a privileged user.
        /// 'Schema': The user is EXPIRED & LOCKED / EXPIRED / LOCKED, or a schema-only account (authentication type is NONE).
        /// 'Non-privileged': The user is a non-privileged user.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "userTypes", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<UserTypesEnum> UserTypes { get; set; }
                ///
        ///
        public enum AdminRolesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PDB_DBA")]
            PdbDba,
            [EnumMember(Value = "DBA")]
            Dba,
            [EnumMember(Value = "DV_ADMIN")]
            DvAdmin,
            [EnumMember(Value = "AUDIT_ADMIN")]
            AuditAdmin
        };

        /// <value>
        /// The admin roles granted to the user.
        /// </value>
        [JsonProperty(PropertyName = "adminRoles", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<AdminRolesEnum> AdminRoles { get; set; }
        
    }
}
