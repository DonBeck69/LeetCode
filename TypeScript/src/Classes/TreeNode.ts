export class TreeNode {
    public constructor(init?: Partial<TreeNode>) {
        Object.assign(this, init);
    }

    public val: number;
    public left: TreeNode | null;
    public right: TreeNode | null;
}