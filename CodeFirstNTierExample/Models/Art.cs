using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Art
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Detail { get; set; }
        [DataType(DataType.ImageUrl)]
        public byte[] Image { get; set; }

        [ForeignKey("UserId")]
        public User UploadedBy { get; set; }
        public int UserId { get; set; }
    }
}
