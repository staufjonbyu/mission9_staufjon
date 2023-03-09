const rows = document.querySelectorAll("tr");

rows.forEach((row) => {
    row.addEventListener("dragstart", handleDragStart);
    row.addEventListener("dragover", handleDragOver);
    row.addEventListener("dragleave", handleDragLeave);
    row.addEventListener("drop", handleDrop);
});

let draggedRow;

function handleDragStart(event) {
    draggedRow = event.target;
}

function handleDragOver(event) {
    event.preventDefault();
    event.dataTransfer.dropEffect = "move";
}

function handleDragLeave(event) {
    // remove any highlighting or other effects
}

function handleDrop(event) {
    event.preventDefault();
    const targetRow = event.target;
    if (targetRow.tagName === "TD") {
        targetRow = targetRow.parentElement;
    }

    if (targetRow !== draggedRow) {
        const targetIndex = parseInt(targetRow.getAttribute("data-index"));
        const draggedIndex = parseInt(draggedRow.getAttribute("data-index"));

        // swap the items in the Model
        const temp = Model.basket.Items[targetIndex];
        Model.basket.Items[targetIndex] = Model.basket.Items[draggedIndex];
        Model.basket.Items[draggedIndex] = temp;

        // swap the rows in the HTML table
        targetRow.parentElement.insertBefore(draggedRow, targetRow);
    }
//}
