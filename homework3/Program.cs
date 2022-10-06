
Console.WriteLine("Введите любое из чисел '4', '-3', '7'");
int a = Convert.ToInt32(Console.ReadLine());
 while (true)
 {
    if (a==4 | a == -3 | a== 7  ) {
       if  (a % 2 == 0){ 
        Console.WriteLine("четное число");
        break;}
        else{ 
            Console.WriteLine("нечетное число");
            break;
        }
    }
    else if (a!=4 | a!=-3 | a != 7) {
            Console.WriteLine("Извините, другие числа мы не проверяем");
   }
   return;
 }


