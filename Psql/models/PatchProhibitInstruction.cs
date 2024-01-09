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


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// A precondition operation that requires a selection to be empty, or optionally to be non-empty but include no item with a specified value
    /// (useful for asserting that a value does not exist before attempting to create it, avoiding accidental update).
    /// It fails if value is provided and the selection includes an item matching it, or if value is not provided and the selection is not empty,
    /// but ignores NOT_FOUND exceptions.
    /// 
    /// </summary>
    public class PatchProhibitInstruction : PatchInstruction
    {
        
        /// <value>
        /// A value to be compared against each item of the selection.
        /// If this value is an object, then it matches any item that would be unaffected by applying this value as a merge operation.
        /// Otherwise, it matches any item to which it is equal according to the rules of [JSON Schema](https://tools.ietf.org/html/draft-handrews-json-schema-00#section-4.2.3).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public System.Object Value { get; set; }
        
        [JsonProperty(PropertyName = "operation")]
        private readonly string operation = "PROHIBIT";
    }
}
