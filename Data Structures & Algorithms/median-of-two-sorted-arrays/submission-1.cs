public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
    int[] A = nums1;
    int[] B = nums2;
    if (B.Length < A.Length)
    {
        A = nums2;
        B = nums1;
    }
    int len = Math.Min(A.Length, B.Length);
    int left = 0;
    int right = len - 1;
    int total = A.Length + B.Length;
    int half = total / 2;
    while (true)
    {
        int midA = (int)Math.Floor((left + right) / 2.0);
        int midB = half - midA - 2;

        int Aleft = (midA >= 0) ? A[midA] : int.MinValue;
        int Aright = (midA + 1 < A.Length) ? A[midA + 1] : int.MaxValue;
        int Bleft = (midB >= 0) ? B[midB] : int.MinValue;
        int Bright = (midB + 1 < B.Length) ? B[midB + 1] : int.MaxValue;
        if (Aleft <= Bright && Bleft <= Aright)
        {
            if (total % 2 == 1)
            {
                return Math.Min(Aright, Bright);
            }
            return (Math.Max(Aleft, Bleft) + Math.Min(Aright, Bright)) / 2.0;
        }
        else if (Aleft > Bright)
        {
            right = midA - 1;
        }
        else
        {
            left = midA + 1;
        }
    }
}
}
