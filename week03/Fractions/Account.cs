public class Account
{
    private List<int> _transactions;

    public Account()
    {
        _transactions = new List<int>();
    }

    public void Deposit(int amount)
    {
        _transactions.Add(amount);
    }

    public int GetBalance()
    {
        int total = 0;
        foreach (int t in _transactions)
        {
            total += t;
        }
        return total;
    }
}
