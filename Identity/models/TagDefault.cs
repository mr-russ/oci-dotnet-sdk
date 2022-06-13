/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// Tag defaults let you specify a default tag (tagnamespace.tag=\"value\") to apply to all resource types
    /// in a specified compartment. The tag default is applied at the time the resource is created. Resources
    /// that exist in the compartment before you create the tag default are not tagged. The `TagDefault` object
    /// specifies the tag and compartment details.
    /// <br/>
    /// Tag defaults are inherited by child compartments. This means that if you set a tag default on the root compartment
    /// for a tenancy, all resources that are created in the tenancy are tagged. For more information about
    /// using tag defaults, see [Managing Tag Defaults](https://docs.cloud.oracle.com/Content/Tagging/Tasks/managingtagdefaults.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator.
    /// 
    /// </summary>
    public class TagDefault 
    {
        
        /// <value>
        /// The OCID of the tag default.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment. The tag default applies to all new resources that get created in the
        /// compartment. Resources that existed before the tag default was created are not tagged.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the tag namespace that contains the tag definition.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagNamespaceId is required.")]
        [JsonProperty(PropertyName = "tagNamespaceId")]
        public string TagNamespaceId { get; set; }
        
        /// <value>
        /// The OCID of the tag definition. The tag default will always assign a default value for this tag definition.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagDefinitionId is required.")]
        [JsonProperty(PropertyName = "tagDefinitionId")]
        public string TagDefinitionId { get; set; }
        
        /// <value>
        /// The name used in the tag definition. This field is informational in the context of the tag default.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagDefinitionName is required.")]
        [JsonProperty(PropertyName = "tagDefinitionName")]
        public string TagDefinitionName { get; set; }
        
        /// <value>
        /// The default value for the tag definition. This will be applied to all resources created in the compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// Date and time the `TagDefault` object was created, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// The tag default's current state. After creating a `TagDefault`, make sure its `lifecycleState` is ACTIVE before using it.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "ACTIVE")]
            Active
        };

        /// <value>
        /// The tag default's current state. After creating a `TagDefault`, make sure its `lifecycleState` is ACTIVE before using it.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// If you specify that a value is required, a value is set during resource creation (either by the
        /// user creating the resource or another tag defualt). If no value is set, resource creation is
        /// blocked.
        /// <br/>
        /// * If the `isRequired` flag is set to \"true\", the value is set during resource creation.
        /// * If the `isRequired` flag is set to \"false\", the value you enter is set during resource creation.
        /// <br/>
        /// Example: false
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsRequired is required.")]
        [JsonProperty(PropertyName = "isRequired")]
        public System.Nullable<bool> IsRequired { get; set; }
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
    }
}
