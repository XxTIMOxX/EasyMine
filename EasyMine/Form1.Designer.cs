namespace EasyMine
{
    partial class FrmEasyScryptMiner
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblGpu;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbGpu = new System.Windows.Forms.TabPage();
            this.bttnGpuStopMinig = new System.Windows.Forms.Button();
            this.lbCmdOutput = new System.Windows.Forms.ListBox();
            this.bttnStartMining = new System.Windows.Forms.Button();
            this.cbGpu = new System.Windows.Forms.ComboBox();
            this.videoCardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPUDatabaseDataSet = new EasyMine.GPUDatabaseDataSet();
            this.rBttnNvidia = new System.Windows.Forms.RadioButton();
            this.rBttnAti = new System.Windows.Forms.RadioButton();
            this.txtBoxGpuPassword = new System.Windows.Forms.TextBox();
            this.lblGpuPassword = new System.Windows.Forms.Label();
            this.txtBoxGpuUsername = new System.Windows.Forms.TextBox();
            this.lblGpuUsername = new System.Windows.Forms.Label();
            this.txtBoxGpuPool = new System.Windows.Forms.TextBox();
            this.lblGpuPool = new System.Windows.Forms.Label();
            this.tbCpu = new System.Windows.Forms.TabPage();
            this.bttnCpuStopMining = new System.Windows.Forms.Button();
            this.lbCpuOutput = new System.Windows.Forms.ListBox();
            this.bttnCpuStartMining = new System.Windows.Forms.Button();
            this.txtBoxCpuPassword = new System.Windows.Forms.TextBox();
            this.lblCpuPassword = new System.Windows.Forms.Label();
            this.txtBoxCpuUsername = new System.Windows.Forms.TextBox();
            this.lblCpuUsername = new System.Windows.Forms.Label();
            this.txtBoxCpuPool = new System.Windows.Forms.TextBox();
            this.lblCpuPool = new System.Windows.Forms.Label();
            this.videoCardsTableAdapter = new EasyMine.GPUDatabaseDataSetTableAdapters.VideoCardsTableAdapter();
            this.tableAdapterManager = new EasyMine.GPUDatabaseDataSetTableAdapters.TableAdapterManager();
            lblGpu = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbGpu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPUDatabaseDataSet)).BeginInit();
            this.tbCpu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGpu
            // 
            lblGpu.AutoSize = true;
            lblGpu.Location = new System.Drawing.Point(203, 34);
            lblGpu.Name = "lblGpu";
            lblGpu.Size = new System.Drawing.Size(33, 13);
            lblGpu.TabIndex = 14;
            lblGpu.Text = "GPU:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbGpu);
            this.tabControl1.Controls.Add(this.tbCpu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 282);
            this.tabControl1.TabIndex = 0;
            // 
            // tbGpu
            // 
            this.tbGpu.Controls.Add(this.bttnGpuStopMinig);
            this.tbGpu.Controls.Add(this.lbCmdOutput);
            this.tbGpu.Controls.Add(this.bttnStartMining);
            this.tbGpu.Controls.Add(this.cbGpu);
            this.tbGpu.Controls.Add(lblGpu);
            this.tbGpu.Controls.Add(this.rBttnNvidia);
            this.tbGpu.Controls.Add(this.rBttnAti);
            this.tbGpu.Controls.Add(this.txtBoxGpuPassword);
            this.tbGpu.Controls.Add(this.lblGpuPassword);
            this.tbGpu.Controls.Add(this.txtBoxGpuUsername);
            this.tbGpu.Controls.Add(this.lblGpuUsername);
            this.tbGpu.Controls.Add(this.txtBoxGpuPool);
            this.tbGpu.Controls.Add(this.lblGpuPool);
            this.tbGpu.Location = new System.Drawing.Point(4, 22);
            this.tbGpu.Name = "tbGpu";
            this.tbGpu.Padding = new System.Windows.Forms.Padding(3);
            this.tbGpu.Size = new System.Drawing.Size(591, 256);
            this.tbGpu.TabIndex = 0;
            this.tbGpu.Text = "GPU Mining";
            this.tbGpu.UseVisualStyleBackColor = true;
            // 
            // bttnGpuStopMinig
            // 
            this.bttnGpuStopMinig.Location = new System.Drawing.Point(493, 29);
            this.bttnGpuStopMinig.Name = "bttnGpuStopMinig";
            this.bttnGpuStopMinig.Size = new System.Drawing.Size(90, 23);
            this.bttnGpuStopMinig.TabIndex = 19;
            this.bttnGpuStopMinig.Text = "Stop Mining!";
            this.bttnGpuStopMinig.UseVisualStyleBackColor = true;
            this.bttnGpuStopMinig.Click += new System.EventHandler(this.bttnGpuStopMinig_Click);
            // 
            // lbCmdOutput
            // 
            this.lbCmdOutput.FormattingEnabled = true;
            this.lbCmdOutput.Location = new System.Drawing.Point(3, 54);
            this.lbCmdOutput.Name = "lbCmdOutput";
            this.lbCmdOutput.Size = new System.Drawing.Size(585, 199);
            this.lbCmdOutput.TabIndex = 18;
            // 
            // bttnStartMining
            // 
            this.bttnStartMining.Location = new System.Drawing.Point(394, 29);
            this.bttnStartMining.Name = "bttnStartMining";
            this.bttnStartMining.Size = new System.Drawing.Size(90, 23);
            this.bttnStartMining.TabIndex = 17;
            this.bttnStartMining.Text = "Start Mining!";
            this.bttnStartMining.UseVisualStyleBackColor = true;
            this.bttnStartMining.Click += new System.EventHandler(this.bttnStartMining_Click);
            // 
            // cbGpu
            // 
            this.cbGpu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.videoCardsBindingSource, "GPU", true));
            this.cbGpu.DataSource = this.videoCardsBindingSource;
            this.cbGpu.DisplayMember = "GPU";
            this.cbGpu.FormattingEnabled = true;
            this.cbGpu.Location = new System.Drawing.Point(264, 31);
            this.cbGpu.Name = "cbGpu";
            this.cbGpu.Size = new System.Drawing.Size(121, 21);
            this.cbGpu.TabIndex = 16;
            this.cbGpu.ValueMember = "Config";
            // 
            // videoCardsBindingSource
            // 
            this.videoCardsBindingSource.DataMember = "VideoCards";
            this.videoCardsBindingSource.DataSource = this.gPUDatabaseDataSet;
            // 
            // gPUDatabaseDataSet
            // 
            this.gPUDatabaseDataSet.DataSetName = "GPUDatabaseDataSet";
            this.gPUDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rBttnNvidia
            // 
            this.rBttnNvidia.AutoSize = true;
            this.rBttnNvidia.Location = new System.Drawing.Point(116, 32);
            this.rBttnNvidia.Name = "rBttnNvidia";
            this.rBttnNvidia.Size = new System.Drawing.Size(55, 17);
            this.rBttnNvidia.TabIndex = 14;
            this.rBttnNvidia.Text = "Nvidia";
            this.rBttnNvidia.UseVisualStyleBackColor = true;
            this.rBttnNvidia.CheckedChanged += new System.EventHandler(this.rBttnNvidia_CheckedChanged);
            // 
            // rBttnAti
            // 
            this.rBttnAti.AutoSize = true;
            this.rBttnAti.Checked = true;
            this.rBttnAti.Location = new System.Drawing.Point(68, 32);
            this.rBttnAti.Name = "rBttnAti";
            this.rBttnAti.Size = new System.Drawing.Size(42, 17);
            this.rBttnAti.TabIndex = 13;
            this.rBttnAti.TabStop = true;
            this.rBttnAti.Text = "ATI";
            this.rBttnAti.UseVisualStyleBackColor = true;
            this.rBttnAti.CheckedChanged += new System.EventHandler(this.rBttnAti_CheckedChanged);
            // 
            // txtBoxGpuPassword
            // 
            this.txtBoxGpuPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxGpuPassword.Location = new System.Drawing.Point(450, 6);
            this.txtBoxGpuPassword.Name = "txtBoxGpuPassword";
            this.txtBoxGpuPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxGpuPassword.TabIndex = 11;
            this.txtBoxGpuPassword.Text = "Worker Password";
            // 
            // lblGpuPassword
            // 
            this.lblGpuPassword.AutoSize = true;
            this.lblGpuPassword.Location = new System.Drawing.Point(391, 9);
            this.lblGpuPassword.Name = "lblGpuPassword";
            this.lblGpuPassword.Size = new System.Drawing.Size(53, 13);
            this.lblGpuPassword.TabIndex = 10;
            this.lblGpuPassword.Text = "Password";
            // 
            // txtBoxGpuUsername
            // 
            this.txtBoxGpuUsername.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxGpuUsername.Location = new System.Drawing.Point(264, 6);
            this.txtBoxGpuUsername.Name = "txtBoxGpuUsername";
            this.txtBoxGpuUsername.Size = new System.Drawing.Size(121, 20);
            this.txtBoxGpuUsername.TabIndex = 9;
            this.txtBoxGpuUsername.Text = "Username.Worker";
            // 
            // lblGpuUsername
            // 
            this.lblGpuUsername.AutoSize = true;
            this.lblGpuUsername.Location = new System.Drawing.Point(203, 9);
            this.lblGpuUsername.Name = "lblGpuUsername";
            this.lblGpuUsername.Size = new System.Drawing.Size(55, 13);
            this.lblGpuUsername.TabIndex = 8;
            this.lblGpuUsername.Text = "Username";
            // 
            // txtBoxGpuPool
            // 
            this.txtBoxGpuPool.Location = new System.Drawing.Point(42, 6);
            this.txtBoxGpuPool.Name = "txtBoxGpuPool";
            this.txtBoxGpuPool.Size = new System.Drawing.Size(155, 20);
            this.txtBoxGpuPool.TabIndex = 7;
            // 
            // lblGpuPool
            // 
            this.lblGpuPool.AutoSize = true;
            this.lblGpuPool.Location = new System.Drawing.Point(8, 9);
            this.lblGpuPool.Name = "lblGpuPool";
            this.lblGpuPool.Size = new System.Drawing.Size(28, 13);
            this.lblGpuPool.TabIndex = 6;
            this.lblGpuPool.Text = "Pool";
            // 
            // tbCpu
            // 
            this.tbCpu.Controls.Add(this.bttnCpuStopMining);
            this.tbCpu.Controls.Add(this.lbCpuOutput);
            this.tbCpu.Controls.Add(this.bttnCpuStartMining);
            this.tbCpu.Controls.Add(this.txtBoxCpuPassword);
            this.tbCpu.Controls.Add(this.lblCpuPassword);
            this.tbCpu.Controls.Add(this.txtBoxCpuUsername);
            this.tbCpu.Controls.Add(this.lblCpuUsername);
            this.tbCpu.Controls.Add(this.txtBoxCpuPool);
            this.tbCpu.Controls.Add(this.lblCpuPool);
            this.tbCpu.Location = new System.Drawing.Point(4, 22);
            this.tbCpu.Name = "tbCpu";
            this.tbCpu.Padding = new System.Windows.Forms.Padding(3);
            this.tbCpu.Size = new System.Drawing.Size(591, 256);
            this.tbCpu.TabIndex = 1;
            this.tbCpu.Text = "CPU Mining";
            this.tbCpu.UseVisualStyleBackColor = true;
            // 
            // bttnCpuStopMining
            // 
            this.bttnCpuStopMining.Location = new System.Drawing.Point(493, 29);
            this.bttnCpuStopMining.Name = "bttnCpuStopMining";
            this.bttnCpuStopMining.Size = new System.Drawing.Size(90, 23);
            this.bttnCpuStopMining.TabIndex = 21;
            this.bttnCpuStopMining.Text = "Stop Mining!";
            this.bttnCpuStopMining.UseVisualStyleBackColor = true;
            this.bttnCpuStopMining.Click += new System.EventHandler(this.bttnCpuStopMining_Click);
            // 
            // lbCpuOutput
            // 
            this.lbCpuOutput.FormattingEnabled = true;
            this.lbCpuOutput.Location = new System.Drawing.Point(3, 54);
            this.lbCpuOutput.Name = "lbCpuOutput";
            this.lbCpuOutput.Size = new System.Drawing.Size(585, 199);
            this.lbCpuOutput.TabIndex = 20;
            // 
            // bttnCpuStartMining
            // 
            this.bttnCpuStartMining.Location = new System.Drawing.Point(394, 29);
            this.bttnCpuStartMining.Name = "bttnCpuStartMining";
            this.bttnCpuStartMining.Size = new System.Drawing.Size(90, 23);
            this.bttnCpuStartMining.TabIndex = 19;
            this.bttnCpuStartMining.Text = "Start Mining!";
            this.bttnCpuStartMining.UseVisualStyleBackColor = true;
            this.bttnCpuStartMining.Click += new System.EventHandler(this.bttnCpuStartMining_Click);
            // 
            // txtBoxCpuPassword
            // 
            this.txtBoxCpuPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxCpuPassword.Location = new System.Drawing.Point(450, 6);
            this.txtBoxCpuPassword.Name = "txtBoxCpuPassword";
            this.txtBoxCpuPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCpuPassword.TabIndex = 11;
            this.txtBoxCpuPassword.Text = "Worker Password";
            // 
            // lblCpuPassword
            // 
            this.lblCpuPassword.AutoSize = true;
            this.lblCpuPassword.Location = new System.Drawing.Point(391, 9);
            this.lblCpuPassword.Name = "lblCpuPassword";
            this.lblCpuPassword.Size = new System.Drawing.Size(53, 13);
            this.lblCpuPassword.TabIndex = 10;
            this.lblCpuPassword.Text = "Password";
            // 
            // txtBoxCpuUsername
            // 
            this.txtBoxCpuUsername.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxCpuUsername.Location = new System.Drawing.Point(264, 6);
            this.txtBoxCpuUsername.Name = "txtBoxCpuUsername";
            this.txtBoxCpuUsername.Size = new System.Drawing.Size(121, 20);
            this.txtBoxCpuUsername.TabIndex = 9;
            this.txtBoxCpuUsername.Text = "Username.Worker";
            // 
            // lblCpuUsername
            // 
            this.lblCpuUsername.AutoSize = true;
            this.lblCpuUsername.Location = new System.Drawing.Point(203, 9);
            this.lblCpuUsername.Name = "lblCpuUsername";
            this.lblCpuUsername.Size = new System.Drawing.Size(55, 13);
            this.lblCpuUsername.TabIndex = 8;
            this.lblCpuUsername.Text = "Username";
            // 
            // txtBoxCpuPool
            // 
            this.txtBoxCpuPool.Location = new System.Drawing.Point(42, 6);
            this.txtBoxCpuPool.Name = "txtBoxCpuPool";
            this.txtBoxCpuPool.Size = new System.Drawing.Size(155, 20);
            this.txtBoxCpuPool.TabIndex = 7;
            // 
            // lblCpuPool
            // 
            this.lblCpuPool.AutoSize = true;
            this.lblCpuPool.Location = new System.Drawing.Point(8, 9);
            this.lblCpuPool.Name = "lblCpuPool";
            this.lblCpuPool.Size = new System.Drawing.Size(28, 13);
            this.lblCpuPool.TabIndex = 6;
            this.lblCpuPool.Text = "Pool";
            // 
            // videoCardsTableAdapter
            // 
            this.videoCardsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = EasyMine.GPUDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VideoCardsTableAdapter = this.videoCardsTableAdapter;
            // 
            // FrmEasyScryptMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 282);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(615, 320);
            this.MinimumSize = new System.Drawing.Size(615, 320);
            this.Name = "FrmEasyScryptMiner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Scrypt Miner";
            this.Load += new System.EventHandler(this.FrmEasyPoolMiner_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbGpu.ResumeLayout(false);
            this.tbGpu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPUDatabaseDataSet)).EndInit();
            this.tbCpu.ResumeLayout(false);
            this.tbCpu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbGpu;
        private System.Windows.Forms.RadioButton rBttnNvidia;
        private System.Windows.Forms.RadioButton rBttnAti;
        private System.Windows.Forms.TextBox txtBoxGpuPassword;
        private System.Windows.Forms.Label lblGpuPassword;
        private System.Windows.Forms.TextBox txtBoxGpuUsername;
        private System.Windows.Forms.Label lblGpuUsername;
        private System.Windows.Forms.TextBox txtBoxGpuPool;
        private System.Windows.Forms.Label lblGpuPool;
        private System.Windows.Forms.TabPage tbCpu;
        private System.Windows.Forms.TextBox txtBoxCpuPassword;
        private System.Windows.Forms.Label lblCpuPassword;
        private System.Windows.Forms.TextBox txtBoxCpuUsername;
        private System.Windows.Forms.Label lblCpuUsername;
        private System.Windows.Forms.TextBox txtBoxCpuPool;
        private System.Windows.Forms.Label lblCpuPool;
        private GPUDatabaseDataSet gPUDatabaseDataSet;
        private System.Windows.Forms.BindingSource videoCardsBindingSource;
        private GPUDatabaseDataSetTableAdapters.VideoCardsTableAdapter videoCardsTableAdapter;
        private GPUDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbGpu;
        private System.Windows.Forms.Button bttnStartMining;
        private System.Windows.Forms.ListBox lbCmdOutput;
        private System.Windows.Forms.Button bttnCpuStartMining;
        private System.Windows.Forms.ListBox lbCpuOutput;
        private System.Windows.Forms.Button bttnGpuStopMinig;
        private System.Windows.Forms.Button bttnCpuStopMining;

    }
}

