
//Må bruke document.getElementById for å bruke .classList.add og .classList.remove

//funksjon som sjekker om menu bar og toDoList menu er åpent  -----------
function menuOpen() {
    model.toDoListMenu == true ? toDoListMenuTrue() : null;
    model.notatMenu == true ? notesMenuTrue() : null;
}

// Vis og skjul alle notater  -------------------------------------------
function notesMenu() {    
    if (model.notatMenu == false) {
        model.notatMenu = true;
        notesMenuTrue();

    } else if (model.notatMenu == true) {
        model.notatMenu = false;
        notesMenuFalse();
    }
}

    function notesMenuTrue() {
        document.getElementById('notes').classList.add('notes');
        document.getElementById('noteContainer').classList.add('noteContainer');
    
        let alleClassesNoteHidden= document.getElementsByClassName('noteHidden')
            for (var i = 0; i < alleClassesNoteHidden.length; i++) {
                alleClassesNoteHidden[i].classList.add('note');
        }
    
        document.getElementById('nyttNotat').classList.add('nyttNotat');
    }

    function notesMenuFalse() {
        document.getElementById('notes').classList.remove('notes');
        document.getElementById('noteContainer').classList.remove('noteContainer');
    
        //For å gi alle classes med navn 'NoteHidden' classList.toggle('note')
        let alleClassesNoteHidden= document.getElementsByClassName('noteHidden')
            for (var i = 0; i < alleClassesNoteHidden.length; i++) {
                alleClassesNoteHidden[i].classList.remove('note');
        }
    
        document.getElementById('nyttNotat').classList.remove('nyttNotat');
    }


// Vis og skjul to do list menu  -------------------------------------------
function toDoListMenu() {

    if (model.toDoListMenu == false) {
        model.toDoListMenu = true;
        toDoListMenuTrue();

    } else if (model.toDoListMenu == true) {
        model.toDoListMenu = false;
        toDoListMenuFalse();
    }
}


    // funksjon som får opp to do list menu  -------------------------------------------
    function toDoListMenuTrue() {
        document.getElementById('toDoList').classList.add('toDoList');
        document.getElementById('toDoListContainer').classList.add('toDoListContainer');

        let alleClassesTest1 = document.getElementsByClassName('test1')
        for (var i = 0; i < alleClassesTest1.length; i++) {
            alleClassesTest1[i].classList.add('oppgave');
        }

        let alleClassesCheckboxHidden = document.getElementsByClassName('toDoListCheckboxHidden')
        for (var i = 0; i < alleClassesCheckboxHidden.length; i++) {
            alleClassesCheckboxHidden[i].classList.add('toDoListCheckbox');
        }

        let alleClassesOppgaveTekstHidden = document.getElementsByClassName('oppgaveTekstHidden')
        for (var i = 0; i < alleClassesOppgaveTekstHidden.length; i++) {
            alleClassesOppgaveTekstHidden[i].classList.add('oppgaveTekst');
        }

        let alleClassesfjernOppgaveHidden = document.getElementsByClassName('fjernOppgaveHidden')
        for (var i = 0; i < alleClassesfjernOppgaveHidden.length; i++) {
            alleClassesfjernOppgaveHidden[i].classList.add('fjernOppgave');
        }

        document.getElementById('nyttOppgave').classList.add('nyttOppgave');
        document.getElementById('oppgaveInput').classList.add('oppgaveInput');
        document.getElementById('leggTilOppgave').classList.add('leggTilOppgave');
        return;
    }

    // funksjon som skjuler to do list menu  -------------------------------------------
    function toDoListMenuFalse() {
        document.getElementById('toDoList').classList.remove('toDoList');
        document.getElementById('toDoListContainer').classList.remove('toDoListContainer');

        let alleClassesTest1 = document.getElementsByClassName('test1')
        for (var i = 0; i < alleClassesTest1.length; i++) {
            alleClassesTest1[i].classList.remove('oppgave');
        }   

        let alleClassesCheckboxHidden = document.getElementsByClassName('toDoListCheckboxHidden')
        for (var i = 0; i < alleClassesCheckboxHidden.length; i++) {
            alleClassesCheckboxHidden[i].classList.remove('toDoListCheckbox');
        }

        let alleClassesOppgaveTekstHidden = document.getElementsByClassName('oppgaveTekstHidden')
        for (var i = 0; i < alleClassesOppgaveTekstHidden.length; i++) {
            alleClassesOppgaveTekstHidden[i].classList.remove('oppgaveTekst');
        }

        let alleClassesfjernOppgaveHidden = document.getElementsByClassName('fjernOppgaveHidden')
        for (var i = 0; i < alleClassesfjernOppgaveHidden.length; i++) {
            alleClassesfjernOppgaveHidden[i].classList.remove('fjernOppgave');
        }
        
        document.getElementById('nyttOppgave').classList.remove('nyttOppgave');
        document.getElementById('oppgaveInput').classList.remove('oppgaveInput');
        document.getElementById('leggTilOppgave').classList.remove('leggTilOppgave');
        return;
    }
