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
    }

    internal class IfExample
    {
    }
  }
}
