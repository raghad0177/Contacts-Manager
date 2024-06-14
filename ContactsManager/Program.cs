namespace ContactsManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string[]> Contact = new List<string[]>
        {
            new string[] { "Ali", "1234" },
            new string[] { "Ahmad","12345"},
            new string[] {"Malek","123456" }
        };

            // View All 
            List<string[]> x = ContactsManager.CManager.ContactsManager("VeiwAll",Contact);
            Console.WriteLine("View All");
            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine(x[i][0] + " " + x[i][1]);
            }
            Console.WriteLine("");
            // Add
            List<string[]> y = ContactsManager.CManager.ContactsManager("Add", Contact, "Khaled");
            Console.WriteLine("Add Khaled");
            for (int i = 0; i < y.Count; i++)
            {
                Console.WriteLine(y[i][0] + " " + y[i][1]);
            }
            Console.WriteLine("");
            // Delete
            List<string[]> z = ContactsManager.CManager.ContactsManager("Delete", Contact, "Ali");
            Console.WriteLine("Delete Ali");
            for (int i = 0; i < z.Count; i++)
            {
                Console.WriteLine(z[i][0] + " " + z[i][1]);
            }
        }

    
}
}
