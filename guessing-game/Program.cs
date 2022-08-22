using System;

Console.WriteLine("Guess the secret number: ");
string answer = Console.ReadLine();
int parsedAnswer = int.Parse(answer);
Console.WriteLine($"Your guess is {parsedAnswer}");