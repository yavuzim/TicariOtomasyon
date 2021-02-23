
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.btnExplanation = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnProductExit = new System.Windows.Forms.Button();
            this.btnPage = new System.Windows.Forms.Button();
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
            this.gridProducts.Location = new System.Drawing.Point(12, 52);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowHeadersWidth = 51;
            this.gridProducts.RowTemplate.Height = 24;
            this.gridProducts.Size = new System.Drawing.Size(1621, 742);
            this.gridProducts.TabIndex = 2;
            this.gridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellClick);
            // 
            // btnExplanation
            // 
            this.btnExplanation.BackColor = System.Drawing.Color.White;
            this.btnExplanation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExplanation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExplanation.FlatAppearance.BorderSize = 2;
            this.btnExplanation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExplanation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExplanation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExplanation.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExplanation.ForeColor = System.Drawing.Color.Black;
            this.btnExplanation.Location = new System.Drawing.Point(1640, 250);
            this.btnExplanation.Name = "btnExplanation";
            this.btnExplanation.Size = new System.Drawing.Size(226, 60);
            this.btnExplanation.TabIndex = 3;
            this.btnExplanation.Text = "DETAY";
            this.btnExplanation.UseVisualStyleBackColor = false;
            this.btnExplanation.Click += new System.EventHandler(this.btnExplanation_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = global::WindowsFormsUI.Properties.Resources.icons8_delete_48;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(1640, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(226, 60);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = global::WindowsFormsUI.Properties.Resources.icons8_update_48;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(1640, 118);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(226, 60);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = global::WindowsFormsUI.Properties.Resources.icons8_add_new_48;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(1640, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 60);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "EKLE";
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
            // btnPage
            // 
            this.btnPage.BackColor = System.Drawing.Color.White;
            this.btnPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPage.FlatAppearance.BorderSize = 2;
            this.btnPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPage.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPage.ForeColor = System.Drawing.Color.Black;
            this.btnPage.Location = new System.Drawing.Point(1640, 316);
            this.btnPage.Name = "btnPage";
            this.btnPage.Size = new System.Drawing.Size(226, 60);
            this.btnPage.TabIndex = 3;
            this.btnPage.Text = "SAYFA YENİLE";
            this.btnPage.UseVisualStyleBackColor = false;
            this.btnPage.Click += new System.EventHandler(this.btnPage_Click);
            // 
            // ProductForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnPage);
            this.Controls.Add(this.btnExplanation);
            this.Controls.Add(this.btnDelete);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExplanation;
        private System.Windows.Forms.Button btnPage;
    }
}