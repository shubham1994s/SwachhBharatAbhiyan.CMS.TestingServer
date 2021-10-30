





function changeit() {
    debugger;
    var shortget = document.getElementsByClassName("side-navbar")[0];
    //var pageheader = document.getElementsByClassName("page-header")[0];
    //var TextDash = document.getElementsByClassName("no-margin-bottom")[0];
    //var SvgColor = document.getElementsByClassName("svg")[0];
    //var card = document.getElementsByClassName("card")[0];
    var aaa = shortget.style.backgroundColor;

    var defaultnavbar = {
        backgroundColor: "#f3fdf8"
    };
    var DTextDash = {
        color: "#000"
    };
    var BTextDash = {
        color: "#fff"
    };
    var Dpageheader = {
        backgroundColor: "#fff"
    };
    var Bpageheader = {
        backgroundColor: "#000"
    };
    var blacknavbar = {
        backgroundColor: "black",
        color: "#fff"
    };
 
    var blackcard = {
        backgroundColor: "black"
    };
    var defaultcard = {
        backgroundColor: "#FFF"
    };
    var BlackColor = {
        color: "#fff"
    };
    var DefaultColor = {
        color: "#686a76"
    };
    var WhiteColor = {
        color: "#fff"
    };
    var BlackColor = {
        color: "#000"
    };
    var SvgDC = {
        fill: "#686a76"
    };
    var SvgBC = {
        fill: "#fff"
    };
    var Dtable = {
        backgroundColor: "#FFF" ,
        color:"#000"
    };
    var Btable = {
        backgroundColor: "#000",
        color: "#fff"
    };
    var Dnav = {
        backgroundColor: "#1e3770"
    };
    var Bnav = {
        backgroundColor: "#000"
    };

    if (aaa == "black") {
        //shortget.style.backgroundColor = "#f3fdf8";
        //pageheader.style.backgroundColor = "#fff";
        //TextDash.style.color = "#000";
        //shortget.style.color = "#686a76";
        //SvgColor.style.fill = "#686a76";
        //card.style.backgroundColor = "#fff";
        /*$(".navbar").css(Dnav);*/
        $(".side-navbar").css(defaultnavbar);
        $(".card").css(defaultcard);
        $(".has-shadow").css(defaultcard);
        $(".no-margin-bottom").css(DTextDash);
        $(".page-header").css(Dpageheader);
        $("nav.side-navbar ul li a").css(DefaultColor);
        $(".card-header h3").css(BlackColor);
        $(".card .text h4").css(BlackColor);
        $("g").css(SvgDC);
        $("svg.svg3 g path").css(SvgDC);
        $("nav.side-navbar a[aria-expanded='true']").css(defaultnavbar);
        $("nav.side-navbar ul li li a").css(defaultnavbar);
        $(".table.dataTable").css(Dtable);
    } else {
        //shortget.style.backgroundColor = "black";
        //pageheader.style.backgroundColor = "black";
        //TextDash.style.color = "#fff";
        //shortget.style.color = "#fff";
        //SvgColor.style.fill = "#fff";
        //card.style.backgroundColor = "#000";
      /*  $(".navbar").css(Bnav);*/
        $(".side-navbar").css(blacknavbar);
        $(".no-margin-bottom").css(BTextDash);
        $(".card").css(blackcard);
        $(".has-shadow").css(blackcard);
        $("#housetotal").css(defaultcard);
        $(".page-header").css(Bpageheader);
        $("nav.side-navbar ul li a").css(WhiteColor);
        $(".card-header h3").css(BlackColor);
        $(".card .text h4").css(WhiteColor);
        $("g").css(SvgBC);
        $("svg.svg3 g path").css(SvgBC);
        $("nav.side-navbar a[aria-expanded='true']").css(blackcard);
        $("nav.side-navbar ul li li a").css(blackcard);
        $("thead").css(Btable);

    }

}

