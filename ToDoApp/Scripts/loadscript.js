function LoadContent() {
    $("#ContentID").load("/Home/GetPageContent");
}

function ClearContent() {
    $("#ContentID").empty();
}