using FluentAssertions;

namespace _88.Merge.Sorted.Array
{
    public class ExampleTests
    {
        /*
         Example 1:

        Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        Output: [1,2,2,3,5,6]
        Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
        The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
         */
        [Fact]
        public void Test1()
        {
            int[] expected = { 1, 2, 2, 3, 5, 6 };
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            int m = 3;
            int n = 3;

            var result = Solution.Merge(nums1, m, nums2, n);


            result.Should().Equal(expected);
        }

        /*
         Example 2:

        Input: nums1 = [1], m = 1, nums2 = [], n = 0
        Output: [1]
        Explanation: The arrays we are merging are [1] and [].
        The result of the merge is [1].
         */
        [Fact]
        public void Test2()
        {
            int[] expected = { 1};
            int[] nums1 = { 1 };
            int[] nums2 = { };
            int m = 1;
            int n = 0;

            var result = Solution.Merge(nums1, m, nums2, n);


            result.Should().Equal(expected);
        }

        /*
        Example 3:

        Input: nums1 = [0], m = 0, nums2 = [1], n = 1
        Output: [1]
        Explanation: The arrays we are merging are [] and [1].
        The result of the merge is [1].
        Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
        */
        [Fact]
        public void Test3()
        {
            int[] expected = { 1 };
            int[] nums1 = { 0 };
            int[] nums2 = { 1 };
            int m = 0;
            int n = 1;

            var result = Solution.Merge(nums1, m, nums2, n);


            result.Should().Equal(expected);
        }

        [Fact]
        public void Test4()
        {
            int[] expected = { 1,2,3,4,5,6 };
            int[] nums1 = { 4,5,6,0,0,0 };
            int[] nums2 = { 1,2,3 };
            int m = 3;
            int n = 3;

            var result = Solution.Merge(nums1, m, nums2, n);


            result.Should().Equal(expected);
        }

        [Fact]
        public void Test5()
        {
            int[] expected = { -1,0,0,1,2,2,3,3,3 };
            int[] nums1 = { -1,0,0,3,3,3,0,0,0};
            int[] nums2 = { 1,2,2 };
            int m = 6;
            int n = 3;

            var result = Solution.Merge(nums1, m, nums2, n);

            result.Should().Equal(expected);
        }

        [Fact]
        public void Test6()
        {
            int[] expected = { 1,2 };
            int[] nums1 = {1,0 };
            int[] nums2 = { 2 };
            int m = 1;
            int n = 1;

            var result = Solution.Merge(nums1, m, nums2, n);

            result.Should().Equal(expected);
        }
    }
}