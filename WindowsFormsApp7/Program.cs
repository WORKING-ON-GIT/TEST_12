namespace WindowsFormsApp7
{
	static class Program
	{
		[System.STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

			Form1 form = new Form1();

			System.Windows.Forms.Application.Run(form);

			if (form != null)
			{
				form.Dispose();
				form = null;
			}
		}
	}
}
