    using System;
    using System.Collections.Generic;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public static void Main() 
            {
                List<int?> elem = new List<int?>()
                {
                    0,
                    5,
                    null,
                    48,
                    31,
                    null,
                    91,
                    77,
                    12,
                    21,
                    null
                };
     
            DisplayInfos(elem);
        }
     
            static void DisplayInfos(List<int?> val)
            {
                foreach(var v in val)
                {
                    Console.WriteLine(v ?? 0);
                }
            }
        }
    }