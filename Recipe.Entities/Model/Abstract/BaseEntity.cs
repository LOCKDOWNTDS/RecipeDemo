namespace Recipe.Entities.Model.Abstract
{
    public abstract class BaseEntity<T>
    {
        public T ID { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
