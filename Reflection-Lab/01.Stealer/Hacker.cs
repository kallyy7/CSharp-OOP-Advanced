namespace Stealer
{
    public class Hacker
    {
        public string username = "userName123";
        private string password = "mySuperSecretPass0rd";

        public string Password
        {
            get => this.password;
            set => this.password = value;
        }

        private int Id { get; set; }

        public double BankAccountBalance { get; private set; }

        public void DownloadAllBankAccountsInTheWorld()
        {
        }
    }
}
