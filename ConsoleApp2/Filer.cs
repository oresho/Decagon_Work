using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Filer
    {
        private const string FilePath = @"C:\Users\HP\Desktop\Decagon\MyFile.txt";
        public Filer()
        {
            while (true)
            {
                Console.WriteLine("Press 1 for SignUp or 2 for Login");
                if (!int.TryParse(Console.ReadLine(), out int input)) 
                { 
                    Console.WriteLine("Please input 1 or 2"); 
                }
                string? username, password;
                switch(input)
                {
                    case 1:
                        var signinputs = GetInput();
                        username = signinputs[0];
                        password = signinputs[1];
                        SignUp(username, password);
                        break;

                    case 2:
                        var loginputs = GetInput();
                        username = loginputs[0];
                        password = loginputs[1];
                        Login(username, password);
                        break;

                    default:
                        Console.WriteLine("You can only input 1 or 2"); break;
                }
            }
        }
        string[] GetInput()
        {
            Console.Write("Username: ");
            var username = Console.ReadLine();
            Console.Write("Password: ");
            var password = Console.ReadLine();
            return new string[] { username, password };
        }

        private void Login(string? username, string? password)
        {
            CreateFile();
            // Read the CSV file and store user credentials in a dictionary
            Dictionary<string, string> credentials = ReadCredentials();

            // Check if a provided username and password match any entry in the credentials dictionary
            if (credentials.ContainsKey(username) && credentials[username] == password)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }

        private void SignUp(string? username, string? password)
        {
            CreateFile();
            // Read the CSV file and store user credentials in a dictionary
            Dictionary<string, string> credentials = ReadCredentials();

            // Check if a provided username and password match any entry in the credentials dictionary
            if (credentials.ContainsKey(username) && credentials[username] == password)
            {
                Console.WriteLine("Credentials already exist please Login instead");
            }
            else
            {
                WriteCredentials(username, password);
                Console.WriteLine("You may Login.");
            }
        }
    

        private void CreateFile()
        {
            if (!File.Exists(FilePath)) 
            {
                //FileStream fileStream = new FileStream(FilePath, FileMode.Create);
                //fileStream.Close();
                File.Create(FilePath).Close();
                Console.Write($"File has been created and the Path is {FilePath}");
            }
        }

        static Dictionary<string, string> ReadCredentials()
        {
            Dictionary<string, string> credentials = new Dictionary<string, string>();

            try
            {
                // Read lines from the CSV file
                string[] lines = File.ReadAllLines(FilePath);

                // Parse each line and extract username and password
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        string username = parts[0].Trim();
                        string password = parts[1].Trim();
                        // Add username and password to the dictionary
                        credentials.Add(username, password);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }

            return credentials;
        }

        private void WriteCredentials(string username, string password)
        {
            if (File.Exists(FilePath))
            {
                //FileStream fileStream = new FileStream(FilePath, FileMode.Append);
                byte[] bytedata = Encoding.Default.GetBytes($"{username},{password}\n");
                List<string> lines = [$"{username},{password}\n"];
                //fileStream.Write(bytedata, 0, bytedata.Length);
                //fileStream.Close();
                File.AppendAllLines(FilePath, lines);
                Console.WriteLine("Successfully saved new Credentials to File");
            }
        }
    }
}
