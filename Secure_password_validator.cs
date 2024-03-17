using System;
using System.Text.RegularExpressions;

class MainClass
{
    // Function to validate the password acording to criteria
    static string StringChallenge(string str)
    {

        // Password must be between  8 -30
        if (str.Length < 8 || str.Length > 30)
        {
            return "false"; // password length does not meet the crieteria
        }

        // Check password must contain one uppercase
        if (!Regex.IsMatch(str, "[A-Z]"))
        {
            return "false"; // missing uppercase
        }

        // check password must conatain one digit
        if (!Regex.IsMatch(str, "[0-9]"))
        {
            return "false"; // missing one digit
        }

        // Check password contains punctuation or matimatical symbol
        if (!Regex.IsMatch(str, "[^a-zA-Z0-9]"))
        {
            return "false";// Missing either punctuation or Mathematical operation
        }

        // check if password contain the word 'password'
        if (str.ToLower().Contains("password"))
        {
            return "false";// password comatins the word "password"
        }
        else
        {
            return "true"; // when all requirement mets
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(StringChallenge(Console.ReadLine())); //Validate the Password input and print the result
    }
}
