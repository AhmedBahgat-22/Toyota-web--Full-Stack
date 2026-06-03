document.addEventListener('DOMContentLoaded', function() {
    fetchAndRender(0);
    setupCategoryFilter();
});

function fetchAndRender(categoryId) {
    var grid = document.getElementById('vehicles-grid');
    grid.innerHTML = '<div class="v-loading">Loading vehicles...</div>';
    var url = categoryId === 0 ? '/api/vehicles' : '/api/vehicles?categoryId=' + categoryId;
    
    fetch(url)
        .then(function(res) { return res.json(); })
        .then(function(data) { renderGrid(data); })
        .catch(function() {
            grid.innerHTML = '<div class="v-loading">Error loading vehicles.</div>';
        });
}

function renderGrid(vehicles) {
    var grid = document.getElementById('vehicles-grid');
    if (!vehicles.length) {
        grid.innerHTML = '<div class="v-loading">No vehicles found.</div>';
        return;
    }
    var html = '';
    for (var i = 0; i < vehicles.length; i++) {
        var v = vehicles[i];
        var badge = v.badge ? '<span class="v-badge">' + v.badge + '</span>' : '';
        html += '<div class="v-card">';
        html += badge;
        html += '<div class="v-card-img"><img src="' + v.imageUrl + '" alt="' + v.name + '"></div>';
        html += '<p class="v-as-shown">$' + Number(v.asShownPrice).toLocaleString() + ' as shown *</p>';
        html += '<p class="v-year">' + v.year + '</p>';
        html += '<h3 class="v-car-name">' + v.name + '</h3>';
        html += '<p class="v-msrp">$' + Number(v.startingMSRP).toLocaleString() + '* Starting MSRP</p>';
        html += '<div class="v-card-btns">';
        html += '<button class="v-btn-build" data-id="' + v.id + '" data-type="build">Build</button>';
        html += '<button class="v-btn-shop" data-id="' + v.id + '" data-type="shop">Shop</button>';
        html += '</div></div>';
    }
    grid.innerHTML = html;

    var buildBtns = document.querySelectorAll('[data-type="build"]');
    var shopBtns  = document.querySelectorAll('[data-type="shop"]');

    buildBtns.forEach(function(btn) {
        btn.addEventListener('click', function() {
            window.location.href = '/Build/Index/' + this.getAttribute('data-id');
        });
    });

    shopBtns.forEach(function(btn) {
        btn.addEventListener('click', function() {
            window.location.href = '/Shop/Checkout/' + this.getAttribute('data-id');
        });
    });
}

function setupCategoryFilter() {
    var items = document.querySelectorAll('.v-cat-item');
    items.forEach(function(item) {
        item.addEventListener('click', function(e) {
            e.preventDefault();
            items.forEach(function(i) { i.classList.remove('active'); });
            item.classList.add('active');
            fetchAndRender(parseInt(item.getAttribute('data-id'), 10));
        });
    });
}