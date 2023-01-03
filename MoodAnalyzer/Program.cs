using MoodAnalyser;

Console.WriteLine("Ability to analyse and respond Happy or Sad Mood: ");
string input = Console.ReadLine();

MoodAnalyzer analyse = new MoodAnalyzer(input);
Console.WriteLine(analyse.analyseMood());

