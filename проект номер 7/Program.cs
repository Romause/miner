namespace проект_номер_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int x = 1;

            List <string> list = new List<string>();

            for (int i = 0; i < 2; i++)
            {
                list.Add(Console.ReadLine());//строки с консоли
            }
            //циклы для перебора списков
            foreach (string str1 in list) 
            { 
                Console.WriteLine("елемент списка:"+str1);
            }
        }
    }
}