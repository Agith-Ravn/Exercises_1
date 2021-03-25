// NavBar ----------------------------------------------------------------------
function view() {
    
    let html = '';

    html += `<div id="navBar">`

        html += `<div id="notesButton" onclick="notesMenu()"> Notes </div>
                <div id="tools"> Agith's super kule notat app 😎 </div>
                <div id="toDoListButton" onclick="toDoListMenu()"> To do list </div>`     

    html += `</div>`
    
    //Lager alt av notat menu view
    html += notatMenuView();

    //Lager alt av to do list menu view
    html += toDoListView();

    //Lager alt av notater
    html += notater();

    

    document.getElementById('app').innerHTML = html;
}


// Notat menu  ---------------------------------------------------------------

function notatMenuView() {

    let html = '';

    html += `<div id="notes">
                <div id="noteContainer">`

    //Lage + hente alle notatene
    for (let i = 0; i < model.notater.length; i++) {
        html += lageAlleNotater(i);
    }

    html += `</div>
            <h2 onclick="LeggtilNotater()" id="nyttNotat" class="nyttNotatHidden"> + Nytt notat </h2>
            </div>`
    
    return html;
}


// Lage view av alle notater i modell ----------------------------------------
function lageAlleNotater(index) {
    return `<h2 id="note" class="noteHidden" onclick="visNotatX(${index})">` + model.notater[index].notatNavn + ` </h2>`
    
}


// Notat innhold ---------------------------------------------------------------
function notater() {
    let html = ``;
    let index = model.currentPage

    html += `<div class="notatGridLayout">
                <div class="grid1"> </div>`
    
        if (model.notatEditMode == false) {

            html += `<div id="notatContainer" class="grid2">
                <div class="slettOgEndreContainer">
                    <div class="slettNotat" onclick="slettNotat(${index})"> Slett notat </div>               
                    <div class="endreNotat" onclick="endreNotat(${index})"> Endre notat </div>
                </div>`               
                
            if (model.notater.length == 0) {
                html += `<h2 id="overskrift"> Ingen notater </h2>
                <div id="tekst"> </div>`
            } else { 
                html += `<h2 id="overskrift">`+ model.notater[index].notatNavn +`</h2>
                <div id="tekst">`+ model.notater[index].innhold +`</div>`
            }

        } if (model.notatEditMode == true) {

            html += `<div id="notatContainer" class="grid2">
            <div class="slettOgEndreContainer">
                <div class="slettNotat" onclick="slettNotat(${index})"> Slett notat </div>               
                <div class="endreNotat" onclick="lagreNotat(${index})"> Lagre </div>
            </div>`               
            
            if (model.notater.length == 0) {
                html += `<h2 id="overskrift"> Ingen notater </h2>
                <div id="tekst"> </div>`
            } else { 
                html += `<input type="text" oninput="model.notater[${index}].notatNavn = this.value" id="overskriftInput" value="`+ model.notater[index].notatNavn +`">
                <textarea oninput="model.notater[${index}].innhold = this.value" id="notatTekstInput">`+ model.notater[index].innhold +`</textarea>`
            }

        }

    html += `</div>`

    html += `<div class="grid3"> </div>
            </div>`

    return html;
}


// To do list menu -------------------------------------------------------------
function toDoListView() {
    let html = '';
 
    html = `<div id="toDoList">    
                <div id="toDoListContainer">`

                //Lage oppgaver
    for (let i = 0; i < model.toDoList.length; i++) {
        html += lageAlleOpggaver(i);
    }

    html += `</div>
                <div id="nyttOppgave" > 
                    <input type="text" oninput="model.nyOppgaveInput = this.value" id="oppgaveInput" class="oppgaveInputHidden">
                    <button onclick="leggTilOppgave()" id="leggTilOppgave" class="leggTilOppgaveHidden"> + </button>
                </div>
            </div>
            `

    return html;
}


// Lager alle oppgaver ---------------------------------------------------------
function lageAlleOpggaver(index) {

    //Sjekker verdiene i model og krysser av checkbox
    let alleCheckbox = model.toDoList[index]
    let krysseCheckbox;
    if (alleCheckbox.kryssetAv == true) {
        krysseCheckbox = 'checked="checked"';
    } else {
        krysseCheckbox = '';
    }

    return `<div id="oppgave" class="test1">
                <input type="checkbox" onchange="oppgaveKryssetAv(${index})" id="toDoListCheckbox" class="toDoListCheckboxHidden" ${krysseCheckbox}>
                <div id="oppgaveTekst" class="oppgaveTekstHidden">` +  model.toDoList[index].oppgave + `</div>
                <div id="fjernOppgave" class="fjernOppgaveHidden" onclick="slettOppgave(${index})"> x </div>
            </div>`

}


