using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Exercise_7
{
    public class StudentRegistry
    {
        private readonly Dictionary<string, int> studentAges = new Dictionary<string, int>();

        public Dictionary<string, int> StudentAges
        {
            get
            {
                if (!studentAges.Any())
                {
                    InitializeStudentAges();
                }

                return studentAges;
            }
        }

        private void InitializeStudentAges()
        {
            // Extra sleep, to make it easier to prove the race condition
            Thread.Sleep(3);

            studentAges.Add("Jan", 21);
            studentAges.Add("Ruud", 14);
            studentAges.Add("Klaas", 19);
        }
    }
}