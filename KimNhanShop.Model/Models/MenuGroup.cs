using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KimNhanShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// chỉ ra ID này tự tăng, tương ứng với việc set Identity trong SQL
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        public virtual IEnumerable<Menu> Menus { set; get; }
    }
}