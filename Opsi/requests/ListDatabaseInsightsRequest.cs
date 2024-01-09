/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OpsiService.Models;

namespace Oci.OpsiService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/opsi/ListDatabaseInsights.cs.html">here</a> to see an example of how to use ListDatabaseInsights request.
    /// </example>
    public class ListDatabaseInsightsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Unique Enterprise Manager bridge identifier
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "enterpriseManagerBridgeId")]
        public string EnterpriseManagerBridgeId { get; set; }
        
        /// <value>
        /// Optional list of database insight resource [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "id", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Id { get; set; }
        
        /// <value>
        /// Resource Status
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "status", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<ResourceStatus> Status { get; set; }
        
        /// <value>
        /// Lifecycle states
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<LifecycleState> LifecycleState { get; set; }
        
        ///
        /// <value>
        /// Filter by one or more database type.
        /// Possible values are ADW-S, ATP-S, ADW-D, ATP-D, EXTERNAL-PDB, EXTERNAL-NONCDB.
        /// 
        /// </value>
        ///
        public enum DatabaseTypeEnum {
            [EnumMember(Value = "ADW-S")]
            AdwS,
            [EnumMember(Value = "ATP-S")]
            AtpS,
            [EnumMember(Value = "ADW-D")]
            AdwD,
            [EnumMember(Value = "ATP-D")]
            AtpD,
            [EnumMember(Value = "EXTERNAL-PDB")]
            ExternalPdb,
            [EnumMember(Value = "EXTERNAL-NONCDB")]
            ExternalNoncdb,
            [EnumMember(Value = "COMANAGED-VM-CDB")]
            ComanagedVmCdb,
            [EnumMember(Value = "COMANAGED-VM-PDB")]
            ComanagedVmPdb,
            [EnumMember(Value = "COMANAGED-VM-NONCDB")]
            ComanagedVmNoncdb,
            [EnumMember(Value = "COMANAGED-BM-CDB")]
            ComanagedBmCdb,
            [EnumMember(Value = "COMANAGED-BM-PDB")]
            ComanagedBmPdb,
            [EnumMember(Value = "COMANAGED-BM-NONCDB")]
            ComanagedBmNoncdb,
            [EnumMember(Value = "COMANAGED-EXACS-CDB")]
            ComanagedExacsCdb,
            [EnumMember(Value = "COMANAGED-EXACS-PDB")]
            ComanagedExacsPdb,
            [EnumMember(Value = "COMANAGED-EXACS-NONCDB")]
            ComanagedExacsNoncdb
        };

        /// <value>
        /// Filter by one or more database type.
        /// Possible values are ADW-S, ATP-S, ADW-D, ATP-D, EXTERNAL-PDB, EXTERNAL-NONCDB.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "databaseType", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<DatabaseTypeEnum> DatabaseType { get; set; }
        
        /// <value>
        /// Optional list of database [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the associated DBaaS entity.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "databaseId", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DatabaseId { get; set; }
        
        ///
        /// <value>
        /// Specifies the fields to return in a database summary response. By default all fields are returned if omitted.
        /// 
        /// </value>
        ///
        public enum FieldsEnum {
            [EnumMember(Value = "compartmentId")]
            CompartmentId,
            [EnumMember(Value = "databaseName")]
            DatabaseName,
            [EnumMember(Value = "databaseDisplayName")]
            DatabaseDisplayName,
            [EnumMember(Value = "databaseType")]
            DatabaseType,
            [EnumMember(Value = "databaseVersion")]
            DatabaseVersion,
            [EnumMember(Value = "databaseHostNames")]
            DatabaseHostNames,
            [EnumMember(Value = "freeformTags")]
            FreeformTags,
            [EnumMember(Value = "definedTags")]
            DefinedTags
        };

        /// <value>
        /// Specifies the fields to return in a database summary response. By default all fields are returned if omitted.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<FieldsEnum> Fields { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of results per page, or items to
        /// return in a paginated \"List\" call.
        /// For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// Example: 50
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response header from
        /// the previous \"List\" call. For important details about how pagination works,
        /// see [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// Database insight list sort options. If `fields` parameter is selected, the `sortBy` parameter must be one of the fields specified.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "databaseName")]
            DatabaseName,
            [EnumMember(Value = "databaseDisplayName")]
            DatabaseDisplayName,
            [EnumMember(Value = "databaseType")]
            DatabaseType
        };

        /// <value>
        /// Database insight list sort options. If `fields` parameter is selected, the `sortBy` parameter must be one of the fields specified.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of exadata insight resource.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "exadataInsightId")]
        public string ExadataInsightId { get; set; }
        
        /// <value>
        /// A flag to search all resources within a given compartment and all sub-compartments.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        /// <value>
        /// Unique Operations Insights PrivateEndpoint identifier
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "opsiPrivateEndpointId")]
        public string OpsiPrivateEndpointId { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
