$(document).ready(initProgram);

function initProgram() {
    const btnOpen = $(".open");
    const btnClose = $(".closeModal");
    const closeImg = $(".closeImg")
    const modal = $("dialog");

    btnOpen.click(() => {
        modal[0].showModal();
    });

    btnClose.click(() => {
        modal[0].close();
    });

    closeImg.click(() => {
        modal[0].close();
    });
}