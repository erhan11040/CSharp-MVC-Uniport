
        $(function () {
            $("#topbut").click(function () {
                // Sayfamızı kaydıracak olan kod burasıdır.
                $("html,body").stop().animate({ scrollTop: "0" }, 1000);
            });
        });
        $(window).scroll(function () {
            var uzunluk = $(document).scrollTop();
            if (uzunluk > 200) $("#topbut").fadeIn(500);
            else { $("#topbut").fadeOut(500); }
        });
    