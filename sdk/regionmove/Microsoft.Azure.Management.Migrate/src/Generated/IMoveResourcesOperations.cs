// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Migrate
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// MoveResourcesOperations operations.
    /// </summary>
    public partial interface IMoveResourcesOperations
    {
        /// <summary>
        /// Lists the Move Resources in the move collection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name.
        /// </param>
        /// <param name='moveCollectionName'>
        /// The Move Collection Name.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<MoveResource>>> ListWithHttpMessagesAsync(string resourceGroupName, string moveCollectionName, ODataQuery<MoveResourceFilter> odataQuery = default(ODataQuery<MoveResourceFilter>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a Move Resource in the move collection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name.
        /// </param>
        /// <param name='moveCollectionName'>
        /// The Move Collection Name.
        /// </param>
        /// <param name='moveResourceName'>
        /// The Move Resource Name.
        /// </param>
        /// <param name='properties'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<MoveResource>> CreateWithHttpMessagesAsync(string resourceGroupName, string moveCollectionName, string moveResourceName, MoveResourceProperties properties = default(MoveResourceProperties), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Move Resource from the move collection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name.
        /// </param>
        /// <param name='moveCollectionName'>
        /// The Move Collection Name.
        /// </param>
        /// <param name='moveResourceName'>
        /// The Move Resource Name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationStatus>> DeleteWithHttpMessagesAsync(string resourceGroupName, string moveCollectionName, string moveResourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the Move Resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name.
        /// </param>
        /// <param name='moveCollectionName'>
        /// The Move Collection Name.
        /// </param>
        /// <param name='moveResourceName'>
        /// The Move Resource Name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<MoveResource>> GetWithHttpMessagesAsync(string resourceGroupName, string moveCollectionName, string moveResourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a Move Resource in the move collection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name.
        /// </param>
        /// <param name='moveCollectionName'>
        /// The Move Collection Name.
        /// </param>
        /// <param name='moveResourceName'>
        /// The Move Resource Name.
        /// </param>
        /// <param name='properties'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<MoveResource>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string moveCollectionName, string moveResourceName, MoveResourceProperties properties = default(MoveResourceProperties), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Move Resource from the move collection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The Resource Group Name.
        /// </param>
        /// <param name='moveCollectionName'>
        /// The Move Collection Name.
        /// </param>
        /// <param name='moveResourceName'>
        /// The Move Resource Name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationStatus>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string moveCollectionName, string moveResourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Move Resources in the move collection.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<MoveResource>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
