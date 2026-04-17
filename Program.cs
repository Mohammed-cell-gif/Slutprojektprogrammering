using System.Runtime.CompilerServices;

Console.WriteLine("Press Enter to start");
if(string.IsNullOrEmpty(Console.ReadLine()))
{
    bool start=true;
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

    
