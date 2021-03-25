// view --------------------------------------------------------------------------------------------------------------------------------------------------------------------

/*Funksjon tegner opp en tabell 
Tabell inneholder:
  - En checkbox (Personer):
    - checkbox bestemmer om alle checkbox under skal være krysset av eller ikke 
    - Gjør det via funksjon velgAlleEllerIngen
    - sender info om checkbox er krysset av eller ikke (true eller false) igjennom onclick event
*/
function visPersoner() {
    let html = `<table>
                  <tr>
                    <td><input type="checkbox"
                              onclick="velgAlleEllerIngen(this.checked)"
                              ${lagHtmlChecked(model.personer.velgAlle)}/></td>
                    <td><b>Personer</b></td>
                  </tr>`;

    //For of loop går igjennom model.personer.liste og legger verdi inn i person 
    for (let person of model.personer.liste) {
      //console.log(person)

    /*- hver gang du trykker på trykker på velgPerson() sender du person.id
      - ${lagHtmlChecked(person.erValgt)} bestemmer om det skal stå checked=checked 
        når du har krysset av eller ingenting når du ikke har krysset av
      - button + onclick som sletter navnet. sender person.id, slik at man sletter riktig navn */
      html += `<tr>
                  <td><input type="checkbox"
                             onclick="velgPerson(${person.id})" ${lagHtmlChecked(person.erValgt)}"/></td>
                  <td>${person.navn}</td>
                  <td><button class="litenKnapp"  onclick="slettPerson(${person.id})">x</button></td>
                </tr>`;
    }

    /*- input tekst felt for å skrive nye navn
      - input knapp + onlick event for å legge til navnet i lista
      - button med onclick som starter funksjon trekk()
      - input nummer felt der verdi inni er hentet fra model.personer.trekkAntall
      - 2 button med bestemmer som legger til og fjerner 1 verdi 
      */
    html += `<tr>
                <td></td>
                <td colspan="3">
                  <input size="6" type="text" id="nyPerson"/>
                  <button class="litenKnapp" onclick="leggTilPerson()">legg til person</button>
                </td>
             </tr>
             <tr><td>&nbsp;</td></tr>
             <tr>
                <td colspan="3">
                  <button class="knapp" onclick="trekk()">Trekk!</button>
                  <input type="number" size="1" value="${model.personer.trekkAntall}" onchange="model.personer.trekkAntall = parseInt(this.value)"/>
                  <button class="" onclick="justerAntall(1)">▲</button>
                  <button class="" onclick="justerAntall(-1)">▼</button>
                </td>
              </tr>
            </table>`;
    document.getElementById('innhold').innerHTML = html;
  }
  
  //Funksjon hvis box er krysset av send 'checked="checked"', ellers sender ''
  function lagHtmlChecked(valgt) {
    return valgt ? 'checked="checked"' : '';
  }
  
  // controller --------------------------------------------------------------------------------------------------------------------------------------------------------------------
  //Funksjon som krysser av alle personer, når du krysser av personer boks
  function velgAlleEllerIngen(alle) {

    //hvis checkbox personer er krysset > sender true verdi til funksjon (alle)
    //henter velgAlle object property og får true hvis checkbox er krysset
    model.personer.velgAlle = alle;

    //henter objekt som er inni liste: [] og putter det i personn
    for (let person of model.personer.liste) {

      //endrer alle erValgt verdi til true, hvis verdien fra alle er true
      person.erValgt = alle;
    }
    visPersoner();
  }
  

  //funksjon som legger til nye personer når du trykker på leggt til person
  function leggTilPerson() {

    //henter verdier som blir skrevet inni input felt (legg til person)
    //og putter det inni i navn
    const navn = document.getElementById('nyPerson').value;

    //.map() henter alle objektene inni liste array og lager ny array med alle id verdi inni
    const id = model.personer.liste.map(p => p.id)

    //.reduce reduserer alle array element til en array element
    //Math.max() henter det største tallet
    //????????? så når du legger til en person, så får den det størst verdien da eller?
    id.reduce((max, value) => Math.max(max, value), -1) + 1;

    //pusher navnet, id og at personen skal være krysset av til liste array
    model.personer.liste.push(
      { id: id, navn: navn, erValgt: true });
    visPersoner();
  }  

  //Når du velger en person ved å krysse av, sender du id av personen du krysset
  function velgPerson(id) {

    //en egen funksjon som finner person med id og putter inn i person
    const person = finnPerson(id);
    console.log(person)

    //hvis ikke person er valgt (false) = personen sin ervalgt verdi får false 
    //Dette bestemmer bare om boksen skal være krysset av eller ikke
    person.erValgt = !person.erValgt;
    visPersoner(); //updaterer view
  }
  
  //funksjon som sletter person + sender id igjennom event 
  function slettPerson(id) {  // eksempel id:100

    //henter alle verdiene i liste array
    //filter() filtrerer bort alle id som ikke er lik id du sletter
    model.personer.liste = model.personer.liste.filter(p => p.id !== id);
    visPersoner();
  }
  

  //
  function trekk() {
    //Henter info om hvor mange av valgte personer kan trekkes
    let antall = model.personer.trekkAntall;

    //filterer bort alt som ikke er valgt og legger de som har true inn i personerListe
    const personerListe = model.personer.liste.filter(p => p.erValgt);

    //.Keys() lager index av antall stk som er krysset av (true erValgt verdi)
    //Array.from lager en array a string (tallene i dette tilfelle)
    //lager ny array som heter indekser
    const indekser = Array.from(personerListe.keys());

    //ny tom array med navn vinnere
    const vinnere = [];

    //mens antall trekk tall er større OG indekser length er større enn 0 gjør dette:
    while (antall-- > 0 && indekser.length > 0) {

      //Henter tilfeldig tall av mulig tall å velge (indekser.length)
      const tilfeldigIndeks = Math.floor(Math.random() * indekser.length);

      //henter tallet og legger i egen boks
      const indeks = indekser.splice(tilfeldigIndeks, 1);

      //bruker indeks til å finne person navn som vant + pusher opp til vinnere array
      vinnere.push(personerListe[indeks].navn);
    }

    //lager ny array element (en objekt) av vinnere + tidspunkt + liste av hvem som var med på lotteriet
    model.trekninger.unshift({
      vinnere: vinnere,
      tid: lagDatoTekstNåForLagring(),
      deltakere: personerListe.map(p => p.navn)
    });
    visTrekninger();
  }
  
  //justerer antall person (1+ eller 1-)
  function justerAntall(delta) {
    model.personer.trekkAntall =

    //Math.max henter det største tallet av
    //eksempel: 1 + trekkAntall verdi + -1/1
    Math.max(1, model.personer.trekkAntall + delta);
    visPersoner();
  }
  
  //finner person med id (blir brukt som en hjelpe funksjon til en annen funksjon)
  function finnPerson(id) {
    //Filter() sjekker om id er ===/lik person id
    return model.personer.liste.filter(p => p.id === id)[0];
  }