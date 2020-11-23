var PictureModule = function(url, success) {

    navigator.getUserMedia = (navigator.getUserMedia ||
        navigator.webkitGetUserMedia ||
        navigator.mozGetUserMedia ||
        navigator.msGetUserMedia);

    var video;
    
    function startWebcam() {
        if (navigator.getUserMedia) {
            navigator.getUserMedia(

                // constraints
                {
                    video: true,
                    audio: false
                },

                // successCallback
                function(localMediaStream) {
                    video = document.querySelector('video');

                    if (window.webkitURL) {
                        video.srcObject = localMediaStream;
                    } else {
                        video.src = stream;
                    }

                    sendToServer();
                },

                // errorCallback
                function(err) {
                    console.log("The following error occured: " + err);
                }
            );
        } else {
            console.log("getUserMedia not supported");
        }

    }

    var canvas, ctx;

    function init() {
        // Get the canvas and obtain a context for
        // drawing in it
        canvas = document.getElementById("canvas");
        ctx = canvas.getContext('2d');

        startWebcam();
    }

    function snapshot() {
        // Draws current image from the video element into the canvas
        ctx.drawImage(video, 0, 0, canvas.width, canvas.height);
    }

    function sendToServer() {
        snapshot();

        var image = document.getElementById("canvas").toDataURL("image/png");
        image = image.replace('data:image/png;base64,', '');
        $.ajax({
            type: 'POST',
            url: url,
            data: '{ "imageData" : "' + image + '" }',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function(data) {
                success(data);
                setTimeout(sendToServer, 3000);
            }
        });
    }
    return {
        init: init
    };
}