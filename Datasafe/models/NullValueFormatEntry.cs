/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The Null Value masking format replaces column data with NULL. The column
    /// being masked must be allowed to contain null values. To learn more,
    /// check Null Value in the Data Safe documentation. 
    /// 
    /// </summary>
    public class NullValueFormatEntry : FormatEntry
    {
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "NULL_VALUE";
    }
}
