namespace  NetflixSan_2._0.Series
{
    public class FakeAuthService
    {
        private bool _isLoggedIn = false;
        private string? _username = null;

        public bool IsLoggedIn => _isLoggedIn;
        public string? Username => _username;

        public bool Login(string username, string password)
        {
            if (password == "1234")
            {
                _isLoggedIn = true;
                _username = username;
                return true;
            }
            return false;
        }

        public void Logout()
        {
            _isLoggedIn = false;
            _username = null;
        }
    }
}
