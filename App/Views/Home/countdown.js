$(function () {
  var defaultTimer = 65, // Default amount of seconds if url variable is not found
    callback = function () {
      // Will be executed when the timer finishes
      alert("Time is up!");
    };

  var counter = 1,
    timer,
    match = document.location.href.match(/[\?|&]timer=(\d+)/i),
    totalTime = match ? match[1] : defaultTimer;
  var s;
  timer = setInterval(function () {
    if (totalTime != -1 && !isNaN(totalTime)) {
      val =
        "Time left: " +
        (function () {
          var m = Math.floor(totalTime / 60);
          if (m < 10) {
            return "0".concat(m);
          } else {
            return m;
          }
        })() +
        ":" +
        (function () {
          s = totalTime % 60;
          if (s < 10) {
            return "0".concat(s);
          } else {
            return s;
          }
        })();

      $("#counter").html(val);
      totalTime--;
    } else {
      window.clearInterval(timer);
      timer = null;
      callback();
    }
  }, 1000);
});
