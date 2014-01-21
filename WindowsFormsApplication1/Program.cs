using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Debug;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
			
			//TODO: 
			int a = 5; 
			if (a == 5)
				Debug.Write("Jest ok");
			//to będą zmiany tylko dla brunch1
			Debug.WriteLn("Jesteśmy w debug");
        }
    }
}
