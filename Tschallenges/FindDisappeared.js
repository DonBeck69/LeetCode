"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.FindDisappeared = void 0;
class FindDisappeared {
    findDisappearedNumbers(nums) {
        nums = nums.sort();
        for (let i = 1; i < nums.length; i++) {
            if (nums[i] - nums[i - 1] > 1) {
                let count = nums[i] - nums[i - 1];
                console.log(`count: ${count}`);
                for (let j = count; j > 0; j--) {
                    nums.push(nums[i] - j);
                }
            }
            nums.shift();
            console.log(nums.toString());
        }
        nums.shift();
        return nums;
    }
    ;
}
exports.FindDisappeared = FindDisappeared;
//# sourceMappingURL=FindDisappeared.js.map