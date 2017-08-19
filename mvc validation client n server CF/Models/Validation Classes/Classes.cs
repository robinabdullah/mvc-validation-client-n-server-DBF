using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc_validation_client_n_server_CF.Models
{
    [MetadataType(typeof(CoursMetaData))]
    public partial class Cours
    {

    }
    [MetadataType(typeof(StudentMetaData))]
    public partial class Student
    {
    }
}