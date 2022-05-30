
namespace Week14_praktikum_Timotius_Septian_0706022110022
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
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.lbl_teamname = new System.Windows.Forms.Label();
            this.lbl_stadium = new System.Windows.Forms.Label();
            this.lbl_namamanager = new System.Windows.Forms.Label();
            this.lbl_manager = new System.Windows.Forms.Label();
            this.lbl_namateam = new System.Windows.Forms.Label();
            this.lbl_namastadium = new System.Windows.Forms.Label();
            this.lbl_pencetak = new System.Windows.Forms.Label();
            this.lbl_topscore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_pelanggaran = new System.Windows.Forms.Label();
            this.dgv_lastmatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lastmatch)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(81, 41);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 67);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(220, 41);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 67);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(397, 41);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 67);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(525, 41);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 67);
            this.btn_last.TabIndex = 3;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // lbl_teamname
            // 
            this.lbl_teamname.AutoSize = true;
            this.lbl_teamname.Location = new System.Drawing.Point(78, 136);
            this.lbl_teamname.Name = "lbl_teamname";
            this.lbl_teamname.Size = new System.Drawing.Size(101, 17);
            this.lbl_teamname.TabIndex = 4;
            this.lbl_teamname.Text = "Team Name   :";
            // 
            // lbl_stadium
            // 
            this.lbl_stadium.AutoSize = true;
            this.lbl_stadium.Location = new System.Drawing.Point(78, 226);
            this.lbl_stadium.Name = "lbl_stadium";
            this.lbl_stadium.Size = new System.Drawing.Size(107, 17);
            this.lbl_stadium.TabIndex = 5;
            this.lbl_stadium.Text = "Stadium           :";
            // 
            // lbl_namamanager
            // 
            this.lbl_namamanager.AutoSize = true;
            this.lbl_namamanager.Location = new System.Drawing.Point(217, 181);
            this.lbl_namamanager.Name = "lbl_namamanager";
            this.lbl_namamanager.Size = new System.Drawing.Size(60, 17);
            this.lbl_namamanager.TabIndex = 6;
            this.lbl_namamanager.Text = ".............";
            // 
            // lbl_manager
            // 
            this.lbl_manager.AutoSize = true;
            this.lbl_manager.Location = new System.Drawing.Point(78, 181);
            this.lbl_manager.Name = "lbl_manager";
            this.lbl_manager.Size = new System.Drawing.Size(104, 17);
            this.lbl_manager.TabIndex = 7;
            this.lbl_manager.Text = "Manager         :";
            // 
            // lbl_namateam
            // 
            this.lbl_namateam.AutoSize = true;
            this.lbl_namateam.Location = new System.Drawing.Point(217, 136);
            this.lbl_namateam.Name = "lbl_namateam";
            this.lbl_namateam.Size = new System.Drawing.Size(64, 17);
            this.lbl_namateam.TabIndex = 8;
            this.lbl_namateam.Text = "..............";
            // 
            // lbl_namastadium
            // 
            this.lbl_namastadium.AutoSize = true;
            this.lbl_namastadium.Location = new System.Drawing.Point(217, 226);
            this.lbl_namastadium.Name = "lbl_namastadium";
            this.lbl_namastadium.Size = new System.Drawing.Size(68, 17);
            this.lbl_namastadium.TabIndex = 9;
            this.lbl_namastadium.Text = "...............";
            // 
            // lbl_pencetak
            // 
            this.lbl_pencetak.AutoSize = true;
            this.lbl_pencetak.Location = new System.Drawing.Point(217, 264);
            this.lbl_pencetak.Name = "lbl_pencetak";
            this.lbl_pencetak.Size = new System.Drawing.Size(88, 17);
            this.lbl_pencetak.TabIndex = 10;
            this.lbl_pencetak.Text = "....................";
            // 
            // lbl_topscore
            // 
            this.lbl_topscore.AutoSize = true;
            this.lbl_topscore.Location = new System.Drawing.Point(78, 264);
            this.lbl_topscore.Name = "lbl_topscore";
            this.lbl_topscore.Size = new System.Drawing.Size(107, 17);
            this.lbl_topscore.TabIndex = 11;
            this.lbl_topscore.Text = "Top Scorer      :";
            this.lbl_topscore.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Worst Disipline :";
            // 
            // lbl_pelanggaran
            // 
            this.lbl_pelanggaran.AutoSize = true;
            this.lbl_pelanggaran.Location = new System.Drawing.Point(220, 309);
            this.lbl_pelanggaran.Name = "lbl_pelanggaran";
            this.lbl_pelanggaran.Size = new System.Drawing.Size(84, 17);
            this.lbl_pelanggaran.TabIndex = 13;
            this.lbl_pelanggaran.Text = "...................";
            // 
            // dgv_lastmatch
            // 
            this.dgv_lastmatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lastmatch.Location = new System.Drawing.Point(81, 354);
            this.dgv_lastmatch.Name = "dgv_lastmatch";
            this.dgv_lastmatch.RowHeadersWidth = 51;
            this.dgv_lastmatch.RowTemplate.Height = 24;
            this.dgv_lastmatch.Size = new System.Drawing.Size(638, 345);
            this.dgv_lastmatch.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 725);
            this.Controls.Add(this.dgv_lastmatch);
            this.Controls.Add(this.lbl_pelanggaran);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_topscore);
            this.Controls.Add(this.lbl_pencetak);
            this.Controls.Add(this.lbl_namastadium);
            this.Controls.Add(this.lbl_namateam);
            this.Controls.Add(this.lbl_manager);
            this.Controls.Add(this.lbl_namamanager);
            this.Controls.Add(this.lbl_stadium);
            this.Controls.Add(this.lbl_teamname);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lastmatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Label lbl_teamname;
        private System.Windows.Forms.Label lbl_stadium;
        private System.Windows.Forms.Label lbl_namamanager;
        private System.Windows.Forms.Label lbl_manager;
        private System.Windows.Forms.Label lbl_namateam;
        private System.Windows.Forms.Label lbl_namastadium;
        private System.Windows.Forms.Label lbl_pencetak;
        private System.Windows.Forms.Label lbl_topscore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pelanggaran;
        private System.Windows.Forms.DataGridView dgv_lastmatch;
    }
}

