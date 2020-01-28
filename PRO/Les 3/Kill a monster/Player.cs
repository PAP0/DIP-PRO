using System;
public class Player
{

    private string _name;
    private int _hp = 100;
    private bool _dood = false;
    // Constructor
    public Player(string name) {
        this._name = name;
    }
    public string name {
            get { return this._name; }
            set { this._name = value; }
    }

    public int hp {
        get { return this._hp; }
        set { 
            if (this._dood == true) {
            Console.WriteLine("He already dead");
            return;
            }
            if (value <= 0) {
                this._hp = 0;
                this._dood = true;
            }
            this._hp = value;
        }}
        public bool dood {
            get { return this._dood; }
            set { this._dood = value; }
    }
    }
