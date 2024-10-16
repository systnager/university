const headers = document.querySelectorAll('.accordion-header');

headers.forEach(header => {
    header.addEventListener('click', function () {
        const content = header.nextElementSibling;
        const sub = header.getElementsByClassName('accordion-sym')[0];

        if (content.classList.contains('open')) {
            content.classList.remove('open');
            sub.classList.remove('open');
        } else {
            headers.forEach(h => {
                const siblingContent = h.nextElementSibling;
                let sub2 = h.getElementsByClassName('accordion-sym')[0];
                siblingContent.classList.remove('open');
                sub2.classList.remove('open');
            });

            content.classList.add('open');
            sub.classList.add('open');
        }
    });
});