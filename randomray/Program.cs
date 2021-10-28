int[] a=new int[10];
Random rnd=new Random();//создали класс для случайных чисел
Console.WriteLine(rnd.Next(0,100));
for(int i=0;i<10;++i)
{
    a[i]=rnd.Next(0,100);
}
for(int i=0;i<10;i++)
{
    Console.Write(a[i]+" ");

}