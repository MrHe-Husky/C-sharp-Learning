EventAnnounce使用了一种较为传统完整的事件声明
EventAnnounceSimple则使用了语法糖，目前流行的事件声明方式(field-like)

事件(event)分为5部分，分别为事件拥有者(event sourse)，其拥有事件成员(event)；事件响应者(event subscriber), 其拥有事件处理器(event handler), 事件订阅(subscribe)则是事件成员挂接上事件处理器