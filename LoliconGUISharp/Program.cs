using System.Windows.Forms;

namespace LoliconGUISharp
{
    internal static class Program
    {
        private const string TAG = nameof(Program);

        public static void Main()
        {
#if DEBUG
            Log.I(TAG, $"{Application.ProductName} V{Application.ProductVersion} Debug");
#else
                Log.I(TAG, $"{Application.ProductName} V{Application.ProductVersion}");
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}