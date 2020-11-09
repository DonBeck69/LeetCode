
export class SingleNumberArray {
    public singleNumber(nums: Array<number>): number {
        let hash: Set<number> = new Set<number>();
        for (let i:number = 0; i < nums.length; i++){
            if(hash.delete(nums[i]) === false) {
                hash.add(nums[i]);
            }
        }
        return Array.from(hash)[0];
    }

    public singleNumberX(nums: Array<number>): number {
        let res: number = 0;
        for (let i:number = 0; i < nums.length; i++){
            res ^= nums[i];
        }
        return res;
    }
}