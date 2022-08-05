// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//declaring and initializing variables
//camelCase for the variable name
//explicit typing
string dogName = "Luka";
int dogAge = 4;
char firstLetter = 'L';
bool isAGoodBoy = true;
double balls = 100;
decimal weight = 49.5m;

//string interpolation with the $ and { } around the variable
Console.WriteLine($"My dog's name starts with {firstLetter}. " +
    $"His name is {dogName}. He is {dogAge} years old. It is {isAGoodBoy} " +
    $"that he is a good boy so he has {balls} balls. He is in good shape" +
    $" weighing in at {weight} lbs.");