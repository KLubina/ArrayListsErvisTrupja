using System;
//non-generic collection, das heisst die werte darin hängen nicht explizit miteinander ab (z.B. wie Produkte im Supermarkt)
using System.Collections;

namespace ConsoleApp1
{
    public class Program
    {
    public static void Main( string[] args )
      {
        //bei arraylist musst man die gröse nicht spezifizieren
        ArrayList myValues = new ArrayList();
        myValues.Add( 10 );
        myValues.Add( "This is a string" );
        myValues.Add( 12.25 );

        //method to add complete new arraylists
        myValues.AddRange(new ArrayList() { "John",24, 78.78});

        //method to insert
        myValues.Insert( 1, "This the First index" );
        myValues.Insert( 3, "This is the third index" );

        //method to remove one value
        myValues.Remove( 1 );
        //method to remove several values
        myValues.RemoveRange( 0, 2 );

        //iteration to display the ArrayList myValues
        foreach ( var value in myValues )
        {
        Console.WriteLine( value );
        }
      }
    }
}
