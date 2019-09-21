﻿(function () {
    "use strict";

    const Selectors = {
        MASTHEAD: ".masthead"
    };

    class Masthead {
        static initialize() {
            let masthead = document.querySelector(Selectors.MASTHEAD);
            if (masthead) {
                this.animate(masthead);
            }
        }

        static animate(element) {
            let scrolling = false;
            window.addEventListener("scroll", () => {
                scrolling = true;
                setInterval(() => {
                    if (scrolling) {
                        const height = element.getBoundingClientRect().height;
                        const opacity = 1 - (window.scrollY / height);
                        if (opacity >= 0) {
                            element.style.opacity = opacity.toFixed(2);
                        }

                        scrolling = false;
                    }
                }, 100);
            });
        }
    }

    Masthead.initialize();
}());
