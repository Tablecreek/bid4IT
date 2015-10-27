using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Windows.Storage.Streams;
using Windows.Web.Http;

using HttpClient = Windows.Web.Http.HttpClient;
using HttpResponseMessage = Windows.Web.Http.HttpResponseMessage;

namespace BusinessLayer.Rest {
    public class DataClient {
        private static async Task<HttpResponseMessage> Post (Uri uri, IHttpContent httpContent, List<KeyValuePair<string, string>> headerParameters = null) {
            var httpClient = CreateHttpClient(headerParameters);
            try {
                var response = await httpClient.PostAsync(uri, httpContent);
                return response;
            } catch (Exception exception) {
                throw new Exception(exception.ToString(), exception);
            } finally {
                httpClient.Dispose();
            }
        }

        private static async Task<HttpResponseMessage> Get (Uri uri, List<KeyValuePair<string, string>> headerParameters = null) {
            var httpClient = CreateHttpClient(headerParameters);
            try {
                var response = await httpClient.GetAsync(uri);
                return response;
            } catch (Exception exception) {
                throw new Exception(exception.ToString(), exception);
            } finally {
                httpClient.Dispose();
            }
        }

        private static async Task<HttpResponseMessage> Put (Uri uri, IHttpContent httpContent, List<KeyValuePair<string, string>> headerParameters = null) {
            var httpClient = CreateHttpClient(headerParameters);
            try {
                var response = await httpClient.PutAsync(uri, httpContent);
                return response;
            } catch (Exception exception) {
                throw new Exception(exception.ToString(), exception);
            } finally {
                httpClient.Dispose();
            }
        }

        private static async Task<HttpResponseMessage> Post (Uri uri, List<KeyValuePair<string, string>> headerParameters = null) {
            var httpClient = CreateHttpClient(headerParameters);
            try {
                var response = await httpClient.DeleteAsync(uri);
                return response;
            } catch (Exception exception) {
                throw new Exception(exception.ToString(), exception);
            } finally {
                httpClient.Dispose();
            }
        }

        private static HttpClient CreateHttpClient (List<KeyValuePair<string, string>> headerParameters) {
            var httpClient = new HttpClient();

            if (headerParameters != null)
            {
                foreach (var headerParameter in headerParameters)
                {
                    httpClient.DefaultRequestHeaders.Append(headerParameter.Key, headerParameter.Value);
                }
            }
            
            return httpClient;
        }
    }
}