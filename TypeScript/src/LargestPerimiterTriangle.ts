
export class LargestPerimiterTriangle{
    public LargestPerimeter(A: Array<number>): number {
        let res: number = 0;
        A.sort();
        let i: number = A.length - 1;
        while (i > 1){
            if(A[i - 2] + A[i - 1] <= A[i])
            {
                i--;
            }
            else
            {
                res = A[i - 2] + A[i - 1] + A[i];
                break;
            }
        }

        return res;
    }
}