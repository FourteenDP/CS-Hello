using App.MyLINQ;
namespace App;
class CMD
{
  // public	访问不受限制。
  // protected	访问限于包含类或派生自包含类的类型。
  // internal	访问限于当前程序集。
  // protected internal	访问限于当前程序集或派生自包含类的类型。
  // private	访问限于包含类。
  // private protected	访问限于包含类或当前程序集中派生自包含类的类型。
  // static : 静态的, 可以直接通过类名访问
  // abstract : 抽象的, 不能直接实例化, 只能被继承
  // readonly : 只读的, 只能在初始化时赋值, 不能在其他地方赋值
  public static void Run()
  {
    PrintMenu();
    Console.WriteLine("请输入选项:");
    string? cmd = Console.ReadLine();
    if (cmd == "" || cmd == null)
    {
      Console.WriteLine("选项不得为空!");
      PrintMenu();
      Run();
    }
    else
    {
      Options.Run(cmd);
    }
  }

  // 输出菜单
  private static void PrintMenu()
  {
    // 多行字符串
    string menu =
@"1.类方法成员的重载
2.LINQ操作
3.委托Delegate
4.特性Attribute";
    Console.WriteLine(menu);
  }
}
class Options
{
  public static void Run(string cmd)
  {
    switch (cmd)
    {
      case "1":
        App.MyOverload.Example.Run();
        break;
      case "2":
        App.MyLINQ.Example.Run();
        break;
      case "3":
        App.MyDelegate.Example.Run();
        break;
      case "4":
        App.AttributeExample.Example.Run();
        break;
      default:
        Console.WriteLine("请输出有效的选项!");
        CMD.Run();
        break;
    }
  }
}
