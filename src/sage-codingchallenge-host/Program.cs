namespace Sage.CodingChallenge.Host {
    using System;
    using System.IO;

    class Program {
        static void Main(string[] args) {
            // TODO: Parse text and produce stats
            string content = ReadInputFile();

            Console.WriteLine(content);
        }

        /// <summary>
        /// This is an example method of initially reading the text from the required input resource. 
        /// It's scalability is questionable and the method will run synchronously, so feel free to refactor/replace with your own implementation here or as you deem appropriate.
        /// </summary>
        private static string ReadInputFile() {
            return File.ReadAllText(Path.Combine("resource", "StringInput.txt"));
        }
    }
}
