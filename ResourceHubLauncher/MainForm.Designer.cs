﻿namespace ResourceHubLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.otherMods = new System.Windows.Forms.ListBox();
            this.modListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.VersionLabel = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.enabledMods = new System.Windows.Forms.ListBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.disabledMods = new System.Windows.Forms.ListBox();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.Install = new MetroFramework.Controls.MetroButton();
            this.Uninstall = new MetroFramework.Controls.MetroButton();
            this.ResourceHubPage = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.modListContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // otherMods
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.otherMods, true);
            this.otherMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.otherMods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otherMods.ContextMenuStrip = this.modListContextMenu;
            this.otherMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.otherMods.FormattingEnabled = true;
            this.otherMods.IntegralHeight = false;
            this.otherMods.Location = new System.Drawing.Point(11, 76);
            this.otherMods.Margin = new System.Windows.Forms.Padding(2);
            this.otherMods.Name = "otherMods";
            this.otherMods.Size = new System.Drawing.Size(171, 173);
            this.otherMods.TabIndex = 0;
            this.otherMods.TabStop = false;
            // 
            // modListContextMenu
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.modListContextMenu, true);
            this.modListContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.modListContextMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.modListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installToolStripMenuItem});
            this.modListContextMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.modListContextMenu.Name = "modListContextMenu";
            this.modListContextMenu.ShowImageMargin = false;
            this.modListContextMenu.Size = new System.Drawing.Size(156, 48);
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.installToolStripMenuItem.Text = "Install";
            this.installToolStripMenuItem.Click += new System.EventHandler(this.installToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Other mods:";
            this.label1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(428, 348);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(171, 19);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "ResourceHub Launcher 0.1.0";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.VersionLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(196, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 174);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mod description";
            this.label3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // enabledMods
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.enabledMods, true);
            this.enabledMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.enabledMods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enabledMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.enabledMods.FormattingEnabled = true;
            this.enabledMods.IntegralHeight = false;
            this.enabledMods.Location = new System.Drawing.Point(11, 273);
            this.enabledMods.Margin = new System.Windows.Forms.Padding(2);
            this.enabledMods.Name = "enabledMods";
            this.enabledMods.Size = new System.Drawing.Size(171, 134);
            this.enabledMods.TabIndex = 4;
            this.enabledMods.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Installed mods:";
            this.label4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Disabled mods:";
            this.label5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // disabledMods
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.disabledMods, true);
            this.disabledMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.disabledMods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disabledMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.disabledMods.FormattingEnabled = true;
            this.disabledMods.IntegralHeight = false;
            this.disabledMods.Location = new System.Drawing.Point(198, 273);
            this.disabledMods.Margin = new System.Windows.Forms.Padding(2);
            this.disabledMods.Name = "disabledMods";
            this.disabledMods.Size = new System.Drawing.Size(171, 134);
            this.disabledMods.TabIndex = 7;
            this.disabledMods.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mod description:";
            this.label6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Install
            // 
            this.Install.Location = new System.Drawing.Point(381, 233);
            this.Install.Margin = new System.Windows.Forms.Padding(2);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(218, 21);
            this.Install.TabIndex = 9;
            this.Install.TabStop = false;
            this.Install.Text = "Install mod";
            this.Install.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Install.UseSelectable = true;
            // 
            // Enable
            // 
            this.Enable.Location = new System.Drawing.Point(373, 319);
            this.Enable.Margin = new System.Windows.Forms.Padding(2);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(218, 21);
            this.Enable.TabIndex = 10;
            this.Enable.TabStop = false;
            this.Enable.Text = "Enable mod";
            this.Enable.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Enable.UseSelectable = true;
            // 
            // Uninstall
            // 
            this.Uninstall.Location = new System.Drawing.Point(381, 258);
            this.Uninstall.Margin = new System.Windows.Forms.Padding(2);
            this.Uninstall.Name = "Uninstall";
            this.Uninstall.Size = new System.Drawing.Size(218, 21);
            this.Uninstall.TabIndex = 11;
            this.Uninstall.TabStop = false;
            this.Uninstall.Text = "Uninstall mod";
            this.Uninstall.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Uninstall.UseSelectable = true;
            // 
            // Disable
            // 
            this.Disable.Location = new System.Drawing.Point(373, 342);
            this.Disable.Margin = new System.Windows.Forms.Padding(2);
            this.Disable.Name = "Disable";
            this.Disable.Size = new System.Drawing.Size(218, 21);
            this.Disable.TabIndex = 12;
            this.Disable.TabStop = false;
            this.Disable.Text = "Disable mod";
            this.Disable.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Disable.UseSelectable = true;
            // 
            // ResourceHubPage
            // 
            this.ResourceHubPage.Location = new System.Drawing.Point(381, 325);
            this.ResourceHubPage.Margin = new System.Windows.Forms.Padding(2);
            this.ResourceHubPage.Name = "ResourceHubPage";
            this.ResourceHubPage.Size = new System.Drawing.Size(218, 21);
            this.ResourceHubPage.TabIndex = 13;
            this.ResourceHubPage.TabStop = false;
            this.ResourceHubPage.Text = "Open ResourceHub page";
            this.ResourceHubPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResourceHubPage.UseSelectable = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroStyleExtender1
            // 
            this.metroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RunGooseButton
            // 
            this.RunGooseButton.Location = new System.Drawing.Point(381, 283);
            this.RunGooseButton.Margin = new System.Windows.Forms.Padding(2);
            this.RunGooseButton.Name = "RunGooseButton";
            this.RunGooseButton.Size = new System.Drawing.Size(218, 21);
            this.RunGooseButton.TabIndex = 14;
            this.RunGooseButton.TabStop = false;
            this.RunGooseButton.Text = "Run Goose";
            this.RunGooseButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 380);
            this.Controls.Add(this.RunGooseButton);
            this.Controls.Add(this.ResourceHubPage);
            this.Controls.Add(this.Uninstall);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.disabledMods);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enabledMods);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otherMods);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "ResourceHub Launcher";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.modListContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox otherMods;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel VersionLabel;
        private MetroFramework.Controls.MetroLabel label3;
        private System.Windows.Forms.ListBox enabledMods;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label5;
        private System.Windows.Forms.ListBox disabledMods;
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroButton Install;
        private MetroFramework.Controls.MetroButton Uninstall;
        private MetroFramework.Controls.MetroButton ResourceHubPage;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private System.Windows.Forms.ContextMenuStrip modListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
    }
}
