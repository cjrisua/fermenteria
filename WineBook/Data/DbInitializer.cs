using System;
using WineBook.Models;

namespace WineBook.Data
{
    public class DbInitializer
    {
        public static void Initialize(FermenteriaContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
