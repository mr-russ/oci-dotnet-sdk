/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The information about RuntimeOperator.
    /// </summary>
    public class RuntimeOperatorSummary 
    {
        
        /// <value>
        /// The RuntimeOperator key.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The TaskRun key.
        /// </value>
        [JsonProperty(PropertyName = "taskRunKey")]
        public string TaskRunKey { get; set; }
        
        /// <value>
        /// The runtime operator start time.
        /// </value>
        [JsonProperty(PropertyName = "startTimeInMillis")]
        public System.Nullable<long> StartTimeInMillis { get; set; }
        
        /// <value>
        /// The runtime operator end time.
        /// </value>
        [JsonProperty(PropertyName = "endTimeInMillis")]
        public System.Nullable<long> EndTimeInMillis { get; set; }
                ///
        /// <value>
        /// status
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NOT_STARTED")]
            NotStarted,
            [EnumMember(Value = "QUEUED")]
            Queued,
            [EnumMember(Value = "RUNNING")]
            Running,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "SUCCESS")]
            Success,
            [EnumMember(Value = "ERROR")]
            Error
        };

        /// <value>
        /// status
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The type of the object.
        /// </value>
        [JsonProperty(PropertyName = "modelType")]
        public string ModelType { get; set; }
        
        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The version of the object that is used to track changes in the object instance.
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
                ///
        /// <value>
        /// status
        /// </value>
        ///
        public enum ExecutionStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NOT_STARTED")]
            NotStarted,
            [EnumMember(Value = "RUNNING")]
            Running,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "SUCCESS")]
            Success,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "SKIPPED")]
            Skipped,
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            [EnumMember(Value = "IGNORED")]
            Ignored
        };

        /// <value>
        /// status
        /// </value>
        [JsonProperty(PropertyName = "executionState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExecutionStateEnum> ExecutionState { get; set; }
        
        /// <value>
        /// A list of parameters for the pipeline, this allows certain aspects of the pipeline to be configured when the pipeline is executed.
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<Parameter> Parameters { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public ObjectMetadata Metadata { get; set; }
        
        [JsonProperty(PropertyName = "operator")]
        public Operator Operator { get; set; }
        
        /// <value>
        /// The configuration provider bindings.
        /// </value>
        [JsonProperty(PropertyName = "inputs")]
        public System.Collections.Generic.Dictionary<string, ParameterValue> Inputs { get; set; }
        
        /// <value>
        /// The configuration provider bindings.
        /// </value>
        [JsonProperty(PropertyName = "outputs")]
        public System.Collections.Generic.Dictionary<string, ParameterValue> Outputs { get; set; }
                ///
        /// <value>
        /// The type of task run.
        /// </value>
        ///
        public enum TaskTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INTEGRATION_TASK")]
            IntegrationTask,
            [EnumMember(Value = "DATA_LOADER_TASK")]
            DataLoaderTask,
            [EnumMember(Value = "PIPELINE_TASK")]
            PipelineTask,
            [EnumMember(Value = "SQL_TASK")]
            SqlTask,
            [EnumMember(Value = "OCI_DATAFLOW_TASK")]
            OciDataflowTask,
            [EnumMember(Value = "REST_TASK")]
            RestTask
        };

        /// <value>
        /// The type of task run.
        /// </value>
        [JsonProperty(PropertyName = "taskType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TaskTypeEnum> TaskType { get; set; }
        
        [JsonProperty(PropertyName = "configProvider")]
        public ConfigProvider ConfigProvider { get; set; }
                ///
        /// <value>
        /// The type of Runtime Operator
        /// </value>
        ///
        public enum OperatorTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "BASH_OPERATOR")]
            BashOperator,
            [EnumMember(Value = "TASK_OPERATOR")]
            TaskOperator,
            [EnumMember(Value = "REST_OPERATOR")]
            RestOperator,
            [EnumMember(Value = "START_OPERATOR")]
            StartOperator,
            [EnumMember(Value = "END_OPERATOR")]
            EndOperator,
            [EnumMember(Value = "EXPRESSION_OPERATOR")]
            ExpressionOperator,
            [EnumMember(Value = "MERGE_OPERATOR")]
            MergeOperator,
            [EnumMember(Value = "DECISION_OPERATOR")]
            DecisionOperator,
            [EnumMember(Value = "LOOP_OPERATOR")]
            LoopOperator,
            [EnumMember(Value = "ACTUAL_END_OPERATOR")]
            ActualEndOperator
        };

        /// <value>
        /// The type of Runtime Operator
        /// </value>
        [JsonProperty(PropertyName = "operatorType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperatorTypeEnum> OperatorType { get; set; }
        
        /// <value>
        /// A map metrics for the task run.
        /// </value>
        [JsonProperty(PropertyName = "metrics")]
        public System.Collections.Generic.Dictionary<string, float> Metrics { get; set; }
        
    }
}
