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


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// The table extracted from a document.
    /// </summary>
    public class Table 
    {
        
        /// <value>
        /// The number of rows.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RowCount is required.")]
        [JsonProperty(PropertyName = "rowCount")]
        public System.Nullable<int> RowCount { get; set; }
        
        /// <value>
        /// The number of columns.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ColumnCount is required.")]
        [JsonProperty(PropertyName = "columnCount")]
        public System.Nullable<int> ColumnCount { get; set; }
        
        /// <value>
        /// The header rows.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HeaderRows is required.")]
        [JsonProperty(PropertyName = "headerRows")]
        public System.Collections.Generic.List<TableRow> HeaderRows { get; set; }
        
        /// <value>
        /// The body rows.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BodyRows is required.")]
        [JsonProperty(PropertyName = "bodyRows")]
        public System.Collections.Generic.List<TableRow> BodyRows { get; set; }
        
        /// <value>
        /// the footer rows.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FooterRows is required.")]
        [JsonProperty(PropertyName = "footerRows")]
        public System.Collections.Generic.List<TableRow> FooterRows { get; set; }
        
        /// <value>
        /// The confidence score between 0 and 1.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Confidence is required.")]
        [JsonProperty(PropertyName = "confidence")]
        public System.Nullable<float> Confidence { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BoundingPolygon is required.")]
        [JsonProperty(PropertyName = "boundingPolygon")]
        public BoundingPolygon BoundingPolygon { get; set; }
        
    }
}
