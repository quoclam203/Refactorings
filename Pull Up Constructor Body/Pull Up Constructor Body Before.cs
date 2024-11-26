using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pull_Up_Constructor_Body
{
    internal class Pull_Up_Constructor_Body_Before
    {
        class Manager extends Employee
        {
  public Manager(String name, String id, int grade)
        {
            this.name = name;
            this.id = id;
            this.grade = grade;
        }
        // ...
    }
}
}
