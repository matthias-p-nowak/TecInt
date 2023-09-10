internal partial class Inquisitor
{
    static void Main(string[] args)
    {
        var programType = typeof(Inquisitor);
        foreach (var runMethod in args)
        {
            var method = programType.GetMethod(runMethod);
            if (method == null)
            {
                Console.WriteLine($"can't find {runMethod}");
                continue;
            }
            if (!method.IsStatic)
            {
                Console.WriteLine($"mark {method.Name} as static!");
                continue;
            }
            method.Invoke(null, new object[] { });
        }
    }
}
