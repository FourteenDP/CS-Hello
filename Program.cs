// Program.cs
// 引入命名空间
using System; // 在 C# 中，所有的类都在命名空间中，所以需要引入命名空间才能使用类, System 是 C# 的根命名空间，所有的类都在 System 命名空间中, 所以在 C# 中，不需要引入 System 命名空间也可以使用类
namespace Application
{
  class Program
  {
    static int Main(string[] args)
    {
      // 在控制台输出 Hello World!
      Console.WriteLine("Hello World!"); // 如果不引入命名空间，需要使用 System.Console.WriteLine("Hello World!");
      return 0; // 返回 0 表示程序正常退出, 如果不返回值，C# 会自动返回 0,所以可以省略 return 语句
    }
  }
}
