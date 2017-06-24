namespace Tests
{
    public class TestSettings
    {
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] TestsToExecute { get; set; }

        public TestSettings()
        {
            TestsToExecute = new string[0];
        }
    }
}