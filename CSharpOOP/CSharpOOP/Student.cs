using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public class Student : IHuman, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int mark;
        public int Mark {
            get { return mark; }
            set
            {
                if (mark < 0 || mark > 100)
                    throw new ArgumentException("Enter a correct Mark");
                else
                {
                    mark = value;
                }
            }
        }

        public Student(string firstName, string lastName, int mark)
        {
            FirstName = firstName;
            LastName = lastName;
            Mark = mark;
        }

        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return Mark.CompareTo(other.mark);
        }
        public static bool operator >=(Student student1, Student student2)
        {
            return student1.CompareTo(student2) >= 0;
        }
        public static bool operator <=(Student student1, Student student2)
        {
            return (student1.CompareTo(student2) <= 0);
        }
        public static bool operator >(Student student1, Student student2)
        {
            return student1.CompareTo(student2) > 0;
        }
        public static bool operator <(Student student1, Student student2)
        {
            return student1.CompareTo(student2) < 0;
        }

    }

}
