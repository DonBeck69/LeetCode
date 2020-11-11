// Fibionachi numbers
export class FibonacciNumber {
    public fib(N: number): number {
        let res = N;
        let fibFirst: number = 1;
        let fibSecond: number = 0;
        for (let i: number = 2; i <= N; i++) {
            res = fibFirst + fibSecond;
            fibSecond = fibFirst;
            fibFirst = res;
        }

        return res;
    };
}