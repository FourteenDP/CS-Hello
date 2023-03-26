namespace ConditionExample
{
  internal class Example
  {
    internal static void Run()
    {
      Console.WriteLine(@"什么是条件语句?
  条件语句是指在程序中根据条件的不同执行不同的操作。");
      Console.WriteLine("1. if 语句");
      Console.WriteLine("2. switch 语句");
      Console.WriteLine("请输入选项:");
      string? cmd = Console.ReadLine();
      if (cmd == "" || cmd == null)
      {
        Console.WriteLine("选项不得为空!");
        Run();
      }
      else
      {
        switch (cmd)
        {
          case "1":
            IfExample.Run();
            break;
          case "2":
            SwitchExample.Run();
            break;
          default:
            Console.WriteLine("选项不存在!");
            Run();
            break;
        }
      }
    }
  }

  internal class IfExample
  {
    internal static void Run()
    {
      Console.WriteLine(@"什么是if ... else ...语句?
  if语句是一种单分支选择结构，它的语法格式如下：
  if(表达式)
  {
    语句1;
  }
  else
  {
    语句2;
  }");
      Console.WriteLine("请输入一个数字:");
      string? num = Console.ReadLine();
      if (num == "" || num == null)
      {
        Console.WriteLine("输入不得为空!");
        Run();
      }
      else
      {
        int n = int.Parse(num);
        if (n == 1)
        {
          Console.WriteLine("你输入的是1");
        }
        else
        {
          Console.WriteLine("你输入的不是1");
        }
      }
    }
  }
  internal class SwitchExample
  {
    internal static void Run()
    {
      Console.WriteLine(@"什么是switch语句?
  switch语句是一种多分支选择结构，它的语法格式如下：
  switch(表达式)
  {
    case 常量1:
      语句1;
      break;
    case 常量2:
      语句2;
      break;
    ...
    default:
      语句n;
      break;
  }");
      Console.WriteLine("请输入一个数字:");
      string? num = Console.ReadLine();
      if (num == "" || num == null)
      {
        Console.WriteLine("输入不得为空!");
        Run();
      }
      else
      {
        int n = int.Parse(num);
        switch (n)
        {
          case 1:
            Console.WriteLine("你输入的是1");
            break;
          case 2:
            Console.WriteLine("你输入的是2");
            break;
          default:
            Console.WriteLine("你输入的不是1或2");
            break;
        }
      }
    }


  }
}
