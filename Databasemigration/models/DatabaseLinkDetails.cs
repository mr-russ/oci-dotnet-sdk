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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Optional details for creating a network database link from OCI database to on-premise database.
    /// 
    /// </summary>
    public class DatabaseLinkDetails 
    {
        
        /// <value>
        /// Name of database link from OCI database to on-premise database. ODMS will create link, if the link does not already exist.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        [JsonProperty(PropertyName = "walletBucket")]
        public ObjectStoreBucket WalletBucket { get; set; }
        
    }
}
