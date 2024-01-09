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


namespace Oci.AispeechService.Models
{
    /// <summary>
    /// Speaker diarization is a combination of speaker segmentation and speaker clustering. Provide diarization details to enable this feature.
    /// </summary>
    public class Diarization 
    {
        
        /// <value>
        /// Set true to enable Speaker diarization and tag transcription with speaker tags. By default this is disabled.
        /// </value>
        [JsonProperty(PropertyName = "isDiarizationEnabled")]
        public System.Nullable<bool> IsDiarizationEnabled { get; set; }
        
        /// <value>
        /// Number of speakers in the audio provided. By default service will auto detect all speakers in audio file
        /// </value>
        [JsonProperty(PropertyName = "numberOfSpeakers")]
        public System.Nullable<int> NumberOfSpeakers { get; set; }
        
    }
}
