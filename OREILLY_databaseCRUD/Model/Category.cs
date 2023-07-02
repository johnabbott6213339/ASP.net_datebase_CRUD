using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OREILLY_databaseCRUD.Models
{


    [Table("Category")]
    [Serializable]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; } 

        public string Title { get; set; }
        public string Author { get; set; }
    }
}
