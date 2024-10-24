using System;
using System.Collections.Generic;
using System.Threading;

public class Reflection : Activity
{
    private List<string> _prompts = new List<string> 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    
    private List<string> _questions = new List<string> 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _usedPrompts = new List<string> {};
    private List<string> _usedQuestions = new List<string> {};

    public Reflection() : base("Reflection Activity") {}

    public void Run()
    {
        StartMessage("This activity will help you reflect on times in your life when you have shown strength and resilience.This will help you recognize the power you have and how you can use it in other aspects of your life.");
        int duration = GetDuration();
        
        DisplayPrompt();
        
        while (duration > 0)
        {
            DisplayQuestions();
            duration -= 10; // Assume 10 seconds per question reflection
        }

        EndMessage("Well done! You have completed the reflection exercise.");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count) // Check if all prompts have been used
        {
            _usedPrompts.Clear(); // Reset the used prompts
        }

        string prompt;
        do
        {
            prompt = GetRandomPrompt();
        }
        while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);
        Console.WriteLine(prompt);
        Thread.Sleep(2000); // Pause for the user to read
    }

    public void DisplayQuestions()
{
    if (_usedQuestions.Count == _questions.Count)
    {
        _usedQuestions.Clear(); // Reset used questions
    }

    for (int i = 0; i < 2; i++) // Assume we display 2 questions per run
    {
        string question;
        do
        {
            question = GetRandomQuestion();
        }
        while (_usedQuestions.Contains(question));

        _usedQuestions.Add(question);
        Console.WriteLine(question);
        CountDownTimer(8); // Pause 8 seconds after each question
    }
}
}
