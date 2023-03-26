namespace App
{
  // internal : 内部的, 只能在当前程序集中访问
  internal class Overload
  {
    // static : 静态的, 可以直接通过类名访问
    // void : 空的, 没有返回值
    internal static void Run()
    {
      // 多行字符串
      Console.WriteLine(@"什么是方法重载?
  方法重载是指在同一个类中，允许存在一个以上的同名方法，只要它们的参数个数或参数类型不同即可。");
      Console.WriteLine("请输入两个或三个数字:");
      string? num1 = Console.ReadLine();
      string? num2 = Console.ReadLine();
      string? num3 = Console.ReadLine();

      if (num1 == "" || num1 == null || num2 == "" || num2 == null)
      {
        Console.WriteLine("输入不得为空!");
        Run();
      }
      else
      {
        int n1 = int.Parse(num1);
        int n2 = int.Parse(num2);
        if (num3 == "" || num3 == null)
        {
          Console.WriteLine("两个数字的和为: " + Add(n1, n2));
        }
        else
        {
          int n3 = int.Parse(num3);
          Console.WriteLine("三个数字的字符串拼接为: " + Add(n1, n2, n3));
        }
      }
    }

    // 重载方法
    private static int Add(int n1, int n2)
    {
      return n1 + n2;
    }
    private static string Add(int n1, int n2, int n3)
    {
      return n1.ToString() + n2.ToString() + n3.ToString();
    }
  }
}
