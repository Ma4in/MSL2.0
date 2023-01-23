namespace MSL2._0
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.versionList = new System.Windows.Forms.ComboBox();
            this.Version = new System.Windows.Forms.Label();
            this.versionSelect = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.minMemmory = new System.Windows.Forms.Label();
            this.maxMemmory = new System.Windows.Forms.Label();
            this.curentMemmory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // versionList
            // 
            this.versionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionList.FormattingEnabled = true;
            this.versionList.Items.AddRange(new object[] {
            "1.12.2",
            "1.7.10"});
            this.versionList.Location = new System.Drawing.Point(80, 12);
            this.versionList.Name = "versionList";
            this.versionList.Size = new System.Drawing.Size(151, 28);
            this.versionList.TabIndex = 0;
            this.versionList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Version.Location = new System.Drawing.Point(11, 15);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(63, 20);
            this.Version.TabIndex = 1;
            this.Version.Text = "Version";
            // 
            // versionSelect
            // 
            this.versionSelect.Enabled = false;
            this.versionSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionSelect.Location = new System.Drawing.Point(254, 12);
            this.versionSelect.Name = "versionSelect";
            this.versionSelect.Size = new System.Drawing.Size(127, 28);
            this.versionSelect.TabIndex = 2;
            this.versionSelect.Text = "Select";
            this.versionSelect.UseVisualStyleBackColor = true;
            this.versionSelect.Click += new System.EventHandler(this.versionSelect_Click);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(93, 428);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(35, 13);
            this.testLabel.TabIndex = 3;
            this.testLabel.Text = "label1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(60, 43);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(236, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Used Memmory :";
            // 
            // minMemmory
            // 
            this.minMemmory.AutoSize = true;
            this.minMemmory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minMemmory.Location = new System.Drawing.Point(3, 43);
            this.minMemmory.Name = "minMemmory";
            this.minMemmory.Size = new System.Drawing.Size(36, 20);
            this.minMemmory.TabIndex = 1;
            this.minMemmory.Text = "512";
            // 
            // maxMemmory
            // 
            this.maxMemmory.AutoSize = true;
            this.maxMemmory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxMemmory.Location = new System.Drawing.Point(302, 43);
            this.maxMemmory.Name = "maxMemmory";
            this.maxMemmory.Size = new System.Drawing.Size(45, 20);
            this.maxMemmory.TabIndex = 1;
            this.maxMemmory.Text = "1000";
            // 
            // curentMemmory
            // 
            this.curentMemmory.AutoSize = true;
            this.curentMemmory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curentMemmory.Location = new System.Drawing.Point(137, 10);
            this.curentMemmory.Name = "curentMemmory";
            this.curentMemmory.Size = new System.Drawing.Size(36, 20);
            this.curentMemmory.TabIndex = 1;
            this.curentMemmory.Text = "512";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minMemmory);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.maxMemmory);
            this.panel1.Controls.Add(this.curentMemmory);
            this.panel1.Location = new System.Drawing.Point(12, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 90);
            this.panel1.TabIndex = 6;
            // 
            // openFolder
            // 
            this.openFolder.Location = new System.Drawing.Point(12, 423);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(75, 23);
            this.openFolder.TabIndex = 7;
            this.openFolder.Text = "open folder";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.openFolder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.versionSelect);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.versionList);
            this.Name = "StartForm";
            this.Text = "MSL";
            this.Shown += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox versionList;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Button versionSelect;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minMemmory;
        private System.Windows.Forms.Label maxMemmory;
        private System.Windows.Forms.Label curentMemmory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openFolder;
    }
}

