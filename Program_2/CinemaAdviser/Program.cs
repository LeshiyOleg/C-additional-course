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

            Console.WriteLine("Что хотим смотреть сегодня: комедия, драма, детектив, мульт, триллер, боевик");
            String genre = Console.ReadLine();
            if(genre == "комедия")
            {
                Console.WriteLine("В таком случае рекомендуем:");
                Console.WriteLine("Иван Васильевич меняет профессию");
                Console.WriteLine("Джентльмены удачи");
                Console.WriteLine("Назад в будущее");
                Console.WriteLine("1+1");
            }
                
            else if (genre == "драма")
            {
                Console.WriteLine("В таком случае рекомендуем к просмотру:");
                Console.WriteLine("Зеленая миля");
                Console.WriteLine("Побег из Шоушенка");
                Console.WriteLine("Форрест Гамп");
            }

            else if (genre == "детектив")
            {
                Console.WriteLine("Это все детективы, котороые у меня есть:");
                Console.WriteLine("Шерлок");
                Console.WriteLine("Достать ножи");
                Console.WriteLine("Черный ящик");
            }

            else if (genre == "мульт")
            {
                Console.WriteLine("Есть такие мультфильмы:");
                Console.WriteLine("Ну, погоди!");
                Console.WriteLine("Рататуй");
                Console.WriteLine("Шрэк");
                Console.WriteLine("Холодное сердце");
            }

            else if (genre == "триллер")
            {
                Console.WriteLine("Выбирай триллер:");
                Console.WriteLine("Бойцовский клуб");
                Console.WriteLine("Остров проклятых");
                Console.WriteLine("Престиж");
                Console.WriteLine("Семь");
            }

            else if (genre == "боевик")
            {
                Console.WriteLine("Какой боевик посмотришь?");
                Console.WriteLine("Карты, деньги, два ствола");
                Console.WriteLine("Джон Уик");
                Console.WriteLine("Крепкий орешек");
                Console.WriteLine("Убить Билла");
            }

            else
            {
                Console.WriteLine("К сожалению, пока это все жанры, которые мы можем тебе предложить, дружище!");
            }
            Console.ReadLine();
        
        
        }

    }
}
