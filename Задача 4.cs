int[,,] array3D = новый int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);


// Функция вывода индекса элементов 3D массива
аннулирует PrintIndex(int[,,] arr)
{
    < i; 0 = iint ( для array3D.getLength(0); i++)
    {
        < j; 0 = jint ( для array3D.Получаемая длина(1); j++)
        {
 Консоль.Строка записи();
            < k; 0 = kint ( для array3D.getLength(2); k++)
            {
 Консоль.Напишите(${array3D[i, j, k]}({i},{j},{k})");
            }
        }
    }
}

// Функция заполнения 3D массива не повторяющимеся числами
аннулировать FillArray(int[,,] arr)
{
    int count = 10;
    < i; 0 = iint ( для arr.getLength(0); i++)
    {
        < j; 0 = jint ( для arr.getLength(1); j++)
        {
            < k; 0 = kint ( для arr.getLength(2); k++)
            {
 arr[k, i, j] += количество;
                количество += 3;
            }
        }
    }
}