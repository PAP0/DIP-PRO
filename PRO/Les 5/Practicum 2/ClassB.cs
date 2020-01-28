using System;

public class ClassB : ClassA
{
    public string nogWatTekst = "Hierzo";
    public static int statischeIntOpenbaar = 0;
    private static int statischeIntPrive = 55;

    public ClassB()
    {
        Console.WriteLine( this.GetalBeschermt );
        DoeIets();
    }

    protected void BeschermdeFuncite()
    {
        Console.WriteLine("Leuk");
        Console.WriteLine("Prive statisch " + ClassB.statischeIntPrive);
    }

    private void DoeIets()
    {
        Console.WriteLine("Prive, alleen hier binnen!");
    }
}