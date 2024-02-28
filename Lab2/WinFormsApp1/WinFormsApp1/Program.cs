namespace WinFormsApp1
{
    internal class User
    {
        String fio, adress;
        List<string> user =  new List<string>();

        public User(string fio, string adress)
        {
            this.fio = fio;
            this.adress = adress;
            Add_User();
        }

        public string Fio { get; set; }
        public string Adress { get; set;}
        public void Add_User()
        {
            user.Add(fio);
            user.Add(adress);

        }

        public String print()
        {
            return adress + fio;
        }
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}