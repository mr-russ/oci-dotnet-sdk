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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// Text Classification model testing and evaluation results
    /// </summary>
    public class TextClassificationEvaluationResults : EvaluationResults
    {
        
        [JsonProperty(PropertyName = "metrics")]
        public TextClassificationModelMetrics Metrics { get; set; }
        
        /// <value>
        /// List of text classification metrics
        /// </value>
        [JsonProperty(PropertyName = "classMetrics")]
        public System.Collections.Generic.List<ClassMetrics> ClassMetrics { get; set; }
        
        /// <value>
        /// class level confusion matrix
        /// </value>
        [JsonProperty(PropertyName = "confusionMatrix")]
        public System.Collections.Generic.Dictionary<string, ConfusionMatrixDetails> ConfusionMatrix { get; set; }
        
        /// <value>
        /// labels
        /// </value>
        [JsonProperty(PropertyName = "labels")]
        public System.Collections.Generic.List<string> Labels { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "TEXT_CLASSIFICATION";
    }
}
