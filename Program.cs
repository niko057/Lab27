﻿using System.Collections;

namespace Lab27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList=new ArrayList();

            // Person person=new Person();

            // person.Name = "Nicat";
            // person.Age = 27;
            // arrayList.Add(person);

            // Person person1 = new Person();

            // person1.Name = "Ali";
            // person1.Age = 23;
            // arrayList.Add(person1);

            // Person person2 = new Person();

            // person2.Name = "Aziz";
            // person2.Age = 24;
            // arrayList.Add(person2);

            // foreach (var item in arrayList)
            // {
            //     Console.WriteLine(item.ToString());
            // }


            string[] arr = { "Nicat", "Ali", "Aziz", "Pasa" };

            Console.WriteLine("Daxil edin ");

            char input = Convert.ToChar(Console.ReadLine());

            for(int i = 0;i < arr.Length; i++)
            {
                for (int j = 0; j <arr[i].Length; j++)
                {
                    
                    if (arr[i][j] == input)
                    {
                        Console.WriteLine(arr[i] + " " + j);
                    }
                  
                }
            }
           











        }
    }
}