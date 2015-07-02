using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidWifiDebug
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mainLoad(object sender, EventArgs e)
        {
            mConfigFilePath = System.Environment.CurrentDirectory + @"\data.ini";

            if (File.Exists(mConfigFilePath))
            {
                StreamReader sr = new StreamReader(mConfigFilePath, Encoding.Default);

                while (sr.Peek() > 0)
                {
                    mConBoBoxIpList.Items.Add(sr.ReadLine());
                }
                sr.Close();

                mConBoBoxIpList.Text = (String)mConBoBoxIpList.Items[0];
            }
        }

        String mConfigFilePath;
        private void buttonConnectClick(object sender, EventArgs e)
        {
            if (!mConBoBoxIpList.Items.Contains(mConBoBoxIpList.Text))
            {
                mConBoBoxIpList.Items.Insert(0, mConBoBoxIpList.Text);
            }
            

            // save content of combobox to file
            StreamWriter sw = new StreamWriter(mConfigFilePath);
            for (int i = 0; i < mConBoBoxIpList.Items.Count; i++)
            {
                sw.WriteLine(mConBoBoxIpList.Items[i]);
            }

            sw.Close();

            Cmd_Adb_connect(mConBoBoxIpList.Text);
        }

        private void Cmd_Adb_connect(String ip)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            process.StandardInput.WriteLine("adb connect " + ip);
            process.StandardInput.WriteLine("exit");
            String output = process.StandardOutput.ReadToEnd();
            MessageBox.Show(output);
        }

        
    }
}
