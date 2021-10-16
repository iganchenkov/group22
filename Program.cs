using System;

namespace Задачки
{
    class Program
    {

        static void Main(string[] args)

        {

            //string a = "";
            //string b = "";


            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //int a2 = x + y;
            //while (a2 > 0)
            //{
            //    a2 = a2 / 2;
            //    a = a + a2 % 2;

            //}
            //Console.WriteLine(a);
            //for (int i = a.Length - 1; i >= 0; i--)
            //{
            //    b = b + a[i];

            //}
            //Console.WriteLine(b);


         



            // Определить процент вхождения буквы в строку
            //Numbers A = new Numbers(5, 4);
            //A.summa();

            //string alphabet = "лфовыаофыэваолфыважлфыоа";
            //Console.WriteLine("Введите 1 букву");
            //float percent = 0;
            //int count = 0;
            //char a = Convert.ToChar(Console.ReadLine());
            //for (int i = 0; i < alphabet.Length; i++)
            //{
            //    if (a == alphabet[i])
            //    {
            //        count++;
            //    }
            //}
            //percent = count * 100 / alphabet.Length;
            //Console.WriteLine($"Процент вхождения вашей буквы в строку ={percent}%");

            //int[] A2 = new int[100];
            //Random rand = new Random();
            //int min = 100;
            //int max = 0;
            //int result = 0;
            //for (int i = 0; i < A2.Length; i++)
            //{
            //    A2[i] = rand.Next(0, 100);
            //    if (A2[i] > max)
            //    {
            //        max = A2[i];
            //    }
            //    if (A2[i] < min)
            //    {
            //        min = A2[i];
            //    }
            //}
            //result = max - min;
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Console.WriteLine(result);



            //Books books = new Books();
            //books.addBook();
            //books.addBook();
            //books.GetInfo();
            //books.Search();


            //app start = new app();
            //start.start();

            //counter counter = new counter();
            //counter.Count = 9;

            //counter.add();
            //Console.WriteLine(counter.Count);




        }



        //Пользователь вводит две буквы. Определить, на каких местах алфавита они стоят, и сколько между ними находится букв.
        // Пользователь вводит номер буквы в алфавите. Определить, какая это буква.

        //string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        //Console.WriteLine("Введите 1 букву");

        //char a = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine("Введите 2 букву");
        //char b = Convert.ToChar(Console.ReadLine());
        //int c=0;
        //int d=0;
        //int f = 0;

        //for (int i = 0; i < alphabet.Length; i++)
        //{

        //    if (a == alphabet[i])
        //    {
        //        c = i;
        //        Console.WriteLine($"Буква {a} {i} по счету");
        //        ++f;
        //    }


        //}

        //for (int i = 0; i < alphabet.Length; i++)
        //{
        //    if (b == alphabet[i])
        //    {
        //        d = i;
        //        Console.WriteLine($"Буква {b} {i} по счету");
        //        ++f;
        //    }

        //}
        //if (f<2)
        //{
        //    Console.WriteLine("Введи нормальные буквы");
        //}
        //else if (c > d)
        //{
        //    Console.WriteLine($"Между буквами {(c - d) - 1} символов");
        //}
        //else if (c == d)
        //{
        //    Console.WriteLine($"Между буквами 0 символов");
        //}
        //else
        //{
        //    Console.WriteLine($" Между буквами {(d - c) - 1} символов");
        //}
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        //Пользователь вводит номер буквы в алфавите. Определить, какая это буква.
        //Console.WriteLine("Введите вашу цифру");
        //int a = Convert.ToInt32(Console.ReadLine());
        //string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        //for (int i = 0; i < alphabet.Length; i++)
        //{
        //    if (a==(i+1))
        //    {
        //        Console.WriteLine($"Ваша буква {alphabet[i]}");
        //    }
        //}
        //////////////////////////////////////////////////////////////////////////////////////////////////////

        //По двум введенным пользователем катетам вычислить длину гипотенузы.
        //Console.WriteLine("Введите длинну 1 катета");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите длинну 2 катета");
        //int b = Convert.ToInt32(Console.ReadLine());
        //double z = Math.Sqrt(a * a + b * b);
        //Console.WriteLine($"Гипотенуза = {z}");
        //////////////////////////////////////////////////////////////////////////////////////////////////
        // Написать программу, которая генерирует в указанных пользователем границах
        //случайное целое число,
        // случайное вещественное число,
        //случайный символ.

        //Console.WriteLine("Введите границу 1 ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите границу 2 ");
        //int s = Convert.ToInt32(Console.ReadLine());
        //Random R = new Random();
        //Console.WriteLine(R.Next(a, s));
        //Console.WriteLine("Введите границу 1 ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите границу 2 ");
        //int s = Convert.ToInt32(Console.ReadLine());
        //Random R = new Random();
        //Console.WriteLine(R.Next(a, s)+R.NextDouble());

        //Console.WriteLine("Введите границу 1 ");
        //char a =Convert.ToChar(Console.ReadLine());
        //Console.WriteLine("Введите границу 2 ");
        //char s = Convert.ToChar(Console.ReadLine());
        //string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        //int c = 0;
        //int v = 0;
        //for (int i = 0; i < alphabet.Length; i++)
        //{
        //    if (a==alphabet[i])
        //    {
        //        c = i;
        //    }
        //}
        //for (int i = 0; i < alphabet.Length; i++)
        //{
        //    if (s == alphabet[i])
        //    {
        //        v = i;
        //    }
        //}
        //Random R = new Random();
        //int m = R.Next(c, v);
        //Console.WriteLine(alphabet[m]);

        //Сумма и произведение цифр числа
        //Найти сумму и произведение цифр трехзначного числа, которое вводит пользователь.

        //Console.WriteLine("Введите 3 значное число");
        //string a = (Console.ReadLine());
        //int result = 0;
        //for (int i = 0; i < a.Length; i++)
        //{
        //    result += Convert.ToInt32(a[i]);
        //}
        //Console.WriteLine(result);

        //Console.WriteLine("Введите 3 значное число");
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = (a % 10);
        //int c = (a / 10) % 10;
        //int d = ((a / 10) / 10) % 10;
        //int v = b + c + d;
        //int r = b * c * d;
        //Console.WriteLine(v);
        //Console.WriteLine(r);
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        // Битовые операции над числами
        // Выполнить логические побитовые операции "И", "ИЛИ" и др. над числами 5 и 6.Выполнить над числом 5 побитовый сдвиг вправо и влево на два знака. Объяснить полученный результат.


        //public abstract class Figur

        //{
        //    public abstract int Ploshad();



        //    public abstract int Perimetr();



        //}
        //public class Kvadrat : Figur
        //{
        //    int x;

        //    public Kvadrat(int x)
        //    {
        //        this.x = x;
        //    }

        //    public override int Ploshad()
        //    {
        //        int a = x * x;
        //        return a;
        //    }
        //    public override int Perimetr()
        //    {
        //        int a = x + x;
        //        return a;
        //    }


        //}
        //public abstract class triangle : Figur
        //{
        //    int x;
        //    int y;
        //    int z;


        //    public triangle(int x, int y, int z)
        //    {
        //        this.x = x;
        //        this.y = y;
        //        this.z = z;
        //    }

        //    public override int Ploshad()
        //    {
        //        int a = (x + y + z) / 2;
        //        return a;
        //    }
        //    public override int Perimetr()
        //    {
        //        int a = x + y + z;
        //        return a;
        //    }
        //}
        //public abstract class pryamougolnik : Figur
        //{
        //    int x;
        //    int y;

        //    public pryamougolnik (int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }
        //    public override int Ploshad()
        //    {
        //        int a = x * y;
        //        return a;
        //    }
        //    public override int Perimetr()
        //    {
        //        int a = x + y;
        //        return a;
        //    }

        //}


        //public int getkvadrat()
        //{
        //    Console.WriteLine("Введите сколько квадратов");
        //    int v = Convert.ToInt32(Console.ReadLine());
        //    return v;
        //}
        //public int gettriangle()
        //{
        //    Console.WriteLine("Введите сколько треугольников");
        //    int z = Convert.ToInt32(Console.ReadLine());
        //    return z;
        //}








        // Наработки по созданию меню. инфо, удаление, добавление, выбор, выход.
        //public class menu
        //{
        //    persons another = new persons();

        //    public bool rabotaem = true;

        //    public void printmenu()
        //    {
        //        Console.WriteLine("Меню: \n" +

        //                          "1)Кто ты сталкер? \n" +


        //                          "2)Погуляй до монолита \n" +

        
        //                          "3)Кто на базе? \n" +

        //                          "4)Кого отправить? \n" +

        //                          "5)Иди своей дорогой");

        //    }


        //    public void workmenu()
        //    {
        //        int vibor = Convert.ToInt32(Console.ReadLine());
        //        if (vibor == 1)
        //        {

        //            another.add();
        //        }
        //        else if (vibor == 2)
        //        {
        //            another.remove();
        //        }
        //        else if (vibor == 3)
        //        {

        //            another.print();

        //        }
        //        else if (vibor == 4)
        //        {
        //            another.rnd();
        //        }
        //        else if (vibor == 5)
        //        {
        //            rabotaem = false;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Выбери по человечески, а?");
        //        }
        //    }







        //}
        //public class person
        //{
        //    public string name { get; set; }
        //    public string secondname { get; set; }
        //    public string fathername { get; set; }

        //    public person(string name, string secondname, string fathername)
        //    {
        //        this.name = name;
        //        this.secondname = secondname;
        //        this.fathername = fathername;
        //    }
        //    public override string ToString()
        //    {
        //        return $"Имя: {name} \nФамилия: {secondname} \nОтчество:{fathername}";
        //    }

        //}
        //public class persons
        //{
        //    person[] users;


        //    public persons()
        //    {
        //        users = new person[0];
        //    }
        //    public void add()
        //    {
        //        Console.WriteLine("Введите имя: ");
        //        string name = Console.ReadLine();
        //        Console.WriteLine("Введите Фамилию: ");
        //        string secondname = Console.ReadLine();
        //        Console.WriteLine("Введите Отчество: ");
        //        string fathername = Console.ReadLine();
        //        person person = new person(name, secondname, fathername);
        //        Array.Resize(ref users, users.Length + 1);
        //        users[users.Length - 1] = person;
        //    }

        //    public void remove()
        //    {
        //        Console.WriteLine("Кто сгинул?");
        //        var name = Console.ReadLine();

        //        var anyusers = new person[users.Length - 1];

        //            for (int i = 0; i < users.Length; i++)
        //            {
        //                if (users[i].name != name)
        //                {
        //                    int j = 0;
        //                    anyusers[j] = users[i];


        //                }
        //                users = anyusers;
        //            }


        //    }
        //    public void rnd()
        //    {
        //        Random r = new Random();
        //        int random = r.Next(0, users.Length);
        //        Console.WriteLine($"Пойдет {users[random]}");
        //    }

        //    public void print()
        //    {
        //        for (int i = 0; i < users.Length; i++)
        //        {
        //            Console.WriteLine(users[i].ToString());
        //        }


        //    }
        //}
        //public class app : menu
        //{
        //    public void start()
        //    {

        //        while (rabotaem)
        //        {

        //            printmenu();
        //            workmenu();
        //        }
        //    }
        //}




        //////////////////////////////////////////////////////////////////////////////
        //public class counter
        //{
        //    int count;
        //    public int Count
        //    {
        //        get
        //        {

        //            return count;
        //        }
        //        set
        //        {
        //            count = value;
        //        }
        //    }

        //    public int add()
        //    {
        //        if (count == 9)
        //        {
        //            count = 0;
        //        }
        //        else
        //        {
        //            count++;
        //        }
        //        return count;

        //    }
        //    public int decr()
        //    {
        //        if (count == 0)
        //        {
        //            count = 9;
        //        }
        //        else
        //        {
        //            count--;
        //        }
        //        return count;
        //    }

        //}







        // Наработки по созданию библиотеки
        //        public class Book
        //        {
        //            private string name;
        //            public string Name
        //            {
        //                get
        //                {
        //                    return name;
        //                }
        //                set
        //                {
        //                    name = value;
        //                }
        //            }

        //            public override string ToString()
        //            {
        //                return $"{name} {age}";

        //            }

        //            private int age;
        //            public int Age
        //            {
        //                get
        //                {
        //                    return age;
        //                }
        //                set
        //                {
        //                    age = value;
        //                }
        //            }




        //        }
        //        public class Books
        //        {
        //            public Book[] library;
        //            public Books()
        //            {
        //                library = new Book[0];
        //            }
        //            public void addBook()
        //            {
        //                Book book = new Book();
        //                Book[] newLib = new Book[library.Length+1];
        //                for (int i = 0; i <library.Length; i++)
        //                {
        //                    newLib[i] = library[i];
        //                }
        //                Console.WriteLine("Введите название книги");
        //                book.Name = Console.ReadLine();
        //                Console.WriteLine("Введите год");
        //                book.Age = Convert.ToInt32(Console.ReadLine());
        //                newLib[newLib.Length - 1] = book;
        //                library = newLib;
        //            }
        //            public void GetInfo()
        //            {
        //                for (int i = 0; i < library.Length; i++)
        //                {
        //                    Console.WriteLine(library[i].ToString());
        //                }
        //            }
        //            public void RemoveBook()
        //            {


        //                Console.WriteLine("Введите название книги");
        //                string name = Console.ReadLine();

        //                Console.WriteLine("Введите год");
        //                int age = Convert.ToInt32(Console.ReadLine());
        //                int Ind = 0;
        //                for (int i = 0; i <library.Length; i++)
        //                {
        //                    if (name == library[i].Name & age == library[i].Age)
        //                    {
        //                        Ind = i;
        //                    }
        //                }
        //                Book[] removeLib = new Book[library.Length-1];
        //                Book tmp = library[library.Length - 1];
        //                library[library.Length - 1] = library[Ind];
        //                library[Ind] = tmp;
        //                for (int i = 0; i <library.Length-1; i++)
        //                {
        //                    removeLib[i] = library[i];
        //                }
        //                library = removeLib;
        //            }
        //            public void Search()
        //            {
        //                Console.WriteLine("Введите название книги");
        //                string name = Console.ReadLine();

        //                Console.WriteLine("Введите год");
        //                int age = Convert.ToInt32(Console.ReadLine());
        //                for (int i = 0; i < library.Length; i++)
        //                {
        //                    if (name == library[i].Name & age == library[i].Age)
        //                    {
        //                        Console.WriteLine(library[i].ToString());
        //                        return;
        //                    }

        //                }
        //                Console.WriteLine("Такой книги нет");
        //            }
        //            public void SortbyName()
        //            {
        //                for (int i = 0; i < library.Length; i++)
        //                {
        //                    if (  ) < 0)  
        //                    {

        //                    }
        //                }
        //                {

        //                }
        //            }

        //        }


        //    }
        //}


        //public class Numbers
        //{
        //    int x;
        //    int y;

        //    public Numbers(int x, int y)
        //    {
        //        this.x = x;

        //        this.y = y;
        //        summa();
        //    }



        //        public interface Ibla
        //    {
        //        public void Iwork();
        //    }


