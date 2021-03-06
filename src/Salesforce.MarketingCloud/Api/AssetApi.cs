/* 
 * Marketing Cloud REST API
 *
 * Marketing Cloud's REST API is our newest API. It supports multi-channel use cases, is much more lightweight and easy to use than our SOAP API, and is getting more comprehensive with every release.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: mc_sdk@salesforce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using RestSharp.Authenticators;
using Salesforce.MarketingCloud.Authentication;
using Salesforce.MarketingCloud.Client;
using Salesforce.MarketingCloud.Model;

namespace Salesforce.MarketingCloud.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAssetApi
    {
        #region Synchronous Operations
        /// <summary>
        /// createAsset
        /// </summary>
        /// <remarks>
        /// Creates a new asset.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Asset</returns>
        Asset CreateAsset (Asset body);

        /// <summary>
        /// createAsset
        /// </summary>
        /// <remarks>
        /// Creates a new asset.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>ApiResponse of Asset</returns>
        ApiResponse<Asset> CreateAssetWithHttpInfo (Asset body);
        /// <summary>
        /// deleteAssetById
        /// </summary>
        /// <remarks>
        /// Deletes an asset.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to delete</param>
        /// <returns></returns>
        void DeleteAssetById (decimal? id);

        /// <summary>
        /// deleteAssetById
        /// </summary>
        /// <remarks>
        /// Deletes an asset.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAssetByIdWithHttpInfo (decimal? id);
        /// <summary>
        /// getAssetById
        /// </summary>
        /// <remarks>
        /// Gets an asset by ID.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset</param>
        /// <returns>Asset</returns>
        Asset GetAssetById (decimal? id);

        /// <summary>
        /// getAssetById
        /// </summary>
        /// <remarks>
        /// Gets an asset by ID.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset</param>
        /// <returns>ApiResponse of Asset</returns>
        ApiResponse<Asset> GetAssetByIdWithHttpInfo (decimal? id);
        /// <summary>
        /// partiallyUpdateAssetById
        /// </summary>
        /// <remarks>
        /// Updates part of an asset.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to update</param>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Asset</returns>
        Asset PartiallyUpdateAssetById (decimal? id, Asset body);

        /// <summary>
        /// partiallyUpdateAssetById
        /// </summary>
        /// <remarks>
        /// Updates part of an asset.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to update</param>
        /// <param name="body">JSON Parameters</param>
        /// <returns>ApiResponse of Asset</returns>
        ApiResponse<Asset> PartiallyUpdateAssetByIdWithHttpInfo (decimal? id, Asset body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// createAsset
        /// </summary>
        /// <remarks>
        /// Creates a new asset.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of Asset</returns>
        System.Threading.Tasks.Task<Asset> CreateAssetAsync (Asset body);

        /// <summary>
        /// createAsset
        /// </summary>
        /// <remarks>
        /// Creates a new asset.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        System.Threading.Tasks.Task<ApiResponse<Asset>> CreateAssetAsyncWithHttpInfo (Asset body);
        /// <summary>
        /// deleteAssetById
        /// </summary>
        /// <remarks>
        /// Deletes an asset.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAssetByIdAsync (decimal? id);

        /// <summary>
        /// deleteAssetById
        /// </summary>
        /// <remarks>
        /// Deletes an asset.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssetByIdAsyncWithHttpInfo (decimal? id);
        /// <summary>
        /// getAssetById
        /// </summary>
        /// <remarks>
        /// Gets an asset by ID.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset</param>
        /// <returns>Task of Asset</returns>
        System.Threading.Tasks.Task<Asset> GetAssetByIdAsync (decimal? id);

        /// <summary>
        /// getAssetById
        /// </summary>
        /// <remarks>
        /// Gets an asset by ID.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        System.Threading.Tasks.Task<ApiResponse<Asset>> GetAssetByIdAsyncWithHttpInfo (decimal? id);
        /// <summary>
        /// partiallyUpdateAssetById
        /// </summary>
        /// <remarks>
        /// Updates part of an asset.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to update</param>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of Asset</returns>
        System.Threading.Tasks.Task<Asset> PartiallyUpdateAssetByIdAsync (decimal? id, Asset body);

        /// <summary>
        /// partiallyUpdateAssetById
        /// </summary>
        /// <remarks>
        /// Updates part of an asset.
        /// </remarks>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to update</param>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        System.Threading.Tasks.Task<ApiResponse<Asset>> PartiallyUpdateAssetByIdAsyncWithHttpInfo (decimal? id, Asset body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AssetApi : BaseApi, IAssetApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetApi"/> class.
        /// </summary>
        /// <returns></returns>
        internal AssetApi(string authBaseUrl, string clientId, string clientSecret, string accountId, string scope)
            : base(authBaseUrl, clientId, clientSecret, accountId, scope)
        {
        }

        /// <summary>
        /// createAsset Creates a new asset.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Asset</returns>
        public Asset CreateAsset (Asset body)
        {
             ApiResponse<Asset> localVarResponse = CreateAssetWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// createAsset Creates a new asset.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>ApiResponse of Asset</returns>
        public ApiResponse< Asset > CreateAssetWithHttpInfo (Asset body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssetApi->CreateAsset");

            var localVarPath = "/asset/v1/content/assets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateAsset", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Asset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Asset) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Asset)));
        }

        /// <summary>
        /// createAsset Creates a new asset.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of Asset</returns>
        public async System.Threading.Tasks.Task<Asset> CreateAssetAsync (Asset body)
        {
             ApiResponse<Asset> localVarResponse = await CreateAssetAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// createAsset Creates a new asset.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Asset>> CreateAssetAsyncWithHttpInfo (Asset body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssetApi->CreateAsset");

            var localVarPath = "/asset/v1/content/assets";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateAsset", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Asset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Asset) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Asset)));
        }

        /// <summary>
        /// deleteAssetById Deletes an asset.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to delete</param>
        /// <returns></returns>
        public void DeleteAssetById (decimal? id)
        {
             DeleteAssetByIdWithHttpInfo(id);
        }

        /// <summary>
        /// deleteAssetById Deletes an asset.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteAssetByIdWithHttpInfo (decimal? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AssetApi->DeleteAssetById");

            var localVarPath = "/asset/v1/content/assets/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAssetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// deleteAssetById Deletes an asset.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAssetByIdAsync (decimal? id)
        {
             await DeleteAssetByIdAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// deleteAssetById Deletes an asset.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAssetByIdAsyncWithHttpInfo (decimal? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AssetApi->DeleteAssetById");

            var localVarPath = "/asset/v1/content/assets/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteAssetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// getAssetById Gets an asset by ID.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset</param>
        /// <returns>Asset</returns>
        public Asset GetAssetById (decimal? id)
        {
             ApiResponse<Asset> localVarResponse = GetAssetByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getAssetById Gets an asset by ID.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset</param>
        /// <returns>ApiResponse of Asset</returns>
        public ApiResponse< Asset > GetAssetByIdWithHttpInfo (decimal? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AssetApi->GetAssetById");

            var localVarPath = "/asset/v1/content/assets/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAssetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Asset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Asset) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Asset)));
        }

        /// <summary>
        /// getAssetById Gets an asset by ID.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset</param>
        /// <returns>Task of Asset</returns>
        public async System.Threading.Tasks.Task<Asset> GetAssetByIdAsync (decimal? id)
        {
             ApiResponse<Asset> localVarResponse = await GetAssetByIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// getAssetById Gets an asset by ID.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Asset>> GetAssetByIdAsyncWithHttpInfo (decimal? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AssetApi->GetAssetById");

            var localVarPath = "/asset/v1/content/assets/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAssetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Asset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Asset) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Asset)));
        }

        /// <summary>
        /// partiallyUpdateAssetById Updates part of an asset.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to update</param>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Asset</returns>
        public Asset PartiallyUpdateAssetById (decimal? id, Asset body)
        {
             ApiResponse<Asset> localVarResponse = PartiallyUpdateAssetByIdWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// partiallyUpdateAssetById Updates part of an asset.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to update</param>
        /// <param name="body">JSON Parameters</param>
        /// <returns>ApiResponse of Asset</returns>
        public ApiResponse< Asset > PartiallyUpdateAssetByIdWithHttpInfo (decimal? id, Asset body)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AssetApi->PartiallyUpdateAssetById");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssetApi->PartiallyUpdateAssetById");

            var localVarPath = "/asset/v1/content/assets/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PartiallyUpdateAssetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Asset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Asset) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Asset)));
        }

        /// <summary>
        /// partiallyUpdateAssetById Updates part of an asset.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to update</param>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of Asset</returns>
        public async System.Threading.Tasks.Task<Asset> PartiallyUpdateAssetByIdAsync (decimal? id, Asset body)
        {
             ApiResponse<Asset> localVarResponse = await PartiallyUpdateAssetByIdAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// partiallyUpdateAssetById Updates part of an asset.
        /// </summary>
        /// <exception cref="Salesforce.MarketingCloud.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the asset to update</param>
        /// <param name="body">JSON Parameters</param>
        /// <returns>Task of ApiResponse (Asset)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Asset>> PartiallyUpdateAssetByIdAsyncWithHttpInfo (decimal? id, Asset body)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AssetApi->PartiallyUpdateAssetById");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssetApi->PartiallyUpdateAssetById");

            var localVarPath = "/asset/v1/content/assets/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PartiallyUpdateAssetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Asset>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Asset) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Asset)));
        }

    }
}
