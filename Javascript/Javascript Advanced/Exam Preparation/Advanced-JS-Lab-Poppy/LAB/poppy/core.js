var poppy = poppy || {};

(function(scope) {

function pop(type, title, message) {
    var popup = {};
    popup._popupData = {};

    var OPACITY_STEP = 0.04,
        FADE_IN_INTERVAL = 20,
        FADE_OUT_INTERVAL = 40;

        switch (type) {
            case 'success':
                popup = new scope._models.Success(title, message);
                break;
            case 'info':
                popup = new scope._models.Info(title, message);
                break;
            case 'error':
                popup = new scope._models.Error(title, message);
                break;
            case 'warning':
                popup = new scope._models.Warning(title, message, callback);
                break;
        }
        //success, info, error, warnin
    }
	
	// generate view from view factory
    var view = createPopupView(popup);

    processPopup(view, popup);
}

function processPopup(domView, popup) {
	// TODO: Implement popup logic
    if (popup._popupData.autoHide === true) {
        setTimeout(function() {
            fadeOut(element, FADE_OUT_INTERVAL);
        }, popup._popupData.timeout);
    }

    if (popup._popupData.closeButton === true) {
        element.getElementsByClassName('poppy-close-button')[0]
            .addEventListener('click', function() {
                fadeOut(element, FADE_OUT_INTERVAL);
            });
    }

    if (popup._popupData.callback) {
        element.addEventListener('click', function() {
            popup._popupData.callback();
        });
    }

    element.style.opacity = 0;
    document.body.appendChild(element);
    fadeIn(element, FADE_IN_INTERVAL);
}

function fadeOut(element, interval) {
    var opacity = 1,
        disappearInterval = setInterval(function() {
            if (opacity <= 0) {
                document.body.removeChild(element);
                clearInterval(disappearInterval);
            }

            element.style.opacity = opacity;
            opacity -= OPACITY_STEP;
        }, interval);
}


function fadeIn(element, interval) {
    var opacity = 0,
        disappearInterval = setInterval(function() {
            if (opacity >= 1) {
                clearInterval(disappearInterval);
            }

            element.style.opacity = opacity;
            opacity += OPACITY_STEP;
        }, interval);

    scope.pop = pop;

} (poppy);

