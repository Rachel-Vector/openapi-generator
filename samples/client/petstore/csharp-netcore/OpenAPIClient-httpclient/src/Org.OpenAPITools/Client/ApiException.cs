/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// API Exception
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// The reason the api request failed
        /// </summary>
        public string? ReasonPhrase { get; }

        /// <summary>
        /// The HttpStatusCode
        /// </summary>
        public System.Net.HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The raw data returned by the api
        /// </summary>
        public string RawData { get; }
        
        /// <summary>
        /// Construct the ApiException from parts of the reponse
        /// </summary>
        /// <param name="reasonPhrase"></param>
        /// <param name="statusCode"></param>
        /// <param name="rawData"></param>
        public ApiException(string? reasonPhrase, System.Net.HttpStatusCode statusCode, string rawData) : base(reasonPhrase ?? rawData)
        {
            ReasonPhrase = reasonPhrase;

            StatusCode = statusCode;

            RawData = rawData;
        }
    }
}
