Console.WriteLine("Введите размерность массива: ");
int j = Convert.ToInt32(Console.ReadLine());

int[] FillingArray(int n){
    Random rnd = new Random();
    int[] arr = new int[n];
    for(int i = 0; i < n; i++){
        arr[i] = rnd.Next(0,20);
    }
    return arr;
}
Console.WriteLine("Получился массив: ");
int[] arr = FillingArray(j);
Console.WriteLine(String.Join(",", arr));