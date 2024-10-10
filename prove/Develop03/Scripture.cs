using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor that accepts a reference and the scripture text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects
        string[] wordsArray = text.Split(' '); // Split by spaces
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Method to hide a given number of random words
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int randomIndex = rand.Next(_words.Count); // Get a random index
            if (!_words[randomIndex].IsHidden()) // Only hide if it's not already hidden
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }

    // Method to return the scripture with hidden words replaced by underscores
    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + " - ";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return scriptureText.Trim(); // Remove trailing space
    }

    // Method to check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
