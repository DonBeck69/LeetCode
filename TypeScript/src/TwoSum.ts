import { Hash } from "crypto";

export class TwoSum {
    public twoSums(nums: Array<number>, target: number): Array<number> {
        let res: Array<number> = new Array<number>();
        let index: Map<number, number> = new Map<number, number>();
        let diff: number = 0;
        console
        for (let i: number = 0; i < nums.length; i++) {
            diff = target - nums[i];
            if (index.has(diff)) {
                res.push(index.get(diff)!);
                res.push(i);
                break;
            } else {
                index.set(nums[i], i);
            }
        }
        return res;
    }

    public twoSumsII(numbers: Array<number>, target: number): Array<number> {
        let res: Array<number> = [0,0];
        let l: number = 0;
        let r:number = numbers.length - 1;
        let sum:number = 0;
        while(l < r){
            sum = numbers[l] + numbers[r];
            if (sum === target) {
                res[0] = l + 1;
                res[1] = r + 1;
                break;
            } else if (sum < target) {
                l++;
            } else {
                r--;
            }
        }
        return res;
    }
}