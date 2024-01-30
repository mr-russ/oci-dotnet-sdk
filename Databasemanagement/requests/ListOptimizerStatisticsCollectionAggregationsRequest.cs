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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemanagement/ListOptimizerStatisticsCollectionAggregations.cs.html">here</a> to see an example of how to use ListOptimizerStatisticsCollectionAggregations request.
    /// </example>
    public class ListOptimizerStatisticsCollectionAggregationsRequest : Oci.Common.IOciRequest
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
        /// The optimizer statistics tasks grouped by type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GroupType is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "groupType")]
        public System.Nullable<OptimizerStatisticsGroupByTypes> GroupType { get; set; }
        
        /// <value>
        /// The start time of the time range to retrieve the optimizer statistics of a Managed Database
        /// in UTC in ISO-8601 format, which is \"yyyy-MM-dd'T'hh:mm:ss.sss'Z'\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "startTimeGreaterThanOrEqualTo")]
        public string StartTimeGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// The end time of the time range to retrieve the optimizer statistics of a Managed Database
        /// in UTC in ISO-8601 format, which is \"yyyy-MM-dd'T'hh:mm:ss.sss'Z'\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "endTimeLessThanOrEqualTo")]
        public string EndTimeLessThanOrEqualTo { get; set; }
        
        /// <value>
        /// The filter types of the optimizer statistics tasks.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "taskType")]
        public System.Nullable<OptimizerStatisticsTaskFilterTypes> TaskType { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The maximum number of records returned in the paginated response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page from where the next set of paginated results
        /// are retrieved. This is usually retrieved from a previous list call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The OCID of the Named Credential.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-named-credential-id")]
        public string OpcNamedCredentialId { get; set; }
    }
}
