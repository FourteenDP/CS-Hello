# C# Hello World

## 项目结构

```shell
CS-Hello
├── bin # 编译后的文件
│   └── Debug
├── CS-Hello.csproj # 项目文件
├── CS-Hello.sln # 解决方案文件
├── obj # 编译后的中间文件
└── Program.cs # 程序入口
```

## 程序入口基本结构

```csharp
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

```

### 如果使用顶级语句

**顶级语句** 是 C# 10.0 引入的新特性，可以让我们不用写 `Main` 方法，直接在文件中写代码，这样可以让我们的代码更加简洁。

```csharp
// Program.cs
// 顶级语句
Console.WriteLine("Hello World!");
```

> 注意：顶级语句只能在程序入口文件中使用，不能在其他文件中使用。
