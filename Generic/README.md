泛型(Generic)的使用使一个方法能够接受更多类型的参数，可以有效地减少重复代码量
1.GenericExample 中的一个泛型类Box<TCargo>用来存储东西，盒子内的东西各式各样，盒子的类型也随里面的东西而变成了苹果盒(Box<Apple>)和书盒(Box<Book>)
2.GenericExample_Interface使用了泛型接口。接口也可以使用泛型，实现接口的类可以特化(直接把接口的泛型类型确定)，或者保留，留在实例化类时再决定。
3.GenericExampleU展示了一些现有的泛型类的使用方法包括：IList<T>, IDictionary<T,T>,泛型委托Action<T>, Func<T,T,T>。 T[] Zip<T>(T[] a, T[] b)是自定的泛型方法。