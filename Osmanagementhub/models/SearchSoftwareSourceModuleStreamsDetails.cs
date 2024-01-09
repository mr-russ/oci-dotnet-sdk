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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Contains a list of software sources to get the combined list of module streams from all of those software sources.
    /// </summary>
    public class SearchSoftwareSourceModuleStreamsDetails 
    {
        
        /// <value>
        /// List of software source OCIDs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SoftwareSourceIds is required.")]
        [JsonProperty(PropertyName = "softwareSourceIds")]
        public System.Collections.Generic.List<string> SoftwareSourceIds { get; set; }
                ///
        /// <value>
        /// The sort order.
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order.
        /// </value>
        [JsonProperty(PropertyName = "sortOrder")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The name of a module.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "moduleName")]
        public string ModuleName { get; set; }
                ///
        /// <value>
        /// The field to sort by.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "MODULENAME")]
            Modulename
        };

        /// <value>
        /// The field to sort by.
        /// </value>
        [JsonProperty(PropertyName = "sortBy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
    }
}
