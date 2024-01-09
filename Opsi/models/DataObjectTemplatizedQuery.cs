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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Information required in a structured template to form and execute query on a data object.
    /// </summary>
    public class DataObjectTemplatizedQuery : DataObjectQuery
    {
        
        /// <value>
        /// List of items to be added into the SELECT clause of the query; items will be added with comma separation.
        /// </value>
        [JsonProperty(PropertyName = "selectList")]
        public System.Collections.Generic.List<string> SelectList { get; set; }
        
        /// <value>
        /// Unique data object name that will be added into the FROM clause of the query, just like a view name in FROM clause.
        /// - Use actual name of the data objects (e.g: tables, views) in case of Warehouse (e.g: Awr hub) data objects query. SCHEMA.VIEW name syntax can also be used here.
        /// e.g: SYS.DBA_HIST_SNAPSHOT or DBA_HIST_SNAPSHOT
        /// - Use name of the data object (e.g: SQL_STATS_DO) in case of OPSI data objects. Identifier of the OPSI data object cannot be used here.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fromClause")]
        public string FromClause { get; set; }
        
        /// <value>
        /// List of items to be added into the WHERE clause of the query; items will be added with AND separation.
        /// Item can contain a single condition or multiple conditions.
        /// Single condition e.g:  \"optimizer_mode='mode1'\"
        /// Multiple conditions e.g: (module='module1' OR module='module2')
        /// 
        /// </value>
        [JsonProperty(PropertyName = "whereConditionsList")]
        public System.Collections.Generic.List<string> WhereConditionsList { get; set; }
        
        /// <value>
        /// List of items to be added into the GROUP BY clause of the query; items will be added with comma separation.
        /// </value>
        [JsonProperty(PropertyName = "groupByList")]
        public System.Collections.Generic.List<string> GroupByList { get; set; }
        
        /// <value>
        /// List of items to be added into the HAVING clause of the query; items will be added with AND separation.
        /// </value>
        [JsonProperty(PropertyName = "havingConditionsList")]
        public System.Collections.Generic.List<string> HavingConditionsList { get; set; }
        
        /// <value>
        /// List of items to be added into the ORDER BY clause of the query; items will be added with comma separation.
        /// </value>
        [JsonProperty(PropertyName = "orderByList")]
        public System.Collections.Generic.List<string> OrderByList { get; set; }
        
        [JsonProperty(PropertyName = "timeFilters")]
        public DataObjectQueryTimeFilters TimeFilters { get; set; }
        
        [JsonProperty(PropertyName = "queryType")]
        private readonly string queryType = "TEMPLATIZED_QUERY";
    }
}
