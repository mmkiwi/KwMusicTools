(function () {
    "use strict";
    var script = document.createElement("script");
    script.src = "//code.jquery.com/jquery-2.1.1.min.js";
    document.getElementsByTagName("head")[0].appendChild(script);

    var checkready = function (callback) {
        if (window.jQuery) {
            callback(window.jQuery);
        } else {
            window.setTimeout(function () {
                checkready(callback);
            }, 100);
        }
        checkready(function ($) {
            alert($("body").text());
        });
    }
})();