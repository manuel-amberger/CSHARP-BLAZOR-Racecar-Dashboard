let speedChart;
let rpmChart;

window.createCharts = (labels, speedData, rpmData) => {

    const speedCtx = document.getElementById("speedChart");
    const rpmCtx = document.getElementById("rpmChart");

    // SPEED CHART
    speedChart = new Chart(speedCtx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: [{
                label: 'Speed (km/h)',
                data: speedData,
                borderColor: 'cyan',
                tension: 0.1,
                fill: false,
                pointRadius: 0
            }]
        },
        options: {
            plugins: { legend: { display: false } },
            responsive: true,
            maintainAspectRatio: false,
            animation: false,
            scales: {
                x: {
                    bounds: 'ticks',
                    ticks: {
                        display: false
                    },
                    grid: {
                        display: true,
                        color: 'rgba(255, 255, 255, 0.2)',
                        stepSize: 15
                    }
                },
                y: {
                    grid: {
                        display: true,
                        color: 'rgba(255, 255, 255, 0.2)'
                    }
                }
            }
        }
    });

    // RPM CHART
    rpmChart = new Chart(rpmCtx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: [{
                label: 'RPM',
                data: rpmData,
                borderColor: 'orange',
                tension: 0.0,
                fill: false,
                pointRadius: 0
            }]
        },
        options: {
            plugins: { legend: { display: false } },
            responsive: true,
            maintainAspectRatio: false,
            animation: false,
            scales: {
                x: {
                    bounds: 'ticks',
                    grid: {
                        display: true,
                        color: 'rgba(255, 255, 255, 0.2)',
                        stepsize: 15
                    }
                },
                y: {
                    grid: {
                        display: true,
                        color: 'rgba(255, 255, 255, 0.2)'
                    }
                }
            }
        }
    });
};

window.updateChartData = (currentSpeed, currentRpm) => {
    if (!speedChart || !rpmChart) return;
    
    const maxDataPoints = 30;
    
    // SPEED CHART UPDATEN
    speedChart.data.datasets[0].data.push(currentSpeed);
    speedChart.data.labels.push("");
    
    if (speedChart.data.datasets[0].data.length > maxDataPoints) {
        speedChart.data.datasets[0].data.shift();
        speedChart.data.labels.shift();
    }
    speedChart.update('none');
    
    // RPM CHART UPDATEN
    rpmChart.data.datasets[0].data.push(currentRpm);
    rpmChart.data.labels.push("");
    
    if (rpmChart.data.datasets[0].data.length > maxDataPoints) {
        rpmChart.data.datasets[0].data.shift();
        rpmChart.data.labels.shift();
    }
    rpmChart.update('none');
}

window.resetCharts = () => {
    if (speedChart && rpmChart) {
        // SPEED CHART RESET
        speedChart.data.datasets[0].data = [];
        speedChart.data.labels = [];
        speedChart.update();
        
        // RPM CHART RESET
        rpmChart.data.datasets[0].data = [];
        rpmChart.data.labels = [];
        rpmChart.update();
    }
}