using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebAPI_Testing.Enumerations;
using WebAPI_Testing.Models;

namespace WebAPI_Testing.Api
{
    public static class Smartlock
    {
        private static HttpClient _client;

        public static HttpClient Client
        {
            get { return _client ?? InitializeClient(); }
        }

        private static HttpClient InitializeClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.nuki.io/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Models.Authorization.ApiToken}");
            return client;
        }

        /// <summary>
        /// Get a list of Smartlocks
        /// </summary>
        /// <returns></returns>
        public static async Task<Models.Smartlock.Smartlock[]> GetSmartlocksAsync()
        {
            using (Client)
            {
                var response = await Client.GetAsync($"smartlock");
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Models.Smartlock.Smartlock[]>(responseString);
            }
        }
        /// <summary>
        /// Create a Smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="authUuid"></param>
        /// <param name="authId"></param>
        /// <param name="authSecret"></param>
        /// <param name="lmType"></param>
        /// <returns></returns>
        public static async Task<Models.Smartlock.Smartlock> PutSmartlockAsync(int smartlockId, int type, string name, string authUuid, int authId, string authSecret, int lmType)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            allInputParams.Add(new KeyValuePair<string, string>("smartlockId", $"{smartlockId}"));
            allInputParams.Add(new KeyValuePair<string, string>("type", $"{type}"));
            allInputParams.Add(new KeyValuePair<string, string>("name", $"{name}"));
            allInputParams.Add(new KeyValuePair<string, string>("authUuid", $"{authUuid}"));
            allInputParams.Add(new KeyValuePair<string, string>("authId", $"{authId}"));
            allInputParams.Add(new KeyValuePair<string, string>("authSecret", $"{authSecret}"));
            allInputParams.Add(new KeyValuePair<string, string>("lmType", $"{lmType}"));
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (Client)
            {
                var response = await Client.PutAsync($"smartlock", requestParams);
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Models.Smartlock.Smartlock>(responseString);
            }
        }
        /// <summary>
        /// Delete a Smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> DeleteSmartlockAsync(int smartlockId)
        {
            using (Client)
            {
                var response = await Client.DeleteAsync($"smartlock/{smartlockId}");
                return response.StatusCode;
            }
        }
        /// <summary>
        /// Get a Smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <returns></returns>
        public static async Task<Models.Smartlock.Smartlock> GetSmartlockAsync(int smartlockId)
        {
            using (Client)
            {
                var response = await Client.GetAsync($"smartlock/{smartlockId}");
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Models.Smartlock.Smartlock>(responseString);
            }
        }
        /// <summary>
        /// Update a Smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="name"></param>
        /// <param name="favorite"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockAsync(int smartlockId, string name, bool favorite)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();

            allInputParams.Add(new KeyValuePair<string, string>("name", $"{name}"));
            allInputParams.Add(new KeyValuePair<string, string>("favorite", $"{favorite}"));
            var requestParams = new FormUrlEncodedContent(allInputParams);
            
            using (Client)
            {
                var response = await Client.PostAsync($"smartlock/{smartlockId}", requestParams);
                return response.StatusCode;
            }
        }
        /// <summary>
        /// Lock & unlock a smartlock with options
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="action"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockActionAsync(int smartlockId, int action, int option)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            allInputParams.Add(new KeyValuePair<string, string>("action", $"{action}"));
            allInputParams.Add(new KeyValuePair<string, string>("option", $"{option}"));

            using (Client)
            {
                var requestParams = new FormUrlEncodedContent(allInputParams);
                var response = await Client.PostAsync($"smartlock/{smartlockId}/action", requestParams);
                return response.StatusCode;
            }
        }
        /// <summary>
        /// Lock a smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockActionLock(int smartlockId)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            var requestParams = new FormUrlEncodedContent(allInputParams);
            
            using (Client)
            {
                var response = await Client.PostAsync($"smartlock/{smartlockId}/action/lock", requestParams);
                return response.StatusCode;
            }
        }
        /// <summary>
        /// Unlock a smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockActionUnlock(int smartlockId)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (Client)
            {
                var response = await Client.PostAsync($"smartlock/{smartlockId}/action/unlock", requestParams);
                return response.StatusCode;
            }
        }
        /// <summary>
        /// Updates a smartlock admin pin
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="adminPin"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockAdminPin(int smartlockId, int adminPin)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            allInputParams.Add(new KeyValuePair<string, string>("adminPin", $"{adminPin}"));
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (Client)
            {
                var response = await Client.PostAsync($"smartlock/{smartlockId}/action/unlock", requestParams);
                return response.StatusCode;
            }
        }

    }
}
