let slideshowpage = document.querySelectorAll(".slideshow-img img");
var parentlast = slideshowpage[slideshowpage.length - 1];
var newel = slideshowpage[0];
var cln = parentlast.cloneNode(true);
$(cln).insertBefore(newel).addClass('ignore');
console.log(parentlast);

let imgs = document.querySelectorAll(".slideshow-img img");
let index = 1;
$(".indexnumber span:nth-of-type(1)").html(`<span>${index}</span>`);
$(".indexnumber span:nth-of-type(2)").html(`<span>${imgs.length}</span>`);

let leftamount = 15;
let amount = 7.5;

let nextimage = function() {
  $(".slideshow-img").css("left", `calc(-${(amount += leftamount)}vw + 10.8px)`);
  $(".selectedimg")
    .removeClass("selectedimg")
    .next()
    .addClass("selectedimg");

  let slideshowpage = $(".slideshow-img img");
  cln = slideshowpage[index].cloneNode(true);
  parentlast = slideshowpage[slideshowpage.length - 1];
  console.log(parentlast);
  $(cln).insertAfter(parentlast);

  index++;
  if (index > imgs.length) {
    index = 1;
  }
  $(".indexnumber span:nth-of-type(1)").html(`<span>${index}</span>`);
  $(".indexnumber span:nth-of-type(2)").html(`<span>${imgs.length}</span>`);
};

let previmage = function() {
  if (index > 1) {
    $(".slideshow-img").css(
      "left",
      `calc(-${(amount -= leftamount)}vw + 10.8px)`
    );
    $(".selectedimg")
      .removeClass("selectedimg")
      .prev()
      .addClass("selectedimg");

    index--;
    if (index < 1) {
      index = 1;
    }
    $(".indexnumber span:nth-of-type(1)").html(`<span>${index}</span>`);
    $(".indexnumber span:nth-of-type(2)").html(`<span>${imgs.length}</span>`);
  } else {
    $(".fa-angle-right").addClass("arrownotice");
    setTimeout(() => {
      $(".fa-angle-right").removeClass("arrownotice");
    }, 500);
  }
};
