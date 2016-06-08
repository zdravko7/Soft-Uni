using System.Globalization;
using System.Threading;

/// <summary>
/// Creates a new engine and runs it
/// </summary>
public class BuhtigMain
{  
    /// <summary>
    /// Main method of the program
    /// </summary>
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        var engine = new engine();
        engine.Run();
    }
}
