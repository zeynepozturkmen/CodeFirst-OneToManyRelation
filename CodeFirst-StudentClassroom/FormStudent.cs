using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst_StudentClassroom.DAL.ORM.Entity;

namespace CodeFirst_StudentClassroom
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        StudentClassroomContext db = new StudentClassroomContext();

        private void FormStudent_Load(object sender, EventArgs e)
        {
            FillStudent();
            FillClassroom();

        }

        //DataGridi öğrenci listesiyle doldurma.
        private void FillStudent()
        {
            var FillStudent = db.Students.Select(x => new
            {
                x.StudentID,
                x.FullName,
                x.ClassroomID,
                x.classroom.Description,
 
            }).ToList();
            dtGridStudent.DataSource = FillStudent;
        }

        //ComboBox'ı sınıf isimleriyle doldurma
        private void FillClassroom()
        {
            var FillClassroom = db.Classrooms.Select(x => x).ToList();
            cmbClassroom.DisplayMember = "Description";
            cmbClassroom.ValueMember = "ClassroomID";
            cmbClassroom.DataSource = FillClassroom;

        }

        //Ogrenci Ekle
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FullName = txtFullName.Text;
            student.ClassroomID = (int)cmbClassroom.SelectedValue;
            db.Students.Add(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci eklendi");
            FillStudent();
        }

        //Student Delete
        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (dtGridStudent.SelectedRows.Count == 1)
            {


                int seciliStudentID = (int)dtGridStudent.CurrentRow.Cells["StudentID"].Value;
                var deleteStudent = db.Students.Where(x => x.StudentID == seciliStudentID).Single();
                db.Students.Remove(deleteStudent);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                FillStudent();
            }
            else
            {
                MessageBox.Show("Birden fazla kayıt seçtiniz.Lütfen 'çoklu kayıt sildirme' butonunu kullanınız ya da birden fazla kayıt seçip tekrar deneyiniz.");
            }



        }

        int studentID;
        //DataGridde seçili öğrencinin bilgilerini textBox'a ve comboBox'a getirme
        private void dtGridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
             studentID =(int)dtGridStudent.CurrentRow.Cells["StudentID"].Value;

            var kıyaslaStudent = db.Students.Where(x => x.StudentID== studentID ).FirstOrDefault();
            txtFullName.Text = kıyaslaStudent.FullName;
            cmbClassroom.SelectedValue = kıyaslaStudent.ClassroomID;


        }

        //Student Update
        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            var student = db.Students.Find(studentID);
            student.FullName = txtFullName.Text;
            student.ClassroomID = (int)cmbClassroom.SelectedValue;

            db.SaveChanges();
            MessageBox.Show("Güncellendi");
            FillStudent();


        }

        //Coklu kayıt sildirme
        private void btnCokluKayitSilme_Click(object sender, EventArgs e)
        {
            if (dtGridStudent.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow item in dtGridStudent.SelectedRows)
                {
                    int FindStudentID = Convert.ToInt32(item.Cells[0].Value);
                    var FindStudent = db.Students.Find(FindStudentID);
                    db.Students.Remove(FindStudent);
                    db.SaveChanges();

                }
                FillStudent();
                MessageBox.Show("Seçilen kayıtlar silindi.");

            }

            else
            {
                MessageBox.Show("Bir kayıt seçtiniz.Lütfen 'delete' butonunu kullanınız ya da birden fazla kayıt seçip tekrar deneyiniz.");
            }


        }
    }
}
