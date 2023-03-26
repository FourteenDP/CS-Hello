// Program.cs
// 引入命名空间
using System; // 在 C# 中，所有的类都在命名空间中，所以需要引入命名空间才能使用类, System 是 C# 的根命名空间，所有的类都在 System 命名空间中, 所以在 C# 中，不需要引入 System 命名空间也可以使用类
using App; // 引入自行义 App 命名空间
namespace Application // 命名空间 Application, 用于区分不同的程序, 一个程序可以有多个命名空间, 但是只能有一个入口类, 也就是只能有一个类有 Main 方法
{ // 如果一个文件中只要一个命名空间，可以省略命名空间的大括号, 可以直接在头部加上 using System; 然后在类前面加上 namespace Application; 就可以了
  class Program
  {
    static int Main(string[] args)
    {
      // 在控制台输出 Hello World!
      Console.WriteLine("Hello World!"); // 如果不引入命名空间，需要使用 System.Console.WriteLine("Hello World!"); 来输出

      CMD.Run();
      return 0; // 返回 0 表示程序正常退出, 如果不返回值，C# 会自动返回 0,所以可以省略 return 语句
    }

  }
}
