using System;

public class Task1
{
    int[] array = new int[10];
    Random rnd = new Random();

    int i = 0;
    for (int i = 0; i < array.Length; i++)
 {
        array[i] = rnd.Next(20);
 }

public int secondPart = from n in array
                        orderby n
                        select n;
    }
    //не хватило времени из-за проблем с интернетом
}