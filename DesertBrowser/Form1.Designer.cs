namespace DesertBrowser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BrowserPanel = new System.Windows.Forms.Panel();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.BrowserGoButton = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BrowserPanel
            // 
            this.BrowserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserPanel.Location = new System.Drawing.Point(0, 65);
            this.BrowserPanel.Name = "BrowserPanel";
            this.BrowserPanel.Size = new System.Drawing.Size(800, 385);
            this.BrowserPanel.TabIndex = 0;
            // 
            // UrlBox
            // 
            this.UrlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UrlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlBox.ForeColor = System.Drawing.Color.White;
            this.UrlBox.Location = new System.Drawing.Point(12, 11);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(694, 20);
            this.UrlBox.TabIndex = 1;
            this.UrlBox.TextChanged += new System.EventHandler(this.UrlBox_TextChanged);
            // 
            // BrowserGoButton
            // 
            this.BrowserGoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserGoButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowserGoButton.Location = new System.Drawing.Point(712, 11);
            this.BrowserGoButton.Name = "BrowserGoButton";
            this.BrowserGoButton.Size = new System.Drawing.Size(76, 20);
            this.BrowserGoButton.TabIndex = 2;
            this.BrowserGoButton.Text = "Go";
            this.BrowserGoButton.UseVisualStyleBackColor = true;
            this.BrowserGoButton.Click += new System.EventHandler(this.BrowserGoButton_click);
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Copyright.Location = new System.Drawing.Point(8, 34);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(333, 19);
            this.Copyright.TabIndex = 3;
            this.Copyright.Text = "Desert Browser (c) 2021 Scott Looker";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.BrowserGoButton);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.BrowserPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Desert Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BrowserPanel;
        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Button BrowserGoButton;
        private System.Windows.Forms.Label Copyright;
    }
}

