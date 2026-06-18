window.gaugeInstances = {};

window.gaugeInterop = {
    initGauge: function (canvasId, maxValue) {
        var opts = {
            angle: 0, // The span of the gauge arc
            lineWidth: 0.1, // The line thickness
            radiusScale: 0.75, // Relative radius
            pointer: {
                length: 0, // // Relative to gauge radius
                strokeWidth: 0.046, // The thickness
                color: '#121E2B' // Fill color
            },
            limitMax: false,     // If false, max value increases automatically if value > maxValue
            limitMin: false,     // If true, the min value of the gauge will be fixed
            colorStart: '#FFFFFF',   // Colors
            colorStop: '#FFFFFF',    // just experiment with them
            strokeColor: '#121E2B',  // to see which ones work best for you
            generateGradient: true,
            highDpiSupport: true,     // High resolution support

        };
        var target = document.getElementById(canvasId);
        
        window.gaugeInstances[canvasId] = new Gauge(target).setOptions(opts);
        window.gaugeInstances[canvasId].maxValue = maxValue;
        window.gaugeInstances[canvasId].setMinValue(0);
        window.gaugeInstances[canvasId].animationSpeed = 35; 
    },

    // Aktualisiert werte
    updateValue: function (canvasId, value) {
        if (window.gaugeInstances[canvasId]) {
            window.gaugeInstances[canvasId].set(value);
        }
    }
};