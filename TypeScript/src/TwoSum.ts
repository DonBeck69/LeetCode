export class TwoSum {
    public twoSums(nums: Array<number>, targate: number): Array<number> {
        let res: Array<number> = [0,0];
        let l: number = 0;
        let r:number = nums.length - 1;
        let sum:number = 0;
        while(l < r){
            sum = nums[l] + nums[r];
            if (sum === targate) {
                res[0] = l + 1;
                res[1] = r + 1;
                break;
            } else if (sum < targate) {
                l++;
            } else {
                r--;
            }
        }
        return res;
    }
}