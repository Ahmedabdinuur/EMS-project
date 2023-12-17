using EMS.MyDB;
namespace EMS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            using (var context = new ContextDB()){context.Database.EnsureCreated();}
            Application.Run(new Mainform());
        }
    }
}