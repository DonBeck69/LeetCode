// Fibionachi numbers
export class ClimbingStairs {
    public climbStairs(n: number): number {
        let res = n;
        if (res < 4) {
            return res;
        }

        let fibFirst: number = 3;
        let fibSecond: number = 2;
        for (let i: number = 4; i <= n; i++) {
            res = fibFirst + fibSecond;
            fibSecond = fibFirst;
            fibFirst = res;
        }

        return res;
    };
}