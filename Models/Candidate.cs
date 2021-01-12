
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactDotNetApp.Models
{
    public class Candidate
    {
        [Key]
        public int id { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string fullName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string email { get; set; }
        
        [Column(TypeName = "nvarchar(20)")]
        public string mobile { get; set; }
        
        public int age { get; set; }
        
        [Column(TypeName = "nvarchar(5)")]
        public string bloodGroup { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string address { get; set; }
        
    }
}