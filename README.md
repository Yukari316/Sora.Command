# Sora.Command

这是一个简单轻量的指令分发服务扩展

实现了和Discord.Net框架类似的特性指令服务

通过特性 `GroupCommand` 和 `PrivateCommand` 来分发群聊和私聊指令

但是并没有实现自动的参数转换和注入（个人觉得这样做会限制很大的开发空间就不做实现了）,该指令服务只会传递框架中的 `GroupMessageEventArgs` 和 `PrivateMessageEventArgs` 的事件参数，其余的响应逻辑和参数处理需要自己完成

所以特性和方法的参数有如下的对应关系，并且只能有一个对应的参数，否则将不会被识别

`GroupCommand` -> `GroupMessageEventArgs`

`PrivateCommand`-> `PrivateMessageEventArgs`

## 使用方法

~~咕了~~