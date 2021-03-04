using System;
using System.Drawing;
using System.Threading;
using Xunit;

namespace towerDefense
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            GameObject GO = new GameObject(new Units(100, 50), new Point(0,0), new Point(1,0), 5);
            
            // Act
            Thread.Sleep(1000);
            GO.objectUpdate();
 
            // Assert
            Assert.Equal(new PointF(5,0), GO.getPosition());
        }
    }
}
