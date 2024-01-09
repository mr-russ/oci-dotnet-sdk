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


namespace Oci.DataflowService.Models
{
    /// <summary>
    /// The create run details. The following properties are optional and override the default values
    /// set in the associated application:
    ///   - applicationId
    ///   - archiveUri
    ///   - applicationLogConfig
    ///   - arguments
    ///   - configuration
    ///   - definedTags
    ///   - displayName
    ///   - driverShape
    ///   - execute
    ///   - executorShape
    ///   - freeformTags
    ///   - logsBucketUri
    ///   - metastoreId
    ///   - numExecutors
    ///   - parameters
    ///   - sparkVersion
    ///   - warehouseBucketUri
    /// It is expected that either the applicationId or the execute parameter is specified; but not both.
    /// If both or none are set, a Bad Request (HTTP 400) status will be sent as the response.
    /// If an appicationId is not specified, then a value for the execute parameter is expected.
    /// Using data parsed from the value, a new application will be created and assicated with the new run.
    /// See information on the execute parameter for details on the format of this parameter.
    /// <br/>
    /// The optional parameter spark version can only be specified when using the execute parameter.  If it
    /// is not specified when using the execute parameter, the latest version will be used as default.
    /// If the execute parameter is not used, the spark version will be taken from the associated application.
    /// <br/>
    /// If displayName is not specified, it will be derived from the displayName of associated application or
    /// set by API using fileUri's application file name.
    /// Once a run is created, its properties (except for definedTags and freeformTags) cannot be changed.
    /// If the parent application's properties (including definedTags and freeformTags) are updated,
    /// the corresponding properties of the run will not update.
    /// 
    /// </summary>
    public class CreateRunDetails 
    {
        
        [JsonProperty(PropertyName = "applicationLogConfig")]
        public ApplicationLogConfig ApplicationLogConfig { get; set; }
        
        /// <value>
        /// The OCID of the associated application. If this value is set, then no value for the execute parameter is required. If this value is not set, then a value for the execute parameter is required, and a new application is created and associated with the new run.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }
        
        /// <value>
        /// A comma separated list of one or more archive files as Oracle Cloud Infrastructure URIs. For example, ``oci://path/to/a.zip,oci://path/to/b.zip``. An Oracle Cloud Infrastructure URI of an archive.zip file containing custom dependencies that may be used to support the execution of a Python, Java, or Scala application.
        /// See https://docs.cloud.oracle.com/iaas/Content/API/SDKDocs/hdfsconnector.htm#uriformat.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "archiveUri")]
        public string ArchiveUri { get; set; }
        
        /// <value>
        /// The arguments passed to the running application as command line arguments.  An argument is
        /// either a plain text or a placeholder. Placeholders are replaced using values from the parameters
        /// map.  Each placeholder specified must be represented in the parameters map else the request
        /// (POST or PUT) will fail with a HTTP 400 status code.  Placeholders are specified as
        /// `Service Api Spec`, where `name` is the name of the parameter.
        /// Example: [ &quot;--input&quot;, &quot;${input_file}&quot;, &quot;--name&quot;, &quot;John Doe&quot; ]If &quot;input_file&quot; has a value of &quot;mydata.xml&quot;, then the value above will be translated to--input mydata.xml --name &quot;John Doe&quot;
        /// </value>
        [JsonProperty(PropertyName = "arguments")]
        public System.Collections.Generic.List<string> Arguments { get; set; }
        
        /// <value>
        /// The OCID of a compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The Spark configuration passed to the running process.
        /// See https://spark.apache.org/docs/latest/configuration.html#available-properties.
        /// Example: { &quot;spark.app.name&quot; : &quot;My App Name&quot;, &quot;spark.shuffle.io.maxRetries&quot; : &quot;4&quot; }Note: Not all Spark properties are permitted to be set.  Attempting to set a property that isnot allowed to be overwritten will cause a 400 status to be returned.
        /// </value>
        [JsonProperty(PropertyName = "configuration")]
        public System.Collections.Generic.Dictionary<string, string> Configuration { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name that does not have to be unique. Avoid entering confidential information. If this value is not specified, it will be derived from the associated application's displayName or set by API using fileUri's application file name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The VM shape for the driver. Sets the driver cores and memory.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "driverShape")]
        public string DriverShape { get; set; }
        
        [JsonProperty(PropertyName = "driverShapeConfig")]
        public ShapeConfig DriverShapeConfig { get; set; }
        
        /// <value>
        /// The input used for spark-submit command. For more details see https://spark.apache.org/docs/latest/submitting-applications.html#launching-applications-with-spark-submit.
        /// Supported options include ``--class``, ``--file``, ``--jars``, ``--conf``, ``--py-files``, and main application file with arguments.
        /// Example: --jars oci://path/to/a.jar,oci://path/to/b.jar --files oci://path/to/a.json,oci://path/to/b.csv --py-files oci://path/to/a.py,oci://path/to/b.py --conf spark.sql.crossJoin.enabled=true --class org.apache.spark.examples.SparkPi oci://path/to/main.jar 10Note: If execute is specified together with applicationId, className, configuration, fileUri, language, arguments, parameters during application create/update, or run create/submit,Data Flow service will use derived information from execute input only.
        /// </value>
        [JsonProperty(PropertyName = "execute")]
        public string Execute { get; set; }
        
        /// <value>
        /// The VM shape for the executors. Sets the executor cores and memory.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "executorShape")]
        public string ExecutorShape { get; set; }
        
        [JsonProperty(PropertyName = "executorShapeConfig")]
        public ShapeConfig ExecutorShapeConfig { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// An Oracle Cloud Infrastructure URI of the bucket where the Spark job logs are to be uploaded.
        /// See https://docs.cloud.oracle.com/iaas/Content/API/SDKDocs/hdfsconnector.htm#uriformat.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logsBucketUri")]
        public string LogsBucketUri { get; set; }
        
        /// <value>
        /// The OCID of OCI Hive Metastore.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metastoreId")]
        public string MetastoreId { get; set; }
        
        /// <value>
        /// The number of executor VMs requested.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "numExecutors")]
        public System.Nullable<int> NumExecutors { get; set; }
        
        /// <value>
        /// An array of name/value pairs used to fill placeholders found in properties like
        /// `Application.arguments`.  The name must be a string of one or more word characters
        /// (a-z, A-Z, 0-9, _).  The value can be a string of 0 or more characters of any kind.
        /// Example: [ { name: &quot;iterations&quot;, value: &quot;10&quot;}, { name: &quot;input_file&quot;, value: &quot;mydata.xml&quot; }, { name: &quot;variable_x&quot;, value: &quot;${x}&quot;} ]
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<ApplicationParameter> Parameters { get; set; }
        
        /// <value>
        /// The OCID of a pool. Unique Id to indentify a dataflow pool resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "poolId")]
        public string PoolId { get; set; }
        
        /// <value>
        /// The Spark version utilized to run the application. This value may be set if applicationId is not since the Spark version will be taken from the associated application.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sparkVersion")]
        public string SparkVersion { get; set; }
        
        /// <value>
        /// The Spark application processing type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ApplicationType> Type { get; set; }
        
        /// <value>
        /// An Oracle Cloud Infrastructure URI of the bucket to be used as default warehouse directory
        /// for BATCH SQL runs.
        /// See https://docs.cloud.oracle.com/iaas/Content/API/SDKDocs/hdfsconnector.htm#uriformat.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "warehouseBucketUri")]
        public string WarehouseBucketUri { get; set; }
        
        /// <value>
        /// The maximum duration in minutes for which an Application should run. Data Flow Run would be terminated
        /// once it reaches this duration from the time it transitions to `IN_PROGRESS` state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxDurationInMinutes")]
        public System.Nullable<long> MaxDurationInMinutes { get; set; }
        
        /// <value>
        /// The timeout value in minutes used to manage Runs. A Run would be stopped after inactivity for this amount of time period.
        /// Note: This parameter is currently only applicable for Runs of type `SESSION`. Default value is 2880 minutes (2 days)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "idleTimeoutInMinutes")]
        public System.Nullable<long> IdleTimeoutInMinutes { get; set; }
        
    }
}
