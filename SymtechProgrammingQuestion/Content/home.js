

$.fn.dateTimex =function () {
    $("#datetime").focus(function () {
        $("#myform input[type=text]").val('');
        document.getElementById("datetime").value='';
        $("#myform").show(500);


        $.ajax({
            url: '/api/date/',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                 document.getElementById("datetime").value = data.replace("T", " ");
                console.log(data);
            },
            error: function () {
                console.log('Error in Operation');
            }
        });

    });

};




$("#dateTime").dateTimex();
