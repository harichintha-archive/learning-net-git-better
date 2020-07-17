using System;
using System.Collections.Generic;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        string rev;
        char[] arr = new char[word.Length];
        arr = word.ToLower().ToCharArray();
        Array.Reverse(arr);
        rev = new string(arr);
        if (rev == word.ToLower())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
   
}
public class AlertService
{
    private readonly AlertDAO storage = new AlertDAO();

    IAlertDAO con;
    public AlertService(IAlertDAO input)
    {
        this.con = input;
    }

    public Guid RaiseAlert()
    {
        return this.con.AddAlert(DateTime.Now);
    }

    public DateTime GetAlertTime(Guid id)
    {
        return this.con.GetAlert(id);
    }
}
public interface IAlertDAO
{
    Guid AddAlert(DateTime time);
    DateTime GetAlert(Guid id);
}

public class AlertDAO : IAlertDAO
{
    private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

    public Guid AddAlert(DateTime time)
    {
        Guid id = Guid.NewGuid();
        this.alerts.Add(id, time);
        return id;
    }

    public DateTime GetAlert(Guid id)
    {
        return this.alerts[id];
    }


public static void Main(string[] args)
{
    // Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    Console.ReadLine();
}
}
public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        int count = 0;
        string[] OutputArray = new string[names1.Length + names2.Length];
        foreach(string name in names1)
        {
            Dictionary<string, int> names = new Dictionary<string, int>();
            if (!name.Contains(name))
            {
                names.Add(name, 1);
            }
        }
        foreach (string name in names2)
        {
            for (int i = 0; i < OutputArray.Length; i++)
            {
                if (OutputArray[i] != name)
                {
                    OutputArray[count] = name;
                    count++;
                }
            }

        }
        return OutputArray;
    }

    public static void Main(string[] args)
    {
        string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        Console.ReadLine();
    }
}