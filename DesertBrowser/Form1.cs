using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace DesertBrowser
{
    public partial class Form1 : Form
    {
        // Variables
        private ChromiumWebBrowser chromeBrowser;

        // Init methods
        private void InitializeChromium() 
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("https://www.duckduckgo.com");
            // Add it to the form and fill it to the form window.
            BrowserPanel.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        // Constructor
        public Form1() 
        {
            InitializeComponent();
            InitializeChromium();
        }

        // Form methods
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => Cef.Shutdown();

        private void BrowserGoButton_click(object sender, EventArgs e) => chromeBrowser.Load(UrlBox.Text);

        private void UrlBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
