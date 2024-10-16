function create_table(row_count, column_count) {
    let table = document.createElement("table");
    for (let i = 0; i < row_count; i++) {
        let row = document.createElement("tr");
        table.appendChild(row);
        for (let j = 0; j < column_count; j++) {
            let column = document.createElement("td");
            column.textContent = `${j}`;
            row.appendChild(column);
        }
    }

    return table;
}

document.body.appendChild(create_table(3, 3));

/* ------------------------------------------------------------------ */

function create_form_element(label_text, input_count, input_type, input_name, input_text='') {
    let label = document.createElement("label");
    label.textContent = label_text;
    for (let i = 0; i < input_count; i++) {
        let input = document.createElement("input");
        label.appendChild(input);
        input.type = input_type;
        input.name = input_name;
        input.textContent = input_text;
    }

    return label;
}

function create_form_select(label_text, option_count, options_text) {
    let label = document.createElement("label");
    let select = document.createElement("select");
    label.textContent = label_text;
    label.appendChild(select);
    select.name = label_text;
    for (let i = 0; i < option_count; i++) {
        let option = document.createElement("option");
        select.appendChild(option);
        option.textContent = options_text[i];
        option.value = options_text[i];
    }

    return label;
}

let form = document.createElement("form");


form.appendChild(create_form_element('Логін: ', 1, 'text', 'login'));
form.appendChild(document.createElement('br'));


form.appendChild(create_form_element('Пароль: ', 1, 'password', 'password'));
form.appendChild(document.createElement('br'));


create_form_element('Повторіть пароль: ', 1, 'password', 'rp_password');
form.appendChild(document.createElement('br'));


let sex_label = document.createElement("label");
sex_label.textContent = 'Стать: ';
sex_label.appendChild(create_form_element('Чоловіча', 1, 'radio', 'sex'));
sex_label.appendChild(create_form_element('Жіноча', 1, 'radio', 'sex'));
form.appendChild(sex_label);
form.appendChild(document.createElement('br'));


form.appendChild(create_form_select('Вкажіть місто: ', 3, [
    'Житомир',
    'Київ',
    'Львів',
]));
form.appendChild(document.createElement('br'));


let interest_label = document.createElement("label");
interest_label.textContent = 'Інтереси: ';
interest_label.appendChild(create_form_element('футбол', 1, 'checkbox', 'interest'));
interest_label.appendChild(create_form_element('шахи', 1, 'checkbox', 'interest'));
interest_label.appendChild(create_form_element('малювання', 1, 'checkbox', 'interest'));
interest_label.appendChild(create_form_element('музика', 1, 'checkbox', 'interest'));
form.appendChild(interest_label);
form.appendChild(document.createElement('br'));


let clear_button = document.createElement("button");
let submit_button = document.createElement("button");
clear_button.textContent = 'Очистити';
submit_button.textContent = 'Відправити';
clear_button.type = 'reset';
submit_button.type = 'submit';
form.appendChild(clear_button);
form.appendChild(submit_button);


document.body.appendChild(form);