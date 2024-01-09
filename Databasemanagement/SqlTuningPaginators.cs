/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Collections.Generic;
using System.Threading;
using Oci.DatabasemanagementService.Requests;
using Oci.DatabasemanagementService.Responses;
using Oci.DatabasemanagementService.Models;

namespace Oci.DatabasemanagementService
{
    /// <summary>
    /// Collection of helper methods that can be used to provide an enumerator interface
    /// to any list operations of SqlTuning where multiple pages of data may be fetched.
    /// Two styles of enumerators are supported:
    /// <list type="bullet">
    /// <item>
    /// <description>
    /// Enumerating over the Response objects returned by the list operation. These are referred to as ResponseEnumerators, and the methods are suffixed with ResponseEnumerator. For example: listUsersResponseEnumerator.
    /// </description>
    /// </item>
    /// <item>
    /// <description>
    /// Enumerating over the resources/records being listed. These are referred to as RecordEnumerators, and the methods are suffixed with RecordEnumerator. For example: listUsersRecordEnumerator.
    /// </description>
    /// </item>
    /// </list>
    /// These enumerators abstract away the need to write code to manually handle pagination via looping and using the page tokens.
    /// They will automatically fetch more data from the service when required.
    /// <br/>
    /// <br/>
    /// As an example, if we were using the ListUsers operation in IdentityService, then the iterator returned by calling a
    /// ResponseEnumerator method would iterate over the ListUsersResponse objects returned by each ListUsers call, whereas the enumerables
    /// returned by calling a RecordEnumerator method would iterate over the User records and we don't have to deal with ListUsersResponse objects at all.
    /// In either case, pagination will be automatically handled so we can iterate until there are no more responses or no more resources/records available.
    /// </summary>
    public class SqlTuningPaginators
    {
        private readonly SqlTuningClient client;

        public SqlTuningPaginators(SqlTuningClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListSqlTuningAdvisorTaskFindings operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListSqlTuningAdvisorTaskFindingsResponse> ListSqlTuningAdvisorTaskFindingsResponseEnumerator(ListSqlTuningAdvisorTaskFindingsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListSqlTuningAdvisorTaskFindingsRequest, ListSqlTuningAdvisorTaskFindingsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListSqlTuningAdvisorTaskFindings(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the SqlTuningAdvisorTaskFindingSummary objects
        /// contained in responses from the ListSqlTuningAdvisorTaskFindings operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<SqlTuningAdvisorTaskFindingSummary> ListSqlTuningAdvisorTaskFindingsRecordEnumerator(ListSqlTuningAdvisorTaskFindingsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListSqlTuningAdvisorTaskFindingsRequest, ListSqlTuningAdvisorTaskFindingsResponse, SqlTuningAdvisorTaskFindingSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListSqlTuningAdvisorTaskFindings(request, retryConfiguration, cancellationToken),
                response => response.SqlTuningAdvisorTaskFindingCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListSqlTuningAdvisorTaskRecommendations operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListSqlTuningAdvisorTaskRecommendationsResponse> ListSqlTuningAdvisorTaskRecommendationsResponseEnumerator(ListSqlTuningAdvisorTaskRecommendationsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListSqlTuningAdvisorTaskRecommendationsRequest, ListSqlTuningAdvisorTaskRecommendationsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListSqlTuningAdvisorTaskRecommendations(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the SqlTuningAdvisorTaskRecommendationSummary objects
        /// contained in responses from the ListSqlTuningAdvisorTaskRecommendations operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<SqlTuningAdvisorTaskRecommendationSummary> ListSqlTuningAdvisorTaskRecommendationsRecordEnumerator(ListSqlTuningAdvisorTaskRecommendationsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListSqlTuningAdvisorTaskRecommendationsRequest, ListSqlTuningAdvisorTaskRecommendationsResponse, SqlTuningAdvisorTaskRecommendationSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListSqlTuningAdvisorTaskRecommendations(request, retryConfiguration, cancellationToken),
                response => response.SqlTuningAdvisorTaskRecommendationCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListSqlTuningAdvisorTasks operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListSqlTuningAdvisorTasksResponse> ListSqlTuningAdvisorTasksResponseEnumerator(ListSqlTuningAdvisorTasksRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListSqlTuningAdvisorTasksRequest, ListSqlTuningAdvisorTasksResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListSqlTuningAdvisorTasks(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the SqlTuningAdvisorTaskSummary objects
        /// contained in responses from the ListSqlTuningAdvisorTasks operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<SqlTuningAdvisorTaskSummary> ListSqlTuningAdvisorTasksRecordEnumerator(ListSqlTuningAdvisorTasksRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListSqlTuningAdvisorTasksRequest, ListSqlTuningAdvisorTasksResponse, SqlTuningAdvisorTaskSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListSqlTuningAdvisorTasks(request, retryConfiguration, cancellationToken),
                response => response.SqlTuningAdvisorTaskCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListSqlTuningSets operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListSqlTuningSetsResponse> ListSqlTuningSetsResponseEnumerator(ListSqlTuningSetsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListSqlTuningSetsRequest, ListSqlTuningSetsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListSqlTuningSets(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the SqlTuningSetSummary objects
        /// contained in responses from the ListSqlTuningSets operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<SqlTuningSetSummary> ListSqlTuningSetsRecordEnumerator(ListSqlTuningSetsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListSqlTuningSetsRequest, ListSqlTuningSetsResponse, SqlTuningSetSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListSqlTuningSets(request, retryConfiguration, cancellationToken),
                response => response.SqlTuningSetCollection.Items
            );
        }

    }
}
