class Program
{
    static void Main(string[] args)
    {
        player p1 = new player("Youssef", 85, 750);
        p1 =p1.TakeDamage(20);
        p1 =p1.AddScore(50);
        p1.show_info();
        p1 = p1.TakeDamage(80);
        p1.show_info();

    }
}

readonly struct player
{
    readonly string _name;
    readonly int _health;
    readonly int _score;
    readonly int _level;

    public player(string name,int health,int score)
    {
        this._name = name;
        this._score = score;
        this._level = (score/1000) + 1;
        if (health >= 0 && health <= 100)
            this._health = health;
        else
        {
            Console.WriteLine("Invalid health value. Setting health to 0 .");
            this._health = 0;
        }
    }

    public player TakeDamage(int damage)
    {
        int temp_health = this._health - damage;
        if(temp_health > 0)
        {
            return new player(this._name, temp_health, this._score);
        }
        Console.WriteLine("Game over");
        return new player(this._name,0,this._score);
    }

    public player AddScore(int score) => new player(this._name, this._health, (this._score + score));

    public bool IsAlive(player player)
    {
        if (player._health > 0) return true;
        return false;
    }
    public void show_info()
    {
        Console.WriteLine($"Player name : {_name}\n" +
                          $"Player health : {_health}\n" +
                          $"Player score : {_score}\n" +
                          $"Player level : {_level}\n"+
                          $"----------------");
    }
}