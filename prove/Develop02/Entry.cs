using System;

public class Entry
{
    private string _prompt;
    private string _response;
    private string _date;

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToShortDateString();
    }

    public string GetEntry()
    {
        return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n";
    }
}
