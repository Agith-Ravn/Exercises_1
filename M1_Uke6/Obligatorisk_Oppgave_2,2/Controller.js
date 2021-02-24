/* -------------------------------------------------------| C O N T R O L L E R |----------------------------------------------------------------*/
function chooseDiagram(valgtDiagram) {
    chosenDiagramValue = numbers[valgtDiagram - 1]
    //console.log(chosenDiagramValue)

    chosenDiagram = chosenDiagram != valgtDiagram ? valgtDiagram : 'ingen';
    // chosenDiagram får verdi:
    // Hvis chosenDiagram ikke er lik valgtDiagram verdi, får den valgtDiagram verdi
    // Hvis ikke får chosenDiagram 'ingen' verdi    

    //console.log(chosenDiagram)
    show();
}

function deleteDiagram() {
    let posisjon = chosenDiagram;
    posisjon -= 1;
    numbers.splice(posisjon, 1)
    chosenDiagram = 'ingen';
    //console.log(posisjon)
    show();    
}

function changeDiagram() {
    if (inputValue < 1 && inputValue !=0 || inputValue > 10 ) {
        alert('Ugydlig verdi. Verdi skal være mellom 1 og 10.')
    } 
    else if (numbers[chosenDiagram - 1] == inputValue || inputValue == '' || inputValue == 0) {
        alert('Du må legge til en ny verdi');
    }
    else {
        numbers[chosenDiagram - 1] = inputValue
        chosenDiagramValue = inputValue
    }
    show();
}

function addDiagram() {
    if (inputValue <= 0 || inputValue > 10 || inputValue == '') {
        alert('Ugydlig verdi. Verdi skal være mellom 1 og 10.');
    }
    else if (numbers.length > 8) {
        alert('Max 8 stolpe diagrammer');
    }
    else {
        numbers.push(inputValue);
    }
    show();
}