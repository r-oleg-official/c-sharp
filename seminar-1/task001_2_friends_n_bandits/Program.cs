//Task: two friends and a dog.
double distance = 1000,         // m
    min_distance = 10,          // m
    first_friend_speed = 1,     // m/s
    second_friend_speed = 2,    // m/s
    dog_speed = 5,              // m/s
    time = 0;                   // time to meeting of friends
int friend = 2,                 // path of travel a dog to...
    count = 0;                  // counter

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
