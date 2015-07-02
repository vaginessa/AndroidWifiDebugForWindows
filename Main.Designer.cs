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
            this.mComBoBoxIpList = new System.Windows.Forms.ComboBox();
            this.mButtonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mConBoBoxIpList
            // 
            this.mComBoBoxIpList.FormattingEnabled = true;
            this.mComBoBoxIpList.Location = new System.Drawing.Point(13, 12);
            this.mComBoBoxIpList.Name = "mConBoBoxIpList";
            this.mComBoBoxIpList.Size = new System.Drawing.Size(263, 21);
            this.mComBoBoxIpList.TabIndex = 0;
            // 
            // mButtonConnect
            // 
            this.mButtonConnect.Location = new System.Drawing.Point(201, 39);
            this.mButtonConnect.Name = "mButtonConnect";
            this.mButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.mButtonConnect.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(288, 163);
            this.Controls.Add(this.mButtonConnect);
            this.Controls.Add(this.mComBoBoxIpList);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Android Wifi Debug";
            this.Load += new System.EventHandler(this.mainLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mComBoBoxIpList;
        private System.Windows.Forms.Button mButtonConnect;
    }
}

