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
            // set config file's path
            //mConfigFilePath = System.Environment.CurrentDirectory;    // current directory
            mConfigFilePath = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\AndroidWifiDebug\Config\"; // my documents in user's home directory
            mConfigFileName = "his.ini";

            if (File.Exists(mConfigFilePath + mConfigFileName))  // if exists his.ini file, load item from his.ini file
            {
                StreamReader sr = new StreamReader(mConfigFilePath + mConfigFileName, Encoding.Default);

                while (sr.Peek() > 0)
                {
                    mComBoBoxIpList.Items.Add(sr.ReadLine());
                }
                sr.Close();

                // set recently ip to comBoBox
                mComBoBoxIpList.Text = (String)mComBoBoxIpList.Items[0];
            }
            else
            {
                Directory.CreateDirectory(mConfigFilePath);
            }
        }

        String mConfigFilePath;
        String mConfigFileName;
        private void buttonConnectClick(object sender, EventArgs e)
        {
            if (!mComBoBoxIpList.Items.Contains(mComBoBoxIpList.Text))
            {
                mComBoBoxIpList.Items.Insert(0, mComBoBoxIpList.Text);
            }

            // save content of combobox to file
            StreamWriter sw = new StreamWriter(mConfigFilePath + mConfigFileName);
            for (int i = 0; i < mComBoBoxIpList.Items.Count; i++)
            {
                sw.WriteLine(mComBoBoxIpList.Items[i]);
            }

            sw.Close();

            Cmd_Adb_connect(mComBoBoxIpList.Text);
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
