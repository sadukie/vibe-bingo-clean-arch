window.bingoSpeak = function (text) {
    if ('speechSynthesis' in window) {
        var utter = new window.SpeechSynthesisUtterance(text);
        utter.lang = 'en-US';
        window.speechSynthesis.speak(utter);
    }
};
