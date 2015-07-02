namespace AndroidWifiDebug
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mComBoBoxIpList = new System.Windows.Forms.ComboBox();
            this.mLabelUsage = new System.Windows.Forms.Label();
            this.mTextBoxOutput = new System.Windows.Forms.TextBox();
            this.mButtonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mComBoBoxIpList
            // 
            this.mComBoBoxIpList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.mComBoBoxIpList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mComBoBoxIpList.Cursor = System.Windows.Forms.Cursors.Default;
            this.mComBoBoxIpList.FormatString = "N3";
            this.mComBoBoxIpList.FormattingEnabled = true;
            this.mComBoBoxIpList.Location = new System.Drawing.Point(4, 12);
            this.mComBoBoxIpList.Name = "mComBoBoxIpList";
            this.mComBoBoxIpList.Size = new System.Drawing.Size(273, 21);
            this.mComBoBoxIpList.TabIndex = 0;
            this.mComBoBoxIpList.SelectedIndexChanged += new System.EventHandler(this.mComBoBoxIpList_SelectedIndexChanged);
            this.mComBoBoxIpList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mComBoBoxIpList_KeyDown);
            // 
            // mLabelUsage
            // 
            this.mLabelUsage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLabelUsage.AutoSize = true;
            this.mLabelUsage.Location = new System.Drawing.Point(6, 65);
            this.mLabelUsage.Name = "mLabelUsage";
            this.mLabelUsage.Size = new System.Drawing.Size(271, 65);
            this.mLabelUsage.TabIndex = 2;
            this.mLabelUsage.Text = "使用须知：\n1、确定电脑已接入局域网。\n2、确定手机和电脑能相互ping通。\n3、确定手机上安装有【wifi调试】(可在应用市场搜\n索wifi debug)并确定" +
    "其已打开。";
            // 
            // mTextBoxOutput
            // 
            this.mTextBoxOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mTextBoxOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.mTextBoxOutput.Location = new System.Drawing.Point(4, 133);
            this.mTextBoxOutput.Multiline = true;
            this.mTextBoxOutput.Name = "mTextBoxOutput";
            this.mTextBoxOutput.ReadOnly = true;
            this.mTextBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mTextBoxOutput.Size = new System.Drawing.Size(273, 280);
            this.mTextBoxOutput.TabIndex = 4;
            // 
            // mButtonConnect
            // 
            this.mButtonConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mButtonConnect.AutoSize = true;
            this.mButtonConnect.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.mButtonConnect.Location = new System.Drawing.Point(202, 39);
            this.mButtonConnect.Name = "mButtonConnect";
            this.mButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.mButtonConnect.TabIndex = 2;
            this.mButtonConnect.Text = "Connect";
            this.mButtonConnect.UseVisualStyleBackColor = true;
            this.mButtonConnect.Click += new System.EventHandler(this.buttonConnectClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(281, 420);
            this.Controls.Add(this.mTextBoxOutput);
            this.Controls.Add(this.mLabelUsage);
            this.Controls.Add(this.mButtonConnect);
            this.Controls.Add(this.mComBoBoxIpList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Android Wifi Debug";
            this.Load += new System.EventHandler(this.mainLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mComBoBoxIpList;
        private System.Windows.Forms.Label mLabelUsage;
        private System.Windows.Forms.TextBox mTextBoxOutput;
        private System.Windows.Forms.Button mButtonConnect;
    }
}

