public class Parella<T1, T2>
{
    public T1 ValueOne { get; set; }
    public T2 ValueTwo { get; set; }

    public Parella (T1 valueOne, T2 valueTwo)
    {
        ValueOne = valueOne;
        ValueTwo = valueTwo;
    }
    public void MostraInfo()
    {
        Console.WriteLine($"1. Value: {ValueOne}\n2. Value: {ValueTwo}");
    }
}