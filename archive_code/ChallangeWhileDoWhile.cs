// Challange while/do-while

Random rand = new();

int monsterHp = rand.Next(1, 15);
int heroHp = rand.Next(1, 15);

Console.WriteLine($"Hero HP: {heroHp}");
Console.WriteLine($"Monster HP: {monsterHp}");

do
{
    int damage = rand.Next(1, 5);

    if (heroHp > 0)
    {
        monsterHp -= damage;
        Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHp} health.");
    }

    if (monsterHp > 0)
    {
        heroHp -= damage;
        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHp} health.");
    }

} while (monsterHp > 0 && heroHp > 0);

if (heroHp > 0)
{
    Console.WriteLine("Hero wins!");
}
else
{
    Console.WriteLine("Monster wins!");
}