public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) 
    {
        HashSet<string> wordSet = new HashSet<string>(wordList);
        
        if (!wordSet.Contains(endWord)) 
        {
            return 0;
        }

        Queue<(string word, int steps)> queue = new Queue<(string word, int steps)>();
        queue.Enqueue((beginWord, 1));
        
        wordSet.Remove(beginWord);

        while (queue.Count > 0) 
        {
            var current = queue.Dequeue();
            string currentWord = current.word;
            int steps = current.steps;

            if (currentWord == endWord) 
            {
                return steps;
            }

            char[] wordChars = currentWord.ToCharArray();
            
            for (int i = 0; i < wordChars.Length; i++) 
            {
                char originalChar = wordChars[i]; 
                for (char c = 'a'; c <= 'z'; c++) 
                {
                    if (c == originalChar) continue;

                    wordChars[i] = c;
                    string newWord = new string(wordChars);

                    if (wordSet.Contains(newWord)) 
                    {
                        queue.Enqueue((newWord, steps + 1));                        
                        wordSet.Remove(newWord);
                    }
                }
                wordChars[i] = originalChar;
            }
        }
        return 0;
    }
}
