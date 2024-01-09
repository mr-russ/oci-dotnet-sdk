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


namespace Oci.MonitoringService.Models
{
    /// <summary>
    /// The configuration details for updating an alarm.
    /// 
    /// </summary>
    public class UpdateAlarmDetails 
    {
        
        /// <value>
        /// A user-friendly name for the alarm. It does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// This value determines the title of each alarm notification.
        /// <br/>
        /// Example: High CPU Utilization
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the alarm.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the metric
        /// being evaluated by the alarm.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metricCompartmentId")]
        public string MetricCompartmentId { get; set; }
        
        /// <value>
        /// When true, the alarm evaluates metrics from all compartments and subcompartments. The parameter can
        /// only be set to true when metricCompartmentId is the tenancy OCID (the tenancy is the root compartment).
        /// A true value requires the user to have tenancy-level permissions. If this requirement is not met,
        /// then the call is rejected. When false, the alarm evaluates metrics from only the compartment specified
        /// in metricCompartmentId. Default is false.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "metricCompartmentIdInSubtree")]
        public System.Nullable<bool> MetricCompartmentIdInSubtree { get; set; }
        
        /// <value>
        /// The source service or application emitting the metric that is evaluated by the alarm.
        /// <br/>
        /// Example: oci_computeagent
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// Resource group that you want to match. A null value returns only metric data that has no resource groups. The alarm retrieves metric data associated with the specified resource group only. Only one resource group can be applied per metric.
        /// A valid resourceGroup value starts with an alphabetical character and includes only alphanumeric characters, periods (.), underscores (_), hyphens (-), and dollar signs ($).
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: frontend-fleet
        /// </value>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }
        
        /// <value>
        /// The Monitoring Query Language (MQL) expression to evaluate for the alarm. The Alarms feature of
        /// the Monitoring service interprets results for each returned time series as Boolean values,
        /// where zero represents false and a non-zero value represents true. A true value means that the trigger
        /// rule condition has been met. The query must specify a metric, statistic, interval, and trigger
        /// rule (threshold or absence). Supported values for interval depend on the specified time range. More
        /// interval values are supported for smaller time ranges. You can optionally
        /// specify dimensions and grouping functions. Supported grouping functions: `grouping()`, `groupBy()`.
        /// For information about writing MQL expressions, see
        /// [Editing the MQL Expression for a Query](https://docs.cloud.oracle.com/iaas/Content/Monitoring/Tasks/query-metric-mql.htm).
        /// For details about MQL, see
        /// [Monitoring Query Language (MQL) Reference](https://docs.cloud.oracle.com/iaas/Content/Monitoring/Reference/mql.htm).
        /// For available dimensions, review the metric definition for the supported service. See
        /// [Supported Services](https://docs.cloud.oracle.com/iaas/Content/Monitoring/Concepts/monitoringoverview.htm#SupportedServices).
        /// <br/>
        /// Example of threshold alarm:
        /// <br/>
        ///   -----
        /// <br/>
        ///     CpuUtilization[1m]{availabilityDomain=\"cumS:PHX-AD-1\"}.groupBy(availabilityDomain).percentile(0.9) > 85
        /// <br/>
        ///   -----
        /// <br/>
        /// Example of absence alarm:
        /// <br/>
        ///   -----
        /// <br/>
        ///     CpuUtilization[1m]{availabilityDomain=\"cumS:PHX-AD-1\"}.absent()
        /// <br/>
        ///   -----
        /// 
        /// </value>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }
        
        /// <value>
        /// The time between calculated aggregation windows for the alarm. Supported value: `1m`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resolution")]
        public string Resolution { get; set; }
        
        /// <value>
        /// The period of time that the condition defined in the alarm must persist before the alarm state
        /// changes from \"OK\" to \"FIRING\". For example, a value of 5 minutes means that the
        /// alarm must persist in breaching the condition for five minutes before the alarm updates its
        /// state to \"FIRING\".
        /// <br/>
        /// The duration is specified as a string in ISO 8601 format (`PT10M` for ten minutes or `PT1H`
        /// for one hour). Minimum: PT1M. Maximum: PT1H. Default: PT1M.
        /// <br/>
        /// Under the default value of PT1M, the first evaluation that breaches the alarm updates the
        /// state to \"FIRING\".
        /// <br/>
        /// The alarm updates its status to \"OK\" when the breaching condition has been clear for
        /// the most recent minute.
        /// <br/>
        /// Example: PT5M
        /// </value>
        [JsonProperty(PropertyName = "pendingDuration")]
        public string PendingDuration { get; set; }
        
        /// <value>
        /// The perceived severity of the alarm with regard to the affected system.
        /// <br/>
        /// Example: CRITICAL
        /// </value>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Alarm.SeverityEnum> Severity { get; set; }
        
        /// <value>
        /// The human-readable content of the delivered alarm notification. Oracle recommends providing guidance
        /// to operators for resolving the alarm condition. Consider adding links to standard runbook
        /// practices. Avoid entering confidential information.
        /// <br/>
        /// Example: High CPU usage alert. Follow runbook instructions for resolution.
        /// </value>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }
        
        /// <value>
        /// When set to `true`, splits alarm notifications per metric stream.
        /// When set to `false`, groups alarm notifications across metric streams.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isNotificationsPerMetricDimensionEnabled")]
        public System.Nullable<bool> IsNotificationsPerMetricDimensionEnabled { get; set; }
                ///
        /// <value>
        /// The format to use for alarm notifications. The formats are:
        /// * `RAW` - Raw JSON blob. Default value. When the `destinations` attribute specifies `Streaming`, all alarm notifications use this format.
        /// * `PRETTY_JSON`: JSON with new lines and indents. Available when the `destinations` attribute specifies `Notifications` only.
        /// * `ONS_OPTIMIZED`: Simplified, user-friendly layout. Available when the `destinations` attribute specifies `Notifications` only. Applies to Email subscription types only.
        /// 
        /// </value>
        ///
        public enum MessageFormatEnum {
            [EnumMember(Value = "RAW")]
            Raw,
            [EnumMember(Value = "PRETTY_JSON")]
            PrettyJson,
            [EnumMember(Value = "ONS_OPTIMIZED")]
            OnsOptimized
        };

        /// <value>
        /// The format to use for alarm notifications. The formats are:
        /// * `RAW` - Raw JSON blob. Default value. When the `destinations` attribute specifies `Streaming`, all alarm notifications use this format.
        /// * `PRETTY_JSON`: JSON with new lines and indents. Available when the `destinations` attribute specifies `Notifications` only.
        /// * `ONS_OPTIMIZED`: Simplified, user-friendly layout. Available when the `destinations` attribute specifies `Notifications` only. Applies to Email subscription types only.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "messageFormat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MessageFormatEnum> MessageFormat { get; set; }
        
        /// <value>
        /// A list of destinations for alarm notifications.
        /// Each destination is represented by the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)
        /// of a related resource, such as a {@link NotificationTopic}.
        /// Supported destination services: Notifications
        /// , Streaming.          
        /// Limit: One destination per supported destination service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "destinations")]
        public System.Collections.Generic.List<string> Destinations { get; set; }
        
        /// <value>
        /// The frequency for re-submitting alarm notifications, if the alarm keeps firing without
        /// interruption. Format defined by ISO 8601. For example, `PT4H` indicates four hours.
        /// Minimum: PT1M. Maximum: P30D.
        /// <br/>
        /// Default value: null (notifications are not re-submitted).
        /// <br/>
        /// Example: PT2H
        /// </value>
        [JsonProperty(PropertyName = "repeatNotificationDuration")]
        public string RepeatNotificationDuration { get; set; }
        
        /// <value>
        /// The configuration details for suppressing an alarm.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "suppression")]
        public Suppression Suppression { get; set; }
        
        /// <value>
        /// Whether the alarm is enabled.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
