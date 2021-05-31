using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    [Table("Students", Schema = "public")]
    public class StudentClass
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SID { get; set; }
        public String firstname { get; set; }
        public String lastname { get; set; }
     
        public int room_id { get; set; }
        [ForeignKey("room_id")]
        public Rooms rooms { get; set; }
        public int group_id { get; set; }
        [ForeignKey("group_id")]
        public Groups groups{ get; set; }
    }
}