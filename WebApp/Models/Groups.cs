using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    [Table("Groups", Schema = "public")]
    public class Groups
    {
        [Key]
        public int group_id { get; set; }
        public String name { get; set; }

        public ICollection<StudentClass> Students { get; set; }
    }
}