You theYou = new You();
Enemy theEnemy = new Enemy();

Console.WriteLine($"{theYou.name} has {theYou.health} healths");
Console.WriteLine($"{theEnemy.name} has {theEnemy.health} health and {theEnemy.size} size");

Console.WriteLine("attack");
theEnemy.health -= 10;

Console.WriteLine($"{theEnemy.name} now has {theEnemy.health} health");
Console.WriteLine("press to continue .,.,.,.,.,.,.,.,.,.,,..,.,");
Console.ReadKey();