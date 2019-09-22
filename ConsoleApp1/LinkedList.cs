using System;
using System.Collections.Generic;
using System.Text;

namespace LL
{
    public class LinkedList
    {
        private ListData Start;

        public void Addfirst(Object data)
        {
            ListData addf = new ListData();
            addf.LData = data;
            addf.Next = Start;
            Start = addf;
        }

        public void Addlast(Object data)
        {
            ListData point = Start;
            ListData Addl = new ListData();
            if (point == null)
            {
                Addfirst(data);
            }
            else
            {
                while (point.Next != null)
                {
                    point = point.Next;
                }
                Addl.LData = data;
                Addl.Next = null;
                point.Next = Addl;
            }
        }

        public void AddAt(Object data, int n)
        {
            int i = 1;
            ListData point = Start;
            ListData Addat = new ListData();
            while (point != null)
            {
                if (i == n)
                {
                    Addat.LData = data;
                    Addat.Next = point.Next;
                    point.Next = Addat;
                    return;

                }
                point = point.Next;
                i++;
            }
            Console.WriteLine(" не можливо додати елемент {0} довжина списка менше", n);
            return;
        }

        public void PrintAll()
        {
            if (Start == null)
            {
                Console.WriteLine(" список порожній");
                return;
            }
            ListData point = Start;
            int i = 0;
            while (point != null)
            {
                Console.WriteLine(" вивід елемент {0}   {1}", i, point.LData);
                i++;
                point = point.Next;
            }

        }
        public void Length()
        {
            if (Start == null)
            {
                Console.WriteLine(" список порожній довжина 0");
                return;
            }
            ListData point = Start;
            int i = 0;
            while (point != null)
            {
                //Console.WriteLine(" {0}   {1}",i,point.LData);
                i++;
                point = point.Next;
            }
            Console.WriteLine("кількість членів списку {0}", i);
            return;
        }

        public void RemoveFirst()
        {
            Start = Start.Next;
        }

        public void RemoveAt(Object find)
        {
            ListData point = Start;
            ListData Privious = point;
            while (point != null)
            {

                if (ReferenceEquals(find, point.LData))
                {
                    if (ReferenceEquals(find, Start.LData))
                    {
                        Start = Start.Next;
                        return;
                    }

                    //Console.WriteLine("  {0}  в списке",find);
                    Privious.Next = point.Next;
                    break;
                }
                Privious = point;
                point = point.Next;
            }
            if (point == null) Console.WriteLine(" обєкт {0} відсутній в списку і тому видалити не можливо ", find);
        }

        public void Remove(int n)
        {
            int i = 1;
            ListData point = Start;
            ListData Privious = point;
            while (point != null)
            {
                if (i == n)
                {
                    if (i == 1)
                    {
                        Start = Start.Next;
                        return;
                    }

                    //Console.WriteLine("  {0}  в списке",find);
                    Privious.Next = point.Next;
                    break;
                }
                i++;
                Privious = point;
                point = point.Next;
            }
            if (point == null) Console.WriteLine(" обєкт {0} відсутній в списку і тому видалити не можливо ", n);
        }
        public void ElementAt(int n)
        {
            if (Start == null)
            {
                Console.WriteLine(" список порожній елемент відсутній {0}", n);
                return;
            }
            ListData point = Start;
            int i = 1;
            while (point != null)
            {
                if (i == n)
                {
                    Console.WriteLine("елемент {0} є {1}", n, point.LData);
                    return;
                }
                //Console.WriteLine(" {0}   {1}",i,point.LData);
                i++;
                point = point.Next;
            }
            Console.WriteLine("кількість членів списку {0} і тому вивести елемент {1} не можливо", i, n);
            return;
        }
    }
}
