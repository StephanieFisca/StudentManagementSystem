namespace StudentManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new LoginForm());
            LoginForm Login = new LoginForm();

            if(Login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}