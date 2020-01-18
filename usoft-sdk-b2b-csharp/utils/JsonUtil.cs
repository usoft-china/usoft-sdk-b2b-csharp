using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.utils
{
    public class JsonUtil
    {
        private static readonly JsonSerializerSettings jsetting = new JsonSerializerSettings
        {
            //忽略默认值
            DefaultValueHandling = DefaultValueHandling.Ignore
        };

        /// <summary>
        /// Object To Json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJSON(object obj)
        {

            return JsonConvert.SerializeObject(obj, jsetting);
        }
        /// <summary>
        /// Json To Object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public static T ToObject<T>(string jsonStr)
        {
            return JsonConvert.DeserializeObject<T>(jsonStr, jsetting);
        }

    }
}
