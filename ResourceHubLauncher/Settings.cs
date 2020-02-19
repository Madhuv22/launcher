﻿using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourceHubLauncher {
    public partial class Settings : MetroForm {
        List<Color> colors = new List<Color>() {
            Color.FromArgb(0, 0, 0, 0),
            MetroColors.Black,
            MetroColors.White,
            MetroColors.Silver,
            MetroColors.Blue,
            MetroColors.Green,
            MetroColors.Lime,
            MetroColors.Teal,
            MetroColors.Orange,
            MetroColors.Brown,
            MetroColors.Pink,
            MetroColors.Magenta,
            MetroColors.Purple,
            MetroColors.Red,
            MetroColors.Yellow
        };

        public Settings() {
            InitializeComponent();

            Config.Theme(this);

            styleManager.Theme = (MetroThemeStyle)(int)Config.Options["theme"];
            styleManager.Style = (MetroColorStyle)(int)Config.Options["color"];

            metroCheckBox1.Checked = (int)Config.Options["theme"] != 2;

            for(int i = 0; i < colors.Count; i++) {
                Control c = Controls[(Controls.Count - 1) - i];
                c.BackColor = colors[i];
                int _ = i;
                c.Click += (object s, EventArgs e) => {
                    Config.Options["color"] = _;
                    styleManager.Style = (MetroColorStyle)(int)Config.Options["color"];
                    Config.Theme(this);
                };
            }
        }

        private void Settings_Load(object sender, EventArgs e) {
            
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e) {
            Config.Options["theme"] = metroCheckBox1.Checked ? 1 : 2;
            styleManager.Theme = (MetroThemeStyle)(int)Config.Options["theme"];
            Config.Theme(this);
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e) {
            Config.Save();
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e) {

        }

        private void metroPanel5_Paint(object sender, PaintEventArgs e) {

        }

        private void metroPanel8_Paint(object sender, PaintEventArgs e) {

        }

        private void metroPanel10_Paint(object sender, PaintEventArgs e) {

        }

        private void metroPanel12_Paint(object sender, PaintEventArgs e) {

        }
    }
}
