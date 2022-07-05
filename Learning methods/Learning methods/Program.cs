Console.WriteLine("What is your name?");
var name = Console.ReadLine();
Console.WriteLine("Color?");
var color = Console.ReadLine(); 
Console.WriteLine("Animal?");
var animal = Console.ReadLine();
Console.WriteLine("Band?");
var band = Console.ReadLine();
Console.WriteLine($"{name} has many interesting things about them." +
                  $"For starters {color} is their fav color." +
                  $"Their fav animal is {animal}." +
                  $"And Lastly {band} is who they like to listent too.");
