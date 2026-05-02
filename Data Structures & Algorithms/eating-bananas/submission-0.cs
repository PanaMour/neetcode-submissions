public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
{
    double totalHours;
    int kmin = int.MaxValue;
    int left = 1;
    int right = 0;
    foreach(int pile in piles)
    {
        right = Math.Max(right, pile);
    }
    while( left <= right)
    {
        totalHours = 0;
        int mid = left + (right - left) / 2;
        foreach(int pile in piles)
        {
            totalHours += Math.Ceiling((double)pile / mid);
            Console.WriteLine(totalHours + " " + pile + " " + mid);
        }
        if(totalHours > h)
        {
            left = mid + 1;
        }
        else if(totalHours <= h)
        {
            right = mid - 1;
            kmin = Math.Min(mid, kmin);
        }            
    }

    return kmin;
}
}
