import { ListNode } from "./ListNode";

export class MergeSortedList {

    public mergeTwoLists(l1: ListNode | null, l2: ListNode | null): ListNode | null {
        let node: ListNode = new ListNode();
        let tempNode: ListNode = node;
        if (l1 === null && l2 === null) {
            return null;
        }

        if (l1 === null && l2 != null) {
            return l2;
        }

        if (l1 != null && l2 === null) {
            return l1;
        }

        while (l1 != null || l2 != null) {
            if (l2 === null) {
                tempNode.val = l1!.val;
                l1 = l1!.next;
            } else if (l1 === null) {
                tempNode.val = l2!.val;
                l2 = l2!.next;
            } else if (l1!.val < l2!.val) {
                tempNode.val = l1!.val;
                l1 = l1!.next;
            } else if (l2!.val < l1!.val) {
                tempNode.val = l2.val;
                l2 = l2!.next;
            } else {
                tempNode.val = l1!.val;
                tempNode.next = new ListNode();
                tempNode = tempNode.next;
                tempNode.val = l2!.val;
                l1 = l1!.next;
                l2 = l2!.next;
            }

            if (l1 != null || l2 != null) {
                tempNode.next = new ListNode();
                tempNode = tempNode.next;
            }
        }

        return node;
    };


}
