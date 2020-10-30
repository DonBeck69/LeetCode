export class CoinChange {
    
    /*
    some formula, 
    */
    public changeCount (amount: number, coins: Array<number>): number {
        let res: number = 0;
        for (let i:number; i < coins.length; i++) {
            let remain: number = amount % coins[i];
            if (remain > 0) {
                //find remainder in coins
                for(let j: number = i - 1; j > 0; j--){
                    if (coins[j] == remain) {
                        res++;
                    }
                }
            }
        }
        return res;
    }
}

/*
function change(amount: number, coins: number[]): number {
  const dp = new Array(amount + 1).fill(0);

  dp[0] = 1;

  coins.forEach((coin) => {
    for (let i = coin; i <= amount; i += 1) {
      dp[i] += dp[i - coin];
    }
  });

  return dp[amount];
}
*/