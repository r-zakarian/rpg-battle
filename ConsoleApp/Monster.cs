using System;

namespace ConsoleApp;

public class Monster(int hp, int attack, int defense)
{
    public int Hp { get; private set; } = hp;
    public int Attack { get; } = attack;
    public int Defense { get; } = defense;

    public void AttackMonster(Monster opponent)
    {
        opponent.TakeDamage(Attack);
    } 

    private void TakeDamage(int attack)
    {
        Hp = Hp - (Attack - Defense);
    }
}
