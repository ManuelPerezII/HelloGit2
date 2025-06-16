using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // alyssa change

        static async Task Main(string[] args)
        {
            var response = GetData();

            // Write each directory name to a file.
            try
            {
                int x = 0;
                int y = 10;
                var xy = y / x;
            }
            catch (Exception e)
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\manuel.perez\Documents\Test\log.txt", true))
                {
                    sw.WriteLine(DateTime.Now.ToString() + " Error :" + e.Message);
                }

            }
            

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader(@"C:\Users\manuel.perez\Documents\Test\log.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Task boilWaterTask = BoilWaterAsync();
            //BoilWaterAsync2();
            ChopVegetables();
            BoilWaterAsync2();

            await boilWaterTask;

        }

        public static (List<string> numbers, string Error, bool isSuccess) GetData()
        {
            List<string> data = new List<string>();
            data.Add("A");
            string error = "";
            bool isSuccess = false;
            try
            {

            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return (data, error, isSuccess);
        }

        static void BoilWaterAsync2()
        {
            Console.WriteLine("Boiling water2 started...");
            Task.Delay(4000);
            Console.WriteLine("Water2 is boiling done!");
        }

        static async Task BoilWaterAsync()
        {
            Console.WriteLine("Boiling water started...");
            await Task.Delay(4000); 
            Console.WriteLine("Water is boiling done!");
        }

        static void ChopVegetables()
        {
            Console.WriteLine("Chopping vegetables started...");
            Task.Delay(2000).Wait(); 
            Console.WriteLine("Vegetables chopped done.");
        }

        static async Task<string> DisplayReader()
        {
            string filePath = @"C:\Users\manuel.perez\Documents\Test\log.text";
            StreamReader streamReader = new StreamReader(filePath);
            string value = "";

            value = await streamReader.ReadToEndAsync();


            return value;
        }

        static string DisplayReader2()
        {
            string filePath = @"C:\Users\manuel.perez\Documents\Test\log.text";
            StreamReader streamReader = new StreamReader(filePath);
            string value = "";

            value = streamReader.ReadToEnd();


            return value;
        }
    }
}
