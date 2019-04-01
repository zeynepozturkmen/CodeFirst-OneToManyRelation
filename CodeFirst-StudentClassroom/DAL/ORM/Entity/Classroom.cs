using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_StudentClassroom.DAL.ORM.Entity
{
    public class Classroom //sınıf
    {
        public Classroom()
        {
            this.students = new HashSet<Student>();
        }

        [Key] //Data annotation
        public int ClassroomID { get; set; } //sınıf ID

        public string Description { get; set; } //sınıf aciklama

        public virtual ICollection<Student> students { get; set; } //Bir sınıfta birden fazla öğrenci olur.Bire çok ilişki(one to many)
    }
}
