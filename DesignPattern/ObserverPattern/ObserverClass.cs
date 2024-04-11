using System;

namespace ObserverPattern
{
    // ReSharper disable once InvalidXmlDocComment
    /// <summary>
    /// 观察者对象类
    /// </summary>

    //方法实现 不继承接口 A
    // public class ObserverClass
    // {
    //     public string Name { get; set; }
    //     public string Code { get; set; }
    //     public string Info { get; set; }
    //
    //     public ObserverClass(string name)
    //     {
    //         this.Name = name;
    //     }
    //
    //     public void RenovateInfo(ThemeClass theme)
    //     {
    //         Code = theme.Code;
    //         Info = theme.Info;
    //         Console.WriteLine($"{Name}收到主题更新通知：名称修改为{theme.Code}，信息修改为{theme.Info}");
    //     }
    // }

    
    /// <summary>
    /// 实现接口规范
    /// </summary>
    // public class ObserverClass : IFServer
    // {
    //     public string Name { get; set; }
    //     public string Code { get; set; }
    //     public string Info { get; set; }
    //     public ObserverClass(string name)
    //     {
    //         this.Name = name;
    //     }
    //     public void RenovateInfo(ThemeClass theme)
    //     {
    //         Code = theme.Code;
    //         Info = theme.Info;
    //         Console.WriteLine($"{Name}收到主题更新通知：名称修改为{theme.Code}，信息修改为{theme.Info}");
    //     }
    // }
    
    
    /// <summary>
    /// 实现委托通知的更新
    /// </summary>
    public class ObserverClass
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Info { get; set; }
        public ObserverClass(string name)
        {
            this.Name = name;
        }
        public void RenovateInfo(object sender)
        {
            ThemeClass theme = sender as ThemeClass;
            Code = theme.Code;
            Info = theme.Info;
            Console.WriteLine($"{Name}收到主题更新通知：名称修改为{theme.Code}，信息修改为{theme.Info}");
        }
    }
    
    /*
     * 意图：定义对象间的一种一对多的关系，当一个对象的状态发生改变，所有依赖于它的对象都得到通知并自动更新。
     * 解决：一个对象状态改变给其他对象通知的问题，而且要考虑到易用和低耦合，保证高度协作。
     * 使用：一个对象的状态发生改变，所有的依赖对象（观察者对象）都将得到通知，进行广播通知。
     * 主要：使用面向对象技术，可以将这种依赖关系弱化。
     * 关键代码，用一个ArrayList存放观察者，发生改变时去全部通知。
     * 优点：建立一套触发机制将观察者和被观察者抽象耦合。
     * 缺点：通知每个观察者都需要时间，观察者不知道被观察者是合适如何发生变化的，如果观察目标和观察者直接有循环依赖的话，会触发相互的循环调用
     * ，可能导致系统崩溃
     */
}