using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Victorina
{
    class Victorina
    {
        public Victorina()
        {
            Count = 0;
            Goal = 0;
            Name = "";
        }
        public static int Count { get; set; }
        public static int Goal { get; set; }
        public static string Name { get; set; }
        public void Questions()
        {
            Console.Write("Введите ваше имя: ");
            Name = Console.ReadLine();
            string answ;
            do
            {
                Console.WriteLine("\n1.Единица измерения скорости. \nВведите только эти буквы: a,b,c!");
                Console.Write("a) кг\nb) литр\nc) км/ч.\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "c" || answ == "C")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");
            do
            {
                Console.WriteLine("\n2.Какой по счету от Солнца является Земля? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) Третья.\nb) Пятая\nc) Вторая\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "a" || answ == "A")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");
            do
            {
                Console.WriteLine("\n3.Как называется прямая, ограниченная точками? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) Луч\nb) Отрезок.\nc) Плоскость\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "b" || answ == "B")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");
            do
            {
                Console.WriteLine("\n4.Сколько звуков в слове «конь»? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) Четыре\nb) Три.\nc) Пять\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "b" || answ == "B")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n5.Выберите верное утверждение из перечисленных. \nВведите только эти буквы: a,b,c!");
                Console.Write("a) Согласная буква не образует слог.\nb) Согласная образует слог\nc) Согласная в некоторых случаях образует слог\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "a" || answ == "A")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n6.Какой из этих цветов больше всего любят комары? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) Желтый\nb) Синий.\nc) Красный\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "b" || answ == "B")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n7.Если смешать краску красного и синего цвета, получится… \nВведите только эти буквы: a,b,c!");
                Console.Write("a) Зеленый\nb) Фиолетовый.\nc) Черный\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "b" || answ == "B")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n8.Сколько океанов на нашей планете? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) 4.\nb) 5\nc) 6\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "a" || answ == "A")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n9.Единица измерения силы тока - это … \nВведите только эти буквы: a,b,c!");
                Console.Write("a) Ампер.\nb) Вольт\nc) Ватт\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "a" || answ == "A")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n10.Сатурн - это какая по счёту планета от Солнца?\nВведите только эти буквы: a,b,c!");
                Console.Write("a) 5\nb) 6.\nc) 8\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "b" || answ == "B")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n11.Какой элемент обозначается как Ag? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) Золото\nb) Серебро.\nc) Аргон\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "b" || answ == "B")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n12.Сколько будет 0,2км в дециметрах? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) 20 000 дм.\nb) 2 000 дм\nc) 200 дм\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "a" || answ == "A")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n13.Самая длинная река в мире - это: \nВведите только эти буквы: a,b,c!");
                Console.Write("a) Амазонка.\nb) Нил\nc) Янцзы\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "a" || answ == "A")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n14.Сколько хромосом в геноме человека? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) 42\nb) 44\nc) 46.\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "c" || answ == "C")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n15.Сколько в русском языке частей речи? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) 6\nb) 8\nc) 10.\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "c" || answ == "C")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n16.Какой процент земного шара занимает Мировой океан? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) 50%\nb) 60%\nc) 70%.\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "c" || answ == "C")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n17.Сколько планет в Солнечной системе? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) 6\nb) 8.\nc) 10\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "b" || answ == "B")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n18.Сколько метров в одной миле? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) 0.43\nb) 2.54\nc) 1609.34.\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "c" || answ == "C")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n19.Как называется знак корня в алгебре? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) Радикал.\nb) Модуль\nc) Функция\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "a" || answ == "A")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            do
            {
                Console.WriteLine("\n20.Если перевернуть российский флаг вверх ногами, то флаг какой страны получится? \nВведите только эти буквы: a,b,c!");
                Console.Write("a) Коста-Рики\nb) Сербии.\nc) Словакии\nВвод -> ");
                answ = Console.ReadLine();
                if (answ == "b" || answ == "B")
                {
                    Count++;
                }
                else
                {
                    if (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C")
                    {
                        Console.WriteLine("\nОШИБКА!НЕВЕРНЫЙ ВВОД!ПОПРОБУЙТЕ ЕЩЁ РАЗ!\n");
                    }
                }
            } while (answ != "a" && answ != "A" && answ != "b" && answ != "B" && answ != "c" && answ != "C");

            Evaluations();
        }
        public void Save()
        {
            try
            {
                string _path = "DataOfTest.txt";
                StreamWriter myStream = File.AppendText(_path);

                myStream.WriteLine("Имя: {0}\nПравильных ответов: {1}\nВаша оценка: {2}\n", Name, Count, Goal);
                myStream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("ОШИБКА С СОХРАНЕНИЕМ ПРОЕКТА В ТЕКСТОВЫЙ ДОКУМЕНТ!");
            }
        }
        public void Evaluations()
        {
            if (Count == 0)
            {
                Goal = 0;
            }
            if (Count == 1 || Count == 2 || Count == 3 || Count == 4)
            {
                Goal = 1;
            }
            if (Count == 5 || Count == 6 || Count == 7 || Count == 8)
            {
                Goal = 2;
            }
            if (Count == 9 || Count == 10 || Count == 11 || Count == 12)
            {
                Goal = 3;
            }
            if (Count == 13 || Count == 14 || Count == 15 || Count == 16)
            {
                Goal = 4;
            }
            if (Count == 17 || Count == 18 || Count == 19 || Count == 20)
            {
                Goal = 5;
            }
            Console.WriteLine("\nИмя: {0}\nПравильных ответов: {1}\nВаша оценка: {2}", Name, Count, Goal);
        }
        ////// Pridumai pozdravleniye! //////
        ///
        //public void Emoji()
        //{

        //}
    }
    class Program
    {
        static void Main()
        {
            Victorina _victor = new Victorina();
            _victor.Questions();
            _victor.Save();
        }
    }
}