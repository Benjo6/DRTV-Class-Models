namespace DRTVLib
{
    public sealed class User
    {
        public String Id_Profile { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public List<Reproduction> Reproductions { get; set; }

        public void SignInGoogle()
        {

        }
        public void SignInFacebook()
        {

        }
        public void UpdateAccount() 
        {
        }
        public void SubscribeToDRTV()
        {

        }
    }
}