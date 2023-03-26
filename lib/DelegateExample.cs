namespace DelegateExample
{
  class Test
  {
    public int Add(int a, int b)
    {
      return a + b;
    }
  }
  internal class Example
  {
    public delegate int AddDelegate(int a, int b);
    public static void Run()
    {
      Console.WriteLine(@"什么是委托?
  委托是一种类型安全的函数指针。委托可以将方法当作参数进行传递。");
      Console.WriteLine("请输入两个数字:");
      string? num1 = Console.ReadLine();
      string? num2 = Console.ReadLine();
      if (num1 == "" || num1 == null || num2 == "" || num2 == null)
      {
        Console.WriteLine("输入不得为空!");
        Run();
      }
      else
      {
        int n1 = int.Parse(num1);
        int n2 = int.Parse(num2);
        Test test = new Test();
        // 委托声明
        AddDelegate add = new AddDelegate(test.Add); // 委托实例化，指针指向Add方法F
        // 匿名方法
        AddDelegate add2 = delegate (int a, int b)
        {
          return a + b;
        };
        // Lambda表达式
        AddDelegate add3 = (a, b) => a + b;

        // 以上三种方法都是一样的
        Console.WriteLine("两个数字的和为: " + add(n1, n2));
        Console.WriteLine("两个数字的和为: " + add2(n1, n2));
        Console.WriteLine("两个数字的和为: " + add3(n1, n2));
      }
    }
  }
}
