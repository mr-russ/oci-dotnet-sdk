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
    /// The dimensions available for SQL firewall allow SQL analytics.
    /// </summary>
    public class SqlFirewallAllowedSqlDimensions 
    {
        
        /// <value>
        /// The OCID of the SQL firewall policy corresponding to the SQL firewall allowed SQL.
        /// </value>
        [JsonProperty(PropertyName = "sqlFirewallPolicyId")]
        public string SqlFirewallPolicyId { get; set; }
                ///
        /// <value>
        /// Specifies the level of SQL included for this SQL firewall policy.
        /// USER_ISSUED_SQL - User issued SQL statements only.
        /// ALL_SQL - Includes all SQL statements including SQL statement issued inside PL/SQL units.
        /// 
        /// </value>
        ///
        public enum SqlLevelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "USER_ISSUED_SQL")]
            UserIssuedSql,
            [EnumMember(Value = "ALL_SQL")]
            AllSql
        };

        /// <value>
        /// Specifies the level of SQL included for this SQL firewall policy.
        /// USER_ISSUED_SQL - User issued SQL statements only.
        /// ALL_SQL - Includes all SQL statements including SQL statement issued inside PL/SQL units.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sqlLevel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SqlLevelEnum> SqlLevel { get; set; }
        
        /// <value>
        /// The database user name.
        /// </value>
        [JsonProperty(PropertyName = "dbUserName")]
        public string DbUserName { get; set; }
        
        /// <value>
        /// The current state of the SQL firewall allowed SQL.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SqlFirewallAllowedSqlLifecycleState> LifecycleState { get; set; }
        
    }
}
