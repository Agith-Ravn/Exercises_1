// Legger til i modell om hvilken notat som vises
function visNotatX(index) {
    model.currentPage = index

    view();
    menuOpen(); 
}


// Legger til nye notater i modell  -------------------------------------------
function LeggtilNotater() {    
    model.notater.push({
        notatNavn: 'Notat',
        innhold: ''
    })

    view();
    menuOpen(); 
}


// Slette notater i modell  ---------------------------------------------------
function slettNotat(index) {
    model.notater.splice(index, 1);

    if (model.currentPage == 0) {
        model.currentPage = index
    } else {
    model.currentPage = index - 1;
    }

    view();
    menuOpen(); 
}


// Endre notater i modell  ---------------------------------------------------
function endreNotat(index) {
    model.notatEditMode = true;

    view();
    menuOpen(); 
}


// Lagre notater i modell  ---------------------------------------------------
function lagreNotat(index) {
    model.notatEditMode = false;

    view();
    menuOpen(); 
}


// Lagrer om checkbox i oppgave er krysset eller ikke i modell  ----------------
function oppgaveKryssetAv(index) {    
    if (model.toDoList[index].kryssetAv == false) {
        model.toDoList[index].kryssetAv = true;
    } else {
        model.toDoList[index].kryssetAv = false;
    }
    
    view();
    menuOpen(); 
}


// Sletter oppgave i modell  ---------------------------------------------------
function slettOppgave(oppgaveIndex) {
    model.toDoList.splice(oppgaveIndex, 1);
    
    view();
    menuOpen(); 
}


// Legger til oppgave i modell --------------------------------------------------
function leggTilOppgave() {
    model.toDoList.push({
        oppgave: model.nyOppgaveInput,
        kryssetAv: false
    })
    
    view();
    menuOpen();
}
