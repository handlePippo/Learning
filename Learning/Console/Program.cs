using Excerices;
using System.Runtime.CompilerServices;


// Write a C# Sharp program to get the absolute difference between n and 51.
// If n is greater than 51 return triple the absolute difference.

int height = 5;
int row;
int height2 = 2;
int row2;

for(row = 1; row <= height; row++)
{

    //gestisco gli spazi vuoti
    for(int emptySpace = 0; emptySpace < height - row; emptySpace++)
    {
        Console.Write(" ");
    }

    //gestisco gli asterischi
    for(int asterisk = 1; asterisk < row * 2; asterisk++)
    {
        Console.Write("*");        
    }

    //vado a capo dopo i 2 controlli
    Console.Write("\n");

}

for (row2 = 0; row2 < height2; row2++)
{
    //gestisco gli spazi vuoti tronco
    for (int emptySpace = 1; emptySpace < height - 1; emptySpace++)
    {
        Console.Write(" ");
    }

    //gestisco gli asterischi del tronco
    for(int asterisk2 = 0;  asterisk2 < height2 + 1; asterisk2++)
    {
        Console.Write("*");
    }
    //vado a capo dopo i 2 controlli
    Console.Write("\n");
}