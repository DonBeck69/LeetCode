
export class MaximumSubArray {
    public  maxSubArray(nums: number[]): number {
        //Kadane's algorithm
        let current: number = nums[0];
        let best: number = nums[0];
        for (let i: number = 1; i < nums.length; i++){
            current = Math.max(nums[i], current + nums[i]);
            best = Math.max(best, current);
        }
        return best;
    };
}