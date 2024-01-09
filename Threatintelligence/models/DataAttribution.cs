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


namespace Oci.ThreatintelligenceService.Models
{
    /// <summary>
    /// The confidence, source information, and visibility for a particular sighting or observation of some data associated with a threat indicator. This associated data can be the indicator's threat type, attribute, or relationship.
    /// </summary>
    public class DataAttribution 
    {
        
        /// <value>
        /// An integer from 0 to 100 that provides a measure of our certainty in the maliciousness of data attributed to an indicator. For example, if the source of the data being attributed is the Tor Project, our confidence that the associated indicator is a tor exit node would be 100.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Confidence is required.")]
        [JsonProperty(PropertyName = "confidence")]
        public System.Nullable<int> Confidence { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [JsonProperty(PropertyName = "source")]
        public IndicatorSourceSummary Source { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Visibility is required.")]
        [JsonProperty(PropertyName = "visibility")]
        public DataVisibility Visibility { get; set; }
        
        /// <value>
        /// The date and time the attribution data was first seen for this entity. If the data source does not provide this information, it is set to the last time it was seen. An RFC3339 formatted string.
        /// </value>
        [JsonProperty(PropertyName = "timeFirstSeen")]
        public System.Nullable<System.DateTime> TimeFirstSeen { get; set; }
        
        /// <value>
        /// The last date and time the attribution data was seen for this entity. An RFC3339 formatted string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeLastSeen is required.")]
        [JsonProperty(PropertyName = "timeLastSeen")]
        public System.Nullable<System.DateTime> TimeLastSeen { get; set; }
        
    }
}
