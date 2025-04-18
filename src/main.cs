using System.Net;
using System.Net.Sockets;

string comando;

Console.Write("$ ");
// Wait for user input
comando = Console.ReadLine();

Console.WriteLine($"{comando}: command not found");
