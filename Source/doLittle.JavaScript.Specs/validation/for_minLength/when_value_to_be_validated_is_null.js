﻿describe("when value to be validated is null", function () {
    var validator = doLittle.validation.minLength.create({ options: { length: 3 } })
    var result = validator.validate(null)

    it("should be invalid", function () {
        expect(result).toBe(false);
    });
});
