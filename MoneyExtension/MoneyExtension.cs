namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal Amount)
    {
        if (Amount < 0)
            return 0;

        var text = Amount
                    .ToString("N2")
                    .Replace(",", "")
                    .Replace(".", "");
                    
        if (string.IsNullOrEmpty(text))
            return 0;

        int.TryParse(text, out var result);
        return result;
    }
}
