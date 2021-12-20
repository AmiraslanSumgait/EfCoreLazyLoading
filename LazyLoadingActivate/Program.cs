
using LazyLoadingActivate.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
  
        using (var context = new MyDbContext())
        {
            foreach (var category in context.Categories)
            {
                Console.WriteLine($"Category Name:{category.Name}");
                foreach (var book in category.Books)
                {
                    Console.WriteLine($"Book Name:{book.Name}");
                    Console.WriteLine($"Book Quantity:{book.Quantity}");
                    Console.WriteLine($"Book Price:{book.Price}");
                }
                Console.WriteLine("---------------");
            }
        }
    }
}