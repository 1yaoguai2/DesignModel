using System;

namespace SingletonModel
{
    //sealed 密封的，不可被继承 
    public sealed class SingletonClass
    {
        //没有创建单例模式时，普通类 0，构造函数必须为公开的
        private DateTime NowTime { get; set; }

        private SingletonClass()
        {
            NowTime = DateTime.Now;
            Console.WriteLine($"实例化时间：{NowTime}");
        }

        //普通单例模式 A
        // private static SingletonClass instance = null;
        //
        // public static SingletonClass Instance()
        // {
        //     if (instance == null)
        //     {
        //         instance = new SingletonClass();
        //     }
        //     return instance;
        // }

        //多单线程和多线程适用的单例模式 B
        //public static SingletonClass Instance = new SingletonClass();

        //线程锁单例模式 C
        // private static readonly object locker = new object(); //对象锁 ,性能差
        //
        // private static SingletonClass instance;
        //
        // public static SingletonClass Instance
        // {
        //     get
        //     {
        //         lock (locker)
        //         {
        //             if (instance == null)
        //             {
        //                 instance = new SingletonClass();
        //             }
        //             return instance;
        //         }
        //     }
        // }

        //双重验证线程锁单例模式 D
        // private static readonly object locker = new object();
        //
        // private static SingletonClass instance;
        //
        // public static SingletonClass Instance
        // {
        //     get
        //     {
        //         if (instance == null)   //降低访问时的性能消耗
        //         {
        //             lock (locker)
        //             {
        //                 if (instance == null)
        //                 {
        //                     instance = new SingletonClass();
        //                 }
        //             }
        //         }
        //         return instance;
        //     }
        //     
        // }

        //饿汉模式,使用静态初始化方法，保证线程安全 E
        // private static readonly SingletonClass instance = new SingletonClass();
        // //静态
        // static SingletonClass()
        // {
        // }
        // //构造函数已经有了
        // // private SingletonClass()
        // // {
        // //     
        // // }
        // public static SingletonClass Instance
        // {
        //     get { return instance; }
        // }


        //懒汉模式,利用嵌套类，当嵌套类的成员第一次被引用，才会触发实例化 F
        // public static SingletonClass Instance
        // {
        //     get { return Nested.instance; }
        // }
        //
        // private class Nested    //嵌套的
        // {
        //     static Nested()
        //     {
        //     }
        //     internal static readonly SingletonClass instance = new SingletonClass(); //内部的只读实例
        // }
        
        //Lazy泛型实现延迟实例化，会隐式调用LazyThreadSafetyMode.ExecutionAndPublication以实现lazy<Singleton>线程安全模式. G
        private static readonly Lazy<SingletonClass> lazy = new Lazy<SingletonClass>(() => new SingletonClass());
        
        public static SingletonClass Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        
        //ICO容器单例注册 prism
    }

    /*
     * 单列模式，提供了一种实例化类的最佳方式。
     * 1.单例模式只能有一个实例。
     * 2.单例类必须创建自己的唯一实例。
     * 3.单例类必须给其他所有对象提供这一实例。（static）
     *
     * 意图：保证该类只有一个实例，并提供一个全局访问点。
     * 解决：一个全局都需要使用的类频繁创建与销毁。
     * 使用：节省系统资源，控制多对象管理类（manager）的数目。
     * 创建：判断系统是否存在单例，有则返回使用，无则创建。
     * 关键：构造函数是私有的，自己负责实例化自己。
     *
     * 优点：在内存中只有一个实例，减少了内存开销和频繁的创建和销毁操作；避免对资源的多重占用（例文件操作）。
     * 缺点：没有接口，无法继承；与单一职责原则冲突（一个类只关系内部逻辑，而不关心外面的如何实例化和使用）。
     * 网站：https://blog.csdn.net/q__y__L/article/details/120007527
     */
}