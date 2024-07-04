namespace Testing
{
    [TestFixture]
    public class TestTaskTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { }, ExpectedResult = null, TestName = "FindMin_GotEmptyArray_ReturnNull")]
        [TestCase(new int[] { 6, 6 }, ExpectedResult = 6, TestName = "FindMin_GotTwoSameElements_ReturnFirstElement")]
        [TestCase(new int[] { -6, -2, 6 }, ExpectedResult = -6, TestName = "FindMin_GotNegativeNumber_ReturnFirstElement")]
        public int? FindMin_ReturnsExpectedResult(int[] arr)
        {
            return TestTask.FindMin(arr);
        }


        [TestCase(new int[] { }, ExpectedResult = null, TestName = "FindMax_GotEmptyArray_ReturnNull")]
        [TestCase(new int[] { 6, 6 }, ExpectedResult = 6, TestName = "FindMax_GotTwoSameElements_ReturnLastElement")]
        [TestCase(new int[] { -6, -2, 6 }, ExpectedResult = 6, TestName = "FindMax_GotNegativeNumber_ReturnLastElement")]
        public int? FindMax_ReturnsExpectedResult(int[] arr)
        {
             
            return TestTask.FindMax(arr); ;
        }

        [TestCase(new int[] { }, ExpectedResult = 0.0, TestName = "FindMedian_ReturnZeroEmptyArray")]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 3.0, TestName = "FindMedian_GotOddLength")]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, ExpectedResult = 3.5, TestName = "FindMedian_GotEvenLength")]

        public double FindMedian_ReturnsExpectedResult(int[] arr)
        {
            return TestTask.FindMedian(arr);
        }

        [TestCase(new int[] { }, ExpectedResult = 0.0, TestName = "FindAvg_ReturnZeroEmptyArray")]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 3.0, TestName = "FindAvg_GotPisitiveNumbers_ReturnPositiveNumber")]
        [TestCase(new int[] { -1, -2, -3, -4, -5}, ExpectedResult = - 3.0, TestName = "FindAvg_GotnegativeNumbers_ReturnNegativeNumber")]

        public double FindAvg_ReturnsExpectedResult(int[] arr)
        {
           return TestTask.FindMedian(arr);

        }

        [TestCase(new int[] { 1, 0, 0, 4, -3, 5, 6, 7, 1, 9, 10, 11, 12, 13 }, true, ExpectedResult = new int[] { 1, 9, 10, 11, 12, 13 }, TestName = "FindMinMaxSeq_ReturnsFirstLongestAscendingSequence")]
        [TestCase(new int[] { 1, 0, 0, 4, -3, 5, 6, 7, 1, 9, 10, 11, 12 }, false, ExpectedResult = new int[] { 1, 0 }, TestName = "FindMinMaxSeq_ReturnsFirstLongestDescendingSequence")]
        [TestCase(new int[] { }, false, ExpectedResult = new int[] { }, TestName = "FindMinMaxSeq_GotEmptyArray_ReturnsEmptyList")]
        [TestCase(new int[] { 11 }, false, ExpectedResult = new int[] { 11 }, TestName = "FindMinMaxSeq_GotSingleElement_ReturnFullList")]
        [TestCase(new int[] { 11, 11 }, true, ExpectedResult = new int[] { 11 }, TestName = "FindMinMaxSeq_GotTwoElementsAllSameAsc_ReturnOneElement")]
        [TestCase(new int[] { 1, 1, 2, 2, 4 }, true, ExpectedResult = new int[] { 1, 2 }, TestName = "FindMinMaxSeq_GotSameNeighborElementsAsc_ReturnsCorrectSequenceStartingFromSecondNeighbor")]
        [TestCase(new int[] { 11, 11 }, false, ExpectedResult = new int[] { 11 }, TestName = "FindMinMaxSeq_GotTwoElementsAllSameDesc_ReturnOneElement")]
        [TestCase(new int[] { -1, -1, -2, -2, -4 }, false, ExpectedResult = new int[] { -1, -2 }, TestName = "FindMinMaxSeq_GotSameNeighborElementsDesc_ReturnsCorrectSequenceStartingFromSecondNeighbor")]
        public int[] FindMinMaxSeq_ReturnsExpectedResult(int[] arr, bool direction)
        {
            List<int> result = TestTask.FindMinMaxSeq(arr, direction);
            return result.ToArray();
        }

    } 

}