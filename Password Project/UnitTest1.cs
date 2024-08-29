using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Password;





namespace Password_Project
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }


        [Theory]
        [InlineData("Unique123", true)]
        [InlineData("Valid1A", true)]
        [InlineData("Short1A", false)]
        [InlineData("Space 1A", false)]
        [InlineData("Passw6ord", false)]
        [InlineData("NoVowels1", false)]
        [InlineData("admin", true)]
        [InlineData("mod", true)]
        public void AddingPassword(string pass, bool expect)
        {
            
            bool result = NewPass.AddPassword(pass, expect);
            Assert.True(expect, pass);
        }
}   } 

