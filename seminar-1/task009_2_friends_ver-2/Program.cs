// Nikolay's version
int firstFriendsSpeed = 2,
    secondFriendsSpeed = 3,
    dogSpeed = 5,
    count = 0;

double distance = 1000, time =0;

int directionDog = 1; // 1 - от 1-го ко 2-му, 2 - от 2-го к 1-му.
//Version with boolean.
//bool firstFriendsDirection = false; // собака сначала бежит от 1-го.

while (distance > 2)
{
    if (directionDog == 1)
    //if (firstFriendsDirection) // значение уже рез-т сравнения (если true).
    // 1-я итерация - переход на else.
    {
        time = distance / (secondFriendsSpeed + dogSpeed);
        directionDog = 2;
        //time = distance / (secondFriendsSpeed + dogSpeed);
        //firstFriendsDirection = false; // смена true на false.
    }
    else
    {
        time = distance / (firstFriendsSpeed + dogSpeed);
        directionDog = 1;
        //time = distance / (firstFriendsSpeed + dogSpeed);
        //firstFriendsDirection = true; //в 1-й итерации перекл-ет на false.
    }

    distance = distance - (firstFriendsSpeed + secondFriendsSpeed) * time;
    count++;
}

Console.WriteLine("Собака пробежала между друзьями " + count + " раз.");