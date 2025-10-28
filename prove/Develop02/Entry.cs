
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Mime;

class Entry
{
    public string Date { get; }
    public string Prompt { get; }
    public string UserEntry { get; }

    public Entry(string date, string prompt, string userEntry)
    {
        Date = date;

        Prompt = prompt;

        UserEntry = userEntry;
    }

   public void DisplayEntry()
    {
        Console.WriteLine($"{Date} - {Prompt}\n{UserEntry}\n");
    }
}
