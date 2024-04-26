using System;

namespace ObserverPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var o = new Observable<long>();
            XuSubscribe xu = new XuSubscribe();
            Subscribe xin = new XinSubscribe();
            
            o.Subscribe(xu);
            o.Subscribe(xin);

            while (Console.ReadLine() != "Enter")
            {
                o.Notify(DateTimeOffset.Now.ToUnixTimeSeconds());
            }

            //****
            //实现普通的观察者模式 A
            // ThemeClass themeObject = new ThemeClass("小更新","修复记忆");
            // themeObject.Code = "重大跟新";
            // themeObject.Info = "修改学习方向，修改学习方法";
            // ObserverClass newObserverObject = new ObserverClass("初学者");
            // themeObject.observerObject = newObserverObject;
            // themeObject.Update();
            //-初学者收到主题更新通知：名称修改为重大跟新，信息修改为修改学习方向，修改学习方法
            //****
            //实现接口规范后的观察者模式
            // ThemeClass themeObject = new ThemeObjectClass("接口更新", "使用接口跟新观察者");
            // //添加订阅者
            // themeObject.AddObserverObject(new ObserverClass("xiaoxu"));
            // var observerObject = new ObserverClass("xiaocheng");
            // themeObject.AddObserverObject(observerObject);
            // themeObject.Update();
            // //移除一个订阅者
            // themeObject.RemoveObserverObject(observerObject);
            // themeObject.Update();
            //-xiaoxu收到主题更新通知：名称修改为接口更新，信息修改为使用接口跟新观察者
            //-xiaocheng收到主题更新通知：名称修改为接口更新，信息修改为使用接口跟新观察者
            //-xiaoxu收到主题更新通知：名称修改为接口更新，信息修改为使用接口跟新观察者
            //****


            // //实现委托通知观察者
            // ThemeClass themeObject = new ThemeObjectClass("委托跟新", "使用委托通知订阅者跟新");
            // ObserverClass observerObject1 = new ObserverClass("xiaowang");
            // ObserverClass observerObject2 = new ObserverClass("dawang");
            // //添加订阅者
            // themeObject.AddObserverObject(new RenovateEventHandler(observerObject1.RenovateInfo));
            // themeObject.AddObserverObject(new RenovateEventHandler(observerObject2.RenovateInfo));
            // themeObject.Update();
            // //移除一个订阅者
            // themeObject.RemoveObserverObject(new RenovateEventHandler(observerObject1.RenovateInfo));
            // themeObject.Update();


            //-xiaowang收到主题更新通知：名称修改为委托跟新，信息修改为使用委托通知订阅者跟新
            //-dawang收到主题更新通知：名称修改为委托跟新，信息修改为使用委托通知订阅者跟新
            //-dawang收到主题更新通知：名称修改为委托跟新，信息修改为使用委托通知订阅者跟新

            Console.ReadKey();
        }

        /*
         * 观察者模式 关键字
         * 一对多的依赖关系
         * 主题跟新时通知所有依赖者，依赖对象收到通知后自我跟新
         * 两个主要对象，观察者对象，主题对象
         * 抽象主题角色 抽象观察者角色 具体主题角色 具体观察者角色
         * 接口规范
         * 委托（object） 强制转换（拆箱）
         * 低耦合，依赖，不知道需要通知的对象
         */
    }
}