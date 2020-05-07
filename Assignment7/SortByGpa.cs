using System.Collections;
using System.Management.Instrumentation;

namespace Demo.Assignment7
{
    public class SortByGpa : IComparer
    {
        public int Compare(object x, object y)
        {
            Student a = x as Student;
            Student b = y as Student;

            if (a == null || b == null)
            {
                throw new InstrumentationException();
            }
            else
            {
                if (a.Gpa > b.Gpa)
                {
                    return 1;
                }
                else if (a.Gpa == b.Gpa)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}