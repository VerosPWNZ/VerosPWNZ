using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //Основные типы: int | float | char | string | bool


    //------------------------------------------------------|
    //Целочисленные типы:                                   |
    //byte b (from 0 to 255);                               |
    //sbyte sb (from -128 to 127) = ToSByte();              |
    //short s (from -32768 to 32767) = ToInt16();           |
    //ushort us (from 0 to 65535);                          |
    //int i (from -2147483648 to 2147483647) = ToInt32();   |
    //uint ui (from 0 to 4294672295);                       |
    //long l = long.MaxValue = ToInt64();                   |
    //ulong ul = ulong.MaxValue;                            |
    //------------------------------------------------------|


    //------------------------------------------------------|
    //Числа с плавающей точкой:                             |
    //float f = 5.7f = ToSingle();                          |
    //double d = 5.7d;                                      |
    //------------------------------------------------------|


    //------------------------------------------------------|
    //Символьный тип:                                       |
    //char c = ' ';                                         |
    //------------------------------------------------------|


    //------------------------------------------------------|
    //Строковый тип:                                        |
    //string str = "string" = ToString();                   |
    //------------------------------------------------------|


    //------------------------------------------------------|
    //Логический тип:                                       |
    //bool bl = ToBoolean();                                |
    //------------------------------------------------------|


    //------------------------------------------------------|
    //Арифметические операторы:                             |
    // +, -, *, /, %                                        |
    //------------------------------------------------------|


    //------------------------------------------------------|
    //Логические операторы:                                 |
    // ==, !=, >, <, >=, <=                                 |
    //------------------------------------------------------|


    //------------------------------------------------------|
    //Конкатенация:                                         |   
    //example1:                                             |    
    //string greeting = "Hi,";                              |
    //string name = "name";                                 |
    //string message = greeting + " " + name;               |
    //Console.WriteLine(message + ", glad to see you!");    |
    //------------------------------------------------------|
    //example2:                                             |
    //int age = 5;                                          |
    //Console.WriteLine("Hello, its " + age + "AM");        |
    //Console.WriteLine("Time to wake up!");                |
    //------------------------------------------------------|


    //------------------------------------------------------------|
    //Интерполяция:                                               |
    //int age = 54;                                               |
    //string name = "Name of human";                              |
    //string result = $"Youre name: {name}. \nYou are {age} y.o.";|
    //Console.WriteLine(result);                                  |    
    //------------------------------------------------------------|


    //------------------------------------------------------------|
    //Конвертация:                                                |  
    //example1:                                                   |
    //int age;                                                    |  
    //string input = 15;                                          |  
    //age = Convert.ToInt32(input);                               |
    //Console.WriteLine(age);                                     |
    //------------------------------------------------------------|
    //example2:                                                   |  
    //float result;                                               |
    //int x= 5, y= 2;                                             |
    //result = Convert.ToSingle (x) / y;                          |
    //Console.WriteLine(result);                                  |
    //------------------------------------------------------------|
    //example3:                                                   |  
    //int trigger = 1;                                            |
    //bool triggerInBoolean = Convert.ToBoolean(trigger);         |
    //Console.WriteLine(triggerInBoolean);                        |
    //int reconvert = Convert.ToInt32(trigger);                   |  
    //Console.WriteLine(reconvert);                               |
    //------------------------------------------------------------|


    //------------------------------------------------------------------|
    //Работа с консолью:                                                |   
    //Console.Write("Enter your name: ");                               |
    //string name;                                                      |
    //name = Console.ReadLine();                                        |
    //Console.WriteLine("What is your age?");                           |
    //int age;                                                          |
    //age = Convert.ToInt32(Console.ReadLine());                        |    
    //string userStats = $"Your name is: {name}, you are {age} y.o.";   |
    //Console.WriteLine(userStats);                                     |        
    //------------------------------------------------------------------|


    //------------------------------------------------------------------|
    //Инкремент и декремент:                                            |
    //example1(инкремент):                                              |
    //int i = 0;                                                        |
    //i++;                                                              |
    //Console.WriteLine(i);                                             |
    //------------------------------------------------------------------|
    //example2(декремент):                                              |
    //int i = 0;                                                        |
    //i--;                                                              |
    //Console.WriteLine(i);                                             |
    //------------------------------------------------------------------|
    //example3(префиксная и постфиксная форма):                         |    
    //int i = 0;                                                        |                                                             
    //Console.WriteLine(--i);                                           |
    //------------------------------------------------------------------|


    //-------------------------------------------------------------------|
    //Условный оператор "switch":                                        |       
    //string dayOfWeek;                                                  |   
    //dayOfWeek = Console.ReadLine();                                    |   
    //                                                                   |
    //switch (dayOfWeek)                                                 |
    //{                                                                  |       
    //case "case1":                                                      |   
    //case "case2":                                                      |   
    //case "case3":                                                      |   
    //Console.WriteLine("some text for case1 or 2 or 3");                |
    //    break;                                                         |
    //case "case4":                                                      |   
    //    Console.WriteLine("some text for case4");                      |   
    //    break;                                                         |
    //case "case5":                                                      |   
    //    Console.WriteLine("some text for case5");                      |
    //    break;                                                         |
    //default:                                                           |
    //    Console.WriteLine("You enter wrong case, please try again");   |
    //    break;                                                         |
    //-------------------------------------------------------------------|


    //------------------------------------------------------------------------------------------------------|
    //Циклы:                                                                                                |    
    //while (цикл с условием, выполняется до тех пор, пока условие истинно):                                |
    //int age;                                                                                              |    
    //                                                                                                      |
    //Console.Write("Введите Ваш возраст: ");                                                               |
    //                                                                                                      |
    //age = Convert.ToInt32(Console.ReadLine());                                                            |
    //                                                                                                      |
    //while (age-- > 0)                                                                                     |
    //{                                                                                                     |
    //}                                                                                                     |    
    //if (age == 5) //пропуск одной итерации                                                                |
    //{             //                                                                                      |
    //    continue; //                                                                                      |
    //}             //                                                                                      |    
    //                                                                                                      |
    //Console.WriteLine(age);                                                                               |    
    //                                                                                                      |
    //if (age == 5) //выход из цикла без ожидания завершения                                                |
    //{                                                                                                     |
    //    break;                                                                                            |
    //}                                                                                                     |    
    //}                                                                                                     |    
    //------------------------------------------------------------------------------------------------------|
    //for (цикл с параметром):                                                                              |
    //int age;                                                                                              |
    //                                                                                                      |
    //Console.Write("Введите ваш возраст: ");                                                               |
    //                                                                                                      |
    //age = Convert.ToInt32(Console.ReadLine());                                                            |    
    //                                                                                                      |
    //for (int i = 0; i <= 10; i++)                                                                         |    
    //{                                                                                                     |        
    //    Console.WriteLine($"Поздравляем! Вам исполнилось {i} лет!");                                      |
    //}                                                                                                     |            
    //------------------------------------------------------------------------------------------------------| 


    //------------------------------------------------------------------------------------------------------|
    //Массивы:                                                                                              |
    //Указание неточного размера массива                                                                    |    
    //int[] cucumbers = { 24, 25, 17, 38, 1000, int.MaxValue, int.MinValue};                                |
    //                                                                                                      |
    //for (int i = 0; i < cucumbers.Length; i++)                                                            |
    //{                                                                                                     |
    //    Console.Write(cucumbers[i] + " ");                                                                |
    //}                                                                                                     |
    //                                                                                                      |
    //                                                                                                      |    
    //Указание точного размера массива:                                                                     |    
    //int[] cucumbers = new int[10];                                                                        |
    //                                                                                                      |
    //Random rand = new Random();                                                                           |
    //                                                                                                      |        
    //for (int i = 0; i < cucumbers.Length; i++) //длина массива                                            |
    //{                                                                                                     |
    //    cucumbers[i] = rand.Next(0, 101); //присваивание случайного числа для массива                     |
    //    Console.Write(cucumbers[i] + " ");                                                                |
    //}                                                                                                     |    
    //------------------------------------------------------------------------------------------------------|


    //-------------------------
    //Многомерные массивы:
    //Объявление двумерного массива:
    //int[,] array;
    //--------------------------------------  
    //Инициализация нового массива:
    //int[,] array2 = new int[2, 3];
    //----------------------------
    //Создание значения для нового двумерного массива с помощью сокращенного инициализатора без указания точных размеров:
    //int[,] array3 =
    //{
    //{ 2, 3, 4 }, //0 
    //{ 4, 5, 1 }, //1
    //{ 7, 8, 9 }  //2
    //}; //0 //1 //2 
    //---------------------------------------
    //Создание двумерного массива с помощью сокращенного инициализатора с указанием точных размеров:
    //int[,] array4 = new int[2, 3]
    //{
    //    { 9, 8, 7 },
    //    { 6, 5, 4 }
    //};
    //------------------------------------
    //Обращение по индексу к конкретному элементу:
    //Console.WriteLine(array4[1, 1]);
    //-------------------------------------------------
    //Вывод длины массива на консоль
    //Console.WriteLine(array3.Length);
    //----------------------------------------------------
    //Создание многомерного массива при помощи класса "Random"
    //int[,] testRandomArray = new int[10, 10];
    //
    //Random rand = new Random();
    //
    //Перебирает строки
    //for (int i = 0; i < testRandomArray.GetLength(0); i++)
    //{
    //Перебирает каждый элемент в этих строках
    //for (int j = 0; j < testRandomArray.GetLength(1); j++)
    //{
    //Назначение нового значения последующему элементу массива
    //testRandomArray[i, j] = rand.Next(0, 10);
    //Console.Write(testRandomArray[i, j] + " ");
    //}
    //Console.WriteLine();
    //}
    //---------------------------------------------------------------------------------------


    //ПРАКТИКА:                                                                                                        
    //------------------------------------------------------------------------------------------------------|
    //Проверка пароля:                                                                                      |
    //string password = "123qwerty";                                                                        |   
    //string userInput;                                                                                     |
    //                                                                                                      |
    //Console.Write("Введите пароль: ");                                                                    |
    //                                                                                                      |       
    //userInput = Console.ReadLine();                                                                       |   
    //                                                                                                      |
    //if (userInput == password)                                                                            |
    //{                                                                                                     |
    //    Console.WriteLine("Пароль принят.");                                                              |
    //}                                                                                                     |   
    //                                                                                                      |   
    //else                                                                                                  |   
    //{                                                                                                     |   
    //    Console.WriteLine("Неверный пароль, повторите попытку.");                                         |   
    //}                                                                                                     |   
    //------------------------------------------------------------------------------------------------------|
    //Работа с консолью:                                                                                    |
    //Console.SetCursorPosition(0, 0); //Установка положения курсора                                        |
    //Console.ForegroundColor = ConsoleColor.Green; //Установка пользовательского цвета текста              |
    //Console.BackgroundColor = ConsoleColor.Red; //Установка пользовательского цвета зданего фона          |
    //Console.Clear(); //Очистка буфера консоли и ее окна                                                   |
    //Console.WindowHeight = 600; //Высота окна консоли                                                     |
    //Console.WindowWidth = 600; //Ширина окна консоли                                                      |
    //------------------------------------------------------------------------------------------------------|                                                                              


    //------------------------------------------------------------------------------------------------------|
    //Банкомат:                                                                                             |        
    //float rublesInWallet;                                                                                 |
    //float dollarInWallet;                                                                                 |
    //                                                                                                      |
    //int rubToUsd = 64;                                                                                    |
    //int usdToRub = 66;                                                                                    |    
    //                                                                                                      |
    //float exchangeCurrencyCount; //сумма, которую хочет обменять пользователь                             |
    //                                                                                                      |
    //string desiredOperation; //выбранная операция                                                         |
    //                                                                                                      |
    //Console.WriteLine("Добро пожаловать в обменный пункт валюты!");                                       |
    //Console.Write("Введите баланс рублей: ");                                                             |
    //rublesInWallet = Convert.ToSingle(Console.ReadLine());                                                |
    //Console.Write("Введите баланс долларов: ");                                                           |
    //dollarInWallet = Convert.ToSingle(Console.ReadLine());                                                |    
    //                                                                                                      |
    //Console.WriteLine("Выберите необходимую операцию: ");                                                 |    
    //Console.WriteLine("USD to RUB");                                                                      |    
    //Console.WriteLine("RUB to USD");                                                                      |    
    //Console.Write("Ваш выбор: ");                                                                         |
    //desiredOperation = Console.ReadLine();                                                                |    
    //                                                                                                      |
    //switch (desiredOperation)                                                                             |
    //{                                                                                                     |    
    //    case "USD to RUB":                                                                                |        
    //        Console.WriteLine("Конвертация долларов в рубли.");                                           |
    //        Console.WriteLine("Введите количество необходимой валюты для обмена: ");                      |
    //        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());                                 |    
    //        if (dollarInWallet >= exchangeCurrencyCount)                                                  |            
    //        {                                                                                             |
    //            dollarInWallet -= exchangeCurrencyCount;                                                  |    
    //            rublesInWallet += exchangeCurrencyCount * usdToRub;                                       |
    //        }                                                                                             |
    //        else                                                                                          |        
    //        {                                                                                             |    
    //            Console.WriteLine("Недостаточно средств на балансе.");                                    |
    //        }                                                                                             |
    //        break;                                                                                        |
    //    case "RUB to USD":                                                                                |
    //        Console.WriteLine("Конвертация рублей в доллары.");                                           |
    //        Console.WriteLine("Введите количество необходимой валюты для обмена: ");                      |    
    //        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());                                 |
    //        if (rublesInWallet >= exchangeCurrencyCount)                                                  |        
    //        {                                                                                             |
    //            rublesInWallet -= exchangeCurrencyCount;                                                  |        
    //            dollarInWallet += exchangeCurrencyCount / rubToUsd;                                       |       
    //        }                                                                                             |
    //        else                                                                                          |
    //        {                                                                                             |
    //            Console.WriteLine("Недостаточно средств на балансе.");                                    |    
    //        }                                                                                             |    
    //        break;                                                                                        |
    //    default:                                                                                          |
    //        Console.WriteLine("Неверный ввод");                                                           |
    //        break;                                                                                        |
    //}                                                                                                     |            
    //                                                                                                      |
    //Console.WriteLine($"Ваш баланс: {rublesInWallet} рублей и " + $" {dollarInWallet} долларов." );       |
    //------------------------------------------------------------------------------------------------------|


    //------------------------------------------------------------------------------------------------------|
    //Практика с циклами:                                                                                   |
    //                                                                                                      |
    //Ввод пароля с ограничение на количество попыток:                                                      |            
    //int triesCount = 6;                                                                                   |
    //string password = "12345"                                                                             |    
    //string userInput;                                                                                     |
    //                                                                                                      |
    //for(int i = 1; i < triesCount; i++ )                                                                  |
    //{                                                                                                     |
    //    Console.Write("Введите пароль: ");                                                                |
    //    userInput = Console.ReadLine();                                                                   |    
    //    if ( userInput == password)                                                                       |
    //    {                                                                                                 |
    //        Console.WriteLine("Доступ к данным разрешен");                                                |    
    //        break;                                                                                        |
    //    }                                                                                                 |    
    //    else                                                                                              |    
    //    {                                                                                                 |
    //        Console.WriteLine("Введен неверный пароль");                                                  |
    //        Console.WriteLine("У вас осталось попыток: " + (triesCount - (i + 1)));                       |
    //    }                                                                                                 |
    //}                                                                                                     |    
    //------------------------------------------------------------------------------------------------------|
    //Увеличение вклада по процентам:                                                                       |
    //float money;                                                                                          |       
    //int years;                                                                                            |                                                                                  
    //int percent;                                                                                          |    
    //                                                                                                      |                                                                       
    //Console.Write("Введите количество денег, внесенных на вклад: ");                                      |
    //money = Convert.ToSingle(Console.ReadLine());                                                         |
    //Console.WriteLine("На сколько лет открыт вклад?");                                                    |
    //years = Convert.ToInt32(Console.ReadLine());                                                          |
    //Console.WriteLine("Под какой процент?");                                                              |
    //percent = Convert.ToInt32(Console.ReadLine());                                                        |
    //                                                                                                      |
    //for (int i = 0; i < years; i++)                                                                       |
    //{                                                                                                     |
    //    money += money / 100 * percent;                                                                   |
    //    Console.WriteLine("В этом году у вас " + money);                                                  |
    //    Console.ReadKey();                                                                                |    
    //}                                                                                                     |    
    //------------------------------------------------------------------------------------------------------|    
    //Битва игрока с противником:                                                                           |        
    //int playerHealth = 100;                                                                               |
    //int playerDamage = 50;                                                                                |    
    //int enemyHealth = 100;                                                                                |
    //int enemyDamage  = 30;                                                                                |
    //                                                                                                      |    
    //while (playerHealth > 0 && enemyHealth > 0)                                                           |
    //{                                                                                                     |    
    //    playerHealth -= enemyDamage;                                                                      |
    //    enemyHealth -= playerDamage;                                                                      |
    //                                                                                                      |        
    //    Console.WriteLine("Враг нанес " + enemyDamage + " урона");                                        |
    //    Console.WriteLine("У игрока осталось здоровья: " + playerHealth);                                 |    
    //    Console.WriteLine("Игрок нанес " + playerDamage + " урона");                                      |    
    //    Console.WriteLine("У врага осталось здоровья: " + enemyHealth);                                   |    
    //}                                                                                                     |
    //                                                                                                      |
    //if (playerHealth <= 0 && enemyHealth <= 0)                                                            |
    //{                                                                                                     |
    //    Console.WriteLine("Ничья");                                                                       |    
    //}                                                                                                     |    
    //                                                                                                      |
    //else if (enemyHealth <= 0)                                                                            |
    //{                                                                                                     |
    //    Console.WriteLine("Победа игрока");                                                               |
    //}                                                                                                     |    
    //                                                                                                      |
    //else if (playerHealth <= 0)                                                                           |
    //{                                                                                                     |
    //    Console.WriteLine("Игрок был побежден врагом");                                                   |    
    //}                                                                                                     |    
    //------------------------------------------------------------------------------------------------------|


    //----------------------------------------------------------------------------------------------------------------------|   
    //Практика с классом "Random":                                                                                          |
    //Random rand = new Random();                                                                                           |
    //int value;                                                                                                            |
    //                                                                                                                      |
    //while (true)                                                                                                          |
    //{                                                                                                                     |        
    //    value = rand.Next(0, 2);                                                                                          |
    //    Console.WriteLine(value);                                                                                         |
    //    Console.ReadKey();                                                                                                |
    //}                                                                                                                     |
    //----------------------------------------------------------------------------------------------------------------------|
    //Random rand = new Random();                                                                                           |
    //                                                                                                                      |
    //for (int i = 0; i < 5; i++)                                                                                           |
    //{                                                                                                                     |
    //    Console.WriteLine(rand.Next(0, 5));                                                                               |
    //}                                                                                                                     |
    //----------------------------------------------------------------------------------------------------------------------|
    //Игра "Угадай число"                                                                                                   |
    //int number;                                                                                                           |
    //int lower, higher;                                                                                                    |
    //int triesCount = 5;                                                                                                   |
    //int userInput;                                                                                                        |
    //Random rand = new Random();                                                                                           |
    //                                                                                                                      |
    //number = rand.Next(0, 101);                                                                                           |
    //lower = rand.Next(number - 10, number);                                                                               |
    //higher = rand.Next(number + 1, number + 10);                                                                          |
    //Console.WriteLine($"Мы загадали число от {number}. Оно больше чем {lower}, но меньше чем {higher}");                  |
    //Console.WriteLine("Что это за число?");                                                                               |
    //Console.WriteLine("У вас осталось попыток: " + triesCount);                                                           |
    //                                                                                                                      |
    //while ( triesCount-- > 0 )                                                                                            |    
    //{                                                                                                                     |
    //    Console.Write("Ваш ответ: ");                                                                                     |
    //    userInput = Convert.ToInt32(Console.ReadLine());                                                                  |
    //                                                                                                                      |    
    //    if (userInput == number)                                                                                          |
    //    {                                                                                                                 |
    //        Console.WriteLine("Вы оказались правы! Это число " + number + ".");                                           |
    //        break;                                                                                                        |    
    //    }                                                                                                                 |
    //                                                                                                                      |
    //    else                                                                                                              |    
    //    {                                                                                                                 |    
    //        Console.WriteLine("Неверно! Попробуйте еще раз.");                                                            |
    //        Console.WriteLine("Попыток осталось: " + triesCount);                                                         |    
    //    }                                                                                                                 |
    //}                                                                                                                     |
    //                                                                                                                      |
    //if (triesCount < 0)                                                                                                   |
    //{                                                                                                                     |
    //    Console.WriteLine("Вы исчерпали все свои попытки, повезет в другой раз!");                                        |
    //    Console.WriteLine("Правильное число было: " + number);                                                            |
    //}                                                                                                                     |
    //----------------------------------------------------------------------------------------------------------------------|
    //Битва игрока с противником (с использованием класса "Random")                                                         |
    //Random rand = new Random();                                                                                           |
    //float playerHealth = rand.Next(90, 110);                                                                              |    
    //int playerArmor = rand.Next(45, 100);                                                                                 |    
    //int playerDamage = rand.Next(7, 35);                                                                                  |
    //                                                                                                                      |        
    //float enemyHealth = rand.Next(80, 120);                                                                               |
    //int enemyArmor = rand.Next(65, 100);                                                                                  |    
    //int enemyDamage = rand.Next(5, 40);                                                                                   |
    //                                                                                                                      |
    //Console.WriteLine($"Игрок имеет {playerHealth} здоровья и {playerArmor} брони, нанес урона: {playerDamage}");         |    
    //Console.WriteLine($"Противник имеет {enemyHealth} здоровья и {enemyArmor} брони, нанес урона: {enemyDamage}");        |
    //                                                                                                                      |
    //while (playerHealth > 0 && enemyHealth > 0)                                                                           |
    //{                                                                                                                     |    
    //    playerHealth -= Convert.ToSingle(rand.Next(0, enemyDamage + 1)) / 100 * playerArmor;                              |    
    //    enemyHealth -= Convert.ToSingle(rand.Next(0, playerDamage + 1)) / 100 * enemyArmor;                               |
    //                                                                                                                      |
    //    Console.WriteLine($"У игрока осталось {playerHealth} здоровья и {playerArmor} брони");                            |
    //    Console.WriteLine($"У противника осталось {enemyHealth} здоровья и {enemyArmor} брони");                          |
    //}                                                                                                                     |
    //                                                                                                                      |        
    //if (playerHealth <= 0 && enemyHealth <= 0)                                                                            |                
    //{                                                                                                                     |            
    //    Console.WriteLine("Ничья");                                                                                       |    
    //}                                                                                                                     |    
    //else if (enemyHealth <= 0)                                                                                            |
    //{                                                                                                                     |    
    //    Console.WriteLine("Победа игрока");                                                                               |
    //}                                                                                                                     |
    //else if (playerHealth <= 0)                                                                                           |
    //{                                                                                                                     |
    //    Console.WriteLine("Игрок был побежден врагом");                                                                   |      
    //}                                                                                                                     |
    //----------------------------------------------------------------------------------------------------------------------|


    //----------------------------------------------------------------------------------------------------------------------|
    //Практика работы с массивами:                                                                                          |
    //Создание программы отвечающая за регистрацию пассажиров на рейс самолета                                              |
    //int[] sectors = { 6, 28, 15, 15, 17 };                                                                                |
    //bool isOpen = true;                                                                                                   |        
    //                                                                                                                      |    
    //while (isOpen)                                                                                                        |
    //{                                                                                                                     |
    //    Console.SetCursorPosition(0, 23);                                                                                 |
    //    for (int i = 0; i < sectors.Length; i++)                                                                          |    
    //    {                                                                                                                 |
    //        Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест. ");                                         |    
    //    }                                                                                                                 |
    //                                                                                                                      |
    //    Console.SetCursorPosition(0, 0);                                                                                  |    
    //    Console.WriteLine("Регистрация рейса.");                                                                          |
    //    Console.WriteLine("\n\n1 - Бронирование рейса. \n\n2 - Выход из программы.\n\n");                                 |
    //    Console.Write("Введите номер команды: ");                                                                         |
    //                                                                                                                      |            
    //    switch (Convert.ToInt32(Console.ReadLine()))                                                                      |
    //    {                                                                                                                 |
    //        case 1:                                                                                                       |    
    //            int userSector, userPlaceAmount;                                                                          |
    //            Console.WriteLine("\nПожалуйста, выберите в каком секторе вы хотите лететь?");                            |
    //            userSector = Convert.ToInt32(Console.ReadLine()) - 1;                                                     |    
    //            if (sectors.Length <= userSector || userSector < 0)                                                       |
    //            {                                                                                                         |
    //                Console.WriteLine("\nТакого сектора не существует.");                                                 |    
    //                break;                                                                                                |
    //            }                                                                                                         |
    //            Console.WriteLine("\nСколько мест вы хотите забронировать?");                                             |
    //            userPlaceAmount = Convert.ToInt32(Console.ReadLine());                                                    |
    //            if (userPlaceAmount < 0)                                                                                  |
    //            {                                                                                                         |
    //                Console.WriteLine("Неверное количество мест.");                                                       |
    //                break;                                                                                                |
    //            }                                                                                                         |    
    //            if (sectors[userSector] < userPlaceAmount)                                                                |
    //            {                                                                                                         |
    //                Console.WriteLine($"\nОшибка. В секторе {userSector + 1} недостаточно мест.");                        |    
    //                Console.WriteLine($"В данном секторе осталось {sectors[userSector]} мест");                           |
    //                break;                                                                                                |    
    //            }                                                                                                         |
    //            sectors[userSector] -= userPlaceAmount;                                                                   |
    //            Console.WriteLine("\nМеста были успешно забронированы.");                                                 |
    //            break;                                                                                                    |        
    //        case 2:                                                                                                       |
    //            isOpen = false;                                                                                           |
    //            Console.Clear();                                                                                          |
    //            break;                                                                                                    |
    //    }                                                                                                                 |
    //                                                                                                                      |    
    //    Console.ReadKey();                                                                                                |
    //    Console.Clear();                                                                                                  |
    //}                                                                                                                     |    
    //----------------------------------------------------------------------------------------------------------------------|
    //Определение максимального элемента в массиве                                                                          |
    //int[] array = { 1, 3, 5, 8, 12, 2, 25 };                                                                              |    
    //int maxElement = int.MinValue;                                                                                        |
    //                                                                                                                      |            
    //for (int i = 0; i < array.Length; i++)                                                                                |
    //{                                                                                                                     |
    //    if (maxElement < array[i])                                                                                        |
    //    {                                                                                                                 |    
    //        maxElement = array[i];                                                                                        |
    //    }                                                                                                                 |
    //}                                                                                                                     |    
    //                                                                                                                      |
    //Console.WriteLine(maxElement);                                                                                        |
    //----------------------------------------------------------------------------------------------------------------------|
    //Расчет суммы каждого элемента массива                                                                                 |        
    //int[] array = { 2, 3, 4, 7, 8 };                                                                                      |
    //int sum = 0;                                                                                                          |
    //                                                                                                                      |
    //for (int i = 0; i < array.Length; i++)                                                                                |
    //{                                                                                                                     |    
    //    sum += array[i];                                                                                                  |
    //}                                                                                                                     |    
    //                                                                                                                      |
    //Console.WriteLine(sum);                                                                                               |
    //----------------------------------------------------------------------------------------------------------------------|
    //Вывод каждого значения в консоль                                                                                      |
    //int[] array = { 2, 3, 4, 7, 8 };                                                                                      |
    //                                                                                                                      |    
    //for (int i = 0; i < array.Length; i++)                                                                                |
    //{                                                                                                                     |
    //    Console.WriteLine(array[i]);                                                                                      |    
    //}                                                                                                                     |    
    //                                                                                                                      |
    //----------------------------------------------------------------------------------------------------------------------|


    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
    //Практика работы с многомерными массивами:                                                                                                                                                    | 
    ////Система управления библиотекой                                                                                                                                                             |     
    //bool isOpen = true;                                                                                                                                                                          |                 
    //string[,] books =                                                                                                                                                                            |                             
    //{                                                                                                                                                                                            |         
    //    {"А.С. Пушкин", "М.Ю. Лермонтов", "С.А. Есенин"},                                                                                                                                        | 
    //    {"Роберт Мартин", "Джесси Шелл", "С.А. Тепляков"},                                                                                                                                       | 
    //    {"Стивен Кинг", "Говард Лавкрафт", "Брем Стокер"}                                                                                                                                        | 
    //};                                                                                                                                                                                           |             
    //                                                                                                                                                                                             |         
    //while (isOpen)                                                                                                                                                                               |     
    //{                                                                                                                                                                                            |     
    //    Console.SetCursorPosition(0, 20);                                                                                                                                                        | 
    //    Console.WriteLine("\nВесь список авторов:\n");                                                                                                                                           | 
    //    for (int i = 0; i < books.GetLength(0); i++)                                                                                                                                             |     
    //    {                                                                                                                                                                                        |                                 
    //        for (int j = 0; j < books.GetLength(1); j++)                                                                                                                                         | 
    //        {                                                                                                                                                                                    |                                     
    //            Console.Write(books[i, j] + " | ");                                                                                                                                              | 
    //        }                                                                                                                                                                                    |                                 
    //        Console.WriteLine(); //Для перехода на следующую строку                                                                                                                              | 
    //    }                                                                                                                                                                                        |                     
    //    Console.SetCursorPosition(0, 0);                                                                                                                                                         | 
    //    Console.WriteLine("Библиотека"); //Название программы                                                                                                                                    | 
    //    Console.WriteLine("\n1 - Узнать имя автора по индексу книги." +                                                                                                                          | 
    //        "\n\n2 - Найти книгу по автору." +                                                                                                                                                   |                  
    //        "\n\n3 - Выход из программы");                                                                                                                                                       | 
    //    Console.WriteLine("\nВыберите пункт меню: ");                                                                                                                                            | 
    //                                                                                                                                                                                             |             
    //    switch (Convert.ToInt32(Console.ReadLine()))                                                                                                                                             | 
    //    {                                                                                                                                                                                        |                         
    //        case 1:                                                                                                                                                                              |         
    //            int line, column;                                                                                                                                                                | 
    //            Console.Write("Введите номер полки: ");                                                                                                                                          | 
    //            line = Convert.ToInt32(Console.ReadLine()) - 1;                                                                                                                                  | 
    //            Console.WriteLine("Введите номер столбца: ");                                                                                                                                    | 
    //            column = Convert.ToInt32(Console.ReadLine()) - 1;                                                                                                                                | 
    //            Console.WriteLine("Это автор " + books[line, column]);                                                                                                                           | 
    //            break;                                                                                                                                                                           |             
    //        case 2:                                                                                                                                                                              |                 
    //            string author;                                                                                                                                                                   |     
    //            bool authorIsFound = false;                                                                                                                                                      | 
    //            Console.WriteLine("Введите автора: ");                                                                                                                                           | 
    //            author = Console.ReadLine();                                                                                                                                                     | 
    //            for (int i = 0; i < books.GetLength(0); i++)                                                                                                                                     | 
    //            {                                                                                                                                                                                |                 
    //                for (int j = 0; j < books.GetLength(1); j++)                                                                                                                                 | 
    //                {                                                                                                                                                                            |                                     
    //                    if (author.ToLower() == books[i, j].ToLower()) //Приводит копию строки к нижнему регистру                                                                                | 
    //                    {                                                                                                                                                                        |                             
    //                        Console.Write($"Автор {books[i, j]} находится по адресу: {i + 1} полка и {j + 1} место.");                                                                           | 
    //                        authorIsFound = true;                                                                                                                                                | 
    //                        Console.ReadKey();                                                                                                                                                   | 
    //                    }                                                                                                                                                                        |                     
    //                    else if (author.ToUpper() == books[i, j].ToUpper()) //Приводит копию строки к верхнему регистру                                                                          | 
    //                    {                                                                                                                                                                        |                     
    //                        Console.Write($"Автор {books[i, j]} находится по адресу: {i + 1} полка и {j + 1} место.");                                                                           | 
    //                        authorIsFound = true;                                                                                                                                                | 
    //                        Console.ReadKey();                                                                                                                                                   | 
    //                    }                                                                                                                                                                        |                     
    //                }                                                                                                                                                                            |                 
    //            }                                                                                                                                                                                |                                  
    //            if (authorIsFound == false)                                                                                                                                                      |  
    //            {                                                                                                                                                                                |     
    //                Console.WriteLine("Такого автора нету.");                                                                                                                                    | 
    //            }                                                                                                                                                                                |                                 
    //            break;                                                                                                                                                                           |                                 
    //        case 3:                                                                                                                                                                              |         
    //            if (isOpen)                                                                                                                                                                      | 
    //            {                                                                                                                                                                                |                                     
    //                Console.WriteLine("\nВыход из программы. Нажмите любую клавишу для продолжения..."); //Дополнительная проверка работы программы после выполнения какой-либо операции         |     
    //            }                                                                                                                                                                                |                                                 
    //            isOpen = false;                                                                                                                                                                  | 
    //            break;                                                                                                                                                                           |                     
    //        default:                                                                                                                                                                             |                                 
    //            Console.WriteLine("Неверный ввод. Повторите попытку.");                                                                                                                          | 
    //            break;                                                                                                                                                                           |                                                         
    //                                                                                                                                                                                             |                                                         
    //    }                                                                                                                                                                                        |                                             
    //                                                                                                                                                                                             |                                         
    //    Console.ReadKey(); //Обновление цикла только после нажатия на клавишу                                                                                                                    | 
    //    Console.Clear(); //Очистка консоли после выполнения каждой операции                                                                                                                      | 
    //}                                                                                                                                                                                            |                                 
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
}