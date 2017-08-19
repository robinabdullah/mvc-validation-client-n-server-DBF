using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc_validation_client_n_server_CF.Models
{
    public class CoursMetaData
    {
        [Required, DataType(DataType.Text), StringLength(20, ErrorMessage = "Length must be less than 20")]
        public string Name { get; set; }
        [Required]
        public int Credit { get; set; }
    }
    public class StudentMetaData
    {
        [Required, StringLength(30, ErrorMessage = "Length must be less than 30")]
        public string Name { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,DataType(DataType.Date)]
        public Nullable<System.DateTime> DOB { get; set; }
        [Required]
        public Nullable<int> CourseID { get; set; }
    }
}