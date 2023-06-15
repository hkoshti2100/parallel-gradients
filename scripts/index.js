$(function() {

	//navMobile
	const hamburger = $("header #hamburger");
	const navMobileClose = $("#nav-mobile .header-mobile > .close-button");
	const navMobile = $("body > #nav-mobile");

	// navMobile
	hamburger.on("click", function() {
		navMobile
			.toggleClass("open")
			.prev().toggleClass("open");

		$("header, main, footer").toggleClass("transparent");
	});

	navMobileClose.on("click", function() {
		navMobile
			.toggleClass("open")
			.prev().toggleClass("open");

		$("header, main, footer").toggleClass("transparent");
	});

	navMobile.prev().on("click", function() {
		navMobile
			.toggleClass("open")
			.prev().toggleClass("open");

		$("header, main, footer").toggleClass("transparent");
	});

	hamburger.click();

});