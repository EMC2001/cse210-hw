using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using Microsoft.VisualBasic;

class JournalEntry
{
    public string Prompt { get; }
    public string Response { get; }
    public string Date { get; }

    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public string GetEntry()
    {
        return $"{Date} - {Prompt}: {Response}";
    }
}

class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.GetEntry());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                JournalEntry entry = new JournalEntry(parts[1], parts[2], parts[0]);
                entries.Add(entry);
            }
        }
    }
}

class Program
{
    static Random rand = new Random();
    static Journal journal = new Journal();

    static void Main(string[] args)
    {
          string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };


          while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    WriteEntry(prompts);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }

      static void WriteEntry(string[] prompts)
    {
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        JournalEntry entry = new JournalEntry(prompt, response, date);
        journal.AddEntry(entry);
    }

        static void SaveJournal()
    {
        Console.Write("Enter the filename to save to: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    static void LoadJournal()
    {
        Console.Write("Enter the filename to load from: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}
