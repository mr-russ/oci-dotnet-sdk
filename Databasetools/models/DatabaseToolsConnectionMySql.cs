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


namespace Oci.DatabasetoolsService.Models
{
    /// <summary>
    /// Database Tools connection of a MySQL Server.
    /// </summary>
    public class DatabaseToolsConnectionMySql : DatabaseToolsConnection
    {
        
        [JsonProperty(PropertyName = "relatedResource")]
        public DatabaseToolsRelatedResourceMySql RelatedResource { get; set; }
        
        /// <value>
        /// The connection string used to connect to the MySQL Server.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectionString is required.")]
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }
        
        /// <value>
        /// The user name.
        /// </value>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        
        [JsonProperty(PropertyName = "userPassword")]
        public DatabaseToolsUserPassword UserPassword { get; set; }
        
        /// <value>
        /// The advanced connection properties key-value pair (for example, `sslMode`).
        /// </value>
        [JsonProperty(PropertyName = "advancedProperties")]
        public System.Collections.Generic.Dictionary<string, string> AdvancedProperties { get; set; }
        
        /// <value>
        /// The CA certificate to verify the server's certificate and
        /// the client private key and associated certificate required for client authentication.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyStores")]
        public System.Collections.Generic.List<DatabaseToolsKeyStoreMySql> KeyStores { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Database Tools private endpoint used to access the database in the customer VCN.
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointId")]
        public string PrivateEndpointId { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "MYSQL";
    }
}
