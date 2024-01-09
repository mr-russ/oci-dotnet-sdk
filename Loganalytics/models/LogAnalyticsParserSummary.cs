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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsParserSummary
    /// </summary>
    public class LogAnalyticsParserSummary 
    {
        
        /// <value>
        /// The content.
        /// </value>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
        
        /// <value>
        /// The parser description.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The parser display name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The parser edit version.
        /// </value>
        [JsonProperty(PropertyName = "editVersion")]
        public System.Nullable<long> EditVersion { get; set; }
        
        /// <value>
        /// The encoding.
        /// </value>
        [JsonProperty(PropertyName = "encoding")]
        public string Encoding { get; set; }
        
        /// <value>
        /// The example content.
        /// </value>
        [JsonProperty(PropertyName = "exampleContent")]
        public string ExampleContent { get; set; }
        
        /// <value>
        /// The parser fields.
        /// </value>
        [JsonProperty(PropertyName = "fieldMaps")]
        public System.Collections.Generic.List<LogAnalyticsParserField> FieldMaps { get; set; }
        
        /// <value>
        /// The footer regular expression.
        /// </value>
        [JsonProperty(PropertyName = "footerContent")]
        public string FooterContent { get; set; }
        
        /// <value>
        /// The header content.
        /// </value>
        [JsonProperty(PropertyName = "headerContent")]
        public string HeaderContent { get; set; }
        
        /// <value>
        /// The parser name.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A flag indicating if this is a default parser.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
        /// <value>
        /// A flag indicating if this is a single line content parser.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSingleLineContent")]
        public System.Nullable<bool> IsSingleLineContent { get; set; }
        
        /// <value>
        /// The system flag.  A value of false denotes a custom, or user
        /// defined object.  A value of true denotes a built in object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }
        
        /// <value>
        /// The language.
        /// </value>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
        
        /// <value>
        /// The last updated date.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The log type test request version.
        /// </value>
        [JsonProperty(PropertyName = "logTypeTestRequestVersion")]
        public System.Nullable<int> LogTypeTestRequestVersion { get; set; }
        
        /// <value>
        /// The mapped parser list.
        /// </value>
        [JsonProperty(PropertyName = "mappedParsers")]
        public System.Collections.Generic.List<LogAnalyticsParser> MappedParsers { get; set; }
        
        /// <value>
        /// The line characters for the parser to ignore.
        /// </value>
        [JsonProperty(PropertyName = "parserIgnorelineCharacters")]
        public string ParserIgnorelineCharacters { get; set; }
        
        /// <value>
        /// A flag indicating if the parser is hidden or not.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHidden")]
        public System.Nullable<bool> IsHidden { get; set; }
        
        /// <value>
        /// The parser sequence.
        /// </value>
        [JsonProperty(PropertyName = "parserSequence")]
        public System.Nullable<int> ParserSequence { get; set; }
        
        /// <value>
        /// The time zone.
        /// </value>
        [JsonProperty(PropertyName = "parserTimezone")]
        public string ParserTimezone { get; set; }
        
        [JsonProperty(PropertyName = "parserFilter")]
        public LogAnalyticsParserFilter ParserFilter { get; set; }
        
        /// <value>
        /// A flag indicating whther or not the parser is write once.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isParserWrittenOnce")]
        public System.Nullable<bool> IsParserWrittenOnce { get; set; }
        
        /// <value>
        /// The parser function list.
        /// </value>
        [JsonProperty(PropertyName = "parserFunctions")]
        public System.Collections.Generic.List<LogAnalyticsParserFunction> ParserFunctions { get; set; }
        
        /// <value>
        /// The number of sources using this parser.
        /// </value>
        [JsonProperty(PropertyName = "sourcesCount")]
        public System.Nullable<long> SourcesCount { get; set; }
        
        /// <value>
        /// The list of sources using this parser.
        /// </value>
        [JsonProperty(PropertyName = "sources")]
        public System.Collections.Generic.List<LogAnalyticsSource> Sources { get; set; }
        
        /// <value>
        /// A flag indicating whether or not to tokenize the original text.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shouldTokenizeOriginalText")]
        public System.Nullable<bool> ShouldTokenizeOriginalText { get; set; }
        
        /// <value>
        /// The parser field delimiter.
        /// </value>
        [JsonProperty(PropertyName = "fieldDelimiter")]
        public string FieldDelimiter { get; set; }
        
        /// <value>
        /// The parser field qualifier.
        /// </value>
        [JsonProperty(PropertyName = "fieldQualifier")]
        public string FieldQualifier { get; set; }
                ///
        /// <value>
        /// The parser type.  Default value is REGEX.
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "XML")]
            Xml,
            [EnumMember(Value = "JSON")]
            Json,
            [EnumMember(Value = "REGEX")]
            Regex,
            [EnumMember(Value = "ODL")]
            Odl,
            [EnumMember(Value = "DELIMITED")]
            Delimited
        };

        /// <value>
        /// The parser type.  Default value is REGEX.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the parser has been deleted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isUserDeleted")]
        public System.Nullable<bool> IsUserDeleted { get; set; }
        
        /// <value>
        /// A flag indicating whether the XML parser should consider the namespace(s) while processing the log data.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isNamespaceAware")]
        public System.Nullable<bool> IsNamespaceAware { get; set; }
        
    }
}
