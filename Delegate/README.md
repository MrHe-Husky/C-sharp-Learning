委托(delegate)可以起到与C/C++中函数指针相同的作用。

由于其本质也是一个类，一般在于类平级的地方声明，声明方式为 public delegate 返回值类型 委托类名(类型1 参数1,类型2 参数2,类型3 参数3...);

DelegateExample是用委托写的一个工厂，其生产玩具车(toycar),披萨(pizza),和面包(bread)。如果将来要修改或添加生产产品，则无需修改WrapFactory，而直接在ProductFactoty中修改或添加新项目即可。低耦合的实现。

MulticastDelegate中展示了 直接同步调用 单播委托形式(间接同步调用) 多播委托形式，用一个委托封装多个方法(也是同步的) 委托隐式异步调用(BeginInvoke方法) 显式异步调用，方法一(Thread)[古老方法] 显式异步调用，方法二(Task)[新方法] 委托的多种同步与异步调用方式