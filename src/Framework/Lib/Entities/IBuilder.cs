namespace Framework.Lib.Entities
{
    public interface IBuilder<T>
    {
        T Object { get; set; }
        T Create();
    }
}
