using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AndroidWifiDebug
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private String mConfigFilePath;
        private String mConfigFileName;
        private void mainLoad(object sender, EventArgs e)
        {
            // set config file's path
            //path = System.Environment.CurrentDirectory;    // current directory
            mConfigFilePath = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\AndroidWifiDebug\Config\"; // my documents in user's home directory
            mConfigFileName = "his.ini";

            loadIpHistory(mConfigFilePath, mConfigFileName);

        }

        private void loadIpHistory(String path, String name)
        {
            if (File.Exists(path + name))  // if exists his.ini file, load item from his.ini file
            {
                StreamReader sr = new StreamReader(path + name, Encoding.Default);

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
                Directory.CreateDirectory(path);
            }
        }


        private void buttonConnectClick(object sender, EventArgs e)
        {
            mButtonConnect.UseWaitCursor = true;
            // If input string is new, remember it.
            if (!mComBoBoxIpList.Items.Contains(mComBoBoxIpList.Text))
            {
                mComBoBoxIpList.Items.Insert(0, mComBoBoxIpList.Text);
            }

            // save content of combobox to file
            StreamWriter sw = new StreamWriter(mConfigFilePath + mConfigFileName);
            for (int i = 0; i < mComBoBoxIpList.Items.Count; i++)
            {
                String line = mComBoBoxIpList.Items[i].ToString();
                if (line != @"")  // delete empty line
                {
                    sw.WriteLine(line);
                }
            }

            sw.Close();

            // prevent main form is not respondint, do it in background.
            //Thread connectThread = new Thread(Cmd_Adb_connect);
            //connectThread.Start(mComBoBoxIpList.Text);

            using (BackgroundWorker bw = new BackgroundWorker())
            {
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwRunWorkerCompleted);
                bw.DoWork += new DoWorkEventHandler(Cmd_Adb_connect);
                bw.RunWorkerAsync(mComBoBoxIpList.Text);
            }

        }

        // after input finished, enter "Enter" Key will same as "click button click".
        private void mComBoBoxIpList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonConnectClick(sender, e);
            }
        }

        static String output;
        static void Cmd_Adb_connect(object sender, DoWorkEventArgs args)
        {
            String ip = args.Argument.ToString();
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            process.StandardInput.WriteLine("adb connect " + ip);
            process.StandardInput.WriteLine("exit");

            output = process.StandardOutput.ReadToEnd();

        }

        void bwRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mTextBoxOutput.AppendText(output);
            mButtonConnect.UseWaitCursor = false;
        }

        private void mComBoBoxIpList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
