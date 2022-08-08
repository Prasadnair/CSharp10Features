//using System.Text.Json;

var names = new[] { "Prasad", "Praveen" };
var serialized = JsonSerializer.Serialize(names);

Console.WriteLine(serialized);