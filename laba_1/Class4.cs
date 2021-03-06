using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace labaratornaya_1_main
{
  class Worker
  {
    public string Name { get; set; }
    public int ID { get; set; }

  }

  class laba_4
  {
    public static async Task practice_4()
    {
      using (FileStream fs = new FileStream("person.json", FileMode.OpenOrCreate))
      {
        Worker tom = new Worker() { Name = "R6853", ID = 5060396 };
        await JsonSerializer.SerializeAsync<Worker>(fs, tom);
        Console.WriteLine("Данные сохранены в файл");
      }

      using (FileStream fs = new FileStream("person.json", FileMode.Open))
      {
        Worker restoredPerson = await JsonSerializer.DeserializeAsync<Worker>(fs);
        Console.WriteLine($"Name: {restoredPerson.Name}  Age: {restoredPerson.ID}");
      }

    }
  }
}
