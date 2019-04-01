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
    public partial class FormClassroom : Form  //Sınıf
    {
        public FormClassroom() 
        {
            InitializeComponent();
        }

        StudentClassroomContext db = new StudentClassroomContext();
        
        private void FillClassroom()  //datagridi SınıfID ve açıklaması ile doldurma
        {
            var FillClassroom = db.Classrooms.Select(x =>new
            {
                x.ClassroomID,
                x.Description,
            }).ToList();
            dtGridClassroom.DataSource = FillClassroom;
         
        }

        private void FormClassroom_Load(object sender, EventArgs e) //form yuklendiğinde dataGridi sınıf bilgileri ile doldurma
        {
            FillClassroom();
        }

        private void btnInsert_Click(object sender, EventArgs e)  //sınıf ekleme
        {
            Classroom classRoom=new Classroom();
            classRoom.Description = txtDescription.Text;

            db.Classrooms.Add(classRoom);
            db.SaveChanges();
            MessageBox.Show("Eklendi");

            FillClassroom();

        }

        //sınıf silme
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dtGridClassroom.SelectedRows.Count == 1)
            {


                //dataGriddeki seçili satırın classroomID'sini alıyor.
                int classroomID = (int)dtGridClassroom.CurrentRow.Cells[0].Value;
                //Bu classroomID'ye göre tabloda kaydı buluyor.
                var removeClassroom = db.Classrooms.Find(classroomID);
                //ve siliyor.
                db.Classrooms.Remove(removeClassroom);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                FillClassroom();
            }
            else
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz ya da çoklu satır sildirme butonunu kullanınız.");
            }

        }


        //Classroom update işlemi
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int secilenClassroomID = (int)dtGridClassroom.CurrentRow.Cells[0].Value;
            // string secilenDescription = dtGridClassroom.CurrentRow.Cells[1].Value.ToString();

            var kıyaslaClassroom = db.Classrooms.Where(x => x.ClassroomID == secilenClassroomID).Single();
            kıyaslaClassroom.Description = txtDescription.Text;
            db.SaveChanges();

            MessageBox.Show("Güncellendi");
            FillClassroom();



        }


        //dataGridde bir satıra tıklandıgı an textBox'a sınıfın verisini getirme
        private void dtGridClassroom_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //dataGridde secilen kaydın ClassroomID'si ve Descriptionını değişkenlere atadım.
            int secilenClassroomID = (int)dtGridClassroom.CurrentRow.Cells[0].Value;
            string secilenDescription = dtGridClassroom.CurrentRow.Cells[1].Value.ToString();

            var kıyaslaClassroom = db.Classrooms.Where(x => x.ClassroomID == secilenClassroomID && x.Description == secilenDescription).FirstOrDefault();

            txtDescription.Text = kıyaslaClassroom.Description;

        }


        //DataGridde birden fazla kayıt seçildiğinde toplu olarak sildirme
        private void btnCokluKayitSildirme_Click(object sender, EventArgs e)
        {
            if (dtGridClassroom.SelectedRows.Count > 1)
            {
                foreach (DataGridViewRow item in dtGridClassroom.SelectedRows)
                {
                    //dataGriddeki seçili satırın classroomID'sini alıyor.
                    int classroomID = Convert.ToInt32(item.Cells[0].Value);
                    //Bu classroomID'ye göre tabloda kaydı buluyor.
                    var removeClassroom = db.Classrooms.Find(classroomID);
                    //ve siliyor.
                    db.Classrooms.Remove(removeClassroom);
                    db.SaveChanges();
             
                  


                }
                FillClassroom();
                MessageBox.Show("Silindi");
            }

            else
            {
                MessageBox.Show("Bir kayıt seçtiniz lütfen delete tuşuna basınız.");
            }

        }

    }
}
