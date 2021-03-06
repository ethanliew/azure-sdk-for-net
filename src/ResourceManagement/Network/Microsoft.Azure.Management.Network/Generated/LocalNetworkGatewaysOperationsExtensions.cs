// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LocalNetworkGatewaysOperations.
    /// </summary>
    public static partial class LocalNetworkGatewaysOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a local network gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update local network gateway
            /// operation.
            /// </param>
            public static LocalNetworkGateway CreateOrUpdate(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters)
            {
                return Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).CreateOrUpdateAsync(resourceGroupName, localNetworkGatewayName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a local network gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update local network gateway
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocalNetworkGateway> CreateOrUpdateAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified local network gateway in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            public static LocalNetworkGateway Get(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName)
            {
                return Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).GetAsync(resourceGroupName, localNetworkGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified local network gateway in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocalNetworkGateway> GetAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified local network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            public static void Delete(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName)
            {
                Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).DeleteAsync(resourceGroupName, localNetworkGatewayName), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified local network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all the local network gateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<LocalNetworkGateway> List(this ILocalNetworkGatewaysOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the local network gateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LocalNetworkGateway>> ListAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a local network gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update local network gateway
            /// operation.
            /// </param>
            public static LocalNetworkGateway BeginCreateOrUpdate(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters)
            {
                return Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, localNetworkGatewayName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a local network gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update local network gateway
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LocalNetworkGateway> BeginCreateOrUpdateAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified local network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            public static void BeginDelete(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName)
            {
                Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).BeginDeleteAsync(resourceGroupName, localNetworkGatewayName), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified local network gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all the local network gateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<LocalNetworkGateway> ListNext(this ILocalNetworkGatewaysOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the local network gateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LocalNetworkGateway>> ListNextAsync(this ILocalNetworkGatewaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

