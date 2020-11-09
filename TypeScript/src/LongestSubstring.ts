
export class LongestSubstring {

    public LengthOfLongestSubstring(s: string): number {
        let res: number = 0;
        let visited: Set<string> = new Set<string>();
        let l: number = 0;
        let r: number = 0;
        //let chars: Array<string> = new Array(s);
        while(r < s.length){
            if (visited.has(s[r])){
                visited.delete(s[l]);
                l++;
            } else {
                visited.add(s[r]);
                res = Math.max(Array.from(visited).length, res);
                r++;
            }
        }
        return res;
    }
}