using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected int duration; // duração em segundos
    protected string activityName;
    protected string description;

    public Activity(string name, string description, int durationInSeconds)
    {
        activityName = name;
        this.description = description;
        duration = durationInSeconds;
    }

    // Exibe mensagem inicial comum a todas as atividades
    public virtual void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {activityName}.");
        Console.WriteLine(description);
        Console.WriteLine($"Duration: {duration} seconds.");
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Exibe mensagem final comum a todas as atividades
    public virtual void End()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed the {activityName} for {duration} seconds.");
        ShowSpinner(3);
    }

    // Método abstrato que cada atividade implementa com sua lógica específica
    public abstract void Run();

    // Exemplo de animação spinner simples para pausas
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write("|/-\\"[i % 4]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(250);
        }
    }

    // Exemplo de contagem regressiva em segundos
    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(1000);
        }
        Console.Write(" ");
    }
}
