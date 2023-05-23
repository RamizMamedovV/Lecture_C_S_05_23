int count = 0;
int dist;
Console.Write("Введите длину дистанции в целых числах: ");
string input = Console.ReadLine();
if (int.TryParse(input, out dist))
{
    Console.WriteLine("ОГО! Ну ладно, побежали))");
}
else
{
    Console.Write("Введите число, иначн расходимся((:");
}
int firsFrSpeed = 1;
int secFrSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;
while(dist > 10)
{
    if(friend == 1)
    {
        time = dist/(firsFrSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = dist/(secFrSpeed + dogSpeed);
        friend = 1;
    }
    dist = dist - (firsFrSpeed + secFrSpeed) * time;
    count++;
}
Console.WriteLine("dog runs " + count + " times!");
