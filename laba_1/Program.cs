using System;
//Хуртин Никита БББО-08-19

namespace labaratornaya_1_main
{

  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("1-5 задание. 0-выйти.");
        //сценарии запуска программ
        switch (Console.ReadLine())
        {
          case "1": laba_1.practice_1(); break;
          case "2": laba_2.practice_2(); break;
          case "3": laba_3.practice_3(); break;
          case "4": laba_4.practice_4(); break;
          case "5": laba_5.practice_5(); break;
          case "0": return;

          default:
            Console.WriteLine("Вы ввели некоректное значение.");
            break;
        }
      }


  
    }
  }
}

