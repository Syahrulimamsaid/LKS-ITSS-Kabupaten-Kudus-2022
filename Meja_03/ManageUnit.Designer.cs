namespace Meja_03
{
    partial class ManageUnit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UNID = new System.Windows.Forms.TextBox();
            this.UNIT = new System.Windows.Forms.TextBox();
            this.CARI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.INSERT = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.SVINSERT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Unit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(519, 305);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unit ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unit Item";
            // 
            // UNID
            // 
            this.UNID.Location = new System.Drawing.Point(144, 149);
            this.UNID.Name = "UNID";
            this.UNID.Size = new System.Drawing.Size(202, 22);
            this.UNID.TabIndex = 4;
            // 
            // UNIT
            // 
            this.UNIT.Location = new System.Drawing.Point(144, 212);
            this.UNIT.Name = "UNIT";
            this.UNIT.Size = new System.Drawing.Size(202, 22);
            this.UNIT.TabIndex = 5;
            // 
            // CARI
            // 
            this.CARI.Location = new System.Drawing.Point(697, 91);
            this.CARI.Name = "CARI";
            this.CARI.Size = new System.Drawing.Size(202, 22);
            this.CARI.TabIndex = 7;
            this.CARI.TextChanged += new System.EventHandler(this.CARI_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(597, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search";
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(23, 337);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(87, 40);
            this.INSERT.TabIndex = 8;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(147, 337);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(87, 40);
            this.UPDATE.TabIndex = 9;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(269, 337);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(87, 40);
            this.DELETE.TabIndex = 10;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.Location = new System.Drawing.Point(23, 384);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(333, 40);
            this.CANCEL.TabIndex = 11;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // SVINSERT
            // 
            this.SVINSERT.Location = new System.Drawing.Point(23, 337);
            this.SVINSERT.Name = "SVINSERT";
            this.SVINSERT.Size = new System.Drawing.Size(87, 40);
            this.SVINSERT.TabIndex = 12;
            this.SVINSERT.Text = "SAVE";
            this.SVINSERT.UseVisualStyleBackColor = true;
            this.SVINSERT.Click += new System.EventHandler(this.SVINSERT_Click);
            // 
            // ManageUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 436);
            this.Controls.Add(this.SVINSERT);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.CARI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UNIT);
            this.Controls.Add(this.UNID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ManageUnit";
            this.Text = "ManageUnit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UNID;
        private System.Windows.Forms.TextBox UNIT;
        private System.Windows.Forms.TextBox CARI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Button SVINSERT;
    }
}