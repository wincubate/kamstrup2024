namespace Wincubate.Module05.E;

static class DateTimeExtensions
{
    public static string ToMyTimestamp(this DateTime dt) =>
        dt.ToString("yyyy-MM-dd HH:mm:ss.fff");
}
