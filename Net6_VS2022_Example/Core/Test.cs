using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net6_VS2022_Example.Core
{
    public record class Test(string Name, string Surname);

    //The same
    //   public record Test(string Name, string Surname);




    record struct Test1(string Name, string Surname); //can use record struct



    public record TestRec(string name, string surname)
    {
        public sealed override string ToString()// ovveride ToString() sealed
        {
            return $"{name} {surname}";
        }

        public string TakeFourSymbols(TestRec obj) => obj switch
        {
            // old method:
            //TestRec { name: {Length: > 4} } rec => rec.name.Substring(0,4),

            // new method:
            TestRec { name.Length: > 4 } rec => rec.name.Substring(0, 4),
            TestRec rec => rec.name,
        };
    }
    public record InheritedRecord : TestRec //inherided ToString()
    {
        public InheritedRecord(string name, string surname)
        : base(name, surname)
        {

        }
    }
}
