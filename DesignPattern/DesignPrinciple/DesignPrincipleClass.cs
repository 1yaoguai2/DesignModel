﻿namespace DesignPrinciple
{
    public class DesignPrincipleClass
    {
        
    }
    /* 面向对象设计原则
     * --开闭原则 1.对扩展开放，模块的行为可以被扩展，从而满足新的需求。
     *           2.对修改关闭，不允许修改模块的源代码，或者使修改最小化。
     * 开闭是面向对象设计的核心，满足该原则可以达到最大限度的复用性和可维护性。
     * 努力设计无需修改的代码模块，隔离变化和不变的代码，把变化的代码抽象成稳定接口，针对接口进行编程。
     * 一般通过添加子类和重写父类来添加新代码，不修改旧的代码。
     *
     * --单一原则 每个类只负责处理一种改变，需要改变时，只需要修改对应的类，不会影响其他类。
     *
     * --接口隔离原则 表明客户端不应该被迫实现一些不会使用的接口，应该把胖接口中的方法分组，换为多个接口，每个接口服务于一个子模块。
     * 存在的胖接口，可以使用适配器模式隔离不需要的方法。
     * 接口隔离原则需要花费额外的精力和时间，会增加代码复杂性，可以生产更灵活的设计。过度使用会产生大量的包含单一方法的接口。
     *
     * --里氏替换原则 是对开闭原则的扩展，表面创建基类的新子类时，不应该改变基类的行为。只扩展父类而不替换功能。
     * 当一个程序模块使用基类时，基类的引用可以被子类替换而不影响模块功能。
     *
     * --依赖倒转原则 1.上层模块不应该依赖于底层模块，它们都应该依赖于抽象。
     *              2.抽象不应该依赖于细节，细节应该依赖于抽象。
     * 依赖倒转原则意味着上层类不直接使用底层类，使用接口作为抽象层。上层类中创建底层类的对象的代码不能直接使用new操作符。
     * 模板设计模式是应用依赖倒转原则的实例，可以使用工厂方法，抽象工厂和原型模式。
     * 一个类的功能在将来不会改变，就不需要使用该原则。
     *
     *--迪米特法则 最少知识原，一个对象应当对其他对象有尽可能少的了解。
     *
     *
     *
     * 网页 https://zhuanlan.zhihu.com/p/89833731
     */
}