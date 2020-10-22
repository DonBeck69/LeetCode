export class BestTimeToBuy {
    public maxProfit(prices: number[]): number {
        if(prices.length == 0) {
            return 0;
        }
        
        let min: number = prices[0];
        let max: number = prices[0];
        let diff: number = 0;
        for (let i: number = 0; i < prices.length; i++) {
            if (min > prices[i]) {
                min = prices[i];
                max = prices[i];
            }
            
            if (max < prices[i]) {
                max = prices[i];
            }
            
            if (diff < max - min) {
                diff = max - min;
            }
        }
        
        return diff;
    };
}