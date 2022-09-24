namespace NLayer.Core
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
