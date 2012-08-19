class Scorer
  score: (username, callback) ->
    $.getJSON "#{_baseUrl}/users/#{username}", (data) =>
        callback data

$ ->
  window.scorer = new Scorer

  $('.score-trigger').click ->
    scorer.score $('#username').val(), (data) =>
      $('#total-score').text data.TotalScore