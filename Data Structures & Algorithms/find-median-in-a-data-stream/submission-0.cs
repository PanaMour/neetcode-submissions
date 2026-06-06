public class MedianFinder {
    PriorityQueue<int, int> smallHeap;
    PriorityQueue<int, int> largeHeap;
    public MedianFinder() {
        smallHeap = new PriorityQueue<int, int>();
        largeHeap = new PriorityQueue<int, int>();
    }

    public void AddNum(int num) {
        smallHeap.Enqueue(num, -num);

        if (largeHeap.Count > 0 && smallHeap.Peek() > largeHeap.Peek()) {
            int val = smallHeap.Dequeue();
            largeHeap.Enqueue(val, val);
        }

        if (smallHeap.Count > largeHeap.Count + 1) {
            int val = smallHeap.Dequeue();
            largeHeap.Enqueue(val, val);
        } else if (largeHeap.Count > smallHeap.Count + 1) {
            int val = largeHeap.Dequeue();
            smallHeap.Enqueue(val, -val);
        }
    }

    public double FindMedian() {
        if (smallHeap.Count > largeHeap.Count) {
            return smallHeap.Peek();
        }
        if (largeHeap.Count > smallHeap.Count) {
            return largeHeap.Peek();
        }
        return (smallHeap.Peek() + largeHeap.Peek()) / 2.0;
    }
}
