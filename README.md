mono-for-android-listview-button
================================

use button in mono for android with listview

## **简述**
我在使用Mono for android的过程中，发现listview的一个问题：
1、如果不复用item，可以实现上面的效果，但是如果加载的数据流超过50左右直接会导致卡死；所以必须得复用；
2、如果复用item，需要注意如何给button添加复用事件。我已经想到解决办法了：只能在item的view被创建的第一次的时候给item加click事件，否则会发现有n个item，就会执行n次click事件。
这个已经发邮件给Xamarin公司，估计是一个bug，希望他们尽快修复。

## **代码说明：**
代码我是修改了《C#开发Android应用实战——使用Mono for Android和.NET/C#》，即《Professional AndroidTM Programming with Mono for Android and .NET/C#》上面的例子。核心代码请具体查看AnimalListAdapter这个类中GetView这个方法，里面我做了详细的注释。

## **其他说明：**
我们已经使用mono for android开发了两个应用，作为企业级商业产品，肯定没有问题，大家完全可以放心使用mono for android，“人生短暂，enjoy mono,enjoy C#,enjoy life”
## **新的说明：**
好久不更新，本人从今日起，全心投给C#
