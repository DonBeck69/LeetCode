//import { describe } from 'mocha';
import { expect } from "chai";
import { ListNode } from "../src/merge_two_arrays/ListNode";
import { MergeSortedList } from "../src/merge_two_arrays/MergeSortedList";


describe('MergeLists', () => {
    it("l1 null l2 null", () => {
        let merge: MergeSortedList = new MergeSortedList();
        let node1: ListNode = null;
        let node2: ListNode = null;
        let res: ListNode | null = merge.mergeTwoLists(node1, node2);
        expect(res).to.deep.equal(null);
    });

    it("l1 null l2 is list", () => {
        let merge: MergeSortedList = new MergeSortedList();
        let node1: ListNode = null;
        let node2: ListNode = new ListNode();
        node2.val = 0;
        let res: ListNode | null = merge.mergeTwoLists(node1, node2);
        expect(res.val).to.deep.equal(0);
    });

    it("l1=[1,2,4] l2=[1,3,4]", () => {
        let merge: MergeSortedList = new MergeSortedList();
        let ln4: ListNode = new ListNode();
        ln4.val = 4;
        let ln2: ListNode = new ListNode();
        ln2.val = 2;
        ln2.next = ln4;
        let ln1: ListNode = new ListNode();
        ln1.val = 1;
        ln1.next = ln2;

        
        let rn4: ListNode = new ListNode();
        rn4.val = 4;
        let rn3: ListNode = new ListNode();
        rn3.val = 3;
        rn3.next = rn4;
        let rn1: ListNode = new ListNode();
        rn1.val = 1;
        rn1.next = rn3;
        
        let res: ListNode | null = merge.mergeTwoLists(ln1, rn1);
        expect(res.next.next.val).to.deep.equal(2);
    });
});
