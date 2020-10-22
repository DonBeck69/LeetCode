/**
 * MergeArrays
 */
export class MergeArrays {

    public merge(nums1: number[], m: number, nums2: number[], n: number): Array<number> {
        let process: boolean = true;
        if ((m === 0 || nums1.length === 0) && (n === 0 || nums2.length === 0)) {
            nums1 = [];
            process = false;
        }

        if (m === 0 || nums1.length === 0) {
            nums1 = nums2;
            process = false;
        }

        if (n === 0 || nums2.length === 0) {
            process = false;
        }

        if (process) {
            let mi: number = 0;
            let i: number = 1;
            while (nums2.length > 0 && mi < m + n) {
                if (i > Math.max(m, Math.abs(m-n))) {
                    nums1[mi++] = nums2[0];
                    nums2.shift();

                } else if (nums2[0] === nums1[mi]) {
                    nums1.splice(mi + 1, 0, nums2[0]);
                    nums1.pop();
                    mi += 2;
                    nums2.shift();
                } else if (nums2[0] < nums1[mi]) {
                    nums1.splice(mi++, 0, nums2[0]);
                    nums1.pop();
                    nums2.shift();
                } else if (nums2[0] > nums1[mi]) {
                    if (i >= m){
                        nums1[mi++] = nums2[0];
                        nums2.shift();
                    } else {
                        mi++;
                    }
                }
                i++;
            }
        }

        return nums1;
    };
}