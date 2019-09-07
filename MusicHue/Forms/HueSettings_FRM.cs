using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicBeePlugin.SHue;
using MusicBeePlugin.Configuration;
using System.Diagnostics;
using System.Timers;

namespace MusicBeePlugin.Forms {
    public partial class HueSettings_FRM : Form {
        public Plugin.MusicBeeApiInterface MBApiInterface;

        public HueSettings_FRM() {
            InitializeComponent();
            MBApiInterface = new Plugin.MusicBeeApiInterface();
        }

        public void Initialize(bool FirstRun = false) {
            Activity_LBL.Text = "";
            if (FirstRun) {
                chk_ShowRegistration.Checked = true;
                RegistrationGroup.Visible = true;
                MainPanel.Top = 178;
                MainPanel.Enabled = false;
                AverageColor_Radio.Checked = true;
                ColorPalette_Radio.Checked = false;
                Brightness_TB.Value = 10;
            } else {
                SetKeyText(Settings.Username);
                GetKey_Button.Enabled = false;
                chk_ShowRegistration.Checked = false;
                RegistrationGroup.Visible = false;
                MainPanel.Enabled = true;
                MainPanel.Top = 36;
            }
        }

        public void StartUp() {
            AverageColor_Radio.Checked = (bool)Settings.Instance.AverageColor;
            ColorPalette_Radio.Checked = (bool)Settings.Instance.ColorPalette;
            Brightness_TB.Value = Settings.Instance.Brightness;
            foreach (string LightNames in Settings.Instance.HueLights) {
                AddedLights_ListBox.Items.Add(LightNames);
            }

            if (Settings.Username != null) {
                Initialize(false);
            } else {
                Initialize(true);
            }
        }

        private void GetKey_Button_Click(object sender, EventArgs e) {
            SHueConfig.AddUser();
            SetKeyText(Settings.Username);
            GetKey_Button.Enabled = false;
            Settings.Instance.SaveSettings("");
            Initialize(false);
        }

        private void Chk_ShowRegistration_CheckedChanged(object sender, EventArgs e) {
            if (chk_ShowRegistration.Checked) {
                Initialize(true);
            } else {
                Initialize(false);
            }
        }

        private void HueSettings_FRM_Load(object sender, EventArgs e) {
            GetKey_Button.Left = (MainPanel.Width - GetKey_Button.Width) / 2;
        }

        public void SetKeyText(string APIKey) {
            GetKey_Button.Text = APIKey.ToString();
            GetKey_Button.Left = (MainPanel.Width - GetKey_Button.Width) / 2;
        }

        private void GetLights_Button_Click(object sender, EventArgs e) {
            if (Settings.Username != null) {
                HueLights_ListBox.Items.Clear();
                List<string> LightList = SHueConfig.GetColorableLights();
                foreach (var l in LightList) {
                    HueLights_ListBox.Items.Add(l);
                }
            }
        }

        private void AddLight_Button_Click(object sender, EventArgs e) {
            if (HueLights_ListBox.SelectedItem != null && !AddedLights_ListBox.Items.Contains(HueLights_ListBox.SelectedItem)) {
                List<string> LightToAdd = new List<string>();
                LightToAdd.Add(HueLights_ListBox.SelectedItem.ToString());
                HueLights_ListBox.Items.Add(HueLights_ListBox.SelectedItem);
                SHueConfig.TurnOnOffLights(LightToAdd, true);
                Settings.Instance.IsEnabled = true;
                Activity_LBL.Text = HueLights_ListBox.SelectedItem.ToString() + " has been added ...";
                var TStopwatch = new Stopwatch();
                TStopwatch.Start();
                if (TStopwatch.ElapsedMilliseconds > 4000) {
                    Activity_LBL.Text = "";
                    TStopwatch.Stop();
                }
            }
        }

        private void RemoveLight_Button_Click(object sender, EventArgs e) {
            if (AddedLights_ListBox.SelectedItem != null) {
                List<string> LightToRemove = new List<string>();
                LightToRemove.Add(AddedLights_ListBox.SelectedItem.ToString());
                AddedLights_ListBox.Items.Remove(AddedLights_ListBox.SelectedItem);
                SHueConfig.TurnOnOffLights(LightToRemove, false);
                if (AddedLights_ListBox.Items.Count == 0) {
                    Settings.Instance.IsEnabled = false;
                }
                Activity_LBL.Text = AddedLights_ListBox.SelectedItem.ToString() + " has been removed ...";
                var TStopwatch = new Stopwatch();
                TStopwatch.Start();
                if (TStopwatch.ElapsedMilliseconds > 4000) {
                    Activity_LBL.Text = "";
                    TStopwatch.Stop();
                }
            }
        }

        private void SaveSettings_Button_Click(object sender, EventArgs e) {
            if (AddedLights_ListBox.Items.Count > 0) {
                Settings.Instance.HueLights.Clear();
                foreach (string s in AddedLights_ListBox.Items) {
                    Settings.Instance.AddLight(s);
                }
            }
            if (AverageColor_Radio.Checked) {
                Settings.Instance.AverageColor = true;
                Settings.Instance.ColorPalette = false;
            }
            if (ColorPalette_Radio.Checked) {
                Settings.Instance.AverageColor = false;
                Settings.Instance.ColorPalette = true;
            }

            Settings.Instance.Brightness = Brightness_TB.Value;

            Settings.Instance.SaveSettings("");
            Activity_LBL.Text = "Plugin Settings saved.";
        }
    }
}
