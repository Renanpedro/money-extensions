namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal Amount)
    {
        if (Amount < 0)
            return 0;

        var value = Amount
                    .ToString("N2")
                    .Replace(",", "")
                    .Replace(".", "");
                    
        if (string.IsNullOrEmpty(value))
            return 0;

        int.TryParse(value, out var result);
        return result;
    }
}
