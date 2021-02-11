/* -------------------------------------------------------| C O N T R O L L E R |----------------------------------------------------------------*/
function velgDiagram(valgtDiagram) {
    //console.log(valgtDiagram) //henter diagramNr
    chosenBarValue = numbers[valgtDiagram - 1] //valgt diagram verdi til senere bruk

    if (chosenBar == valgtDiagram) { //hvis chosenBar + valgtDiagram har samme verdi = string byttes til "ingen"
        chosenBar = 'ingen';
        chosenBarValue = ''; // må ha denne slik at chosenBarValue blir '', når du deselecter
        inputValue = "0" // må ha denne, ellers vil input verdi være det samme som verdi du endret stolpe
    } else {
        chosenBar = valgtDiagram; //velger diagram hvis du ikke har valgt den samme verdien 
    }
    show();
}


function slettDiagram() {
    let posisjon = chosenBar; //valgt diagram (nr1-8) > går inn i posisjon 
    posisjon -= 1 ; //chosenBar starter på 1, så du må fjerne 1, for at posisjon verdi for at dette skal stemme når du bruker splice
    //console.log(posisjon)
    numbers.splice(posisjon, 1); //fjerner array element fra posisjon (1-8)verdi 
    chosenBar = "ingen"; 
    show();
}


function endreDiagram() {   
    if (inputValue < 1 || inputValue >= 11) {
        alert("Ugyldig verdi. Verdi skal være mellom 1 og 10..");
    }
    else if (inputValue == "ingen" || inputValue == chosenBarValue) {alert("Du har valgt samme verdi")}
    else {
        numbers[chosenBar - 1] = inputValue;
        chosenBarValue = inputValue;    }    
    show();
}


function leggTilDiagram() {
    if (inputValue == 0)
        alert ("Du må legge til en verdi")

    else if (inputValue < 1 || inputValue >= 11) {
        alert("Ugyldig verdi. Verdi skal være mellom 1 og 10..");        
    } 
    else {
        numbers.length >= 8 ? alert("Du kan ikke ha flere enn 8 stolpe diagrammer") : numbers.push(inputValue);
    }
    show();
}