export class SingleEmelent {
    public findElement (nums: Array<number>): number {
        let res: number = 0;
        for (let i: number = 1; i < nums.length; i+= 2) {
            if (nums[i] != nums[i - 1]) {
                res = nums[i - 1];
                break;
            }
        }
        return res;
    }
}