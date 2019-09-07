using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using MusicBeePlugin.utils;
using MusicBeePlugin.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Dynamic;

namespace MusicBeePlugin.SHue {
    public static class SHueConfig {
        public static string AppID { get; set; }

        internal const string DEFAULT_APP_ID = "SSMBHue";
        static SHueConfig() { }

        public static void AddUser() {
            AppID = string.Format("{0}#{1}", DEFAULT_APP_ID, Environment.MachineName);
            RegisterNewUser();
        }

        private static bool RegisterNewUser() {
            dynamic data = new ExpandoObject();
            data.devicetype = AppID;
            JArray response = JSONClient.Request(HttpMethod.Post, "/api", data);
            try {
                if (response[0]["success"]["username"] != null) {
                    Settings.Username = response[0]["success"]["username"].ToString();
                    return true;
                }
                return false;
            } catch {
                return false;
            }
        }

        public static IPAddress DiscoverBridgeIP() {
            try {
                var bridgeInfo = JSONClient.RequestBroker() as JArray;
                return IPAddress.Parse(((JObject)bridgeInfo[0])["internalipaddress"].Value<string>());

            } catch (Exception e) {
                throw new Exception(e.ToString());
            }
        }

        public static List<string> GetColorableLights() {
            List<string> LightList = new List<string>();
            JToken blah = JToken.Parse(JSONClient.Request(HttpMethod.Get, "/api/" + Settings.Username + "/lights").ToString());
            JObject obj = JObject.Parse(blah.ToString());
            foreach (var pair in obj) {
                if (obj[pair.Key]["type"].ToString() == "Extended color light") {
                    LightList.Add(obj[pair.Key]["name"].ToString());
                }
            }
            return LightList;
        }

        public static string GetAddedLightID(string LightName) {
            List<string> LightList = new List<string>();
            JToken blah = JToken.Parse(JSONClient.Request(HttpMethod.Get, "/api/" + Settings.Username + "/lights").ToString());
            JObject obj = JObject.Parse(blah.ToString());
            string lName = "";
            foreach (var pair in obj) {
                if (obj[pair.Key]["name"].ToString() == LightName) {
                    lName = pair.Key.ToString();
                }
            }
            return lName;
        }

        public static void TurnOnOffLights(List<string> LightList, bool NewState) {
            dynamic data = new ExpandoObject();
            data.on = NewState;
            foreach (string LightName in LightList) {
                string ApiCall = "/api/" + Settings.Username + "/lights/" + GetAddedLightID(LightName) + "/state";
                MessageBox.Show(ApiCall);
                JArray response = JSONClient.Request(HttpMethod.Put, ApiCall, data);
            }
        }
    }
}