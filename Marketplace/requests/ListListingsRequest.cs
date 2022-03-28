/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.MarketplaceService.Models;

namespace Oci.MarketplaceService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/marketplace/ListListings.cs.html">here</a> to see an example of how to use ListListings request.
    /// </example>
    public class ListListingsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The name of the listing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Name { get; set; }
        
        /// <value>
        /// The unique identifier for the listing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "listingId")]
        public string ListingId { get; set; }
        
        /// <value>
        /// The image identifier of the listing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "imageId")]
        public string ImageId { get; set; }
        
        /// <value>
        /// Limit results to just this publisher.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "publisherId")]
        public string PublisherId { get; set; }
        
        /// <value>
        /// A filter to return only packages that match the given package type exactly.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "packageType")]
        public string PackageType { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request,
        /// please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// How many records to return. Specify a value greater than zero and less than or equal to 1000. The default is 30.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous \"List\" call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        ///
        /// <value>
        /// The field to use to sort listed results. You can only specify one field to sort by.
        /// `TIMERELEASED` displays results in descending order by default.
        /// You can change your preference by specifying a different sort order.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIMERELEASED")]
            Timereleased
        };

        /// <value>
        /// The field to use to sort listed results. You can only specify one field to sort by.
        /// `TIMERELEASED` displays results in descending order by default.
        /// You can change your preference by specifying a different sort order.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either `ASC` or `DESC`.
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either `ASC` or `DESC`.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// Name of the product category or categories. If you specify multiple categories, then Marketplace returns any listing with
        /// one or more matching categories.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "category", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Category { get; set; }
        
        /// <value>
        /// Name of the pricing type. If multiple pricing types are provided, then any listing with
        /// one or more matching pricing models will be returned.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "pricing", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<PricingTypeEnum> Pricing { get; set; }
        
        /// <value>
        /// Indicates whether to show only featured listings. If this is set to `false` or is omitted, then all listings will be returned.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isFeatured")]
        public System.Nullable<bool> IsFeatured { get; set; }
        
        /// <value>
        /// The type of the listing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "listingTypes", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<ListingType> ListingTypes { get; set; }
        
        /// <value>
        /// The operating system of the listing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "operatingSystems", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> OperatingSystems { get; set; }
        
        /// <value>
        /// The unique identifier for the compartment.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
    }
}
