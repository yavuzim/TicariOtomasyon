
namespace WindowsFormsUI
{
    partial class SaleForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnSales = new System.Windows.Forms.Button();
            this.GetBasket = new System.Windows.Forms.Button();
            this.btnBasket = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BrandCheckList = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.btnCustomerExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnCustomerExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1779, 934);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.btnSales);
            this.groupBox3.Controls.Add(this.GetBasket);
            this.groupBox3.Controls.Add(this.btnBasket);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(158, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1485, 796);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÜRÜNLER";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNumber);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(392, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(361, 81);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ürün Adedi Giriniz";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumber.Location = new System.Drawing.Point(16, 31);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(330, 26);
            this.txtNumber.TabIndex = 9;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSales.BackgroundImage")));
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSales.Location = new System.Drawing.Point(1267, 69);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(185, 40);
            this.btnSales.TabIndex = 9;
            this.btnSales.Text = "Hızlı Satış";
            this.btnSales.UseVisualStyleBackColor = false;
            // 
            // GetBasket
            // 
            this.GetBasket.BackColor = System.Drawing.Color.Gainsboro;
            this.GetBasket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GetBasket.BackgroundImage")));
            this.GetBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GetBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetBasket.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.GetBasket.FlatAppearance.BorderSize = 0;
            this.GetBasket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.GetBasket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.GetBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GetBasket.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GetBasket.Location = new System.Drawing.Point(1029, 69);
            this.GetBasket.Name = "GetBasket";
            this.GetBasket.Size = new System.Drawing.Size(185, 40);
            this.GetBasket.TabIndex = 9;
            this.GetBasket.Text = "Sepete Git";
            this.GetBasket.UseVisualStyleBackColor = false;
            this.GetBasket.Click += new System.EventHandler(this.GetBasket_Click);
            // 
            // btnBasket
            // 
            this.btnBasket.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBasket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBasket.BackgroundImage")));
            this.btnBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBasket.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnBasket.FlatAppearance.BorderSize = 0;
            this.btnBasket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnBasket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasket.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBasket.Location = new System.Drawing.Point(801, 69);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(185, 40);
            this.btnBasket.TabIndex = 9;
            this.btnBasket.Text = "Sepete Ekle";
            this.btnBasket.UseVisualStyleBackColor = false;
            this.btnBasket.Click += new System.EventHandler(this.btnBasket_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(30, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 81);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün Adı";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(37, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 26);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(282, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 40);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(392, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 627);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BrandCheckList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(30, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 304);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Marka";
            // 
            // BrandCheckList
            // 
            this.BrandCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrandCheckList.FormattingEnabled = true;
            this.BrandCheckList.Location = new System.Drawing.Point(21, 34);
            this.BrandCheckList.Name = "BrandCheckList";
            this.BrandCheckList.Size = new System.Drawing.Size(285, 242);
            this.BrandCheckList.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(30, 458);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 304);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İndirim";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(21, 34);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(285, 242);
            this.checkedListBox2.TabIndex = 6;
            // 
            // btnCustomerExit
            // 
            this.btnCustomerExit.BackgroundImage = global::WindowsFormsUI.Properties.Resources.icons8_cancel_161;
            this.btnCustomerExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCustomerExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustomerExit.FlatAppearance.BorderSize = 0;
            this.btnCustomerExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCustomerExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCustomerExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerExit.Location = new System.Drawing.Point(148, 1);
            this.btnCustomerExit.Name = "btnCustomerExit";
            this.btnCustomerExit.Size = new System.Drawing.Size(31, 31);
            this.btnCustomerExit.TabIndex = 5;
            this.btnCustomerExit.UseVisualStyleBackColor = true;
            this.btnCustomerExit.Click += new System.EventHandler(this.btnCustomerExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "SATIŞ İŞLEMLERİ";
            // 
            // SaleForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 934);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleForms";
            this.Text = "SaleForms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaleForms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustomerExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox BrandCheckList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnBasket;
        private System.Windows.Forms.Button GetBasket;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNumber;
    }
}