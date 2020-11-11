
export class TribonacciNumber {
    public tribonacci(n: number): number {
        let seqStarter: Array<number> = [0,1,1,2];
        if (n < 4) {
           return seqStarter[n]; 
        }
        let res: number = n;
        let fibFirst: number = 2;
        let fibSecond: number = 1;
        let fibThird: number = 1
        for (let i: number = 4; i <= n; i++) {
            res = fibFirst + fibSecond + fibThird;
            fibThird = fibSecond;
            fibSecond = fibFirst;
            fibFirst = res;
        }

        return res;
    };
}