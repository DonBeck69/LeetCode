
export class LargestTriangleArea {
    public LargestArea(points: number[][]): number {
        let res: number = 0;
        let len: number = points.length;
        for (let i: number = 0; i < len - 2; i++){
            for (let j:number = i + 1; j < len - 1; j++) {
                for (let k: number = j + 1; k < len; k++ ){
                    let newArea: number = this.TriangleArea(points[i], points[j], points[k]);
                    if (newArea > res){
                        res = newArea;
                    }
                }
            }
        }
        return res;
    }

    public TriangleArea(one: Array<number>, two: Array<number>, three: Array<number>): number {
        let res: number = 0;
        let x: number = this.HypotLength(Math.abs(one[0] - two[0]), Math.abs(one[1] - two[1]));
        let y: number = this.HypotLength(Math.abs(two[0] - three[0]), Math.abs(two[1] - three[1]));
        let h: number = this.HypotLength(Math.abs(one[0] - three[0]), Math.abs(one[1] - three[1]));
        let p:number = (x + y + h) / 2;
        res = Math.sqrt(p * (p-x) * (p-y) * (p-h));
        return res;
    }



    public HypotLength (Y: number, X: number): number {
        return Math.sqrt((Y*Y)+(X*X));
    }
}