function removeit(e) {
  document.querySelector(e).remove();
}

function optionChange() {
  let itemCount = document.querySelector("#itemCount");
  var icValue = itemCount.options[itemCount.selectedIndex].value;
  document.querySelector("#pricetag").innerHTML = icValue * pricetag;
  document.querySelector("#purchase").removeAttribute("disabled");
  document.querySelector("#countoption").setAttribute("disabled", true);
}

let viewBoxSelect = function(item) {
  $(".sc-pname,.sc-p").hide();
  let selected = document.querySelector(".sc-selected");
  if (selected.classList.contains("sc-selected")) {
    selected.classList.remove("sc-selected");
  }
  item.classList.add("sc-selected");
  let allimg = document.querySelectorAll(".viewBox img");
  switch (item.children[1].innerHTML) {
    case "اتوبوس برقی":
      allimg.forEach(item => {
        item.style = "display:none";
      });
      document.querySelector(".viewBox").children[0].style = "display: unset";
      $(".sc-pname,.sc-p").fadeIn(500);
      $(".sc-pname").html("<h2>بلیت اتوبوس</h2>");

      break;
    case "تله‌سیژ":
      allimg.forEach(item => {
        item.style = "display:none";
      });
      document.querySelector(".viewBox").children[1].style = "display: unset";
      $(".sc-pname").html("<h2>بلیت تله سیژ</h2>");
      $(".sc-pname,.sc-p").fadeIn(500);

      break;
    case "سورتمه":
      allimg.forEach(item => {
        item.style = "display:none";
      });
      document.querySelector(".viewBox").children[2].style = "display: unset";
      $(".sc-pname").html("<h2>بلیت سورتمه</h2>");
      $(".sc-pname,.sc-p").fadeIn(500);

      break;
    case "تله‌کابین":
      allimg.forEach(item => {
        item.style = "display:none";
      });
      document.querySelector(".viewBox").children[3].style = "display: unset";
      $(".sc-pname").html("<h2>بلیت تله کابین</h2>");
      $(".sc-pname,.sc-p").fadeIn(500);

      break;
    case "رزرو هتل":
      allimg.forEach(item => {
        item.style = "display:none";
      });
      document.querySelector(".viewBox").children[4].style = "display: unset";
      $(".sc-pname").html("<h2>رزرو هتل</h2>");
      $(".sc-pname,.sc-p").fadeIn(500);

      break;
  }
};

let toggleNav = function(item) {
  setTimeout(() => {
    document
      .querySelector("#backtoggle")
      .setAttribute("style", "display:unset !important");
  }, 500);
  item.setAttribute("style", "visibility:hidden !important");
  $(".fullscreennav")
    .css("display", "flex")
    .animate({ "margin-right": "+=40vw" });
  document
    .querySelector("body")
    .setAttribute("style", "height: 100%; overflow:hidden;");
  $("#fsblur")
    .addClass("fsblur")
    .fadeTo(1000, 1);
};

let toggleNavClose = function(item) {
  setTimeout(() => {
    document
      .querySelector("#toggler")
      .setAttribute("style", "visibility:visible");
    $(".fullscreennav").css("display", "none");
    document
      .querySelector("body")
      .setAttribute("style", "height: unset; overflow-y:unset");
  }, 1000);
  item.setAttribute("style", "visibility:hidden !important");
  $(".fullscreennav").animate({ "margin-right": "-=40vw" });
  $("#fsblur").fadeOut(1000);
};
let signup = function(item) {
  document.querySelector(item).style = "display:none";
  document.querySelector(".signup").style = "display:grid !important";

  if (item == ".signup") {
    document.querySelector(item).style = "display:none";
    document.querySelector(".signin").style = "display:grid !important";
  }
};

let bgindex = 0;
bgSlider();
function bgSlider() {
  let imgs = document.querySelectorAll(".backgroundImage img");
  for (let i = 0; i < imgs.length; i++) {
    imgs[i].style.display = "none";
  }
  bgindex++;
  if (bgindex > imgs.length) {
    bgindex = 1;
  }
  $(imgs[bgindex - 1]).fadeIn(1000, Function());
  setTimeout(bgSlider, 20000);
}

let innavshow = function(item) {
  $(".selectedNav").slideUp();
  $(".selectediNav").slideUp();
  $(item)
    .next()
    .addClass("selectedNav")
    .slideDown();
};

let iinavshow = function(item) {
  // item.nextSibling.nextSibling.style = "display:unset";
  $(".selectediNav").slideUp();
  $(item)
    .next()
    .addClass("selectediNav")
    .slideDown();
};

window.onscroll = function() {
  $(".innerlist").fadeOut(200);
  let navbar = document.querySelector("header");
  let sticky = (navbar.offsetTop = 550);
  if (window.pageYOffset <= sticky) {
    $(navbar).css("display", "none");
    $(".logo img").attr("src", "./src/images/logo3.png");
    // $('.stickynav').css('background-color','#da251e');
  }
  if (window.pageYOffset >= sticky) {
    $(navbar)
      .addClass("stickynav")
      .slideDown();
    // $('.stickynav').css('background-color','white');
    $(".logo img").attr("src", "./src/images/logo5.png");
  } else {
    $(navbar).removeClass("stickynav");
    $(navbar).css("display", "unset");
  }
};

window.addEventListener("click", function(e) {
  console.log(e.target);
  if (e.target.contains(document.querySelector(".innerlist"))) {
    $(".innerlist").fadeOut(200);
  } else {
    console.log("inside");
  }
});

$(".innerlist").fadeOut(200);

let listhandler = function(item) {
  $(item)
    .children()
    .fadeIn();
  $(item)
    .children()
    .css("display", "flex");
  $(".innerlist")
    .not($(item).children())
    .fadeOut();
};
let listhandlerutil = function(item) {
  $(item)
    .next()
    .fadeIn();
  $(item)
    .next()
    .css("display", "flex");
  $(".innerlist")
    .not($(item).next())
    .fadeOut();
};

let listhandlermob = function(item) {
  // $(item).children().next().toggle('fade');
  $(".usericon").show();
  $(".filterdiv").show("fade");
  $(".mobilenav").hide("slide");
  $(item).css("display", "flex");
  $(item).fadeIn();
};

$(".innerlist")
  .not($(".profilelist"))
  .on("mouseleave", () => {
    $(".innerlist").fadeOut(200);
  });

let userformhandler = function(event, event2) {
  $(event2).fadeOut();
  setTimeout(() => {
    $(event).fadeIn();
  }, 400);
};

$(window).on("load", () => {
  console.log("test");
  $(".preloader").fadeOut(1000);
});

let hideout = function(item) {
  $(item)
    .parent()
    .fadeOut();
  $(".filterdiv").fadeOut();
  $(".usericon").hide();
};
let hideoutmob = function(item) {
  $(item)
    .parent()
    .fadeOut();
};

$(".mobilenav").hide();

let slidein = function(item) {
  $(item).show("slide");
};

let showlist = function(item) {
  $(item)
    .next()
    .slideToggle();
  $(item)
    .parent()
    .parent()
    .children()
    .children()
    .next()
    .not($(item).next())
    .slideUp();
};
let showfinallist = function(item) {
  $(item)
    .next()
    .show("slide");
};

let hidefinallist = function(item) {
  $(item)
    .parent()
    .hide("slide");
};

function myFunction(x) {
  if (x.matches) {
    // If media query matches
    $(".logo img").attr("src", "./src/images/logo5.png");
  } else {
    $(".logo img").attr("src", "./src/images/logo3.png");
  }
}

var x = window.matchMedia("(max-width: 1136px)");
myFunction(x);
x.addListener(myFunction);

if (mq.matches) {
  $(".logo img").attr("src", "./src/images/logo5.png");
} else {
  $(".logo img").attr("src", "./src/images/logo3.png");
}
