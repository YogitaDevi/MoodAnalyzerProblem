using MoodAnalyzer;
using MoodAnalyser;

Console.WriteLine("Ability to analyse and respond Happy or Sad Mood: ");
string input = Console.ReadLine();

Analyser analyse = new Analyser(input);
Console.WriteLine(analyse.analyseMood());

