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


namespace Oci.UsageapiService.Models
{
    /// <summary>
    /// The saved dynamic date range (required when the static date range is missing).
    /// </summary>
    public class DynamicDateRange : DateRange
    {
                ///
        ///
        public enum DynamicDateRangeTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "LAST_7_DAYS")]
            Last7Days,
            [EnumMember(Value = "LAST_10_DAYS")]
            Last10Days,
            [EnumMember(Value = "LAST_CALENDAR_WEEK")]
            LastCalendarWeek,
            [EnumMember(Value = "LAST_CALENDAR_MONTH")]
            LastCalendarMonth,
            [EnumMember(Value = "LAST_2_CALENDAR_MONTHS")]
            Last2CalendarMonths,
            [EnumMember(Value = "LAST_3_CALENDAR_MONTHS")]
            Last3CalendarMonths,
            [EnumMember(Value = "LAST_6_CALENDAR_MONTHS")]
            Last6CalendarMonths,
            [EnumMember(Value = "LAST_30_DAYS")]
            Last30Days,
            [EnumMember(Value = "MONTH_TO_DATE")]
            MonthToDate,
            [EnumMember(Value = "LAST_YEAR")]
            LastYear,
            [EnumMember(Value = "YEAR_TODATE")]
            YearTodate,
            [EnumMember(Value = "ALL")]
            All
        };

        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DynamicDateRangeType is required.")]
        [JsonProperty(PropertyName = "dynamicDateRangeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DynamicDateRangeTypeEnum> DynamicDateRangeType { get; set; }
        
        [JsonProperty(PropertyName = "dateRangeType")]
        private readonly string dateRangeType = "DYNAMIC";
    }
}
