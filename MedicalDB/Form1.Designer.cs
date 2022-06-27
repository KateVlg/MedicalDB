
namespace MedicalDB
{
    partial class Analysis
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsFamilyMember = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBDCreaturesTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.типыАнализовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыОбследованийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медицинскиеОбластиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лекарстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.t = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеПосещенияВрачейЧленомСемьиПоРодуДеятельностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеАнализыПоТипуЧленаСемьиЗаПериодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFamilyMember = new System.Windows.Forms.ComboBox();
            this.cbContract = new System.Windows.Forms.ComboBox();
            this.txtSumm = new System.Windows.Forms.TextBox();
            this.dtDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridReport = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridAnalysis = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridVisit = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnalysis)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFamilyMember,
            this.запросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsFamilyMember
            // 
            this.tsFamilyMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBDCreaturesTypes,
            this.типыАнализовToolStripMenuItem,
            this.типыОбследованийToolStripMenuItem,
            this.медицинскиеОбластиToolStripMenuItem,
            this.клиникиToolStripMenuItem,
            this.лекарстваToolStripMenuItem,
            this.t});
            this.tsFamilyMember.Name = "tsFamilyMember";
            this.tsFamilyMember.Size = new System.Drawing.Size(139, 29);
            this.tsFamilyMember.Text = "Справочники";
            // 
            // tsBDCreaturesTypes
            // 
            this.tsBDCreaturesTypes.Name = "tsBDCreaturesTypes";
            this.tsBDCreaturesTypes.Size = new System.Drawing.Size(295, 34);
            this.tsBDCreaturesTypes.Text = "Типы существ";
            this.tsBDCreaturesTypes.Click += new System.EventHandler(this.tsBDCreaturesTypes_Click);
            // 
            // типыАнализовToolStripMenuItem
            // 
            this.типыАнализовToolStripMenuItem.Name = "типыАнализовToolStripMenuItem";
            this.типыАнализовToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.типыАнализовToolStripMenuItem.Text = "Типы анализов";
            this.типыАнализовToolStripMenuItem.Click += new System.EventHandler(this.tsBDAnalysisTypes_Click);
            // 
            // типыОбследованийToolStripMenuItem
            // 
            this.типыОбследованийToolStripMenuItem.Name = "типыОбследованийToolStripMenuItem";
            this.типыОбследованийToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.типыОбследованийToolStripMenuItem.Text = "Типы обследований";
            this.типыОбследованийToolStripMenuItem.Click += new System.EventHandler(this.tsBDExaminationsTypes_Click);
            // 
            // медицинскиеОбластиToolStripMenuItem
            // 
            this.медицинскиеОбластиToolStripMenuItem.Name = "медицинскиеОбластиToolStripMenuItem";
            this.медицинскиеОбластиToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.медицинскиеОбластиToolStripMenuItem.Text = "Медицинские области";
            this.медицинскиеОбластиToolStripMenuItem.Click += new System.EventHandler(this.tsBDMedicalFields_Click);
            // 
            // клиникиToolStripMenuItem
            // 
            this.клиникиToolStripMenuItem.Name = "клиникиToolStripMenuItem";
            this.клиникиToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.клиникиToolStripMenuItem.Text = "Клиники";
            this.клиникиToolStripMenuItem.Click += new System.EventHandler(this.tsBDClinics_Click);
            // 
            // лекарстваToolStripMenuItem
            // 
            this.лекарстваToolStripMenuItem.Name = "лекарстваToolStripMenuItem";
            this.лекарстваToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.лекарстваToolStripMenuItem.Text = "Лекарства";
            this.лекарстваToolStripMenuItem.Click += new System.EventHandler(this.tsBDMedicines_Click);
            // 
            // t
            // 
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(295, 34);
            this.t.Text = "Члены семьи";
            this.t.Click += new System.EventHandler(this.tsBDFamilyMember);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеПосещенияВрачейЧленомСемьиПоРодуДеятельностиToolStripMenuItem,
            this.всеАнализыПоТипуЧленаСемьиЗаПериодToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.запросыToolStripMenuItem.Text = "Отчеты";
            // 
            // всеПосещенияВрачейЧленомСемьиПоРодуДеятельностиToolStripMenuItem
            // 
            this.всеПосещенияВрачейЧленомСемьиПоРодуДеятельностиToolStripMenuItem.Name = "всеПосещенияВрачейЧленомСемьиПоРодуДеятельностиToolStripMenuItem";
            this.всеПосещенияВрачейЧленомСемьиПоРодуДеятельностиToolStripMenuItem.Size = new System.Drawing.Size(607, 34);
            this.всеПосещенияВрачейЧленомСемьиПоРодуДеятельностиToolStripMenuItem.Text = "Все посещения врачей членом семьи по роду деятельности";
            this.всеПосещенияВрачейЧленомСемьиПоРодуДеятельностиToolStripMenuItem.Click += new System.EventHandler(this.tsBDVisitDoctorforMedicalField);
            // 
            // всеАнализыПоТипуЧленаСемьиЗаПериодToolStripMenuItem
            // 
            this.всеАнализыПоТипуЧленаСемьиЗаПериодToolStripMenuItem.Name = "всеАнализыПоТипуЧленаСемьиЗаПериодToolStripMenuItem";
            this.всеАнализыПоТипуЧленаСемьиЗаПериодToolStripMenuItem.Size = new System.Drawing.Size(607, 34);
            this.всеАнализыПоТипуЧленаСемьиЗаПериодToolStripMenuItem.Text = "Все анализы по типу члена семьи за период";
            this.всеАнализыПоТипуЧленаСемьиЗаПериодToolStripMenuItem.Click += new System.EventHandler(this.tsBDAnalysesForPeriod);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 637);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.Location = new System.Drawing.Point(580, 11);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(130, 37);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(716, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 37);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(844, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbFamilyMember);
            this.panel2.Controls.Add(this.cbContract);
            this.panel2.Controls.Add(this.txtSumm);
            this.panel2.Controls.Add(this.dtDateAndTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 145);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Член семьи:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Прием:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Стоимость посещения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата посещения:";
            // 
            // cbFamilyMember
            // 
            this.cbFamilyMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFamilyMember.FormattingEnabled = true;
            this.cbFamilyMember.Location = new System.Drawing.Point(203, 114);
            this.cbFamilyMember.Name = "cbFamilyMember";
            this.cbFamilyMember.Size = new System.Drawing.Size(628, 28);
            this.cbFamilyMember.TabIndex = 3;
            // 
            // cbContract
            // 
            this.cbContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContract.FormattingEnabled = true;
            this.cbContract.Location = new System.Drawing.Point(203, 77);
            this.cbContract.Name = "cbContract";
            this.cbContract.Size = new System.Drawing.Size(628, 28);
            this.cbContract.TabIndex = 2;
            // 
            // txtSumm
            // 
            this.txtSumm.Location = new System.Drawing.Point(203, 45);
            this.txtSumm.Name = "txtSumm";
            this.txtSumm.Size = new System.Drawing.Size(628, 26);
            this.txtSumm.TabIndex = 1;
            // 
            // dtDateAndTime
            // 
            this.dtDateAndTime.Location = new System.Drawing.Point(203, 13);
            this.dtDateAndTime.Name = "dtDateAndTime";
            this.dtDateAndTime.Size = new System.Drawing.Size(628, 26);
            this.dtDateAndTime.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(502, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 459);
            this.panel3.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridReport);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заключение";
            // 
            // gridReport
            // 
            this.gridReport.AllowUserToAddRows = false;
            this.gridReport.AllowUserToDeleteRows = false;
            this.gridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridReport.Location = new System.Drawing.Point(3, 22);
            this.gridReport.Name = "gridReport";
            this.gridReport.ReadOnly = true;
            this.gridReport.RowHeadersWidth = 62;
            this.gridReport.RowTemplate.Height = 28;
            this.gridReport.Size = new System.Drawing.Size(464, 180);
            this.gridReport.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 251);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(470, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridAnalysis);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Анализы";
            // 
            // gridAnalysis
            // 
            this.gridAnalysis.AllowUserToAddRows = false;
            this.gridAnalysis.AllowUserToDeleteRows = false;
            this.gridAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAnalysis.Location = new System.Drawing.Point(3, 22);
            this.gridAnalysis.Name = "gridAnalysis";
            this.gridAnalysis.ReadOnly = true;
            this.gridAnalysis.RowHeadersWidth = 62;
            this.gridAnalysis.RowTemplate.Height = 28;
            this.gridAnalysis.Size = new System.Drawing.Size(464, 226);
            this.gridAnalysis.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(499, 33);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 459);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridVisit);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 459);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Визиты";
            // 
            // gridVisit
            // 
            this.gridVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVisit.Location = new System.Drawing.Point(3, 22);
            this.gridVisit.Name = "gridVisit";
            this.gridVisit.ReadOnly = true;
            this.gridVisit.RowHeadersWidth = 62;
            this.gridVisit.RowTemplate.Height = 28;
            this.gridVisit.Size = new System.Drawing.Size(493, 434);
            this.gridVisit.TabIndex = 0;
            this.gridVisit.CurrentCellChanged += new System.EventHandler(this.grid_CurrentCellChanged);
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 697);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Analysis";
            this.Text = "Анализы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAnalysis)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVisit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem tsFamilyMember;
        private System.Windows.Forms.ToolStripMenuItem tsBDCreaturesTypes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem типыАнализовToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem типыОбследованийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медицинскиеОбластиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лекарстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеПосещенияВрачейЧленомСемьиПоРодуДеятельностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеАнализыПоТипуЧленаСемьиЗаПериодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem t;
        private System.Windows.Forms.ComboBox cbFamilyMember;
        private System.Windows.Forms.ComboBox cbContract;
        private System.Windows.Forms.TextBox txtSumm;
        private System.Windows.Forms.DateTimePicker dtDateAndTime;
        private System.Windows.Forms.DataGridView gridAnalysis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridReport;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridVisit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

