//Task: two friends and a dog.
double distance = 1000;       // m
double min_distance = 10;
double first_friend_speed = 1; // m/s
double second_friend_speed = 2;// m/s
double dog_speed = 5;          // m/s
int friend = 2;             // path of travel a dog to...
int count = 0;              // counter
double time = 0;               // time to meeting of friends



while (distance >= min_distance) {
    if (friend == 1) {
        time = distance/(second_friend_speed + dog_speed);
        friend = 1;
    }
    else {
        time = distance/(first_friend_speed + dog_speed);
        friend = 2;
    }
    distance = distance - (first_friend_speed + second_friend_speed)* time;
    count = count + 1;
}
Console.WriteLine("Собака пробежит " + count + " раз.");
