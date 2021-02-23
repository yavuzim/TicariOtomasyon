
namespace WindowsFormsUI
{
    partial class CustomerForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPage = new System.Windows.Forms.Button();
            this.btnExplanation = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridCustomer = new System.Windows.Forms.DataGridView();
            this.btnCustomerExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPage);
            this.panel1.Controls.Add(this.btnExplanation);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.gridCustomer);
            this.panel1.Controls.Add(this.btnCustomerExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1055);
            this.panel1.TabIndex = 0;
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
            this.btnPage.Location = new System.Drawing.Point(1642, 312);
            this.btnPage.Name = "btnPage";
            this.btnPage.Size = new System.Drawing.Size(226, 60);
            this.btnPage.TabIndex = 5;
            this.btnPage.Text = "SAYFA YENİLE";
            this.btnPage.UseVisualStyleBackColor = false;
            this.btnPage.Click += new System.EventHandler(this.btnPage_Click);
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
            this.btnExplanation.Location = new System.Drawing.Point(1642, 246);
            this.btnExplanation.Name = "btnExplanation";
            this.btnExplanation.Size = new System.Drawing.Size(226, 60);
            this.btnExplanation.TabIndex = 6;
            this.btnExplanation.Text = "DETAY";
            this.btnExplanation.UseVisualStyleBackColor = false;
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
            this.btnDelete.Location = new System.Drawing.Point(1642, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(226, 60);
            this.btnDelete.TabIndex = 7;
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
            this.btnUpdate.Location = new System.Drawing.Point(1642, 114);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(226, 60);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "  GÜNCELLE";
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
            this.btnAdd.Location = new System.Drawing.Point(1642, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 60);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridCustomer
            // 
            this.gridCustomer.BackgroundColor = System.Drawing.Color.White;
            this.gridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomer.Location = new System.Drawing.Point(14, 48);
            this.gridCustomer.Name = "gridCustomer";
            this.gridCustomer.RowHeadersWidth = 51;
            this.gridCustomer.RowTemplate.Height = 24;
            this.gridCustomer.Size = new System.Drawing.Size(1621, 742);
            this.gridCustomer.TabIndex = 4;
            this.gridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCustomer_CellClick);
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
            this.btnCustomerExit.Location = new System.Drawing.Point(113, 1);
            this.btnCustomerExit.Name = "btnCustomerExit";
            this.btnCustomerExit.Size = new System.Drawing.Size(31, 31);
            this.btnCustomerExit.TabIndex = 3;
            this.btnCustomerExit.UseVisualStyleBackColor = true;
            this.btnCustomerExit.Click += new System.EventHandler(this.btnCustomerExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "MÜŞTERİLER";
            // 
            // CustomerForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForms";
            this.Text = "CustomerForms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerForms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustomerExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPage;
        private System.Windows.Forms.Button btnExplanation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gridCustomer;
    }
}