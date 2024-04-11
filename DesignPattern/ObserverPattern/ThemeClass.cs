using System.Collections.Generic;

namespace ObserverPattern
{
    //定义一个委托
    public delegate void RenovateEventHandler(object sender);
    
    /// <summary>
    /// 主题对象类
    /// </summary>
    public class ThemeClass //订阅号抽象类
    {
        public string Code { get; set; }
        public string Info { get; set; }

        public ThemeClass(string code, string info)
        {
            this.Code = code;
            this.Info = info;
        }
        //普通方法实现 A
        // public ObserverClass observerObject;
        // public void Update()
        // {
        //     if (observerObject != null)
        //     {
        //         observerObject.RenovateInfo(this);
        //     }
        // }

        #region 使用接口
        // //使用接口实现规范化观察者
        // //观察者列表
        // public List<IFServer> ObServers = new List<IFServer>();
        //
        // /// <summary>
        // /// 新增
        // /// </summary>
        // /// <param name="observer"></param>
        // public void AddObserverObject(IFServer observer)
        // {
        //     if (!ObServers.Exists(t => t == observer))
        //     {
        //         ObServers.Add(observer);
        //     }
        // }
        //
        // /// <summary>
        // /// 移除
        // /// </summary>
        // /// <param name="observer"></param>
        // public void RemoveObserverObject(IFServer observer)
        // {
        //     if (ObServers.Exists(t => t == observer))
        //     {
        //         ObServers.Remove(observer);
        //     }
        // }
        //
        // /// <summary>
        // /// 更新
        // /// </summary>
        // public void Update()
        // {
        //     foreach (var ob in ObServers)
        //     {
        //         if (ob != null)
        //         {
        //             ob.RenovateInfo(this);
        //         }
        //     }
        // }

        #endregion

        #region 使用委托
        //使用委托实现通知观察者
        
        //实例化委托
        private RenovateEventHandler _renovateEvent;

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="observer"></param>
        public void AddObserverObject(RenovateEventHandler renovateEvent)
        {
            _renovateEvent += renovateEvent;
        }

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserverObject(RenovateEventHandler renovateEvent)
        {
            _renovateEvent -= renovateEvent;
        }

        /// <summary>
        /// 更新
        /// </summary>
        public void Update()
        {
            _renovateEvent?.Invoke(this);
        }
        #endregion
    }

    /// <summary>
    /// 具体订阅号类
    /// </summary>
    public class ThemeObjectClass : ThemeClass
    {
        public ThemeObjectClass(string code, string info) : base(code, info)
        {
        }
    }
}