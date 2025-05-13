using System;

public static class PromptGenerator
{
    private static string[] _prompts = new string[]
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "How are you feeling right now?",
        "Describe a challenge you faced today.",
        "What are you grateful for today?"
    };

    public static string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}
