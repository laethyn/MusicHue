using System;
using System.Windows.Forms;
using MusicBeePlugin.Configuration;
using MusicBeePlugin.Forms;

namespace MusicBeePlugin
{
    public partial class Plugin {
        private MusicBeeApiInterface MBApiInterface;
        private PluginInfo About = new PluginInfo();
        HueSettings_FRM SettingsFORM = new HueSettings_FRM();
        private Hue HueC = new Hue();

        public PluginInfo Initialise(IntPtr apiInterfacePtr) {
            MBApiInterface = new MusicBeeApiInterface();
            MBApiInterface.Initialise(apiInterfacePtr);
            About.PluginInfoVersion = PluginInfoVersion;
            About.Name = "Music Hue";
            About.Description = "Match your Philips Hue lights to the current song color.";
            About.Author = "Sean Sopata";
            About.TargetApplication = "";
            About.Type = PluginType.General;
            About.VersionMajor = 1;
            About.VersionMinor = 1;
            About.Revision = 1;
            About.MinInterfaceVersion = MinInterfaceVersion;
            About.MinApiRevision = MinApiRevision;
            About.ReceiveNotifications = (ReceiveNotificationFlags.PlayerEvents | ReceiveNotificationFlags.TagEvents);
            About.ConfigurationPanelHeight = 0;
            ToolStripMenuItem mainMenuItem = (ToolStripMenuItem)MBApiInterface.MB_AddMenuItem("mnuTools/Music Hue", null, null);
            mainMenuItem.DropDown.Items.Add("Settings", null, OnOpen);
            mainMenuItem.DropDown.Items.Add("Stop", null, StopPlugin);
            mainMenuItem.DropDown.Items.Add("Resume", null, ResumePlugin);
            Settings.Instance.StoragePath = MBApiInterface.Setting_GetPersistentStoragePath();
            Settings.Instance.Initialize();
            Settings.Instance.LoadSettings(MBApiInterface.Setting_GetPersistentStoragePath());
            SettingsFORM.StartUp();
            if (Settings.Instance.IsEnabled) {
                SHue.SHueConfig.TurnOnOffLights(Settings.Instance.HueLights, true);
            }
            return About;
        }

        private void ResumePlugin(object sender, EventArgs e) {
            Settings.Instance.IsEnabled = true;
            throw new NotImplementedException();
        }

        private void StopPlugin(object sender, EventArgs e) {
            Settings.Instance.IsEnabled = false;
            throw new NotImplementedException();
        }

        private void OnOpen(object sender, EventArgs e) {
            SettingsFORM = new HueSettings_FRM();
            SettingsFORM.StartUp();
            SettingsFORM.Show();
        }

        public void SaveSettings() {
            string dataPath = Settings.Instance.StoragePath;
        }

        public void ReceiveNotification(string sourceFileUrl, NotificationType type) {
            switch (type) {
                case NotificationType.PluginStartup:
                    switch (MBApiInterface.Player_GetPlayState()) {
                        case PlayState.Playing:
                        case PlayState.Paused:
                            break;
                    }
                    break;
                case NotificationType.TrackChanged:
                    /*
                    using (var albumArtBMP = new Bitmap(hue.getAlbumArt(@MBApiInterface.NowPlaying_GetFileUrl()))) {

                        if (Settings.Instance.AverageColor && !stop) {
                            var rgbList = hue.getRGBAverage(albumArtBMP, int.Parse(Settings.Instance.QualitySetting));
                            var xy = hue.ToXYZ(rgbList[0], rgbList[1], rgbList[2]);
                            foreach (string lightName in Settings.Instance.HueLights) {
                                new LightStateBuilder().For(lights[lightName]).XYCoordinates(xy[0], xy[1]).Apply();

                            }
                        }
                        if (Settings.Instance.ColorPalette) {
                            List<Tuple<double, double>> colors = new List<Tuple<double, double>>();
                            var palette = hue.getColorPalette(albumArtBMP, 8, int.Parse(Settings.Instance.QualitySetting));
                            foreach (string str in palette) {
                                int red = hue.getRed(str);
                                int green = hue.getGreen(str);
                                int blue = hue.getBlue(str);
                                var xy = hue.ToXYZ(red, green, blue);
                                colors.Add(Tuple.Create((double)xy[0], (double)xy[1]));
                            }
                            if (palette.Count == 0) {
                                var xyWhite = hue.ToXYZ(255, 255, 255);
                                colors.Add(Tuple.Create((double)xyWhite[0], (double)xyWhite[1]));
                            }

                            maxRange = 0;
                            aTimer.Dispose();
                            //System.Threading.Thread.Sleep(1000);
                            aTimer = new System.Timers.Timer();
                            aTimer.Stop();
                            aTimer.Elapsed += (object s, ElapsedEventArgs a) => sendColorsTimer(colors, colors.Count);
                            aTimer.Start();
                            aTimer.Interval = 7000;
                            aTimer.Enabled = true;


                        }

                    }
                    */
                    break;
            }
        }
    }
}
