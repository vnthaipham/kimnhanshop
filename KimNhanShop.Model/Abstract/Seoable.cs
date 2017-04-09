using System.ComponentModel.DataAnnotations;

namespace KimNhanShop.Model.Abstract
{
    public abstract class Seoable : ISeoable
    {
        [MaxLength(256)]
        public abstract string MetaDescripton { get; set; }

        [MaxLength(256)]
        public abstract string MetaKeyword { get; set; }
    }
}