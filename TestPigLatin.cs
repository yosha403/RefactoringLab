using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PigLatin
{
    public class TestPigLatin
    {
        [Theory]
        [InlineData("apple", "appleway")]
        [InlineData("heck", "eckhay")]
        [InlineData("strong", "ongstray")]
        [InlineData("tommy@email.com", "tommy@email.com")]
        [InlineData("aardvark", "aardvarkway")]
        [InlineData("Tommy", "ommytay")]
        [InlineData("gym", "gym")]
       /* [InlineData("apple joy gym tommy@email.com strong", "appleway oyjay gym tommy@email.com ongstray")]*/

        public void TestToPigLatin(string name, string expected)
        {
            //Arrange
            PigLatin p = new PigLatin();
          
            //Act
            string actual = p.ToPigLatin(name);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
