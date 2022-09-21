﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerChallengeDay4
{
    class Person
    {
        public int age;

        public Person(int initialAge)
        {
            if (initialAge <  0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                age = initialAge; 
            }
        }

        public void AmIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager."); 
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void YearPasses()
        {
            age += 1;
        }
    }
}
