using System.Text.RegularExpressions;

namespace tech_interview_api.Application.Common;

public static partial class Regexes
{
    [GeneratedRegex("^\\(\\d{3}\\) \\d{3}-\\d{4}$")]
    public static partial Regex PhoneNumberRegex();

    [GeneratedRegex("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$")]
    public static partial Regex EmailRegex();
}