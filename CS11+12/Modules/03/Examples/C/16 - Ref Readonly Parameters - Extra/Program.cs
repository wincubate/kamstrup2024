int i = 87;
ref readonly int j = ref i;
DoStuff(in j);


static void DoStuff(ref readonly int i)
{
    Console.WriteLine(i);
}