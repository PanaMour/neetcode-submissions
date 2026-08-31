public class Solution {
    public uint ReverseBits(uint n) {
        uint result = 0;
        for (int i = 0; i < 32; i++) {
            uint bit = n & 1;
            result <<= 1;
            result |= bit;
            n >>= 1;
        }
        return result;
    }
}
