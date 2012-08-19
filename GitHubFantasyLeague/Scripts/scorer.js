(function() {
  var Scorer;
  var __bind = function(fn, me){ return function(){ return fn.apply(me, arguments); }; };
  Scorer = (function() {
    function Scorer() {}
    Scorer.prototype.score = function(username, callback) {
      return $.getJSON("" + _baseUrl + "/users/" + username, __bind(function(data) {
        return callback(data);
      }, this));
    };
    return Scorer;
  })();
  $(function() {
    window.scorer = new Scorer;
    return $('.score-trigger').click(function() {
      return scorer.score($('#username').val(), __bind(function(data) {
        return $('#total-score').text(data.TotalScore);
      }, this));
    });
  });
}).call(this);
