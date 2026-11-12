using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split text by spaces and create Word objects
        string[] wordArray = text.Split(" ");
        foreach (string word in wordArray)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Stub implementation
    }

    public string GetDisplayText()
    {
        string textDisplay = "";
        foreach (Word word in _words)
        {
            textDisplay += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {textDisplay.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        return false; // Stub return
    }
}