### ✅ **W02 Assignment: Explain Abstraction**

**Question:** What is abstraction and why is it important?

**Answer:**

Abstraction is a fundamental concept in object-oriented programming that allows developers to focus on what an object does rather than how it does it. It helps us model complex systems by breaking them down into simpler, manageable parts and hiding the internal details that are not relevant at a given level of use.

One of the main benefits of abstraction is that it improves code organization and readability. It allows different parts of a program to change independently, which makes maintaining and updating the code easier over time. For example, if the internal implementation of a class changes, other parts of the program that depend on it don't need to change as long as the interface remains the same.

A practical application of abstraction can be seen in the journal program I developed. I created two main classes: `Journal` and `Entry`. Each one is responsible for handling a specific part of the program. The `Journal` class handles storing and managing entries, while the `Entry` class encapsulates the details of a single journal entry, including the date, prompt, and response.

Here’s a short example of abstraction from my program:

```csharp
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}
```

In this example, the `Journal` class abstracts away how entries are stored internally. Other parts of the program can add or display entries without needing to know that they’re being stored in a list. The complexity of managing multiple entries is hidden behind simple method calls like `AddEntry()` and `DisplayAll()`.

By using abstraction, I was able to design a clear and organized program that separates responsibilities and makes the code easier to extend in the future. For instance, if I later decide to change how entries are stored (e.g., in a database), I could update the `Journal` class without affecting the rest of the application.
