namespace Blog
{
    public static class Configuration
    {
        public static string JwtKey = "MTlmZDgzYjAtOThmNC00ZjlkLWFiMjItYmYxYzU4MWQxNzc5";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "curso_api_0cd$cbb61b#94@09ecf";
        public static SmtpConfiguration Smtp = new();

        public class SmtpConfiguration
        {
            public string Server { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}