/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.DeveloperToolConfigurations;
using Oci.Common.Model;
using Oci.Common.Auth;
using Oci.Common.Retry;
using Oci.ApmtracesService.Requests;
using Oci.ApmtracesService.Responses;

namespace Oci.ApmtracesService
{
    /// <summary>Service client instance for Attributes.</summary>
    public class AttributesClient : RegionalClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/20200630";

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public AttributesClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            if (!DeveloperToolConfiguration.IsServiceEnabled("apmtraces"))
            {
                throw new ArgumentException("The DeveloperToolConfiguration disabled this service, this behavior is controlled by DeveloperToolConfiguration.OciEnabledServiceSet variable. Please check if your local DeveloperToolConfiguration file has configured the service you're targeting or contact the cloud provider on the availability of this service");
            }
            service = new Service
            {
                ServiceName = "ATTRIBUTES",
                ServiceEndpointPrefix = "",
                ServiceEndpointTemplate = "https://apm-trace.{region}.oci.{secondLevelDomain}"
            };

            ClientConfiguration clientConfigurationToUse = clientConfiguration ?? new ClientConfiguration();

            if (authenticationDetailsProvider is IRegionProvider)
            {
                // Use region from Authentication details provider.
                SetRegion(((IRegionProvider)authenticationDetailsProvider).Region);
            }

            if (endpoint != null)
            {
                logger.Info($"Using endpoint specified \"{endpoint}\".");
                SetEndpoint(endpoint);
            }

            this.retryConfiguration = clientConfigurationToUse.RetryConfiguration;
        }

        /// <summary>
        /// Activates a set of attributes for the given APM Domain.  The API is not case-sensitive.  Any duplicates present in the bulk activation
        /// request are deduplicated and only unique attributes are activated.  A maximum number of 700 string attributes and 100 numeric attributes
        /// can be activated in an APM Domain subject to the available string and numeric slots.  Once an attribute has been activated, it may take sometime
        /// for it to be appear in searches as ingest might not have picked up the changes or any associated caches might not have refreshed.  The
        /// bulk activation operation is atomic, and the operation succeeds only if all the attributes in the request have been processed successfully and they
        /// get a success status back.  If the processing of any attribute results in a processing or validation error, then none of the attributes in the bulk
        /// request are activated.  Attributes that are activated are unpinned by default if they are pinned.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/apmtraces/BulkActivateAttribute.cs.html">here</a> to see an example of how to use BulkActivateAttribute API.</example>
        public async Task<BulkActivateAttributeResponse> BulkActivateAttribute(BulkActivateAttributeRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called bulkActivateAttribute");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/attributes/actions/activateAttributes".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "Attributes",
                    OperationName = "BulkActivateAttribute",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/apm-trace-explorer/20200630/BulkActivationStatus/BulkActivateAttribute",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<BulkActivateAttributeResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"BulkActivateAttribute failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Deactivates a set of attributes for the given APM Domain.  The API is case in-sensitive.  Any duplicates present in the bulk deactivation
        /// request are deduplicated and only unique attributes are deactivated.  A maximum number of 700 string attributes and 100 numeric attributes
        /// can be deactivated in an APM Domain subject to the available string and numeric slots.  Out of box attributes (Trace and Span) cannot be
        /// deactivated, and will result in a processing error.  Once an attribute has been deactivated, it may take sometime for it to disappear in
        /// searches as ingest might not have picked up the changes or any associated caches might not have refreshed.  The bulk deactivation
        /// operation is atomic, and the operation succeeds only if all the attributes in the request have been processed successfully and they get a success
        /// status back.  If the processing of any attribute results in a processing or validation error, then none of the attributes in the bulk request
        /// are deactivated.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/apmtraces/BulkDeActivateAttribute.cs.html">here</a> to see an example of how to use BulkDeActivateAttribute API.</example>
        public async Task<BulkDeActivateAttributeResponse> BulkDeActivateAttribute(BulkDeActivateAttributeRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called bulkDeActivateAttribute");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/attributes/actions/deActivateAttributes".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "Attributes",
                    OperationName = "BulkDeActivateAttribute",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/apm-trace-explorer/20200630/BulkDeActivationStatus/BulkDeActivateAttribute",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<BulkDeActivateAttributeResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"BulkDeActivateAttribute failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Pin a set of attributes in the APM Domain.  Attributes that are marked pinned are not autoactivated by ingest.
        /// Attributes that are deactivated are pinned by default.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/apmtraces/BulkPinAttribute.cs.html">here</a> to see an example of how to use BulkPinAttribute API.</example>
        public async Task<BulkPinAttributeResponse> BulkPinAttribute(BulkPinAttributeRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called bulkPinAttribute");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/attributes/actions/pinAttributes".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "Attributes",
                    OperationName = "BulkPinAttribute",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/apm-trace-explorer/20200630/BulkPinStatus/BulkPinAttribute",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<BulkPinAttributeResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"BulkPinAttribute failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Unpin a set of attributes in the APM Domain.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/apmtraces/BulkUnpinAttribute.cs.html">here</a> to see an example of how to use BulkUnpinAttribute API.</example>
        public async Task<BulkUnpinAttributeResponse> BulkUnpinAttribute(BulkUnpinAttributeRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called bulkUnpinAttribute");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/attributes/actions/unPinAttributes".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "Attributes",
                    OperationName = "BulkUnpinAttribute",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/apm-trace-explorer/20200630/BulkUnpinStatus/BulkUnpinAttribute",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<BulkUnpinAttributeResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"BulkUnpinAttribute failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Update a set of attribute properties in the APM Domain.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/apmtraces/BulkUpdateAttribute.cs.html">here</a> to see an example of how to use BulkUpdateAttribute API.</example>
        public async Task<BulkUpdateAttributeResponse> BulkUpdateAttribute(BulkUpdateAttributeRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called bulkUpdateAttribute");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/attributes/actions/updateAttributes".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "Attributes",
                    OperationName = "BulkUpdateAttribute",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/apm-trace-explorer/20200630/BulkUpdateAttributeStatus/BulkUpdateAttribute",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<BulkUpdateAttributeResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"BulkUpdateAttribute failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Add or edit notes to a set of attributes in the APM Domain.  Notes can be added to either an active or an inactive attribute.  The
        /// notes will be preserved even if the attribute changes state (when an active attribute is deactivated or when an inactive attribute
        /// is activated).
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/apmtraces/BulkUpdateAttributeNotes.cs.html">here</a> to see an example of how to use BulkUpdateAttributeNotes API.</example>
        public async Task<BulkUpdateAttributeNotesResponse> BulkUpdateAttributeNotes(BulkUpdateAttributeNotesRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called bulkUpdateAttributeNotes");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/attributes/actions/updateNotes".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "Attributes",
                    OperationName = "BulkUpdateAttributeNotes",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/apm-trace-explorer/20200630/BulkUpdateNotesStatus/BulkUpdateAttributeNotes",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<BulkUpdateAttributeNotesResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"BulkUpdateAttributeNotes failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Get autoactivation status for a private data key or public data key in the APM Domain.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/apmtraces/GetStatusAutoActivate.cs.html">here</a> to see an example of how to use GetStatusAutoActivate API.</example>
        public async Task<GetStatusAutoActivateResponse> GetStatusAutoActivate(GetStatusAutoActivateRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called getStatusAutoActivate");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/attributes/autoActivateStatus".Trim('/')));
            HttpMethod method = new HttpMethod("GET");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "Attributes",
                    OperationName = "GetStatusAutoActivate",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/apm-trace-explorer/20200630/AutoActivateStatus/GetStatusAutoActivate",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<GetStatusAutoActivateResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"GetStatusAutoActivate failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Turn on or off autoactivate for private data key or public data key traffic a given APM Domain.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/apmtraces/PutToggleAutoActivate.cs.html">here</a> to see an example of how to use PutToggleAutoActivate API.</example>
        public async Task<PutToggleAutoActivateResponse> PutToggleAutoActivate(PutToggleAutoActivateRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called putToggleAutoActivate");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/attributes/actions/autoActivate".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "Attributes",
                    OperationName = "PutToggleAutoActivate",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/apm-trace-explorer/20200630/AutoActivateToggleStatus/PutToggleAutoActivate",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<PutToggleAutoActivateResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"PutToggleAutoActivate failed with error: {e.Message}");
                throw;
            }
        }

    }
}
