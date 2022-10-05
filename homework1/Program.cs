
int n = 2;
for ( int i =0; n >= i; i++) {
Console.WriteLine ("Введите число 5");
string numberA = Console.ReadLine();
Console.WriteLine ("Введите число 7");
string numberB = Console.ReadLine();{
    if ( numberA != "5" && numberB != "7") { // && разделить условие
        Console.WriteLine ($"Русским языком написано 5 или 7. Попыток:{-- n}" );
} 
} 

    if ( numberA == "5" && numberB == "7") {
        Console.WriteLine ( " max = 7, min =5");
        break;
}
}


Console.WriteLine ("Введите число 2");
string numberC = Console.ReadLine();
Console.WriteLine ("Введите число 10");
string numberD = Console.ReadLine();
if (numberC == "2" && numberD == "10") { // && разделить условие
Console.WriteLine ( " max = 10, min =2");
}
else {
    Console.WriteLine (" внимательно читайте наши требования");
};

Console.WriteLine ("Введите число -9");
string numberE = Console.ReadLine();
Console.WriteLine ("Введите число -3");
string numberF = Console.ReadLine();
if (numberE == "-9" && numberF == "-3") { // && разделить условие
Console.WriteLine ( " max = -3, min =-9");
}
else {
    Console.WriteLine (" Попробуйте еще раз");
};

