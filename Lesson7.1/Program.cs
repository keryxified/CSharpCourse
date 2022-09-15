namespace Lesson7.Filestream
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string fileDirectory = args[0];
            await WriteFileAsync(fileDirectory);
        }

        static async Task WriteFileAsync(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            using (var fstream = new FileStream($"{Path.Combine(dir, "result.txt")}", FileMode.Append))
            {
                foreach (var file in files)
                {
                    await using (var readFile = new FileStream(file, FileMode.Open))
                    {
                        await readFile.CopyToAsync(fstream);
                    }
                }
                fstream.Close();
            }
        }
    }
}