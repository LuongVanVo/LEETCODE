public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        int i = 0;
        int j = 0;

        // sort both arrays
        Array.Sort(nums1);
        Array.Sort(nums2);

        List<int> list = new List<int>();
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
            {
                i++;
            } else if (nums1[i] > nums2[j])
            {
                j++;
            } else
            {
                list.Add(nums1[i]);
                i++; 
                j++;
            }
        }

        return list.ToArray();
    }
}