using System;
namespace Roman_Integer_Translator {
	class Program {
  public static int Rom_to_int( string input ) {
   input = input + " " ;
   int sum =0 ;
   int index =0 ;
   int counter =0 ;

   while( input [ counter ] == 'M' ) {
    index ++ ;
    counter ++ ;
    if( index >3 ) {
     return 0 ;
     }
    sum +=1000 ;
    }
   if( input [ counter ] == 'C' && input [ counter +1 ] == 'M' ) {
    counter +=2 ;
    sum +=900 ;
    }
   else if( input [ counter ] == 'C' && input [ counter +1 ] == 'D' ) {
    counter +=2 ;
    sum +=400 ;
    }
   else {
    index =0 ;
    while( input [ counter ] == 'D' ) {
     index ++ ;
     counter ++ ;
     if( index >1 ) {
      return 0 ;
      }
     sum +=500 ;
     }
    }
   index =0 ;
   while( input [ counter ] == 'C' ) {
    index ++ ;
    counter ++ ;
    if( index >3 ) {
     return 0 ;
     }
    sum +=100 ;
    }
   if( input [ counter ] == 'X' && input [ counter +1 ] == 'C' ) {
    counter +=2 ;
    sum +=90 ;
    }
   else if( input [ counter ] == 'X' && input [ counter +1 ] == 'L' ) {
    counter +=2 ;
    sum +=40 ;
    }
   else {
    index =0 ;
    while( input [ counter ] == 'L' ) {
     index ++ ;
     counter ++ ;
     if( index >1 ) {
      return 0;
      }
     sum +=50 ;
     }
    }
   index =0 ;
   while( input [ counter ] == 'X' ) {
    index ++ ;
    counter ++ ;
    if( index >3 ) {
     return 0;
     }
    sum +=10 ;
    }
   if( input [ counter ] == 'I' && input [ counter +1 ] == 'X' ) {
    sum +=9 ;
    counter +=2 ;
    }
   else if( input [ counter ] == 'I' && input [ counter +1 ] == 'V' ) {
    sum +=4 ;
    counter +=2 ;
    }
   else {
    index =0 ;
    while( input [ counter ] == 'V' ) {
     index ++ ;
     counter ++ ;
     if( index >1 ) {
      return 0 ;
      }
     sum +=5 ;
     }
    }
   index =0 ;
   while( input [ counter ] == 'I' ) {
    index ++ ;
    counter ++ ;
    if( index >3 ) {
     return 0 ;
     }
    sum +=1 ;
    }
   return sum ;
   }
  public static string Int_to_rom( string input ) {
   string[] rom = new string[] { "I","IV","V","IX","X","XL","L","XC","C","CD","D","CM","M" } ;
   int[] trans = new int[] { 1,4,5,9,10,40,50,90,100,400,500,900,1000 } ;
   string result = "";

   int num = Convert.ToInt32( input ) ;
   if( num <1 || num >3999 ) {
    Console.WriteLine( "Invalid input. Press enter to return." ) ;
    Console.ReadLine( ) ;
    return null;
    }
   for( int i =12 ; i >=0 ; i-- ) {
    while( num >= trans[i] ) {
     num -= trans[i] ;
     result += rom[i] ;
     }
    }
   return result;
   }
  static void Main( string[] args ) {
   Console.WriteLine( "Enter '1' for Roman Number to Integer" ) ;
   Console.WriteLine( "Enter '2' for Integer to Roman Number" ) ;
   string check_input = Console.ReadLine( ) ;
   int check = Convert.ToInt32( check_input ) ;
   if( check == 1 ) {
    Console.WriteLine( "Enter Roman Number: " ) ;
    string input = Console.ReadLine( ) ;
    int result = Rom_to_int( input ) ;
    if( result == 0 ) {
     Console.WriteLine( "Input failure" ) ;
     }
    else {
     Console.WriteLine( result ) ;
     }
    }
   else if( check ==2 ) {
    Console.WriteLine( "Enter integer between 1 and 3999" ) ;
    string input = Console.ReadLine( ) ;
    string result = Int_to_rom( input ) ;
    Console.WriteLine( result ) ;
				}
   else {
    Console.WriteLine( "Input failure" ) ;
				}
   Console.ReadLine( ) ;
   }
  }
	}
