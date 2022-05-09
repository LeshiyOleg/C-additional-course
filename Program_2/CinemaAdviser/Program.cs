using System;

namespace CinemaAdviser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа КИНОВЕЧЕР");
            Console.WriteLine("Введите ваше имя");
            String name = Console.ReadLine();
            
            Console.WriteLine("Привет, " + name);

            Console.WriteLine("Что хотим смотреть сегодня: комедию, драму, детектив, мульт");
            String genre = Console.ReadLine();
            if(genre == "комедия")
            {
                Console.WriteLine("В таком случае рекомендуем:");
                Console.WriteLine("Иван Васильевич меняет профессию");
                Console.WriteLine("Джентльмены удачи");
                Console.WriteLine("Назад в будущее");
                Console.WriteLine("1+1");
            }
                
            if (genre == "драма")
            {
                Console.WriteLine("В таком случае рекомендуем к просмотру:");
                Console.WriteLine("Зеленая миля");
                Console.WriteLine("Побег из Шоушенка");
                Console.WriteLine("Форрест Гамп");
            }

            if (genre == "детектив")
            {
                Console.WriteLine("В таком случае рекомендуем к просмотру:");
                Console.WriteLine("Шерлок");
                Console.WriteLine("Достать ножи");
                Console.WriteLine("Черный ящик");
            }

            if (genre == "мульт")
            {
                Console.WriteLine("Ну, погоди!");
                Console.WriteLine("Рататуй");
                Console.WriteLine("Шрэк");
                Console.WriteLine("Холодное сердце");
            }

            else
            {
                Console.WriteLine("К сожалению, пока это все жанры, которые мы можем тебе предложить, дружище!");
            }
            Console.ReadLine();
        
        
        }

    }
}
