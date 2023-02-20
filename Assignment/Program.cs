using System;
using System.Threading.Tasks;

public class Backgroundop
{ 
    
    //asynchronous method take one parameter 
    public async Task WriteToFileAsync(string message)
    {  //  delay method by 3 seconds
        await Task.Delay(3000);
        await File.WriteAllTextAsync("tmp.txt", message);
    }
}

public class Program
{
    public static async Task Main()
    {  
        var op = new Backgroundop();

        // use while becouse loop will run continues . 
        while (true)
        {
            // Display a menu of options to the user.
           
            Console.WriteLine("1. Write 'Hello World' to tmp.txt");
            Console.WriteLine("2. Write current date to tmp.txt");
            Console.WriteLine("3. Write OS version to tmp.txt");
            Console.WriteLine("4. End the Task and out of the loop. ");
            Console.WriteLine("Enter Choice : ");

            // Read input from user side  
            var ch = Console.ReadLine();
            
          
            if (ch == "1")
            {
                var message = "Hello World";
                await op.WriteToFileAsync(message);
                Console.WriteLine($"{message} write to tmp.txt");
            }
            else if (ch == "2")
            {
                var message = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                await op.WriteToFileAsync(message);
                Console.WriteLine($"{message} write to tmp.txt");   
            }
            else if (ch == "3")
            {
                var message = Environment.OSVersion.VersionString;
                await op.WriteToFileAsync(message);
                Console.WriteLine($"{message} write to tmp.txt");
            }
            // out side of the loop 
            else if (ch == "4")
            {
                break;
            }
            else
            {
               // if Wrong input
                Console.WriteLine("Wrong Input... Please try again.");
            }
        }
    }

}

