using System;

string? text = null;

SayHello(text);

void SayHello(string message)
{
    //if(message is null)
    //{
    //    throw new ArgumentNullException(nameof(message));
    //}
    ArgumentNullException.ThrowIfNull(message);

    Console.WriteLine(message);

}