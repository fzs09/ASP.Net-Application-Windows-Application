namespace sampleWindowsForm
{
    partial class EmployeeDetails
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
            this.lblEid = new System.Windows.Forms.Label();
            this.txtEid = new System.Windows.Forms.TextBox();
            this.lblEname = new System.Windows.Forms.Label();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.lblEsal = new System.Windows.Forms.Label();
            this.txtEsal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEid
            // 
            this.lblEid.AutoSize = true;
            this.lblEid.Location = new System.Drawing.Point(22, 46);
            this.lblEid.Name = "lblEid";
            this.lblEid.Size = new System.Drawing.Size(22, 13);
            this.lblEid.TabIndex = 0;
            this.lblEid.Text = "Eid";
            this.lblEid.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEid
            // 
            this.txtEid.Location = new System.Drawing.Point(63, 43);
            this.txtEid.Name = "txtEid";
            this.txtEid.Size = new System.Drawing.Size(100, 20);
            this.txtEid.TabIndex = 1;
            this.txtEid.TextChanged += new System.EventHandler(this.txtEid_TextChanged);
            // 
            // lblEname
            // 
            this.lblEname.AutoSize = true;
            this.lblEname.Location = new System.Drawing.Point(22, 95);
            this.lblEname.Name = "lblEname";
            this.lblEname.Size = new System.Drawing.Size(40, 13);
            this.lblEname.TabIndex = 2;
            this.lblEname.Text = "Ename";
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(63, 92);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(100, 20);
            this.txtEname.TabIndex = 3;
            this.txtEname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblEsal
            // 
            this.lblEsal.AutoSize = true;
            this.lblEsal.Location = new System.Drawing.Point(22, 145);
            this.lblEsal.Name = "lblEsal";
            this.lblEsal.Size = new System.Drawing.Size(27, 13);
            this.lblEsal.TabIndex = 4;
            this.lblEsal.Text = "Esal";
            this.lblEsal.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEsal
            // 
            this.txtEsal.Location = new System.Drawing.Point(64, 142);
            this.txtEsal.Name = "txtEsal";
            this.txtEsal.Size = new System.Drawing.Size(100, 20);
            this.txtEsal.TabIndex = 5;
            this.txtEsal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(207, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 227);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEsal);
            this.Controls.Add(this.lblEsal);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.lblEname);
            this.Controls.Add(this.txtEid);
            this.Controls.Add(this.lblEid);
            this.Name = "EmployeeDetails";
            this.Text = "EmployeeDetails";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEid;
        private System.Windows.Forms.TextBox txtEid;
        private System.Windows.Forms.Label lblEname;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.Label lblEsal;
        private System.Windows.Forms.TextBox txtEsal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}