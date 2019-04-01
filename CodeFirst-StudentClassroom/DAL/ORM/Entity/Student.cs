using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CodeFirst_StudentClassroom.DAL.ORM.Entity
{
   public class Student //öğrenci sınıfı
    {
        [Key] //data annotation
        public int StudentID { get; set; } //ögrenci ID

        public string FullName { get; set; } //ögrenci ad-soyad


        public int ClassroomID { get; set; } //sınıf ID

        public virtual Classroom classroom { get; set; } //Bir öğrencinin bir sınıfa ait oldugunu gösterir.



    }
}
