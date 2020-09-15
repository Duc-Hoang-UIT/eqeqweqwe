using System;
using System.Collections.Generic;

namespace Library.Shared
{
public class NewStudentComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            int result = (x.DiemToan+x.DiemVan).CompareTo(y.DiemToan+y.DiemVan);
            if (result == 0)
            {
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                return result;
            }
        }
    }
}