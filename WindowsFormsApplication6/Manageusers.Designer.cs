namespace WindowsFormsApplication6
{
    partial class Manageusers
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvusersdetails = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.grpContainer = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusersdetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvusersdetails);
            this.panel2.Location = new System.Drawing.Point(3, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 178);
            this.panel2.TabIndex = 7;
            // 
            // dgvusersdetails
            // 
            this.dgvusersdetails.AllowUserToAddRows = false;
            this.dgvusersdetails.AllowUserToDeleteRows = false;
            this.dgvusersdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvusersdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusersdetails.Location = new System.Drawing.Point(-2, -2);
            this.dgvusersdetails.Name = "dgvusersdetails";
            this.dgvusersdetails.ReadOnly = true;
            this.dgvusersdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvusersdetails.Size = new System.Drawing.Size(635, 176);
            this.dgvusersdetails.TabIndex = 0;
            this.dgvusersdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusersdetails_CellClick);
            this.dgvusersdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusersdetails_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(3, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 49);
            this.panel1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(481, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(334, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(185, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 38);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(43, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "USER\'S INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "FullName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "UserName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Role:";
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(144, 24);
            this.txtfullname.Multiline = true;
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(161, 20);
            this.txtfullname.TabIndex = 4;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(144, 63);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(161, 20);
            this.txtusername.TabIndex = 5;
            this.txtusername.UseSystemPasswordChar = true;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(144, 107);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(161, 20);
            this.txtpassword.TabIndex = 6;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Tester"});
            this.cmbRole.Location = new System.Drawing.Point(144, 147);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(161, 21);
            this.cmbRole.TabIndex = 7;
            // 
            // grpContainer
            // 
            this.grpContainer.BackColor = System.Drawing.Color.SeaGreen;
            this.grpContainer.Controls.Add(this.cmbRole);
            this.grpContainer.Controls.Add(this.txtpassword);
            this.grpContainer.Controls.Add(this.txtusername);
            this.grpContainer.Controls.Add(this.txtfullname);
            this.grpContainer.Controls.Add(this.label5);
            this.grpContainer.Controls.Add(this.label4);
            this.grpContainer.Controls.Add(this.label3);
            this.grpContainer.Controls.Add(this.label2);
            this.grpContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContainer.Location = new System.Drawing.Point(3, 40);
            this.grpContainer.Name = "grpContainer";
            this.grpContainer.Size = new System.Drawing.Size(637, 186);
            this.grpContainer.TabIndex = 5;
            this.grpContainer.TabStop = false;
            // 
            // Manageusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(639, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpContainer);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(655, 505);
            this.MinimumSize = new System.Drawing.Size(655, 505);
            this.Name = "Manageusers";
            this.Text = "Manageusers";
            this.Load += new System.EventHandler(this.Manageusers_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusersdetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpContainer.ResumeLayout(false);
            this.grpContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvusersdetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.GroupBox grpContainer;
    }
}