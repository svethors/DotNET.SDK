﻿describe("when value to be validated is not a string", function () {
    var exception = null;
    try {
        var validator = doLittle.validation.minLength.create({ options: { length: 3 } })
        validator.validate(2)
    } catch (e) {
        exception = e;
    }

    it("should throw not a string exception", function () {
        expect(exception instanceof doLittle.validation.NotAString).toBe(true);
    });
});