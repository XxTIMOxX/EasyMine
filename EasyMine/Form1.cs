using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace EasyMine
{
    public partial class FrmEasyScryptMiner : Form
    {
        private string ATI = "ATI";
        private string Nvidia = "Nvidia";

        SynchronizationContext _syncContext;

        public FrmEasyScryptMiner()
        {
            InitializeComponent();
            _syncContext = SynchronizationContext.Current;

        }

        private void videoCardsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.videoCardsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gPUDatabaseDataSet);

        }

        private void FrmEasyPoolMiner_Load(object sender, EventArgs e)
        {

            this.videoCardsTableAdapter.Fill(this.gPUDatabaseDataSet.VideoCards);                   // TODO: This line of code loads data into the 'gPUDatabaseDataSet.VideoCards' table. You can move, or remove it, as needed.

        }

        private void rBttnAti_CheckedChanged(object sender, EventArgs e)
        {
            if (rBttnAti.Checked == true)                                                           //check if ATI radio button is selected
            {
                videoCardsTableAdapter.FillBy(this.gPUDatabaseDataSet.VideoCards, ATI);             //if selected, only show ATI cards in dropdown
            }
        }

        private void fillBy1ToolStripButton_Click()
        {
        
        }

        private void rBttnNvidia_CheckedChanged(object sender, EventArgs e)
        {
            if (rBttnNvidia.Checked == true)                                                        //check if Nvidia radio button is selected
            {
                videoCardsTableAdapter.FillBy(this.gPUDatabaseDataSet.VideoCards, Nvidia);          //if selected, only show nvidia cards in dropdown
            }
        }

        private void bttnStartMining_Click(object sender, EventArgs e)                    //GPU start mining button
        {
            if (txtBoxGpuPassword.Text == "" || txtBoxGpuPool.Text == "" || txtBoxGpuUsername.Text == "")
            {
                MessageBox.Show("You must fill out all boxes");
            }
            else
            {

                string cmdFileName = "";                                                    //create the cmdFileName string and give it a blank initial value
                string argument;                                                            //create the argument string
                string listBox = "";                                                        //create the listBox string and give it a blank initial value
                string procName = " ";                                                      //create the procName string and give it a blank initial value

                StringBuilder sb = new StringBuilder();                                     //create a new string builder var to house your mining script

                if (rBttnAti.Checked == true)                                               //check if ATI radio button is selected
                {
                    cmdFileName = "cgminer-3.9.0-windows\\cgminer";                         //if so, use the cgminer app 
                    listBox = "lbCmdOutput";                                                //create the listBox string
                    procName = "cgminer";                                                   //create the procName string
                }
                else if (rBttnNvidia.Checked == true)                                       //check if the nvidia radio button is selected
                {
                    cmdFileName = "cudaminer-2013-12-18\\cudaminer";                        //if so use the cudaminer app
                    listBox = "lbCmdOutput";                                                //create the listBox string
                    procName = "cudaminer";                                                 //create the procName string

                }
                //these next lines will append needed flags for the script with strings from our text boxes
                sb.Append("--scrypt  -o ");
                sb.Append(txtBoxGpuPool.Text);
                sb.Append(" -u ");
                sb.Append(txtBoxGpuUsername.Text);
                sb.Append(" -p ");
                sb.Append(txtBoxGpuPassword.Text);
                sb.Append(" ");
                sb.Append(cbGpu.SelectedValue.ToString());

                argument = sb.ToString();                                                   //give the argument string the value from the above appended lines

                startCpuMining(cmdFileName, argument, listBox, procName);                   //call the start mining method with the correct values
            }
        }

        private void bttnCpuStartMining_Click(object sender, EventArgs e)                 //CPU start mining button
        {
            if (txtBoxCpuPassword.Text == "" || txtBoxCpuPool.Text == "" || txtBoxCpuUsername.Text == "")
            {
                MessageBox.Show("You must fill out all boxes");
            }
            else
            {

                string cmdFileName = "cpuminer\\minerd.exe";                                  //create the cmdFileName string and give it the minerd value for cpumining
                string argument;                                                              //create the argument string
                string listBox = "lbCpuOutput";                                               //create the listBox string
                string procName = "minerd";                                                   //create the procName string

                StringBuilder sb = new StringBuilder();                                       //create a new string builder var to house your mining script

                sb.Append("--url=");                                                          //these next lines will append needed flags for the script with strings from our text boxes
                sb.Append(txtBoxCpuPool.Text);
                sb.Append(" -u ");
                sb.Append(txtBoxCpuUsername.Text);
                sb.Append(" -p ");
                sb.Append(txtBoxCpuPassword.Text);

                argument = sb.ToString();                                                     //give the argument string the value from the above appended lines

                startCpuMining(cmdFileName, argument, listBox, procName);                     //call the start mining method with the correct values
            }
        }

        private void startCpuMining(string cmdFileName, string argument, string listBox, string procName)  //startmining test method for cpu mining
        {
            var thread = new Thread(new ThreadStart(() =>                                 //create a new thread to run the cmd line program
            {

            var process = new Process                                                     //create a new process
            {
                StartInfo = new ProcessStartInfo                                          //add all the information to run the cmd program
                {
                    FileName = cmdFileName,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = argument,
                    CreateNoWindow = true,
                }
            };

            process.OutputDataReceived += (sender, args) => Display(args.Data, listBox);  //take the output data from the process and send it to the display method
            process.ErrorDataReceived += (sender, args) => Display(args.Data, listBox);   //take the output errors from the process and send it to the display method

                Process[] pname = Process.GetProcessesByName(procName);                   //check all processes and put into array
                if (pname.Length == 0)                                                    //test process name against length to see if it's running
                {
                    process.Start();                                                      //if it's not running, start the process and reading the output
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    process.WaitForExit();                                                //you need this in order to flush the output buffer
                }
                else
                {   
                    MessageBox.Show("You're already mining!");                            //if the process is running, tell the user they're already mining!
                }

            }));

            thread.Start();                                                               //now that we have all the info for the program, start the thread

        }

        void Display(string output, string listBox)                                       //display the output from the running process
        {
            if (output == null)                                                           //check if the given value is null
            { }                                                                           //if the value is null, do nothing
            else if(listBox == "lbCpuOutput")
            {
                _syncContext.Post(_ => lbCpuOutput.Items.Add(output), null);              //if the value is not null, add it to the Cpu listbox
                _syncContext.Post(_ => this.lbCpuOutput.SelectedIndex = this.lbCpuOutput.Items.Count - 1, null);
                for (int i = 0; i < lbCpuOutput.Items.Count; i++)
                {
                    if (i == 99)
                    {
                        _syncContext.Post(_ => lbCpuOutput.Items.Clear(), null);
                    }
                }
            }
            else if (listBox == "lbCmdOutput")
            {
                _syncContext.Post(_ => lbCmdOutput.Items.Add(output), null);              //if the value is not null, add it to the Cmd listbox
                _syncContext.Post(_ => this.lbCmdOutput.SelectedIndex = this.lbCmdOutput.Items.Count - 1, null);
                for (int i = 0; i < 100; i++)
                {
                    if (i == 99)
                    {
                        _syncContext.Post(_ => lbCmdOutput.Items.Clear(), null);
                    }
                }
            }

        }


        private void bttnCpuStopMining_Click(object sender, EventArgs e)                  //CPU stop mining method
        {
            killProcess("minerd");
        }

        private void killProcess(string processId)                                        //kill processes method
        {
            
            Process[] localByName = Process.GetProcessesByName(processId);                //get all instances of wanted process running
            foreach (Process p in localByName)                                            //put all matching processes into an array
            {
                p.Kill();                                                                 //kill if process is found
            }
        }

        private void bttnGpuStopMinig_Click(object sender, EventArgs e)                   //GPU stop mining button
        {
            if (rBttnAti.Checked == true)                                                 //check if the ATI radio button is selected
            {
                killProcess("cgminer");                                                   //if so kill cgminer process
            }
            else if (rBttnNvidia.Checked == true)                                         //check if nvidia radio button is selected
            {
                killProcess("cudaminer");                                                 //if so kill cudaminer process
            }
        }           

    }
}
