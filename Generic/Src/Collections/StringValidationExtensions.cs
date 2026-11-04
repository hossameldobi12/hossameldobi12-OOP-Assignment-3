
using System.Text.RegularExpressions;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string? phone)
    {
        const string pattern = @"^(?:(?:010|011|012|015)\d{8}|\+20(?:10|11|12|15)\d{8})$";

        return !string.IsNullOrWhiteSpace(phone)
            && Regex.IsMatch(phone, pattern);
    }

    public static bool IsValidEgyptianNationalId(this string? nationalId)
    {
        const string pattern = @"^[23]\d{13}$";

        return !string.IsNullOrWhiteSpace(nationalId)
            && Regex.IsMatch(nationalId, pattern);
    }
}
