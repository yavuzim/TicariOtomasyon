
namespace WindowsFormsUI
{
    partial class PersonnelForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPersonnelAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdPersonnelTask = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdPersonnelCounty = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdPersonnelCity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPersonelMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonnelTc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonnelPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPersonnelLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonnelFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridPersonnel = new System.Windows.Forms.DataGridView();
            this.btnPersonnelExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gridPersonnel);
            this.panel1.Controls.Add(this.btnPersonnelExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1906, 1033);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = global::WindowsFormsUI.Properties.Resources.icons8_delete_48;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(1830, 787);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 60);
            this.btnDelete.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnDelete, "Personel Sil");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = global::WindowsFormsUI.Properties.Resources.icons8_update_48;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(1739, 787);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(63, 60);
            this.btnUpdate.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnUpdate, "Personel Güncelle");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = global::WindowsFormsUI.Properties.Resources.icons8_add_new_48;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(1659, 787);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 60);
            this.btnAdd.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnAdd, "Personel Ekle");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(1624, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 740);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.txtPersonnelAddress);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.cmdPersonnelTask);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(7, 408);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 308);
            this.panel5.TabIndex = 0;
            // 
            // txtPersonnelAddress
            // 
            this.txtPersonnelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonnelAddress.Location = new System.Drawing.Point(28, 98);
            this.txtPersonnelAddress.Multiline = true;
            this.txtPersonnelAddress.Name = "txtPersonnelAddress";
            this.txtPersonnelAddress.Size = new System.Drawing.Size(306, 202);
            this.txtPersonnelAddress.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(24, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Adres:";
            // 
            // cmdPersonnelTask
            // 
            this.cmdPersonnelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmdPersonnelTask.FormattingEnabled = true;
            this.cmdPersonnelTask.Location = new System.Drawing.Point(108, 22);
            this.cmdPersonnelTask.Name = "cmdPersonnelTask";
            this.cmdPersonnelTask.Size = new System.Drawing.Size(193, 26);
            this.cmdPersonnelTask.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(23, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 23);
            this.label10.TabIndex = 28;
            this.label10.Text = "Görev:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.cmdPersonnelCounty);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cmdPersonnelCity);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(7, 279);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 123);
            this.panel4.TabIndex = 0;
            // 
            // cmdPersonnelCounty
            // 
            this.cmdPersonnelCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmdPersonnelCounty.FormattingEnabled = true;
            this.cmdPersonnelCounty.Location = new System.Drawing.Point(108, 54);
            this.cmdPersonnelCounty.Name = "cmdPersonnelCounty";
            this.cmdPersonnelCounty.Size = new System.Drawing.Size(193, 26);
            this.cmdPersonnelCounty.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(23, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "İlçe:";
            // 
            // cmdPersonnelCity
            // 
            this.cmdPersonnelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmdPersonnelCity.FormattingEnabled = true;
            this.cmdPersonnelCity.Location = new System.Drawing.Point(108, 22);
            this.cmdPersonnelCity.Name = "cmdPersonnelCity";
            this.cmdPersonnelCity.Size = new System.Drawing.Size(193, 26);
            this.cmdPersonnelCity.TabIndex = 29;
            this.cmdPersonnelCity.SelectedIndexChanged += new System.EventHandler(this.cmdPersonnelCity_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(23, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Şehir:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.txtPersonelMail);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtPersonnelTc);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtPersonnelPhone);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(7, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 137);
            this.panel3.TabIndex = 0;
            // 
            // txtPersonelMail
            // 
            this.txtPersonelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelMail.Location = new System.Drawing.Point(108, 82);
            this.txtPersonelMail.Name = "txtPersonelMail";
            this.txtPersonelMail.Size = new System.Drawing.Size(193, 24);
            this.txtPersonelMail.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "E-Mail:";
            // 
            // txtPersonnelTc
            // 
            this.txtPersonnelTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonnelTc.Location = new System.Drawing.Point(108, 52);
            this.txtPersonnelTc.Name = "txtPersonnelTc";
            this.txtPersonnelTc.Size = new System.Drawing.Size(193, 24);
            this.txtPersonnelTc.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "T.C:";
            // 
            // txtPersonnelPhone
            // 
            this.txtPersonnelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonnelPhone.Location = new System.Drawing.Point(108, 22);
            this.txtPersonnelPhone.Name = "txtPersonnelPhone";
            this.txtPersonnelPhone.Size = new System.Drawing.Size(193, 24);
            this.txtPersonnelPhone.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Telefon:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.txtPersonnelLastname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPersonnelFirstName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(7, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 108);
            this.panel2.TabIndex = 0;
            // 
            // txtPersonnelLastname
            // 
            this.txtPersonnelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonnelLastname.Location = new System.Drawing.Point(108, 52);
            this.txtPersonnelLastname.Name = "txtPersonnelLastname";
            this.txtPersonnelLastname.Size = new System.Drawing.Size(193, 24);
            this.txtPersonnelLastname.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Soyad:";
            // 
            // txtPersonnelFirstName
            // 
            this.txtPersonnelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonnelFirstName.Location = new System.Drawing.Point(108, 22);
            this.txtPersonnelFirstName.Name = "txtPersonnelFirstName";
            this.txtPersonnelFirstName.Size = new System.Drawing.Size(193, 24);
            this.txtPersonnelFirstName.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ad:";
            // 
            // gridPersonnel
            // 
            this.gridPersonnel.BackgroundColor = System.Drawing.Color.White;
            this.gridPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonnel.Location = new System.Drawing.Point(11, 38);
            this.gridPersonnel.Name = "gridPersonnel";
            this.gridPersonnel.RowHeadersWidth = 51;
            this.gridPersonnel.RowTemplate.Height = 24;
            this.gridPersonnel.Size = new System.Drawing.Size(1592, 809);
            this.gridPersonnel.TabIndex = 8;
            this.gridPersonnel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPersonnel_CellClick);
            // 
            // btnPersonnelExit
            // 
            this.btnPersonnelExit.BackgroundImage = global::WindowsFormsUI.Properties.Resources.icons8_cancel_161;
            this.btnPersonnelExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPersonnelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonnelExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPersonnelExit.FlatAppearance.BorderSize = 0;
            this.btnPersonnelExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPersonnelExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPersonnelExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonnelExit.Location = new System.Drawing.Point(127, 1);
            this.btnPersonnelExit.Name = "btnPersonnelExit";
            this.btnPersonnelExit.Size = new System.Drawing.Size(31, 31);
            this.btnPersonnelExit.TabIndex = 7;
            this.btnPersonnelExit.UseVisualStyleBackColor = true;
            this.btnPersonnelExit.Click += new System.EventHandler(this.btnPersonnelExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "PERSONELLER";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 3000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // PersonnelForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1033);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonnelForms";
            this.Text = "PersonnelForms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PersonnelForms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPersonnelExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridPersonnel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPersonelMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersonnelTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonnelPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPersonnelLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonnelFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmdPersonnelTask;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmdPersonnelCounty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmdPersonnelCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPersonnelAddress;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}