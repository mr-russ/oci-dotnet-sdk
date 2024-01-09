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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The existing named credential used to connect to the ASM instance.
    /// 
    /// </summary>
    public class AsmConnectionCredentailsByName : AsmConnectionCredentials
    {
        
        /// <value>
        /// The name of the credential information that used to connect to the DB system resource.
        /// The name should be in \"x.y\" format, where the length of \"x\" has a maximum of 64 characters,
        /// and length of \"y\" has a maximum of 199 characters. The name strings can contain letters,
        /// numbers and the underscore character only. Other characters are not valid, except for
        /// the \".\" character that separates the \"x\" and \"y\" portions of the name.
        /// *IMPORTANT* - The name must be unique within the OCI region the credential is being created in.
        /// If you specify a name that duplicates the name of another credential within the same OCI region,
        /// you may overwrite or corrupt the credential that is already using the name.
        /// <br/>
        /// For Example: inventorydb.abc112233445566778899
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CredentialName is required.")]
        [JsonProperty(PropertyName = "credentialName")]
        public string CredentialName { get; set; }
        
        [JsonProperty(PropertyName = "credentialType")]
        private readonly string credentialType = "NAME_REFERENCE";
    }
}
