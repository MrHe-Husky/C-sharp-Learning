面向对象设计主要特点：抽象、封装、继承、多态。

类(Class)之间的关系：关联、聚合、继承、实现和多态

类除了静态方法(static)之外，其他的方法必须在类实例化(instantiated)之后才能使用。

method是方法，其中演示了方法的重载，在add方法中使用重载，能够使其运算double和int两种数据类型的参数（不过这种重复的代码更推荐使用泛型）

类的构造函数(constructor)与析构函数(destructor),构造函数(快捷输入ctor)在类实例化时被调用，用于初始化实例(可以被重载)
析构函数(快捷输入~)则再实例删除时调用。(不能被重载)

AbstractClass为抽象类，使用abstract修饰，抽象类中含有纯虚方法，因此不能实例化，只作为其它类的父类使用

Operatores为运算符重载

Property是属性，由语法糖自动完成了get和set方法，使他们看起来更像一个字段，get和set方法可以重写。(C#9.0版本中除了set，你可以使用init关键字来为一个属性赋值，这使得它只能进行一次赋值操作)

//接口其实也是类，只不过其中仅含有虚方法(virtual method)，其主要作用是作为类与类之间的一种协议，实现接口的类就能做到接口所要求的功能