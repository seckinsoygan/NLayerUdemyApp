namespace NLayer.Core
{
    public class Product : BaseEntity
    {

        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }
        //public ProductFeature? productFeature { get; set; }   ? : Kullanımı nullable yani null değer alabilir anlamına gelir referans tipler için.
    }
}
