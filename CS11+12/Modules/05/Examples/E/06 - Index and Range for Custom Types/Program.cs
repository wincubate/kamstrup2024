using Wincubate.Module05.E;

SequencePacker<int> sp = new SequencePacker<int> { 42, 87, 87, 87, 87, 11, 22, 22, 87, 99 };

Console.WriteLine(sp[4]);  // == 87
Console.WriteLine(sp[^4]); // == 22

//for (int i = 0; i < sp.Count; i++)
//{
//    Console.WriteLine(sp[i]);
//}
//Console.WriteLine();

//for (int i = 1; i <= sp.Count; i++)
//{
//    Console.WriteLine(sp[^i]);
//}
//Console.WriteLine();

//foreach (var item in sp[2..^3])
//{
//    Console.WriteLine(item);
//}
