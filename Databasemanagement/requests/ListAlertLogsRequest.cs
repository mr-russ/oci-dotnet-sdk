/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabasemanagementService.Models;

namespace Oci.DatabasemanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemanagement/ListAlertLogs.cs.html">here</a> to see an example of how to use ListAlertLogs request.
    /// </example>
    public class ListAlertLogsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedDatabaseId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "managedDatabaseId")]
        public string ManagedDatabaseId { get; set; }
        
        /// <value>
        /// The optional greater than or equal to timestamp to filter the logs.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// The optional less than or equal to timestamp to filter the logs.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeLessThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeLessThanOrEqualTo { get; set; }
        
        ///
        /// <value>
        /// The optional parameter to filter the alert logs by log level.
        /// </value>
        ///
        public enum LevelFilterEnum {
            [EnumMember(Value = "CRITICAL")]
            Critical,
            [EnumMember(Value = "SEVERE")]
            Severe,
            [EnumMember(Value = "IMPORTANT")]
            Important,
            [EnumMember(Value = "NORMAL")]
            Normal,
            [EnumMember(Value = "ALL")]
            All
        };

        /// <value>
        /// The optional parameter to filter the alert logs by log level.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "levelFilter")]
        public System.Nullable<LevelFilterEnum> LevelFilter { get; set; }
        
        ///
        /// <value>
        /// The optional parameter to filter the attention or alert logs by type.
        /// </value>
        ///
        public enum TypeFilterEnum {
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            [EnumMember(Value = "INCIDENT_ERROR")]
            IncidentError,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "NOTIFICATION")]
            Notification,
            [EnumMember(Value = "TRACE")]
            Trace,
            [EnumMember(Value = "ALL")]
            All
        };

        /// <value>
        /// The optional parameter to filter the attention or alert logs by type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "typeFilter")]
        public System.Nullable<TypeFilterEnum> TypeFilter { get; set; }
        
        /// <value>
        /// The optional query parameter to filter the attention or alert logs by search text.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "logSearchText")]
        public string LogSearchText { get; set; }
        
        /// <value>
        /// The flag to indicate whether the search text is regular expression or not.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isRegularExpression")]
        public System.Nullable<bool> IsRegularExpression { get; set; }
        
        ///
        /// <value>
        /// The possible sortBy values of attention logs.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "LEVEL")]
            Level,
            [EnumMember(Value = "TYPE")]
            Type,
            [EnumMember(Value = "MESSAGE")]
            Message,
            [EnumMember(Value = "TIMESTAMP")]
            Timestamp
        };

        /// <value>
        /// The possible sortBy values of attention logs.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The option to sort information in ascending (\u2018ASC\u2019) or descending (\u2018DESC\u2019) order. Ascending order is the default order.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrders> SortOrder { get; set; }
        
        /// <value>
        /// The page token representing the page from where the next set of paginated results
        /// are retrieved. This is usually retrieved from a previous list call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The maximum number of records returned in the paginated response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The OCID of the Named Credential.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-named-credential-id")]
        public string OpcNamedCredentialId { get; set; }
    }
}
