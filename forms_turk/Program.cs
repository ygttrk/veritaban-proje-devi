using forms_turk.Context;
using forms_turk.Models;
using Microsoft.EntityFrameworkCore;

namespace forms_turk
{

    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormHome());
        }
    }
}