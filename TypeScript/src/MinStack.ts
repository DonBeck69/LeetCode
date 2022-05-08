
export class MinStack {
    
    private _stack: Array<number>;

    constructor(){
        this._stack = new Array<number>();
    }

    public push(x: number): void {
        this._stack.push(x);
    }

    public pop(): void {
        this._stack.pop();
    }

    public top(): number {
        return this._stack[this._stack.length - 1];
    }

    public getMin(): number {
        // the three dots ... break up the array [1, 2, 3] for Math.min into 1, 2, 3 
        return Math.min(...this._stack);
    }
}