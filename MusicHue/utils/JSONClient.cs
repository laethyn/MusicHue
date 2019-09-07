using System;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MusicBeePlugin.Configuration;
using System.Windows.Forms;

namespace MusicBeePlugin.utils {
    public static class JSONClient {
        public static JToken Request(string apiPath) {
            return Request(HttpMethod.Get, apiPath, (string)null);
        }

        public static JToken Request(HttpMethod method, string apiPath) {
            return Request(method, apiPath, (string)null);
        }

        public static JToken Request(HttpMethod method, string apiPath, JObject data) {
            return Request(method, apiPath, data.ToString());
        }

        public static JToken Request(HttpMethod method, string apiPath, object data) {
            return Request(method, apiPath, JsonConvert.SerializeObject(data, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));
        }

        public static JToken Request(HttpMethod method, string apiPath, string data) {
            string response = InvokeRequest(Settings.Instance.BridgeIP, apiPath, data, method);
            JToken responseOBJ = JToken.Parse(response);

            if (responseOBJ is JArray && ((JArray)responseOBJ).Count == 1) {
                JObject err = responseOBJ[0]["error"] as JObject;
                if (err != null) {
                    throw new Exception(err["description"].ToString());
                }
            }

            return responseOBJ;
        }

        public static JToken RequestBroker() {
            WebRequest req = WebRequest.Create(new Uri("https://discovery.meethue.com"));
            var resp = req.GetResponse();
            var respReader = new StreamReader(resp.GetResponseStream());
            var data = respReader.ReadToEnd();

            return JToken.Parse(data);
        }

        private static string InvokeRequest(IPAddress baseURL, string page, string data, HttpMethod method) {
            var uri = new Uri(new Uri("http://" + baseURL.ToString() + "/"), page);
            WebRequest req = WebRequest.Create(uri);
            req.Method = method.Method;

            if (data != null) {
                var reqWriter = new StreamWriter(req.GetRequestStream());
                reqWriter.Write(data);
                reqWriter.Flush();
            }

            var resp = req.GetResponse();
            var respReader = new StreamReader(resp.GetResponseStream());
            var response = respReader.ReadToEnd();

            return response;
        }
    }
}
