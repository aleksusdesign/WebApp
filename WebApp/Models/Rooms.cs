using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    [Table("Rooms", Schema = "public")]
    public class Rooms
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int room_id { get; set; }
        public int capacity { get; set; }
        public int countOfFreePlaces { get; set; }

        public ICollection<StudentClass> students { get; set; }
    }
}