using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPage.Models
{
    public class LoginModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity )]//Identity will takes values automatically, none --> we can give our values
        public int Id{get;set;}
        public string? UserName{get;set;}
        public string? Password{get;set;}
    }
}