
namespace AracSiparisProjesi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYakitTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKasaTipi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVitesTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRenk = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpYil = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMotorTipi = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "VOLKSWAGEN",
            "AUDI",
            "BMW",
            "MERCEDES",
            "RENAULT",
            "HYUNDAI",
            "HONDA"});
            this.cmbMarka.Location = new System.Drawing.Point(15, 45);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 21);
            this.cmbMarka.TabIndex = 0;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(142, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model:";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(145, 45);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 21);
            this.cmbModel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(271, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yakıt Tipi:";
            // 
            // cmbYakitTipi
            // 
            this.cmbYakitTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYakitTipi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYakitTipi.FormattingEnabled = true;
            this.cmbYakitTipi.Items.AddRange(new object[] {
            "BENZİN",
            "DİZEL",
            "LPG"});
            this.cmbYakitTipi.Location = new System.Drawing.Point(274, 45);
            this.cmbYakitTipi.Name = "cmbYakitTipi";
            this.cmbYakitTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbYakitTipi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(398, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kasa Tipi:";
            // 
            // cmbKasaTipi
            // 
            this.cmbKasaTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKasaTipi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKasaTipi.FormattingEnabled = true;
            this.cmbKasaTipi.Items.AddRange(new object[] {
            "SEDAN",
            "VAGON",
            "HATCHBACK",
            "SUV"});
            this.cmbKasaTipi.Location = new System.Drawing.Point(401, 45);
            this.cmbKasaTipi.Name = "cmbKasaTipi";
            this.cmbKasaTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbKasaTipi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vites Tipi:";
            // 
            // cmbVitesTipi
            // 
            this.cmbVitesTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVitesTipi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbVitesTipi.FormattingEnabled = true;
            this.cmbVitesTipi.Items.AddRange(new object[] {
            "MANUEL",
            "OTOMATİK",
            "TRİPTONİK"});
            this.cmbVitesTipi.Location = new System.Drawing.Point(15, 89);
            this.cmbVitesTipi.Name = "cmbVitesTipi";
            this.cmbVitesTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbVitesTipi.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(271, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Renk:";
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(274, 89);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(118, 23);
            this.btnRenk.TabIndex = 6;
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(400, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Yılı:";
            // 
            // dtpYil
            // 
            this.dtpYil.CustomFormat = "yyyy";
            this.dtpYil.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpYil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYil.Location = new System.Drawing.Point(403, 91);
            this.dtpYil.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpYil.Name = "dtpYil";
            this.dtpYil.Size = new System.Drawing.Size(118, 21);
            this.dtpYil.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(145, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Motor Tipi:";
            // 
            // cmbMotorTipi
            // 
            this.cmbMotorTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotorTipi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMotorTipi.FormattingEnabled = true;
            this.cmbMotorTipi.Items.AddRange(new object[] {
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.8",
            "2.0",
            "2.2",
            "3.0",
            "3.5",
            "4.0",
            "4.5",
            "5.0"});
            this.cmbMotorTipi.Location = new System.Drawing.Point(148, 88);
            this.cmbMotorTipi.Name = "cmbMotorTipi";
            this.cmbMotorTipi.Size = new System.Drawing.Size(118, 21);
            this.cmbMotorTipi.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(559, 78);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(73, 35);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Ekle.png");
            this.ımageList1.Images.SetKeyName(1, "remove.png");
            this.ımageList1.Images.SetKeyName(2, "Edit.png");
            this.ımageList1.Images.SetKeyName(3, "save.png");
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(701, 277);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yakıt Tipi";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kasa Tipi";
            this.columnHeader4.Width = 94;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vites Tipi";
            this.columnHeader5.Width = 92;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Motor Tipi";
            this.columnHeader6.Width = 81;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Renk";
            this.columnHeader7.Width = 57;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Model Yılı";
            this.columnHeader8.Width = 94;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 1;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(649, 78);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 35);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzenle.ImageIndex = 2;
            this.btnDuzenle.ImageList = this.ımageList1;
            this.btnDuzenle.Location = new System.Drawing.Point(719, 76);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(87, 40);
            this.btnDuzenle.TabIndex = 11;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.ImageIndex = 3;
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(719, 125);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(87, 37);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbMotorTipi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpYil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbVitesTipi);
            this.Controls.Add(this.cmbKasaTipi);
            this.Controls.Add(this.cmbYakitTipi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYakitTipi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKasaTipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVitesTipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpYil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMotorTipi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}

