internal static class ProgramHelpers
{

    private static string[] FilterArrayByLength(string[] originalArray)
    {
        int count = 0;
        foreach (string str in originalArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }}