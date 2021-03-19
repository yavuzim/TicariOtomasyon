
namespace WindowsFormsUI
{
    partial class ProductAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAddUpdate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmdProductBrand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductExplanation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProductVAT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductSales = new System.Windows.Forms.TextBox();
            this.txtPrdocutDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cmdProductBrand);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtProductExplanation);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtProductVAT);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtProductSales);
            this.panel1.Controls.Add(this.txtPrdocutDiscount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtProductCost);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtProductYear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtProductModel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.lblSonuc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 677);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 80);
            this.panel2.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::WindowsFormsUI.Properties.Resources.icons8_close_window_32;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(733, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ürün Ekleme ve Güncelleme Sayfası";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(364, 569);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(274, 42);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(51, 569);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(274, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmdProductBrand
            // 
            this.cmdProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmdProductBrand.FormattingEnabled = true;
            this.cmdProductBrand.Location = new System.Drawing.Point(155, 154);
            this.cmdProductBrand.Name = "cmdProductBrand";
            this.cmdProductBrand.Size = new System.Drawing.Size(193, 26);
            this.cmdProductBrand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Marka:";
            // 
            // txtProductExplanation
            // 
            this.txtProductExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductExplanation.Location = new System.Drawing.Point(15, 337);
            this.txtProductExplanation.Multiline = true;
            this.txtProductExplanation.Name = "txtProductExplanation";
            this.txtProductExplanation.Size = new System.Drawing.Size(698, 202);
            this.txtProductExplanation.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(11, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ürün Detay:";
            // 
            // txtProductVAT
            // 
            this.txtProductVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductVAT.Location = new System.Drawing.Point(520, 245);
            this.txtProductVAT.Name = "txtProductVAT";
            this.txtProductVAT.Size = new System.Drawing.Size(193, 24);
            this.txtProductVAT.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(369, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "KDV Oranı(%):";
            // 
            // txtProductSales
            // 
            this.txtProductSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductSales.Location = new System.Drawing.Point(520, 158);
            this.txtProductSales.Name = "txtProductSales";
            this.txtProductSales.Size = new System.Drawing.Size(193, 24);
            this.txtProductSales.TabIndex = 2;
            // 
            // txtPrdocutDiscount
            // 
            this.txtPrdocutDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrdocutDiscount.Location = new System.Drawing.Point(520, 201);
            this.txtPrdocutDiscount.Name = "txtPrdocutDiscount";
            this.txtPrdocutDiscount.Size = new System.Drawing.Size(193, 24);
            this.txtPrdocutDiscount.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(399, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Satış Fiyatı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(399, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "İndirim(%):";
            // 
            // txtProductCost
            // 
            this.txtProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductCost.Location = new System.Drawing.Point(520, 114);
            this.txtProductCost.Name = "txtProductCost";
            this.txtProductCost.Size = new System.Drawing.Size(193, 24);
            this.txtProductCost.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(412, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Alış Fiyatı:";
            // 
            // txtProductYear
            // 
            this.txtProductYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductYear.Location = new System.Drawing.Point(155, 244);
            this.txtProductYear.Name = "txtProductYear";
            this.txtProductYear.Size = new System.Drawing.Size(193, 24);
            this.txtProductYear.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürün Yıl:";
            // 
            // txtProductModel
            // 
            this.txtProductModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductModel.Location = new System.Drawing.Point(155, 200);
            this.txtProductModel.Name = "txtProductModel";
            this.txtProductModel.Size = new System.Drawing.Size(193, 24);
            this.txtProductModel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Model:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Location = new System.Drawing.Point(155, 113);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(193, 24);
            this.txtProductName.TabIndex = 2;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.Color.White;
            this.lblSonuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.Red;
            this.lblSonuc.Location = new System.Drawing.Point(60, 630);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 23);
            this.lblSonuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Ad:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProductAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 677);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductAddUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductAddUpdate";
            this.Load += new System.EventHandler(this.ProductAddUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cmdProductBrand;
        private System.Windows.Forms.TextBox txtProductExplanation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProductVAT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProductSales;
        private System.Windows.Forms.TextBox txtPrdocutDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}