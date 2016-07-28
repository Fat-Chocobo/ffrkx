﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFRKInspector.Proxy;
using FFRKInspector.Database;
using Fiddler;
using System.Web;
using System.Net;
using MySql.Data.MySqlClient;

namespace FFRKInspector.UI
{
    public partial class FFRKViewAbout : UserControl
    {
        static readonly string mConnectionSuccessMsg = 
            "Connection successful!  Save the settings, and close and restart fiddler for the settings to take effect.";
        static readonly string mDatabaseTooOldMsg = 
            "The database is for an older version of FFRK Inspector.  Database connectivity will be unavailable with these settings.";
        static readonly string mDatabaseTooNewMsg =
            "The database is for a newer version of FFRK Inspector.  You will need to update to a later version to connect to this database.";
        static readonly string mInvalidConnectionMsg =
            "Unable to establish a connection with the specified parameters.  Check that they are correct and try again.  Message = {0}";

        public FFRKViewAbout()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/r/FFRecordKeeper/");
        }

        private void buttonTestSettings_Click(object sender, EventArgs e)
        {
            FFRKMySqlInstance.ConnectResult result = FFRKMySqlInstance.ConnectResult.InvalidConnection;
            try
            {
                result = FFRKProxy.Instance.Database.TestConnect(
                    textBoxHost.Text, textBoxUser.Text, textBoxPassword.Text, textBoxSchema.Text,
                    FFRKProxy.Instance.MinimumRequiredSchema);
                switch (result)
                {
                    case FFRKMySqlInstance.ConnectResult.Success:
                        MessageBox.Show(mConnectionSuccessMsg, "Success");
                        break;
                    case FFRKMySqlInstance.ConnectResult.InvalidConnection:
                        MessageBox.Show(mInvalidConnectionMsg, "Invalid connection parameters");
                        break;
                    case FFRKMySqlInstance.ConnectResult.SchemaTooNew:
                        MessageBox.Show(mDatabaseTooNewMsg, "Database too new");
                        break;
                    case FFRKMySqlInstance.ConnectResult.SchemaTooOld:
                        MessageBox.Show(mDatabaseTooOldMsg, "Database too old");
                        break;
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(String.Format(mInvalidConnectionMsg, ex.Message));
            }
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DatabaseHost = textBoxHost.Text;
            Properties.Settings.Default.DatabasePassword = textBoxPassword.Text;
            Properties.Settings.Default.DatabaseSchema = textBoxSchema.Text;
            Properties.Settings.Default.DatabaseUser = textBoxUser.Text;
            Properties.Settings.Default.Save();

            labelConnectionResult.Text = "Settings saved.  Close and restart fiddler for the settings to take effect.";
        }

        private void FFRKViewAbout_Load(object sender, EventArgs e)
        {
            textBoxHost.Text = Properties.Settings.Default.DatabaseHost;
            textBoxPassword.Text = Properties.Settings.Default.DatabasePassword;
            textBoxSchema.Text = Properties.Settings.Default.DatabaseSchema;
            textBoxUser.Text = Properties.Settings.Default.DatabaseUser;
        }

        private void buttonDonate_Click(object sender, EventArgs e)
        {
            string business = "cppisking@gmail.com";
            string description = WebUtility.HtmlEncode("Donation for FFRK Inspector");
            string country = "US";
            string currency = "USD";
            string url = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations" +
                         "&business=" + business +
                         "&lc=" + country +
                         "&item_name=" + description +
                         "&currency_code=" + currency +
                         "&bn=PP%2dDonationsBF";

            System.Diagnostics.Process.Start(url);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ffrki.wordpress.com/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/cppisking/ffrk-inspector/");
        }
    }
}
