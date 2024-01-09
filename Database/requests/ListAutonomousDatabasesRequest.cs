/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabaseService.Models;

namespace Oci.DatabaseService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/database/ListAutonomousDatabases.cs.html">here</a> to see an example of how to use ListAutonomousDatabases request.
    /// </example>
    public class ListAutonomousDatabasesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The compartment [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The Autonomous Container Database [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "autonomousContainerDatabaseId")]
        public string AutonomousContainerDatabaseId { get; set; }
        
        /// <value>
        /// The maximum number of items to return per page.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The pagination token to continue listing from.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        ///
        /// <value>
        /// The field to sort by.  You can provide one sort order (`sortOrder`).  Default order for TIMECREATED is descending.  Default order for DISPLAYNAME is ascending. The DISPLAYNAME sort order is case sensitive.
        /// <br/>
        /// **Note:** If you do not include the availability domain filter, the resources are grouped by availability domain, then sorted.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIMECREATED")]
            Timecreated,
            [EnumMember(Value = "DISPLAYNAME")]
            Displayname
        };

        /// <value>
        /// The field to sort by.  You can provide one sort order (`sortOrder`).  Default order for TIMECREATED is descending.  Default order for DISPLAYNAME is ascending. The DISPLAYNAME sort order is case sensitive.
        /// <br/>
        /// **Note:** If you do not include the availability domain filter, the resources are grouped by availability domain, then sorted.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the given Infrastructure Type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "infrastructureType")]
        public System.Nullable<AutonomousDatabaseSummary.InfrastructureTypeEnum> InfrastructureType { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the given lifecycle state exactly.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<AutonomousDatabaseSummary.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A filter to return only autonomous database resources that match the specified workload type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "dbWorkload")]
        public System.Nullable<AutonomousDatabaseSummary.DbWorkloadEnum> DbWorkload { get; set; }
        
        /// <value>
        /// A filter to return only autonomous database resources that match the specified dbVersion.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "dbVersion")]
        public string DbVersion { get; set; }
        
        /// <value>
        /// Filter on the value of the resource's 'isFreeTier' property. A value of `true` returns only Always Free resources.
        /// A value of `false` excludes Always Free resources from the returned results. Omitting this parameter returns both Always Free and paid resources.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isFreeTier")]
        public System.Nullable<bool> IsFreeTier { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the entire display name given. The match is not case sensitive.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// Filter on the value of the resource's 'isRefreshableClone' property. A value of `true` returns only refreshable clones.
        /// A value of `false` excludes refreshable clones from the returned results. Omitting this parameter returns both refreshable clones and databases that are not refreshable clones.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isRefreshableClone")]
        public System.Nullable<bool> IsRefreshableClone { get; set; }
        
        /// <value>
        /// A filter to return only resources that have Data Guard enabled.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isDataGuardEnabled")]
        public System.Nullable<bool> IsDataGuardEnabled { get; set; }
        
        /// <value>
        /// Filter if the resource is the resource pool leader. A value of `true` returns only resource pool leader.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isResourcePoolLeader")]
        public System.Nullable<bool> IsResourcePoolLeader { get; set; }
        
        /// <value>
        /// The database [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the resourcepool Leader Autonomous Database.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourcePoolLeaderId")]
        public string ResourcePoolLeaderId { get; set; }
    }
}
