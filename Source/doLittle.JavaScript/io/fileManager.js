﻿doLittle.namespace("doLittle.io", {
    fileManager: doLittle.Singleton(function () {
        /// <summary>Represents a manager for files, providing capabilities of loading and more</summary>
        var self = this;

        var uri = doLittle.Uri.create(window.location.href);
        if (window.location.protocol === "file:") {
            this.origin = window.location.href;
            this.origin = this.origin.substr(0, this.origin.lastIndexOf("/"));

            if (this.origin.lastIndexOf("/") === this.origin.length - 1) {
                this.origin = this.origin.substr(0, this.origin.length - 1);
            }
        } else {
            var port = uri.port || "";
            if (!doLittle.isUndefined(port) && port !== "" && port !== 80) {
                port = ":" + port;
            }

            this.origin = uri.scheme + "://" + uri.host + port;
        }

        function getActualFilename(filename) {
            var actualFilename = self.origin;

            if (filename.indexOf("/") !== 0) {
                actualFilename += "/";
            }
            actualFilename += filename;

            return actualFilename;
        }

        this.load = function (files) {
            /// <summary>Load files</summary>
            /// <param parameterArray="true" elementType="doLittle.io.File">Files to load</param>
            /// <returns type="doLittle.execution.Promise">A promise that can be continued with the actual files coming in as an array</returns>
            var filesToLoad = [];

            var promise = doLittle.execution.Promise.create();

            files.forEach(function (file) {
                var path = getActualFilename(file.path.fullPath);
                if (file.fileType === doLittle.io.fileType.html) {
                    path = "text!" + path + "!strip";
                    if (!file.path.hasExtension()) {
                        path = "noext!" + path;
                    }
                }

                filesToLoad.push(path);
            });

            require(filesToLoad, function () {
                promise.signal(arguments);
            });

            return promise;
        };
    })
});
doLittle.WellKnownTypesDependencyResolver.types.fileManager = doLittle.io.fileManager;