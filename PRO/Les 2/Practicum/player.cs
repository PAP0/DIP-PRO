using System;

public class Player
{
    public int hp = 100;
    private string name = "Mario";

    public Player(string newName = "Mario")
    {
        //Constructor functie
        name = newName;
    }

    public void Jump()
    {
        Console.WriteLine(name + "SPRINGT xD xD xD");
    }

    public void Shoot(int amount)
    {
        Console.WriteLine(name + "SCHIET" + amount + "KEER LOLOLOLOOLOL");
    }    

}