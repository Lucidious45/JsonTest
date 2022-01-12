using System;

namespace JsonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new DataStore();

            var menu = new SMUtils.Menu();

            menu.AddOption('1', "Set Student Details", () => store.SetStudent(LeerlingView.CreateLeerling)));
        }
    }
}
