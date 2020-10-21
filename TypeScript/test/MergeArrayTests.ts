//import { describe } from 'mocha';
import { expect } from "chai";
import { ListNode } from "../src/merge_two_arrays/ListNode";
import { MergeArrays } from "../src/merge_two_arrays/MergeArrays";


describe('MergeArrays', () => {
    it("can be merged", () => {
        let node1: ListNode = new ListNode();
        node1.val = 1;
        let node2: ListNode = new ListNode();
        node2.val = 2;
        let merge: MergeArrays = new MergeArrays();
        let res: ListNode | null = merge.mergeTwoLists(node1, node2);
        expect(res.val = 1);
    });
});
