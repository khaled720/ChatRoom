

var connection =new signalR.HubConnectionBuilder().withUrl("/chatHub").build();


connection.on("ReceiveMessage", function (userName, message) {
    var msg = userName + " : " + message;
    var li = document.createElement("li");
    li.textContent = msg;
    $("#list").append(li);

});

connection.start();

document.getElementById("btnSend").onclick =
    function () {
        var user = $("#txtUser").val();
        var msg = $("#txtMessage").val();;

        connection.invoke("SendMessage", user, msg);
    };



