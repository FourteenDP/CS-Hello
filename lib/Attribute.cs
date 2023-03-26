namespace App.MyAttribute
{
  // 定义 AuthorAttribute 类作为一个特性，可以应用于类、方法等元素上
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
  public class AuthorAttribute : Attribute
  {
    public string Name { get; set; }
    public string Email { get; set; }

    // 构造函数，用于指定该特性的作者姓名和电子邮件信息
    public AuthorAttribute(string name, string email)
    {
      Name = name;
      Email = email;
    }
  }

  // 标记 MyClass 类由 John Smith 创建
  [Author("John Smith", "john.smith@example.com")]
  public class MyClass
  {
    // 标记 MyMethod 方法由 Jane Doe 创建
    [Author("Jane Doe", "jane.doe@example.com")]
    public void MyMethod()
    {
      Console.WriteLine("MyMethod executed.");
    }
  }


  internal class Example
  {
    public static void Run()
    {
      Console.WriteLine(@"什么是特性?
  特性是一种用于为程序集、模块、类型、成员、参数和其他程序实体添加元数据的声明性标签。");
      // TODO : 特性的使用
    }
  }
}
