public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length > magazine.Length)//如果信件字數比雜誌字數還多則直接打掉(false)
            {
                return false;
            }
            else
            {
                char[] charA = ransomNote.ToCharArray();
                char[] charB = magazine.ToCharArray();
                int[] a = new int[26];// 代表英文的26個字母
                int[] b = new int[26];// 代表英文的26個字母

                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < ransomNote.Length; j++)
                    {
                        if (charA[j] == (char)(97 + i))//(char)(97 + i)為a~z
                        {
                            a[i]++;
                        }
                    }
                    for (int k = 0; k < magazine.Length; k++)
                    {
                        if (charB[k] == (char)(97 + i))
                        {
                            b[i]++;
                        }
                    }
                }
                
                
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > b[i])
                    {
                        return false;
                    }
                }
            }
            return true;
    }
}

/*
1.將兩個string轉為Char[]。charA、charB

2.設兩個 int[] 存放字母出現次數 (a、b)。

3.設大迴圈 i (26次、代表26個英文字母(char)(97)=a)。

4.設兩個小迴圈 j k 做比對用(勒索信字母的長度、雜誌字母的長度)

5.迴圈從A~Z比對勒索信與雜誌共出現哪幾個英文字母及出現幾次。

6.如果勒索信相同的字母出現次數大於雜誌則判斷為假。
*/