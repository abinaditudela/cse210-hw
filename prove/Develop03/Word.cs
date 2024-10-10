using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor that accepts the word text and sets isHidden to false by default
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show the word
    public void Show()
    {
        _isHidden = false;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to return the word text if visible, otherwise return underscores
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length); // Return underscores equal to the length of the word
        }
        else
        {
            return _text;
        }
    }
}
