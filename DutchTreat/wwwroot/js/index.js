var theForm = document.getElementById("theForm");
theForm.hidden = true;

var button = document.getElementById("buyButton");
button.addEventListener("click", function () {
    console.log("Comprando um item");
});

var productInfo = document.getElementByClassName("product-props");
var listItems = productInfo.item[0].children;