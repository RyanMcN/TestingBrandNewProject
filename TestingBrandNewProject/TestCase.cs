using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestingBrandNewProject
{

    [TestFixture]
    class TestCase
    {

        [Test]
       public void methodTest()
        {
            int x = 7;
            int y = 5;
            MessageBox.Show("Testing123");
            //Assert.Pass();
            Assert.Greater(x, y);
            
           
        }
    }
}
