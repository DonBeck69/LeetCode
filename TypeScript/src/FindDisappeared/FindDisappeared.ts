
export class FindDisappeared {

    public findDisappearedNumbers(nums: number[]): number[] {
        nums = nums.sort((a, b) => a - b);
        let numSet: Set<number> = new Set<number>();
        let num: number = 1;
        for (let i: number = 0; i < nums.length; i++) {
            if (numSet.has(nums[i])) {
                numSet.delete(nums[i]);
            }

            if (num < nums[i]) {
                if (numSet.has(num)) {
                    numSet.delete(num);
                } else {
                    numSet.add(num);
                }
                    
                numSet.add(nums[i]);
            }

            if (num > nums[i]) {
                numSet.add(num);
            }
            
            num++;
        }

        return Array.from(numSet);
    };

    // one day, o(n) complex and space... sigh!
    public findDisappearedNumbers2(nums: number[]): number[] {
        nums = nums.sort((a, b) => a - b);
        let high: number = nums.length - 1;
        let numberCount: number = 1;
        let i: number = 0
        while (i <= high) {

            if (nums[0] === numberCount) {
                numberCount++;
            } else if (nums[0] <= numberCount && i + 1 > high) {
                nums.push(numberCount);
            } else if (nums[0] > numberCount && nums[0] < nums[1]  && i + 1 < high) {
                nums.push(numberCount);
                numberCount++;
            } else if (nums[0] > numberCount && nums[0] == nums[1]) {
                numberCount++;            
            } else if (nums[0] <= numberCount && nums[1] == numberCount) {
                numberCount++;
            } else {
                if (nums[1] === nums[nums.length - 1] && i + 1 < high) {
                    nums.pop();
                } 
                nums.push(numberCount);
                numberCount++;
            }
            nums.shift();
            i++;
        }

        return nums;
    };
}
