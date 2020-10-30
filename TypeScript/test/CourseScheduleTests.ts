import { expect } from "chai";
import { CourseSchedule } from "../src/CourseSchedule";


describe('Course schedue tests', () => {
    it("course sched 1", () => {
        let course: CourseSchedule = new CourseSchedule();
        let pre: number[][]= [];
        pre.push([0,1]);
        let res: boolean = course.CanFinish(2,pre);
        expect(res).to.deep.equal(true);
    });

    it("course sched 2", () => {
        let course: CourseSchedule = new CourseSchedule();
        let pre: number[][]= [];
        pre.push([0,1]);        
        pre.push([1, 0]);
        let res: boolean = course.CanFinish(2,pre);
        expect(res).to.deep.equal(false);
    });
    it("course sched 3", () => {
        let course: CourseSchedule = new CourseSchedule();
        let pre: number[][]= [];
        pre.push([0,1]);
        pre.push([0,2]);
        pre.push([1,2]);
        let res: boolean = course.CanFinish(3,pre);
        expect(res).to.deep.equal(true);
    });
    it("course sched 4", () => {
        let course: CourseSchedule = new CourseSchedule();
        let pre: number[][]= [];
        pre.push([0,1]);
        pre.push([1,2]);
        pre.push([2,0]);
        let res: boolean = course.CanFinish(2,pre);
        expect(res).to.deep.equal(false);
    });
});