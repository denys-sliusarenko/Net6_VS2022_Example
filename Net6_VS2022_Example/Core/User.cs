using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// namespace for all file without "namespace 'name_space'{  }"
namespace Net6_VS2022_Example.Core;

public struct User
{
    // constructor without parameters for struct (new in C#10) only when all properties initialized else error
    public User()
    {

    }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; } = string.Empty; //initialize property in struct (new in C#10)
    public int Age { get; set; } = 18;
}
