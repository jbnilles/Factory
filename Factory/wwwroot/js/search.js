$(document).ready(function () {
    
  $('.toggle-eng').click(function () {
    let dom = $('#' + $(this).attr('id'))
    let element = $(this).attr('id').split('-');
    if(dom.text() === '+')
    {
      dom.text('-')
    }
    else{
      dom.text('+')
    }
    $('#ul-e-' + element[element.length - 1]).toggle();
  })
  $('.toggle-mac').click(function () {
    let dom = $('#' + $(this).attr('id'))
    let element = $(this).attr('id').split('-');
    if(dom.text() === '+')
    {
      dom.text('-')
    }
    else{
      dom.text('+')
    }
    $('#ul-m-' + element[element.length - 1]).toggle();
  })
})



