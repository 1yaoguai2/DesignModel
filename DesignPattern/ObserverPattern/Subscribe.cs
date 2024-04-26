using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    
    ///刘冲，创建时间2024-04-26
    public class Observable<T>
    {
        private List<Subscribe> _subscribes;

        public Observable()
        {
            _subscribes = new List<Subscribe>();
        }

        public void Subscribe(Subscribe subscribe)
        {
            _subscribes.Add(subscribe);
        }

        public void Notify(T t)
        {
            Console.WriteLine($"可观察对象通知观察者，通知内容为：{t}");
            Console.WriteLine();
            foreach (var subscribe in _subscribes)
            {
                subscribe.Excute(t);
            }
        }
    }


    public abstract class Subscribe
    {
        private string _name;

        public string Name => _name;

        public Subscribe(string name)
        {
            _name = name;
        }

        public virtual void Excute<T>(T t)
        {
            Console.WriteLine($"[{_name}] 观察到了 {t}");
        }
    }


    public class XuSubscribe : Subscribe
    {
        private int _id;
        public XuSubscribe() : base("我是徐")
        {
            _id = 10;
        }

        public override void Excute<T>(T t)
        {
            base.Excute(t);
            Console.WriteLine("11111");
            Console.WriteLine(_id);
        }
    }

    public class XinSubscribe : Subscribe
    {
        public XinSubscribe() : base("我是鑫哥")
        {
        }

        public override void Excute<T>(T t)
        {
            base.Excute(t);
            Console.WriteLine("22222");
        }
    }
}