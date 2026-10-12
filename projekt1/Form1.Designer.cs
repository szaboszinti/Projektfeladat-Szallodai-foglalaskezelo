namespace projekt1
{
    partial class Form1
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
            this.btnTeszt = new System.Windows.Forms.Button();
            this.dgvAdatok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdatok)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTeszt
            // 
            this.btnTeszt.Location = new System.Drawing.Point(269, 12);
            this.btnTeszt.Name = "btnTeszt";
            this.btnTeszt.Size = new System.Drawing.Size(208, 56);
            this.btnTeszt.TabIndex = 0;
            this.btnTeszt.Text = "Adatok megjelenítése";
            this.btnTeszt.UseVisualStyleBackColor = true;
            this.btnTeszt.Click += new System.EventHandler(this.btnTeszt_Click);
            // 
            // dgvAdatok
            // 
            this.dgvAdatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdatok.Location = new System.Drawing.Point(126, 74);
            this.dgvAdatok.Name = "dgvAdatok";
            this.dgvAdatok.Size = new System.Drawing.Size(505, 351);
            this.dgvAdatok.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAdatok);
            this.Controls.Add(this.btnTeszt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdatok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeszt;
        private System.Windows.Forms.DataGridView dgvAdatok;
    }
}

