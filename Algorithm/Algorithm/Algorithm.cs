﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class Algorithm : Interface
    {
        public void Formula()
        {
            //code here

            int n1 = 0;
            int n2 = 1;
            int n3;
            int i;
            int number;

            Console.Write("Enter the number of elements: ");

            number = int.Parse(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    

            //loop starts from 2 because 0 and 1 are already printed
            for (i = 2; i < number; ++i)    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

            Console.ReadLine();
        }
    }
}
