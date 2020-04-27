public class Solution {
    public string GetHint(string secret, string guess) {
        int bull = 0;
        int cow  = 0;

        // 儲存secret[n],guess[n]數字不同的元素
        List<int> skeep = new List<int>();
        List<int> gkeep = new List<int>();

        //先判斷位置數字都一樣，剩下的用sK, gK來儲存
        for(var i =0; i<guess.Length ;i++){
            // 位置數字都一樣，bull++
            if(secret[i]  == guess[i]){
                bull++;
            } else {
                skeep.Add(secret[i]);
                gkeep.Add(guess[i]);
            }
        }

        // 因為bull已經處理過，這邊只要gkeep內的元素出現在skeep內，代表就是一個cow
        for(var j =0; j<gkeep.Count ;j++){
            var findIndex = skeep.IndexOf(gkeep[j]);
            if(findIndex != -1){
                cow++;
                skeep.RemoveAt(findIndex);
            }
        }

        return bull+ "A" + cow + "B";
        
    }
}