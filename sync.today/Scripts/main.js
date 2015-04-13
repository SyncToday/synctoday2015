$(function () {
    var uri = '/api/journals';

    $.getJSON(uri)
        .done(function (data) {
            $.each(data, function (key, item) {
                $('<tr><td>' + (key + 1) + '</td><td>' + item.date + '</td><td>' + item.message + '</td></tr>')
                    .appendTo($('#journals tbody'));
            });
        });
});
