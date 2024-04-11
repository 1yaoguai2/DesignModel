using System;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //****
            //普通类实列化 0
            //SingletonClass singletonClass1 = new SingletonClass();
            //SingletonClass singletonClass2 = new SingletonClass();
            //-实例化时间：2024/4/10 16:01:42
            //-实例化时间：2024/4/10 16:01:42
            //-结束
            //****
            //单线程调用单例模式 A
            //SingletonClass singletonClass1 = SingletonClass.Instance();
            //SingletonClass singletonClass2 = SingletonClass.Instance();
            //-实例化时间：2024/4/10 16:10:17
            //-结束
            //****
            //多线程调用不适用的单例模式 A
            // for (int i = 0; i < 10; i++)
            // {
            //     Thread thread = new Thread(() =>
            //     {
            //         SingletonClass singletonClass1 = SingletonClass.Instance();
            //         SingletonClass singletonClass2 = SingletonClass.Instance();
            //     });
            //     thread.Start();
            //     //一般使用Task.Run(),需要对长时间运行计算的人物进行精细控制
            //     // Task.Factory.StartNew(() =>
            //     // {
            //     //     SingletonClass singletonClass1 = SingletonClass.Instance();
            //     //     SingletonClass singletonClass2 = SingletonClass.Instance();
            //     // });
            // }
            //-实例化时间：2024/4/10 16:30:17  *  10  //结束
            //****
            //单线程调用单例模式 B
            //SingletonClass singletonClass1 = SingletonClass.Instance;
            //SingletonClass singletonClass2 = SingletonClass.Instance;
            //-实例化时间：2024/4/10 16:48:23
            //-结束
            //****
            //多线程调用适用的单例模式 B
            // for (int i = 0; i < 10; i++)
            // {
            //     Thread thread = new Thread(() =>
            //     {
            //         SingletonClass singletonClass1 = SingletonClass.Instance;
            //         SingletonClass singletonClass2 = SingletonClass.Instance;
            //     });
            //     thread.Start();
            //     //一般使用Task.Run(),需要对长时间运行计算的人物进行精细控制
            //     // Task.Factory.StartNew(() =>
            //     // {
            //     //     SingletonClass singletonClass1 = SingletonClass.Instance;
            //     //     SingletonClass singletonClass2 = SingletonClass.Instance;
            //     // });
            // }
            //-实例化时间：2024/4/10 16:48:23
            //-结束
            // ****
            //单线程调用单例模式 C 或 D 或 E 或 F 或 G
            //SingletonClass singletonClass1 = SingletonClass.Instance;
            //SingletonClass singletonClass2 = SingletonClass.Instance;
            //-实例化时间：2024/4/10 17:07:21
            //-结束
            //****
            //多线程调用单例模式 C
            for (int i = 0; i < 10; i++)
            {
                // Thread thread = new Thread(() =>
                // {
                //     SingletonClass singletonClass1 = SingletonClass.Instance;
                //     SingletonClass singletonClass2 = SingletonClass.Instance;
                // });
                // thread.Start();
                //一般使用Task.Run(),需要对长时间运行计算的人物进行精细控制
                Task.Factory.StartNew(() =>
                {
                    SingletonClass singletonClass3 = SingletonClass.Instance;
                    SingletonClass singletonClass4 = SingletonClass.Instance;
                });
            }
            //-实例化时间：2024/4/10 17:25:14
            //-结束
            //****


            Console.ReadKey(); 
            Console.WriteLine("结束");
        }
        
        /*
         * 关键字
         * 饿汉模式 使用静态实例化
         * 懒汉模式 只有第一次调用才自行实例化，使用嵌套类进行实例化声明，第一次调用嵌套类属性才会实例化
         * 多线程单例，Lock，双重验证
         * NET4后的Lazy泛型
         */
    }
}