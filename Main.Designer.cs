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
            this.mConBoBoxIpList = new System.Windows.Forms.ComboBox();
            this.mButtonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mConBoBoxIpList
            // 
            this.mConBoBoxIpList.FormattingEnabled = true;
            this.mConBoBoxIpList.Location = new System.Drawing.Point(13, 12);
            this.mConBoBoxIpList.Name = "mConBoBoxIpList";
            this.mConBoBoxIpList.Size = new System.Drawing.Size(263, 21);
            this.mConBoBoxIpList.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(288, 163);
            this.Controls.Add(this.mButtonConnect);
            this.Controls.Add(this.mConBoBoxIpList);
            this.Name = "Main";
            this.Text = "Android Wifi Debug";
            this.Load += new System.EventHandler(this.mainLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mConBoBoxIpList;
        private System.Windows.Forms.Button mButtonConnect;
    }
}

