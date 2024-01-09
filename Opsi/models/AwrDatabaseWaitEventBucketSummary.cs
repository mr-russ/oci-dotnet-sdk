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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// A summary of the AWR wait event bucket and waits percentage.
    /// </summary>
    public class AwrDatabaseWaitEventBucketSummary 
    {
        
        /// <value>
        /// The name of the wait event frequency category. Normally, it is the upper range of the waits within the AWR wait event bucket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Category is required.")]
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        
        /// <value>
        /// The percentage of waits in a wait event bucket over the total waits of the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Percentage is required.")]
        [JsonProperty(PropertyName = "percentage")]
        public System.Double Percentage { get; set; }
        
    }
}
