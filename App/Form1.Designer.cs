namespace NinePatch
{
    partial class NinePathTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbConfigSnapShot = new System.Windows.Forms.Label();
            this.txtRootPath = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.cbbConfig = new System.Windows.Forms.ComboBox();
            this.txtNPConfigPath = new System.Windows.Forms.TextBox();
            this.btnSelectConfig = new System.Windows.Forms.Button();
            this.lvImgs = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.btnSelectOutputFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbConfigSnapShot);
            this.groupBox1.Controls.Add(this.txtRootPath);
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Controls.Add(this.cbbConfig);
            this.groupBox1.Controls.Add(this.txtNPConfigPath);
            this.groupBox1.Controls.Add(this.btnSelectConfig);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbConfigSnapShot
            // 
            this.lbConfigSnapShot.AutoSize = true;
            this.lbConfigSnapShot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbConfigSnapShot.Location = new System.Drawing.Point(170, 81);
            this.lbConfigSnapShot.Name = "lbConfigSnapShot";
            this.lbConfigSnapShot.Size = new System.Drawing.Size(2, 14);
            this.lbConfigSnapShot.TabIndex = 7;
            // 
            // txtRootPath
            // 
            this.txtRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRootPath.Location = new System.Drawing.Point(6, 21);
            this.txtRootPath.Name = "txtRootPath";
            this.txtRootPath.Size = new System.Drawing.Size(517, 21);
            this.txtRootPath.TabIndex = 2;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Location = new System.Drawing.Point(529, 20);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 22);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "选择目录";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // cbbConfig
            // 
            this.cbbConfig.FormattingEnabled = true;
            this.cbbConfig.Location = new System.Drawing.Point(6, 75);
            this.cbbConfig.Name = "cbbConfig";
            this.cbbConfig.Size = new System.Drawing.Size(147, 20);
            this.cbbConfig.TabIndex = 6;
            this.cbbConfig.SelectedIndexChanged += new System.EventHandler(this.cbbConfig_SelectedIndexChanged);
            // 
            // txtNPConfigPath
            // 
            this.txtNPConfigPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNPConfigPath.Location = new System.Drawing.Point(6, 48);
            this.txtNPConfigPath.Name = "txtNPConfigPath";
            this.txtNPConfigPath.Size = new System.Drawing.Size(517, 21);
            this.txtNPConfigPath.TabIndex = 4;
            // 
            // btnSelectConfig
            // 
            this.btnSelectConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectConfig.Location = new System.Drawing.Point(529, 48);
            this.btnSelectConfig.Name = "btnSelectConfig";
            this.btnSelectConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSelectConfig.TabIndex = 5;
            this.btnSelectConfig.Text = "选择配置";
            this.btnSelectConfig.UseVisualStyleBackColor = true;
            this.btnSelectConfig.Click += new System.EventHandler(this.btnSelectConfig_Click);
            // 
            // lvImgs
            // 
            this.lvImgs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvImgs.HideSelection = false;
            this.lvImgs.Location = new System.Drawing.Point(9, 117);
            this.lvImgs.MultiSelect = false;
            this.lvImgs.Name = "lvImgs";
            this.lvImgs.Size = new System.Drawing.Size(1018, 532);
            this.lvImgs.TabIndex = 3;
            this.lvImgs.UseCompatibleStateImageBehavior = false;
            this.lvImgs.View = System.Windows.Forms.View.Details;
            this.lvImgs.DoubleClick += new System.EventHandler(this.lvImgs_DoubleClick);
            this.lvImgs.Columns.Add("Name", -1, System.Windows.Forms.HorizontalAlignment.Left);
            this.lvImgs.Columns.Add("Path", -1, System.Windows.Forms.HorizontalAlignment.Left);

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lvImgs);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 700);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSelectOutputFolder);
            this.panel2.Controls.Add(this.txtOutputFolder);
            this.panel2.Controls.Add(this.btnProcess);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 655);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 45);
            this.panel2.TabIndex = 4;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Location = new System.Drawing.Point(952, 10);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "开始处理";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFolder.Location = new System.Drawing.Point(9, 12);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(517, 21);
            this.txtOutputFolder.TabIndex = 8;
            // 
            // btnSelectOutputFolder
            // 
            this.btnSelectOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectOutputFolder.Location = new System.Drawing.Point(538, 10);
            this.btnSelectOutputFolder.Name = "btnSelectOutputFolder";
            this.btnSelectOutputFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectOutputFolder.TabIndex = 8;
            this.btnSelectOutputFolder.Text = "输出目录";
            this.btnSelectOutputFolder.UseVisualStyleBackColor = true;
            this.btnSelectOutputFolder.Click += new System.EventHandler(this.btnSelectOutputFolder_Click);
            // 
            // NinePathTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 700);
            this.Controls.Add(this.panel1);
            this.Name = "NinePathTool";
            this.Text = "9PatchTool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRootPath;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.ComboBox cbbConfig;
        private System.Windows.Forms.TextBox txtNPConfigPath;
        private System.Windows.Forms.Button btnSelectConfig;
        private System.Windows.Forms.ListView lvImgs;
        private System.Windows.Forms.Label lbConfigSnapShot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelectOutputFolder;
        private System.Windows.Forms.TextBox txtOutputFolder;
    }
}

