using System;
using c_basics_session05;

Book book = new Book();

//Q1
 Console.WriteLine(book.password);
//  'Book.password' is inaccessible due to its protection level

//Q2
 Console.WriteLine(book.copiesInStock);
//  internal = same assembly only, and Main is in a different project

//Q3
book.Title = "Dune";
Console.WriteLine(book.Title);               // Dune

//Q4
book.Genre = Genre.Science;
Console.WriteLine(book.Genre);               // Science

//Q5
Console.WriteLine((int)Genre.Fiction);       // 0
Console.WriteLine((int)Genre.NonFiction);    // 1
Console.WriteLine((int)Genre.Science);       // 2

//Q6
int genreNumber = 1;
Genre fromNumber = (Genre)genreNumber;
Console.WriteLine(fromNumber);               // NonFiction

//Q7
Genre genre = Genre.Fiction;
string genreString = genre.ToString();
Console.WriteLine(genreString);              // Fiction

//Q8
string genreText = "Science";
Genre parsed = (Genre)Enum.Parse(typeof(Genre), genreText);
Console.WriteLine(parsed);                   // Science

//Q9
string invalidText = "Mystery";
if (Enum.TryParse(invalidText, out Genre result))
    Console.WriteLine(result);
else
    Console.WriteLine("Unknown genre");     