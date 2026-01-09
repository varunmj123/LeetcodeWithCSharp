public class Solution {
    public bool CheckInclusion(string s1, string s2) {

        if (s1.Length > s2.Length) {
            return false;
        }

        int[] s1Map = new int[26];

        foreach (var character in s1) {
            s1Map[character - 'a']++;
        }

        int left = 0;
        int right = s1.Length - 1;

        int[] s2Map = new int[26];
        for (int start = left; start <= right; start++) {
            s2Map[s2[start] - 'a']++;
        }

        while (right < s2.Length) {

            bool same = true;
            for (int i = 0; i < 26; i++) {
                if (s1Map[i] != s2Map[i]) {
                    same = false;
                    break;
                }
            }

            if (same) {
                return true;
            }

            s2Map[s2[left] - 'a']--;
            left++;
            right++;

            if (right < s2.Length) {
                s2Map[s2[right] - 'a']++;
            }
        }

        return false;
    }
}
