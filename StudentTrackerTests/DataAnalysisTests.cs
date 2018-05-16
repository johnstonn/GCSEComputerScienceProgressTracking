using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentTrackerNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTrackerNS.Tests
{
    [TestClass()]
    public class DataAnalysisTests
    {
        #region  Testing Mock 1 Awarding of grades method
        [TestMethod()]
        public void Progress8Mock1_InputBetween76and80_AwardGradeEightPointFive()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock1(77);
            //assert
            Assert.AreEqual(result, 8.50);
        }
        [TestMethod()]
        public void Progress8Mock1_InputBetween70and75_AwardGradeSevenPointZero()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock1(70);
            //assert
            Assert.AreEqual(result, 7.00);
        }
        [TestMethod()]
        public void Progress8Mock1_InputBetween65and69_AwardGradeFivePointFive()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock1(67);
            //assert
            Assert.AreEqual(result, 5.50);
        }
        [TestMethod()]
        public void Progress8Mock1_InputBetween60and64_AwardGradeFourPointZero()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock1(64);
            //assert
            Assert.AreEqual(result, 4.00);
        }
        [TestMethod()]
        public void Progress8Mock1_InputBetween55and59_AwardGradeThreePointZero()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock1(57);
            //assert
            Assert.AreEqual(result, 3.00);
        }
        [TestMethod()]
        public void Progress8Mock1_InputBetween50and54_AwardGradeTwoPointZero()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock1(52);
            //assert
            Assert.AreEqual(result, 2.00);
        }
        [TestMethod()]
        public void Progress8Mock1_InputBetween45and49_AwardGradeOnePointFive()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock1(45);
            //assert
            Assert.AreEqual(result, 1.5);
        }
        [TestMethod()]
        public void Progress8Mock1_InputBetween40and44_AwardGradeOnePointZero()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock1(40);
            //assert
            Assert.AreEqual(result, 1.00);
        }
        [TestMethod()]
        public void Progress8Mock1_InputBetween0and39_AwardGradeZero()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock1(33);
            //assert
            Assert.AreEqual(result, 0.00);
        }
        #endregion -----------------------------
        
        #region  Testing Mock 2 Awarding of grades method
        [TestMethod()]
        public void Progress8Mock2_InputBetween76and80_AwardGradeEightPointFive()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock2(76);
            //assert
            Assert.AreEqual(result, 8.50);
        }
        [TestMethod()]
        public void Progress8Mock2_InputBetween70and75_AwardGradeSevenPointZero()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock2(74);
            //assert
            Assert.AreEqual(result, 7.00);
        }
        [TestMethod()]
        public void Progress8Mock2_InputBetween65and69_AwardGradeFivePointFive()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock2(69);
            //assert
            Assert.AreEqual(result, 5.50);
        }
        [TestMethod()]
        public void Progress8Mock2_InputBetween60and64_AwardGradeFourPointZero()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock2(64);
            //assert
            Assert.AreEqual(result, 4.00);
        }
        [TestMethod()]
        public void Progress8Mock2_InputBetween55and59_AwardGradeThreePointZero()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock2(55);
            //assert
            Assert.AreEqual(result, 3.00);
        }
        [TestMethod()]
        public void Progress8Mock2_InputBetween50and54_AwardGradeTwoPointZero()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock2(51);
            //assert
            Assert.AreEqual(result, 2.00);
        }
        [TestMethod()]
        public void Progress8Mock2_InputBetween45and49_AwardGradeOnePointFive()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock2(48);
            //assert
            Assert.AreEqual(result, 1.5);
        }
        [TestMethod()]
        public void Progress8Mock2_InputBetween40and44_AwardGradeOnePointZero()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock2(43);
            //assert
            Assert.AreEqual(result, 1.00);
        }
        [TestMethod()]
        public void Progress8Mock2_InputBetween0and39_AwardGradeZero()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.progress8Mock2(12);
            //assert
            Assert.AreEqual(result, 0.00);
        }
        #endregion -----------------------------

        #region Distance Travelled Method Testing
        [TestMethod()]
        public void DistanceTravelled_Mock1Zero_returnMock2Only()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.distanceTravelled(0,76);
            //assert
            Assert.AreEqual(result, 76);
        }

        [TestMethod()]
        public void DistanceTravelled_Mock2Zero_returnMock1Only()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.distanceTravelled(48,0);
            //assert
            Assert.AreEqual(result, 48);
        }

        [TestMethod()]
        public void DistanceTravelled_AverageMock1AndMock2Result_ReturnAverage()
        {
            //arrange
            DataAnalysis da = new DataAnalysis();
            //act
            double result = da.distanceTravelled(48, 55);
            //assert
            Assert.AreEqual(result, 51.5);
        }
#endregion
    }
}