using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewFinal.Models
{
    public class UserEntity
    {
        public UserEntity()
        {
            listCourse = new List<CourseEntity>();
        }

        public int Id { get; set; }
        
        [Required(ErrorMessage ="Need input Role")]
        public string Role { get; set; }
        [Required(ErrorMessage = "Need to input name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Need to input Education")]
        public string Education { get; set; }
        [Required(ErrorMessage = "Need to input Age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Need to input DoB")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        public string ProgrammingLanguage { get; set; }
        [Required(ErrorMessage = "Need to input Toeic")]
        public float Toeic { get; set; }

        public string Experience { get; set; }

        public string Department { get; set; }

        public string Location { get; set; }

        public string Type { get; set; }
      

        public string WorkingPlace { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public int CourseAssignId { get; set; }

        public List<CourseEntity> listCourse { get; set; }


        public string ToSeparatedString(string separator)
        {
            return $"{this.Id}{separator}" +
                $"{this.Name}{separator}" +
                $"{this.Education}{separator}" +
                $"{this.Type}{separator}" +              
                $"{this.WorkingPlace}"+
                $"{this.Age}{separator}" +
                $"{this.DoB}";
        }


        

    }
}