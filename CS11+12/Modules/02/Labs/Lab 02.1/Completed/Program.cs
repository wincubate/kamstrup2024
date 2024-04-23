string s1 = "VoksneIrereDividererIEnSkov";
string s2 = "Otto";
string s3 = "NotAPalindrome";

Console.WriteLine(IsPalindrome(s1));
Console.WriteLine(IsPalindrome(s2));
Console.WriteLine(IsPalindrome(s3));

static bool IsPalindrome(string s) =>
    s switch
    {
        [] or [_] => true,
        [char c1, .. var rest, char c2] when char.ToLower(c1) == char.ToLower(c2) => IsPalindrome(rest),
        _ => false
    };
