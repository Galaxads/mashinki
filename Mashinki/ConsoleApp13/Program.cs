// See https://aka.ms/new-console-template for more information
Console.WriteLine("Сколько создать машин?");
int mashinu=Convert.ToInt32(Console.ReadLine());
Avto[] avtopark= new Avto[mashinu+1];
for(int i=1;i<avtopark.Length;i++)
{
    avtopark[i] = new Avto();
   
}
for (int i = 0; i < 2;)
{
    Console.WriteLine($"Введите индекс машины (достпуно {avtopark.Length-1})");
    int nomerm = Convert.ToInt32(Console.ReadLine());
    avtopark[nomerm].Drive();
   // avtopark[1].avaria(mashinu);
    
}



