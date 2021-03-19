
namespace WindowsFormsUI
{
    partial class ProductForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForms));
            this.label1 = new System.Windows.Forms.Label();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnProductExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜNLER";
            // 
            // gridProducts
            // 
            this.gridProducts.BackgroundColor = System.Drawing.Color.White;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(12, 100);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowHeadersWidth = 51;
            this.gridProducts.RowTemplate.Height = 24;
            this.gridProducts.Size = new System.Drawing.Size(1900, 760);
            this.gridProducts.TabIndex = 2;
            this.gridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(247, 47);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(226, 47);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Ürün Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 47);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ürün Ekle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnProductExit
            // 
            this.btnProductExit.BackgroundImage = global::WindowsFormsUI.Properties.Resources.icons8_cancel_161;
            this.btnProductExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProductExit.FlatAppearance.BorderSize = 0;
            this.btnProductExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProductExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProductExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductExit.Location = new System.Drawing.Point(93, 2);
            this.btnProductExit.Name = "btnProductExit";
            this.btnProductExit.Size = new System.Drawing.Size(31, 31);
            this.btnProductExit.TabIndex = 1;
            this.btnProductExit.UseVisualStyleBackColor = true;
            this.btnProductExit.Click += new System.EventHandler(this.btnProductExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(480, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ürün Sil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(712, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(226, 47);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ProductForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.btnProductExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForms";
            this.Text = "ProductForms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductExit;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefresh;
    }
}