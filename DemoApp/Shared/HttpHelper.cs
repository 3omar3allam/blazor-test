using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClient.Shared
{
    public static class HttpHelper
    {
        public static async Task<T> ReadAsAsync<T>(this HttpContent content) where T : class
        {
            try
            {
                //var stringy = await content.ReadAsStringAsync();

                return Activator.CreateInstance(typeof(T)) as T;
            }
            catch
            {
                return null;
            }
        }
    }
}
