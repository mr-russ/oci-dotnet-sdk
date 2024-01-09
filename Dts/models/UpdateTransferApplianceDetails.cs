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


namespace Oci.DtsService.Models
{
    
    public class UpdateTransferApplianceDetails 
    {
                ///
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PREPARING")]
            Preparing,
            [EnumMember(Value = "FINALIZED")]
            Finalized,
            [EnumMember(Value = "RETURN_LABEL_REQUESTED")]
            ReturnLabelRequested,
            [EnumMember(Value = "RETURN_LABEL_GENERATING")]
            ReturnLabelGenerating,
            [EnumMember(Value = "RETURN_LABEL_AVAILABLE")]
            ReturnLabelAvailable,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "CUSTOMER_NEVER_RECEIVED")]
            CustomerNeverReceived,
            [EnumMember(Value = "CANCELLED")]
            Cancelled
        };

        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        [JsonProperty(PropertyName = "customerShippingAddress")]
        public ShippingAddress CustomerShippingAddress { get; set; }
        
        /// <value>
        /// Expected return date from customer for the device, time portion should be zero.
        /// </value>
        [JsonProperty(PropertyName = "expectedReturnDate")]
        public System.Nullable<System.DateTime> ExpectedReturnDate { get; set; }
        
        /// <value>
        /// Start time for the window to pickup the device from customer.
        /// </value>
        [JsonProperty(PropertyName = "pickupWindowStartTime")]
        public System.Nullable<System.DateTime> PickupWindowStartTime { get; set; }
        
        /// <value>
        /// End time for the window to pickup the device from customer.
        /// </value>
        [JsonProperty(PropertyName = "pickupWindowEndTime")]
        public System.Nullable<System.DateTime> PickupWindowEndTime { get; set; }
        
        /// <value>
        /// Minimum storage capacity of the device, in terabytes. Valid options are 50, 95 and 150.
        /// </value>
        [JsonProperty(PropertyName = "minimumStorageCapacityInTerabytes")]
        public System.Nullable<int> MinimumStorageCapacityInTerabytes { get; set; }
        
    }
}
