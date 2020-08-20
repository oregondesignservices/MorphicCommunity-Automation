using MorphicCommunityAutomation.Objects;

namespace MorphicCommunityAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUp setUp = new SetUp();
            setUp.Initialize();

            LostPassword lostPassword = new LostPassword();
            lostPassword.CheckLostPassword();
            lostPassword.InvalidEmail();

            Login login = new Login();
            login.GoToHomeURL();
            login.CheckIncorrectPassword();
            login.EmptyUserNameAndPassword();
            login.CheckCorrectCredentials();

            Register register = new Register();
            register.CheckErrorMessages();
            register.AlreadyRegisteredEmail();
            register.ValidRegistration();


            MemberInvite invitePerson = new MemberInvite();
            invitePerson.CheckEmptyFields();


            Dashboard dashboard = new Dashboard();
            dashboard.ClickCommunityBTN();

            MorphicbarPreconfigured morphicbarPreconfigured = new MorphicbarPreconfigured();
            morphicbarPreconfigured.StartCustomizingFirstBar();


            MorphicbarEditor morphicbarEditor = new MorphicbarEditor();
            morphicbarEditor.AddAllButtons();
            morphicbarEditor.ChangeCommunityBarName();

            CleanUp cleanUp = new CleanUp();
            cleanUp.CloseBrowser();



        }
    }
}
