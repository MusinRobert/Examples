int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int count = 0;
int distance = 10000;
int friend = 2;
int time = 0;

while (distance > 10)
{
    if (friend == 2)
    {
        time = distance / (dogSpeed + secondFriendSpeed);
        friend = 1;
    }
    else
    {
        time = distance / (dogSpeed + firstFriendSpeed);
        friend = 2;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.WriteLine("Собака пробежит " + count + " раз");