﻿namespace MoneyExtension;

public static class Money
{
    public static int toCents(this decimal amount)
    {
        if (amount < 0) return 0;
        
        var text = amount
            .ToString("N2")
            .Replace(",", "")
            .Replace(".", "");
        
        if(string.IsNullOrWhiteSpace(text)) return 0;

        int.TryParse(text, out var result);
        return result;
    }
}
