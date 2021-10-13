using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewFinal.Models
{
    public class CourseEntity
    {
        public CourseEntity()
        {
            listUser = new List<UserEntity>();
            
        }
        public List<UserEntity> listUser { get; set; }
        public CourseCategoryEntity CourseCategory { get; set; }
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Need to input name")]
        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }
    
}
}