﻿namespace WindowsFormsApp7
{
	static class Program
	{
		[System.STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

			System.Windows.Forms.Application.Run(new Form1());
		}
	}
}
