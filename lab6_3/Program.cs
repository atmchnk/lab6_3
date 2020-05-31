/*
 Створити клас «Весілля» із елементами даних: адреса, ім’я нареченої, ім’я нареченого, кількість
 запрошених.
 Створити елемент колекції Stack<> і занести в нього дані про введену із клавіатури кількість
 весіль. Продемонструвати роботу функцій Push(), Pop(), Peek(). Дані вводити за допомогою
 функції класу «Весілля», а виводити за допомогою перевантаженої функції ToString().
 */

using System;
using System.Collections.Generic;

namespace lab6_3
{
    public class Wedding
    {
        string addressHouse;
        string nameBride, nameGroom;
        int theGuests;

        public Wedding(string addressHouse, string nameBride, string nameGroom, int theGuests)
        {
            this.addressHouse = addressHouse;
            this.nameBride = nameBride;
            this.nameGroom = nameGroom;
            this.theGuests = theGuests;
        }

        public override string ToString()
        {
            return String.Format("Адреса: {0}  Ім’я нареченої: {1}  Ім’я нареченого: {2}, " +
                "К-ть запрошених: {3}", addressHouse, nameBride, nameGroom, theGuests);
        }
    }

    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Stack<Wedding> stack = new Stack<Wedding>();
            Console.Write("Введіть кількість весіль: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            string addressHouse;
            string nameBride, nameGroom;
            int theGuests;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Весілля №" + (i + 1));
                Console.Write("Введіть адресу: ");
                addressHouse = Console.ReadLine();

                Console.Write("Введіть ім’я нареченої: ");
                nameBride = Console.ReadLine();

                Console.Write("Введіть ім’я нареченого: ");
                nameGroom = Console.ReadLine();

                Console.Write("Введіть кількість запрошених: ");
                theGuests = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                stack.Push(new Wedding(addressHouse, nameBride, nameGroom, theGuests));
            }

            Console.WriteLine("Весілля:\t");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(stack.Peek());
                stack.Pop();
            }
        }
    }
}