int[] accounts = {903, 716, 67};

int GetAccountNumber ()
{
    Console.WriteLine("Enter an account number: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintAccountState (int accountId)
{
    Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}

while (true) {
    try {
    int accountId = GetAccountNumber();
    PrintAccountState(accountId);
    } catch (IndexOutOfRangeException) {
   Console.WriteLine("Exception caught! IndexOutOfRangeException");
    } catch (FormatException) {
        Console.WriteLine("Exception caught! System.FormatException");
    }
}