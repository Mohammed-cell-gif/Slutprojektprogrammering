using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

Console.WriteLine("Press Enter to start");
Console.ReadLine();

Ally1 = new Enemy("ally1","fire",100,"water");
Enemy1 = new Enemy("monster2","rock",80,"fire");
Console.WriteLine("{Enemy1 vs enemy2} Fight");

while(!Ally1.dead() && !Enemy1.dead())
{
    
}

class Enemy
{
    public string Name;
    public string Power;
    public int HP;
    public string Weakness;

public Enemy(string name,string power,int hp,string weakness)
    {
        Name = name;
        Power=power;
        HP=hp;
        Weakness=weakness;
    }
    public void Takedamage(int damage)
    {
        HP-= damage;
        if (HP<0) HP=0;
    }
    public bool dead()
    {
        return HP<=0;
    }
}

    
