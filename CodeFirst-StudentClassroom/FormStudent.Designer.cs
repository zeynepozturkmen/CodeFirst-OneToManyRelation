namespace CodeFirst_StudentClassroom
{
    partial class FormStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.dtGridStudent = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCokluKayitSilme = new System.Windows.Forms.Button();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentUpdate = new System.Windows.Forms.Button();
            this.cmbClassroom = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-274, -14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sınıf :";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(183, 27);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(104, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // dtGridStudent
            // 
            this.dtGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridStudent.Location = new System.Drawing.Point(9, 156);
            this.dtGridStudent.Name = "dtGridStudent";
            this.dtGridStudent.ReadOnly = true;
            this.dtGridStudent.Size = new System.Drawing.Size(589, 134);
            this.dtGridStudent.TabIndex = 4;
            this.dtGridStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridStudent_CellClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(299, 21);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 38);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Ekle";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnCokluKayitSilme);
            this.groupBox1.Controls.Add(this.btnStudentDelete);
            this.groupBox1.Controls.Add(this.btnStudentUpdate);
            this.groupBox1.Controls.Add(this.cmbClassroom);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.dtGridStudent);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 345);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci İşlemleri";
            // 
            // btnCokluKayitSilme
            // 
            this.btnCokluKayitSilme.Location = new System.Drawing.Point(391, 21);
            this.btnCokluKayitSilme.Name = "btnCokluKayitSilme";
            this.btnCokluKayitSilme.Size = new System.Drawing.Size(75, 38);
            this.btnCokluKayitSilme.TabIndex = 9;
            this.btnCokluKayitSilme.Text = "Çoklu Kayıt Silme";
            this.btnCokluKayitSilme.UseVisualStyleBackColor = true;
            this.btnCokluKayitSilme.Click += new System.EventHandler(this.btnCokluKayitSilme_Click);
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(299, 65);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(75, 38);
            this.btnStudentDelete.TabIndex = 8;
            this.btnStudentDelete.Text = "Sil";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnStudentUpdate
            // 
            this.btnStudentUpdate.Location = new System.Drawing.Point(391, 65);
            this.btnStudentUpdate.Name = "btnStudentUpdate";
            this.btnStudentUpdate.Size = new System.Drawing.Size(75, 38);
            this.btnStudentUpdate.TabIndex = 7;
            this.btnStudentUpdate.Text = "Güncelle";
            this.btnStudentUpdate.UseVisualStyleBackColor = true;
            this.btnStudentUpdate.Click += new System.EventHandler(this.btnStudentUpdate_Click);
            // 
            // cmbClassroom
            // 
            this.cmbClassroom.FormattingEnabled = true;
            this.cmbClassroom.Location = new System.Drawing.Point(183, 70);
            this.cmbClassroom.Name = "cmbClassroom";
            this.cmbClassroom.Size = new System.Drawing.Size(104, 21);
            this.cmbClassroom.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.DataGridView dtGridStudent;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbClassroom;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentUpdate;
        private System.Windows.Forms.Button btnCokluKayitSilme;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}