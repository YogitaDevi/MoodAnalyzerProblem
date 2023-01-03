using MoodAnalyzer;

Console.WriteLine("Ability to analyse and respond Happy or Sad Mood: ");
string input = Console.ReadLine();

MoodAnalyser analyse = new MoodAnalyser(input);
Console.WriteLine(analyse.AnalyzeMood());

