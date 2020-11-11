import { expect } from "chai";
import { ClimbingStairs } from "../src/ClimbingStairs";

// Fibionachi numbers
describe('Climbing Stairs', () => {
    it("stairs 1", () => {
        let stairs: ClimbingStairs = new ClimbingStairs();
        let res: number = stairs.climbStairs(1);
        expect(res).to.deep.equal(1);
    });

    it("stairs 2", () => {
        let stairs: ClimbingStairs = new ClimbingStairs();
        let res: number = stairs.climbStairs(2);
        expect(res).to.deep.equal(2);
    });
    it("stairs 3", () => {
        let stairs: ClimbingStairs = new ClimbingStairs();
        let res: number = stairs.climbStairs(3);
        expect(res).to.deep.equal(3);
    });
    
    it("stairs 4", () => {
        let stairs: ClimbingStairs = new ClimbingStairs();
        let res: number = stairs.climbStairs(4);
        expect(res).to.deep.equal(5);
    });    
    it("stairs 5", () => {
        let stairs: ClimbingStairs = new ClimbingStairs();
        let res: number = stairs.climbStairs(5);
        expect(res).to.deep.equal(8);
    });
});