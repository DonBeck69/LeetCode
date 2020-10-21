"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const assert = require("assert");
const FindDisappeared_1 = require("../FindDisappeared");
describe("Test Suite 1", () => {
    it("Test Find 1", () => {
        let nums = [4, 3, 2, 7, 8, 2, 3, 1];
        let fd = new FindDisappeared_1.FindDisappeared();
        let result = fd.findDisappearedNumbers(nums);
        console.log(`result: ${result[0]}`);
        assert.ok(result[0] == 5, "This shouldn't fail");
    });
    it("Test Find 2", () => {
        assert.ok(1 === 1, "This shouldn't fail");
        assert.ok(false, "This should fail");
    });
});
//# sourceMappingURL=FindDisappearedTests.js.map