let body = document.body;
body.style.fontFamily = "Arial";
let p_list = body.getElementsByTagName("p");
p_list[0].setAttribute('style', 'color: orange; background: yellow; font-size: 16px; text-align: center; margin: 5px;');
p_list[1].setAttribute('style', 'color: blue; background: #aabfff; font-size: 14px; text-align: right; margin: 5px;');
p_list[2].setAttribute('style', 'color: red; background: #ffb6b6; font-size: 12px; text-align: left; margin: 5px;');

function td_clicked(td) {
    td.setAttribute('class', 'selected');
}

const td_list = document.querySelectorAll('td');
td_list.forEach(function(td) {
    td.addEventListener('click', function() {
        td.classList.add('selected');
    });
});
