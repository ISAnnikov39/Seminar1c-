int q = 2, w = 3, r = 7;
int max1 = q;
if( w > max1) max1 = w;
if ( r > max1 ) max1 = r;
Console.WriteLine ($"Максимальное число = {max1}");// ($"  {}") для вывода текста и переменной

// извините, я знаю что этот код не для этой задачи, но интересно было сделать ее через массив и функцию.
int e = 44, 
    f = 5,
    j = 78;
int max(int e,  int f, int j) {
    int resulte = e;
    if (resulte < f) resulte = f;
    if (resulte < j) resulte = j;
    return resulte;
}
int itog = max(e,f,j);
Console.WriteLine($"максимальное число = {itog}");

int[] array = {22, 3, 9};
int index = 0;
int maximum = array[index];
if ( array[index +1] > maximum) maximum = array[index+1];
if ( array[index +2] > maximum) maximum = array[index +2];
Console.WriteLine($"максимальное число = {maximum}");



