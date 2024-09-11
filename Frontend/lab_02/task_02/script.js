let text = `Lorem ipsum dolor sit amet, consectetur adipisicing elit. Deserunt ea earum incidunt minima nihil. Blanditiis consectetur cumque debitis delectus dolor dolorem dolorum, eos laboriosam, modi nemo, quasi quos sint voluptatibus!`;

let indicesString = text[12] + text[6] + text[18] + text[25];
console.log("Рядок за індексами:", indicesString);

let lowerCaseText = text.toLowerCase();
console.log("Текст у нижньому регістрі:", lowerCaseText);

let positions = [];
let searchStr = "in";
let pos = text.indexOf(searchStr);
while (pos !== -1) {
    positions.push(pos);
    pos = text.indexOf(searchStr, pos + 1);
}
console.log("Позиції послідовності 'in':", positions);

let textArray = text.split(" ");
console.log("Масив підрядків за пробілом:", textArray);

let reversedText = text.split("").reverse().join("");
console.log("Інвертований рядок:", reversedText);

function ucFirst(txt) {
    if (!txt) return txt;
    return txt[0].toUpperCase() + txt.slice(1);
}
console.log(ucFirst('some text'));
