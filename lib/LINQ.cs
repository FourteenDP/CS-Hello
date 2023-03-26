namespace App
{
  enum Sex
  {
    Men, Women, Other
  }
  struct UserInfo
  {
    public string name; // 用户名
    public int age; // 年龄
    public Sex gender; // 性别
    public string address; // 地址
  }
  internal class LINQ
  {
    private static List<UserInfo> userList = new List<UserInfo>(){
        new UserInfo() { name = "张三", age = 20, gender = Sex.Men, address = "北京市海淀区中关村" },
        new UserInfo() { name = "李四", age = 25, gender = Sex.Women, address = "上海市徐汇区" },
        new UserInfo() { name = "王五", age = 30, gender = Sex.Men, address = "广州市天河区" }
      };
    internal static void Run()
    {
      Console.WriteLine(@"什么是 LINQ?
  LINQ (Language Integrated Query) 是微软推出的一种编程语言集成查询的技术，它允许在编程语言中使用 SQL 语句查询数据。");
      string result = string.Format("{0}信息列表：\n", nameof(UserInfo));
      foreach (var user in userList)
      {
        result += string.Format("姓名：{0}，年龄：{1}岁，性别：{2}，地址：{3}\n", user.name, user.age, user.gender.ToString("F"), user.address);
      }
      Console.WriteLine(result);
      Console.WriteLine("1.男性\n2.女性\n3.退出");
      string? cmd = Console.ReadLine();
      if (cmd == "1")
      {
        GetScreenSex(Sex.Men);
      }
      else
      if (cmd == "2")
      {
        GetScreenSex(Sex.Women);
      }
      else
      if (cmd == "3")
      {
        Console.WriteLine("成功");
      }
      else
      {
        Run();
      }

    }

    // 使用LINQ查询
    private static void GetScreenSex(Sex sex)
    {
      var resList = from user in userList
                    where user.gender == sex
                    select string.Format("姓名：{0}，年龄：{1}岁，性别：{2}，地址：{3}", user.name, user.age, user.gender.ToString("F"), user.address);

      Console.WriteLine("{0}性用户信息列表：\n{1}", sex.ToString("F"), string.Join("\n", resList));
      Console.WriteLine("1.继续\n2.退出");
      string? cmd = Console.ReadLine();
      if (cmd == "1")
      {
        Run();
      }
      else
      {
        Console.WriteLine("成功");
      }
    }

  }
}
