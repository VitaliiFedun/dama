namespace DAMA
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripProgressBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonSetup = new System.Windows.Forms.ToolStripButton();
            this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonRun = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.panelSetup = new System.Windows.Forms.Panel();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.labelStore = new System.Windows.Forms.Label();
            this.ButtonCancelSetup = new System.Windows.Forms.Button();
            this.buttonSaveSetup = new System.Windows.Forms.Button();
            this.buttonSetPath = new System.Windows.Forms.Button();
            this.textBoxAttachPath = new System.Windows.Forms.TextBox();
            this.labelAttach = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogMain = new System.Windows.Forms.FolderBrowserDialog();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAllItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNotRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1.SuspendLayout();
            this.ToolStripMain.SuspendLayout();
            this.panelSetup.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripProgressBarMain,
            this.ToolStripStatusLabel2,
            this.ToolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(592, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(577, 17);
            this.ToolStripStatusLabel1.Spring = true;
            this.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1";
            // 
            // ToolStripProgressBarMain
            // 
            this.ToolStripProgressBarMain.Name = "ToolStripProgressBarMain";
            this.ToolStripProgressBarMain.Size = new System.Drawing.Size(100, 16);
            this.ToolStripProgressBarMain.Step = 1;
            this.ToolStripProgressBarMain.Visible = false;
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(228, 17);
            this.ToolStripStatusLabel2.Spring = true;
            this.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolStripStatusLabel2.Visible = false;
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(121, 17);
            this.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Visible = false;
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonSetup,
            this.HelpToolStripButton,
            this.ToolStripButtonRun,
            this.ToolStripButtonCancel,
            this.ToolStripButtonExit});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 0);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new System.Drawing.Size(592, 25);
            this.ToolStripMain.TabIndex = 2;
            this.ToolStripMain.Text = "ToolStrip1";
            // 
            // ToolStripButtonSetup
            // 
            this.ToolStripButtonSetup.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonSetup.Image")));
            this.ToolStripButtonSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonSetup.Name = "ToolStripButtonSetup";
            this.ToolStripButtonSetup.Size = new System.Drawing.Size(57, 22);
            this.ToolStripButtonSetup.Text = "Setup";
            this.ToolStripButtonSetup.Click += new System.EventHandler(this.ToolStripButtonSetup_Click);
            // 
            // HelpToolStripButton
            // 
            this.HelpToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.HelpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripButton.Image")));
            this.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpToolStripButton.Name = "HelpToolStripButton";
            this.HelpToolStripButton.Size = new System.Drawing.Size(73, 22);
            this.HelpToolStripButton.Text = "Спр&авка";
            this.HelpToolStripButton.Click += new System.EventHandler(this.HelpToolStripButton_Click);
            // 
            // ToolStripButtonRun
            // 
            this.ToolStripButtonRun.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonRun.Image")));
            this.ToolStripButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonRun.Name = "ToolStripButtonRun";
            this.ToolStripButtonRun.Size = new System.Drawing.Size(48, 22);
            this.ToolStripButtonRun.Text = "Run";
            this.ToolStripButtonRun.Click += new System.EventHandler(this.ToolStripButtonRun_Click);
            // 
            // ToolStripButtonCancel
            // 
            this.ToolStripButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonCancel.Image")));
            this.ToolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonCancel.Name = "ToolStripButtonCancel";
            this.ToolStripButtonCancel.Size = new System.Drawing.Size(100, 22);
            this.ToolStripButtonCancel.Text = "Canceled Run";
            this.ToolStripButtonCancel.Visible = false;
            this.ToolStripButtonCancel.Click += new System.EventHandler(this.ToolStripButtonCancel_Click);
            // 
            // ToolStripButtonExit
            // 
            this.ToolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonExit.Image")));
            this.ToolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonExit.Name = "ToolStripButtonExit";
            this.ToolStripButtonExit.Size = new System.Drawing.Size(45, 22);
            this.ToolStripButtonExit.Text = "Exit";
            this.ToolStripButtonExit.Click += new System.EventHandler(this.ToolStripButtonExit_Click);
            // 
            // panelSetup
            // 
            this.panelSetup.AutoSize = true;
            this.panelSetup.Controls.Add(this.comboBoxStore);
            this.panelSetup.Controls.Add(this.labelStore);
            this.panelSetup.Controls.Add(this.ButtonCancelSetup);
            this.panelSetup.Controls.Add(this.buttonSaveSetup);
            this.panelSetup.Controls.Add(this.buttonSetPath);
            this.panelSetup.Controls.Add(this.textBoxAttachPath);
            this.panelSetup.Controls.Add(this.labelAttach);
            this.panelSetup.Controls.Add(this.labelSubject);
            this.panelSetup.Controls.Add(this.textBoxSubject);
            this.panelSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSetup.Location = new System.Drawing.Point(0, 0);
            this.panelSetup.Name = "panelSetup";
            this.panelSetup.Size = new System.Drawing.Size(592, 304);
            this.panelSetup.TabIndex = 3;
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.Location = new System.Drawing.Point(83, 51);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(426, 21);
            this.comboBoxStore.Sorted = true;
            this.comboBoxStore.TabIndex = 1;
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Location = new System.Drawing.Point(12, 51);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(32, 13);
            this.labelStore.TabIndex = 8;
            this.labelStore.Text = "Store";
            // 
            // ButtonCancelSetup
            // 
            this.ButtonCancelSetup.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCancelSetup.Image")));
            this.ButtonCancelSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCancelSetup.Location = new System.Drawing.Point(291, 232);
            this.ButtonCancelSetup.Name = "ButtonCancelSetup";
            this.ButtonCancelSetup.Size = new System.Drawing.Size(194, 37);
            this.ButtonCancelSetup.TabIndex = 7;
            this.ButtonCancelSetup.Text = "Canceled Setup";
            this.ButtonCancelSetup.UseVisualStyleBackColor = true;
            this.ButtonCancelSetup.Click += new System.EventHandler(this.ButtonCancelSetup_Click);
            // 
            // buttonSaveSetup
            // 
            this.buttonSaveSetup.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveSetup.Image")));
            this.buttonSaveSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveSetup.Location = new System.Drawing.Point(83, 233);
            this.buttonSaveSetup.Name = "buttonSaveSetup";
            this.buttonSaveSetup.Size = new System.Drawing.Size(194, 37);
            this.buttonSaveSetup.TabIndex = 5;
            this.buttonSaveSetup.Text = "Save Setup";
            this.buttonSaveSetup.UseVisualStyleBackColor = true;
            this.buttonSaveSetup.Click += new System.EventHandler(this.ButtonSaveSetup_Click);
            // 
            // buttonSetPath
            // 
            this.buttonSetPath.Location = new System.Drawing.Point(515, 159);
            this.buttonSetPath.Name = "buttonSetPath";
            this.buttonSetPath.Size = new System.Drawing.Size(35, 23);
            this.buttonSetPath.TabIndex = 4;
            this.buttonSetPath.Text = "***";
            this.buttonSetPath.UseVisualStyleBackColor = true;
            this.buttonSetPath.Click += new System.EventHandler(this.ButtonSetPath_Click);
            // 
            // textBoxAttachPath
            // 
            this.textBoxAttachPath.Location = new System.Drawing.Point(83, 162);
            this.textBoxAttachPath.Name = "textBoxAttachPath";
            this.textBoxAttachPath.Size = new System.Drawing.Size(426, 20);
            this.textBoxAttachPath.TabIndex = 3;
            // 
            // labelAttach
            // 
            this.labelAttach.AutoSize = true;
            this.labelAttach.Location = new System.Drawing.Point(12, 169);
            this.labelAttach.Name = "labelAttach";
            this.labelAttach.Size = new System.Drawing.Size(62, 13);
            this.labelAttach.TabIndex = 3;
            this.labelAttach.Text = "Attach path";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(12, 124);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Subject";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(83, 117);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(426, 20);
            this.textBoxSubject.TabIndex = 2;
            // 
            // panelInfo
            // 
            this.panelInfo.AutoScroll = true;
            this.panelInfo.AutoSize = true;
            this.panelInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelInfo.Controls.Add(this.dataGridViewInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(592, 47);
            this.panelInfo.TabIndex = 8;
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            this.dataGridViewInfo.AllowUserToDeleteRows = false;
            this.dataGridViewInfo.AllowUserToOrderColumns = true;
            this.dataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnAllItems,
            this.ColumnNotRead});
            this.dataGridViewInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInfo.MultiSelect = false;
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.RowHeadersVisible = false;
            this.dataGridViewInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInfo.ShowEditingIcon = false;
            this.dataGridViewInfo.Size = new System.Drawing.Size(592, 47);
            this.dataGridViewInfo.TabIndex = 0;
            this.dataGridViewInfo.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name story ";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnAllItems
            // 
            this.ColumnAllItems.HeaderText = "All emaills";
            this.ColumnAllItems.Name = "ColumnAllItems";
            this.ColumnAllItems.ReadOnly = true;
            this.ColumnAllItems.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnNotRead
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnNotRead.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnNotRead.HeaderText = "Not read";
            this.ColumnNotRead.Name = "ColumnNotRead";
            this.ColumnNotRead.ReadOnly = true;
            this.ColumnNotRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelSetup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelInfo);
            this.splitContainer1.Size = new System.Drawing.Size(592, 355);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 402);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ToolStripMain);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "DAMA";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.panelSetup.ResumeLayout(false);
            this.panelSetup.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.ToolStripButton HelpToolStripButton;
        private System.Windows.Forms.ToolStripButton ToolStripButtonSetup;
        private System.Windows.Forms.ToolStripButton ToolStripButtonRun;
        private System.Windows.Forms.ToolStripButton ToolStripButtonExit;
        private System.Windows.Forms.Panel panelSetup;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMain;
        private System.Windows.Forms.ToolStripButton ToolStripButtonCancel;
        private System.Windows.Forms.ToolStripProgressBar ToolStripProgressBarMain;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
        private System.Windows.Forms.Button buttonSetPath;
        private System.Windows.Forms.TextBox textBoxAttachPath;
        private System.Windows.Forms.Label labelAttach;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Button ButtonCancelSetup;
        private System.Windows.Forms.Button buttonSaveSetup;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAllItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotRead;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.ComboBox comboBoxStore;
    }
}

