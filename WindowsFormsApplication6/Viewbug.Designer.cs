namespace WindowsFormsApplication6
{
    partial class Viewbug
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
            this.dgvviewbug = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewbug)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvviewbug);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 476);
            this.panel1.TabIndex = 0;
            // 
            // dgvviewbug
            // 
            this.dgvviewbug.AllowUserToAddRows = false;
            this.dgvviewbug.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvviewbug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvviewbug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvviewbug.Location = new System.Drawing.Point(0, 0);
            this.dgvviewbug.Name = "dgvviewbug";
            this.dgvviewbug.ReadOnly = true;
            this.dgvviewbug.Size = new System.Drawing.Size(828, 476);
            this.dgvviewbug.TabIndex = 0;
            this.dgvviewbug.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvviewbug_CellContentClick);
            // 
            // Viewbug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 476);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(844, 515);
            this.MinimumSize = new System.Drawing.Size(844, 515);
            this.Name = "Viewbug";
            this.Text = "Viewbug";
            this.Load += new System.EventHandler(this.Viewbug_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewbug)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvviewbug;
    }
}