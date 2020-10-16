$(document).ready(function () {
    
  $('.toggle').click(function () {
      
      let element = $(this).attr('id').split('-');
      
      $('#ul-e-' + element[element.length - 1]).toggle();
      
  })
  
})



