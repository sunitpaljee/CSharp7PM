using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class Person
    {
        int Id;
        string Name, Address, Phone;
    }
    class Student : Person
    {
        int _class, Marks;
        float Fees;
        char Grade;
    }
    class Staff : Person
    {
        double Salary;
        string Designation;
    }
    class Teaching : Staff
    {
        string Qualification, Subject;
    }
    class NonTeaching : Staff
    {
        string DName;
        int MgrID;
    }
}
