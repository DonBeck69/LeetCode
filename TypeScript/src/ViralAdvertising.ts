export class ViralAdvertising {

    public  ViralAdvertising(n: number): number {
        let r: number = 2;
        let s: number = 2;
        for (let i: number = 1; i < n; i++) {
            s = Math.floor((s * 3) / 2);
            r += s; 
        }
        return r;
    
    } 
}