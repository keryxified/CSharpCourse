namespace Lesson7._1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string fileDirectory = args[0];
            string[] files = Directory.GetFiles(fileDirectory);
            using (FileStream fstream = new FileStream($"{fileDirectory}result.txt", FileMode.Append))
            {
                foreach (var file in files)
                {
                    var readFile = new FileStream(file, FileMode.Open);
                    readFile.CopyToAsync(fstream);
                    readFile.Close();
                }
                fstream.Close();
            }
        }
    }
}