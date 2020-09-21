function clickEnum() {
    // When the cell in the table is clicked on, show the values in the enum.
    // This also causes the caret to be flipped upside down.
    var elem = $(this).children("ol");
    var caret = $("img.caret", this);
    if (elem.attr("hidden")) {
        elem.attr("hidden", false);
        elem.css("display", "inline");
        elem.parent().attr("title", "");
        caret.addClass("caret_rotated")
    } else {
        // If it was visible before, make it hidden again and flip the caret back.
        elem.attr("hidden", true);
        elem.css("display", "none");
        elem.parent().attr("title", "Click to see the list of values the enum can take");
        caret.removeClass("caret_rotated")
    }
}


$(document).ready(function() {
    // Every element on the page with the class expandable needs a few things added to it.
    $("div.expandable")
        .each(function() {
            $(this).parent().attr("title", "Click to see the list of values the enum can take");
            $(this).parent().on("click", clickEnum);
            $(this).append("&nbsp;<img class='caret' src='../../../images/caret.png' height='13' width='13' style='float:right'></img>")
        });
});