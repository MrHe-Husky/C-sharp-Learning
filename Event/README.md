EventAnnounce使用了一种较为传统完整的事件声明
EventAnnounceSimple则使用了语法糖，目前流行的事件声明方式(field-like)

事件(event)分为5部分，分别为事件拥有者(event source)，其拥有事件成员(event)；事件响应者(event subscriber), 其拥有事件处理器(event handler), 事件订阅(subscribe)则是事件成员挂接上事件处理器

Way2中Event source与Event subcriber平级
Way3为Event source与Event subscribe为同一个类，而其下的eventhandler订阅自己的event
Way4最为常见，是微软历代延续下来的一种事件模型。Event subscriber是一个大类，其中的Event source是自己的成员，Event subscriber用自己的方法来订阅Event souece的event成员。例如一个窗口为一个大类，其中的button有被点击这一个事件，窗口用自己的方法来相应button被点击这个事件，如此等等。