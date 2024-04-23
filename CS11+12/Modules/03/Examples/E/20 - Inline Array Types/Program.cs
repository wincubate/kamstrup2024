Buffer buffer = new();
buffer[0] = "Hello";
buffer[1] = "Inline";

Console.WriteLine(buffer[0]);

[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer
{
    private object _element0;
}