using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnApp.Web.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


       
        public int ClassRoomID { get; set; }

        //[ForeignKey("ClassRoomId")]
        public ClassRoom ClassRoom { get; set; }

    }
}
