using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class BaseEntity
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}