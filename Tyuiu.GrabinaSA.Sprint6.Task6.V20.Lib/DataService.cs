using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GrabinaSA.Sprint6.Task6.V20.Lib
{
    public class DataService : ISprint6Task6V20
    {
        public string CollectTextFromFile(string str, string path)
        {
            string resStr = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] strings = line.Trim().Split(' ');
                    if (strings.Length > 1)
                    {
                        resStr += strings[1] + " ";
                    }
                }
            }
            return resStr.Trim();
        }
    }
}
