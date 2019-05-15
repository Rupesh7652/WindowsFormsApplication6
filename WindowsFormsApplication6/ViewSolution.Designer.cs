namespace WindowsFormsApplication6
{
    partial class ViewSolution
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
            this.dgvsolutions = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsolutions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvsolutions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 451);
            this.panel1.TabIndex = 0;
            // 
            // dgvsolutions
            // 
            this.dgvsolutions.AllowUserToAddRows = false;
            this.dgvsolutions.AllowUserToDeleteRows = false;
            this.dgvsolutions.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvsolutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsolutions.Location = new System.Drawing.Point(0, 0);
            this.dgvsolutions.Name = "dgvsolutions";
            this.dgvsolutions.ReadOnly = true;
            this.dgvsolutions.Size = new System.Drawing.Size(838, 451);
            this.dgvsolutions.TabIndex = 0;
            // 
            // ViewSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 451);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(854, 490);
            this.MinimumSize = new System.Drawing.Size(854, 490);
            this.Name = "ViewSolution";
            this.Text = "ViewSolution";
            this.Load += new System.EventHandler(this.ViewSolution_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsolutions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvsolutions;
    }
}