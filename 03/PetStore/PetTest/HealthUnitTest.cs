using System;
using Xunit;
using PetLib;

namespace PetTest
{
    public class HealthUnitTest
    {
        [Fact]
        public void TestFbmi()
        {
            //Given - Arrange
            double ribCage=14, legLength=1;
            double expectedFbmi=19.55964651351773;
            HealthStatus status=new HealthStatus();
            //When - Act
            double actualFbmi=status.Fbmi(ribCage,legLength);
            //Then - Assert
            Assert.Equal(expectedFbmi,actualFbmi);
        }
        [Fact]
        public void TestFbmiThrowsException()
        {
            //Given
            double ribCage=-14, legLength=-1;
            HealthStatus status=new HealthStatus();
           
            //Then
            Assert.Throws<ArgumentException>(()=>status.Fbmi(ribCage,legLength));
        }
        [Fact]
        public void TestInterpretation()
        {
            double ribCage=18, legLength=5;
            var expectedHealth=FbmiInterpretation.NormalWeight;
            HealthStatus status=new HealthStatus();
            double actualFbmi=status.Fbmi(ribCage,legLength);
            var actualHealth=status.CatHealth(actualFbmi);
            Assert.Equal(expectedHealth, actualHealth);
        }
    }
}
