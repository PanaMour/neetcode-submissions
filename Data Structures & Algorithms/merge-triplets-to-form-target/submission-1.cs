public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        bool foundX = false;
        bool foundY = false;
        bool foundZ = false;
        foreach(int[] t in triplets){
            if(t[0] > target[0] || t[1] > target[1] || t[2] > target[2]) continue;
            if(t[0] == target[0]) foundX = true;
            if(t[1] == target[1]) foundY = true;
            if(t[2] == target[2]) foundZ = true;
        }

        return foundX && foundY && foundZ;
    }
}
