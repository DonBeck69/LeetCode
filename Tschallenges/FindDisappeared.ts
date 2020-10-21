import { Console } from "console";

export class FindDisappeared {

    public  findDisappearedNumbers(nums: number[]): number[] {
        nums = nums.sort();
        for (let i: number = 1; i < nums.length; i++) {
            if (nums[i] - nums[i - 1] > 1) {
                let count: number = nums[i] - nums[i - 1];
                console.log(`count: ${count}`);
                for (let j: number = count; j > 0; j--) {
                    nums.push(nums[i] - j);
                }
            }

            nums.shift();
            console.log(nums.toString());
        }
        nums.shift();

        return nums;
    };


}