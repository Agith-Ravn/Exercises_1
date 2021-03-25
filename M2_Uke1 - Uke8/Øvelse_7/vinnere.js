// Vinnere view

//Model med dager i array
const dagsNavn = [
    'søndag', 'mandag', 'tirsdag',
    'onsdag', 'torsdag', 'fredag',
    'lørdag'
  ];
  
  //viser trekninger når du trykker på vinnere
  function visTrekninger() {
    let html = '';
    let cssClass = 'førsteTrekning'; //til css class

    //for of loop i model.trekninger og legger alle verdier i trekning (henter verdier altså)
    for (let trekning of model.trekninger) {

      //legger henter tidspunk trekning var gjort
      const tid = new Date(trekning.tid);

      //formaterer tid og putter i datoTekst
      const datoTekst = lagDatoTekstForVisning(tid);

      //heter dag og putter inn i ukedag
      const ukedag = dagsNavn[tid.getDay()];

      //henter verdier fra trekninger array i modell
      const vinnere = trekning.vinnere;
      const deltakere = trekning.deltakere;
      const vinnerOrd = vinnere.length === 1 ? 'Vinneren' : 'Vinnerne';
  
      //Lager html
      html +=
        `<p>
            <small>${ukedag} ${datoTekst}</small><br/>
            <b class="${cssClass}">${vinnerOrd} er ${lagTekstListe(vinnere)}!</b><br/>
            <small>Trukket fra totalt ${deltakere.length} personer: ${lagTekstListe(deltakere)}</small>
        </p>`;
      cssClass = '';
    }
    document.getElementById('innhold').innerHTML = html;
  }
  
  //
  function lagTekstListe(liste) {
    if (liste.length === 0) return '';
    if (liste.length === 1) return liste[0];
  
    const tekstListe = liste.join(', ');
    const indexSisteKomma = tekstListe.lastIndexOf(',');
    return tekstListe.substr(0, indexSisteKomma)
      + ' og ' + tekstListe.substr(indexSisteKomma + 1);
  }