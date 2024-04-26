using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 刘冲 2024-04-26
    /// 依赖抽象
    /// </summary>
    public class Foo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
    public abstract class FooRepository
    {
        public abstract Task<Foo> Query();
        public abstract Task<bool> Add(Foo foo);
    }

    public interface IFooRepository
    {
        Task<Foo> Query();
        Task<bool> Add(Foo foo);
    }

    public class MysqlFooRepository
    {
        
    }

    public class OracleFooRepository
    {
        
    }

    public class HttpFooRepository
    {
        
    }
}