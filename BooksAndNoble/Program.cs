﻿using BooksAndNoble.Data.DataContext;
using BooksAndNoble.Data.Models;
using static System.Reflection.Metadata.BlobBuilder;
using System;

using BooksAndNobleContext _context = new BooksAndNobleContext();
/* OR:
    using (var _context =  new BooksAndNobleContext()) 
    {
        ...
        *Add/save stuff to database...*
        ...
    }
*/


Book scythe_NealShusterman = new Book()
{
    Title = "Scythe",
    Author = "Neal Shusterman",
    Genre = "Science Fiction",
    Price = 10.99M
};
_context.Add(scythe_NealShusterman); // context will implicitly detect which entity to add records to
// OR: _context.Books.Add(scythe_NealShusterman); 


Book wayOfKings_BrandonSanderson = new Book()
{
    Title = "The Way of Kings",
    Author = "Brandon Sanderson",
    Genre = "Fantasy",
    Price = 7.99M
};
_context.Add(wayOfKings_BrandonSanderson);


Book sapiens_YuvalNoahHarari = new Book()
{
    Title = "Sapiens: A Brief History of Humankind",
    Author = "Yuval Noah Harari",
    Genre = "Non-Fiction",
    Price = 9.99M
};
_context.Add(sapiens_YuvalNoahHarari);

_context.SaveChanges();



var results = _context.Books.Where(b => b.Price > 9).ToList();

Console.WriteLine($"Books that are more than $9:");
foreach (var result in results)
{
    Console.WriteLine($"{result.Title} by {result.Author}");
}
/* OUTPUT:
Books that are more than $9:
Scythe by Neal Shusterman
Sapiens: A Brief History of Humankind by Yuval Noah Harari
*/

