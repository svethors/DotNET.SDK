﻿describe("when command is valid", function () {

    var tasks = {
        all: ko.observableArray()
    };

    var messengerFactory = {
        create: function () { },
        global: function () { }
    };
    var operationsFactory = {
        create: function () {
            return {
                all: ko.observableArray(),
                stateful: ko.observableArray()
            }
        }
    };
    var tasksFactory = {
        create: function () {
            return tasks;
        }
    };

    var region = new doLittle.views.Region(
        messengerFactory,
        operationsFactory,
        tasksFactory
    );
    var isValid = false;
    region.isValid.subscribe(function (newValue) {
        isValid = newValue;
    });

    var command = {
        isValid: ko.observable(false),
        isAuthorized: ko.observable(false),
        canExecute: ko.observable(false),
        hasChanges: ko.observable(false),
        isReadyToExecute: ko.observable(false),
        validators: ko.observableArray()
    };

    region.commands.push(command);
    command.isValid(true);

    it("should make the region valid", function () {
        expect(isValid).toBe(true);
    });
});