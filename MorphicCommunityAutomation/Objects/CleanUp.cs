namespace MorphicCommunityAutomation.Objects
{
    class CleanUp : SetUp
    {
        public void CloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
