namespace Agile_Udvikling
{
    public class Program
    {


        static void Main()
        {
            Console.Write("Fornavn:");
            string first_name_id = GetNameId(Console.ReadLine());

            Console.Write("Efternavn:");
            string last_name_id = GetNameId(Console.ReadLine());

            string four_letters_first_name = first_name_id;
            string four_letters_last_name = last_name_id;
            int current_time = DateTime.Now.Millisecond;

            string id = GetId(four_letters_first_name, four_letters_last_name, current_time);
            Console.WriteLine(id);
        }

        static public string GetNameId(string name)
        {
            name = name.Replace(" ", "");
            int substringLength = name.Length >= 4 ? 4 : name.Length;
            name = name.Substring(0, substringLength).ToLower();
            return FillId(name);
        }


        static public string GetId(string first_name_id, string last_name_id, int milliseconds)
        {
            return first_name_id + last_name_id + milliseconds;
        }

        static public string FillId(string id, int requiredLength = 4)
        {
            return id.PadRight(requiredLength, 'X');
        }
    }
}