public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if(hand.Length % groupSize != 0) return false;
        Dictionary<int,int> freq = new Dictionary<int,int>();
        foreach (int card in hand)
        {
            if (!freq.ContainsKey(card))
            {
                freq[card] = 0;
            }
            freq[card]++;
        }
        Array.Sort(hand);
        foreach(int c in hand){
            if(freq[c] > 0){
                for(int i = 0; i < groupSize; i++)
                {
                    int nextCard = c + i;                    
                    if(!freq.ContainsKey(nextCard) || freq[nextCard] == 0)
                    {
                        return false;
                    }                    
                    freq[nextCard]--;
                }
            }
        }
        return true;
    }
}
