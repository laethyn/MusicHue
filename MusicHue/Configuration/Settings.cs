using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using MusicBeePlugin.Forms;
using MusicBeePlugin.SHue;

namespace MusicBeePlugin.Configuration {
    public class Settings {
        public static string Username { get; set; }

        public IPAddress BridgeIP { get; set; }

        public List<string> HueLights;
        public List<string> AvailableLights;

        public bool AverageColor { get; set; }
        public bool ColorPalette { get; set; }
        public int Brightness { get; set; }

        public bool IsEnabled { get; set; }

        public static Settings Instance = new Settings();
        public string StoragePath { get; set; }

        private Settings() { }

        public void Initialize() {
            if (BridgeIP == null) {
                BridgeIP = SHueConfig.DiscoverBridgeIP();
            }
            HueLights = new List<string>();
        }

        public void LoadSettings(string path) {
            if (HueLights == null) {
                Initialize();
            }

            if (File.Exists(@path + @"\HueSettings.xml") && new FileInfo(path + @"\HueSettings.xml").Length == 0) {
                File.Delete(@path + @"\HueSettings.xml");
            }
            if (!File.Exists(@path + @"\HueSettings.xml")) {
                CreateConfigurationFile(@path);
                MessageBox.Show("To use the MusicHue plugin, you first need to configure the plugin.");
                HueSettings_FRM FRM = new HueSettings_FRM();
                FRM.Initialize(true);
                FRM.ShowDialog();
            } else {

                //List<string> LightNames = new List<string>();
                XmlDocument doc = new XmlDocument();
                doc.Load(@path + @"HueSettings.xml");
                Username = doc.DocumentElement.SelectSingleNode("/HueSettings/appConfig/APIKey").InnerText;
                AverageColor = Boolean.Parse(doc.DocumentElement.SelectSingleNode("/HueSettings/appConfig/AverageColor").InnerText);
                ColorPalette = Boolean.Parse(doc.DocumentElement.SelectSingleNode("/HueSettings/appConfig/ColorPalette").InnerText);
                Brightness = int.Parse(doc.DocumentElement.SelectSingleNode("/HueSettings/appConfig/Brightness").InnerText);
                IsEnabled = Boolean.Parse(doc.DocumentElement.SelectSingleNode("/HueSettings/appConfig/Enabled").InnerText);
                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("/HueSettings/appConfig/HueLights")) {
                    HueLights.Add(node.InnerText);
                }
                if (Username != null) {
                    HueSettings_FRM frm = new HueSettings_FRM();
                    frm.SetKeyText(Username);
                }
            }
        }

        public void SaveSettings(string path) {
            if (path == "") {
                path = StoragePath;
            }
            File.WriteAllText(@path + @"\HueSettings.xml", "");
            if (HueLights == null) {
                HueLights.Add("");
            }
            HueLights = HueLights.Distinct().ToList();
            XmlTextWriter xWriter = new XmlTextWriter(@path + @"\HueSettings.xml", Encoding.UTF8) {
                Formatting = Formatting.Indented
            };
            xWriter.WriteStartElement("HueSettings");
            xWriter.WriteStartElement("appConfig");
            xWriter.WriteElementString("APIKey", Username);
            xWriter.WriteStartElement("HueLights");
            foreach (string light in HueLights) {
                if (light != null) {
                    xWriter.WriteElementString("HueLights", light);
                }
            }
            xWriter.WriteEndElement();
            xWriter.WriteElementString("AverageColor", AverageColor.ToString());
            xWriter.WriteElementString("ColorPalette", ColorPalette.ToString());
            xWriter.WriteElementString("Brightness", Brightness.ToString());
            xWriter.WriteElementString("Enabled", IsEnabled.ToString());
            xWriter.WriteEndElement();
            xWriter.Close();
        }

        public void CreateConfigurationFile(string path) {
            XmlTextWriter xWriter = new XmlTextWriter(@path + @"\HueSettings.xml", Encoding.UTF8) {
                Formatting = Formatting.Indented
            };
            AverageColor = true;
            ColorPalette = false;
            Brightness = 10;
            IsEnabled = true;
            xWriter.WriteStartElement("HueSettings");
            xWriter.WriteStartElement("appConfig");
            xWriter.WriteElementString("APIKey", "");
            xWriter.WriteStartElement("HueLights");
            xWriter.WriteElementString("HueLights", "");
            xWriter.WriteEndElement();
            xWriter.WriteElementString("AverageColor", AverageColor.ToString());
            xWriter.WriteElementString("ColorPalette", ColorPalette.ToString());
            xWriter.WriteElementString("Brightness", Brightness.ToString());
            xWriter.WriteElementString("Enabled", IsEnabled.ToString());
            xWriter.WriteEndElement();
            xWriter.Close();
        }

        public void AddLight(string name) {
            if (HueLights == null) {
                Initialize();
            }
            HueLights.Add(name);
        }
    }
}