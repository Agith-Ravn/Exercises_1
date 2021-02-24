function agithRavnSjekkDato(dato) {
  if (
    sjekkDatoLength(dato) &&
    sjekkPunktumer(dato) &&
    sjekkÅrLength(dato) &&
    sjekkMndLength(dato) &&
    sjekkMnd1Til12(dato) &&
    sjekkDag1Til31(dato) &&
    sjekkDag1Til30(dato) &&
    sjekkFebruarOgSkuddår(dato)
  )
    return true;
  else return false;
}

//Hvis lengden ikke er 10
function sjekkDatoLength(dato) {
  if (dato.length == 10) return true;
  else return false;
}

//Skal ha punktumer i riktig posisjon
function sjekkPunktumer(dato) {
  let punktum1 = dato.substr(2, 1);
  let punktum2 = dato.substr(5, 1);

  if (punktum1 == "." && punktum2 == ".") return true;
  else return false;
}

//Året skal ha 4 siffer.
function sjekkÅrLength(dato) {
  /*let datoLengde = dato.substr(0,2)
    let punktum1 = dato.substr(2,1)
    let mndLengde = dato.ssubstr(3,2)
    let punktum2 = dato.substr(5,1)*/
  let årLength = dato.substr(6);

  if (årLength.length === 4 && årLength >= "0000" && årLength <= "9999")
    return true;
  else return false;
}

//Mnd skal ha 2 siffer
function sjekkMndLength(dato) {
  let punktum1 = dato.substr(2, 1);
  let mndLength = dato.substr(3, 2);
  let punktum2 = dato.substr(5, 1);

  if (punktum1 == "." && punktum2 == "." && mndLength.length === 2) return true;
  else return false;
}

//Mnd skal ha være mellom 01-12
function sjekkMnd1Til12(dato) {
  let mnd = dato.substr(3, 2);

  if (mnd >= "01" && mnd <= "12") return true;
  else return false;
}

//Dag skal være mellom 01-31 | januar 01 | mars 03 | mai 05 | juli 07 | august 08 | oktober 10 | desember 12
function sjekkDag1Til31(dato) {
  let dag = dato.substr(0, 2);

  if (dag >= "01" && dag <= "31") return true;
  else return false;
}

//Noen mnd har 30 dager = april 04 | juni 06 | september 09 | november 11
function sjekkDag1Til30(dato) {
  let dag = dato.substr(0, 2);
  let mnd = dato.substr(3, 2);

  if (
    (mnd == "01" && dag >= "00" && dag <= "31") ||
    (mnd == "02" && dag >= "00" && dag <= "31") ||
    (mnd == "03" && dag >= "00" && dag <= "31") ||
    (mnd == "04" && dag >= "00" && dag <= "30") ||
    (mnd == "05" && dag >= "00" && dag <= "31") ||
    (mnd == "06" && dag >= "00" && dag <= "30") ||
    (mnd == "07" && dag >= "00" && dag <= "31") ||
    (mnd == "08" && dag >= "00" && dag <= "31") ||
    (mnd == "09" && dag >= "00" && dag <= "30") ||
    (mnd == "10" && dag >= "00" && dag <= "31") ||
    (mnd == "11" && dag >= "00" && dag <= "30") ||
    (mnd == "12" && dag >= "00" && dag <= "31")
  )
    return true;
  else return false;
}

//Februar har 28 dager (utenom skuddår)
function sjekkFebruarOgSkuddår(dato) {
  let dag = dato.substr(0, 2);
  let mnd = dato.substr(3, 2);
  let year = dato.substr(6, 4);

  if (
    (mnd == "01" && dag >= "00" && dag <= "31") ||
    (mnd == "03" && dag >= "00" && dag <= "31") ||
    (mnd == "05" && dag >= "00" && dag <= "31") ||
    (mnd == "07" && dag >= "00" && dag <= "31") ||
    (mnd == "08" && dag >= "00" && dag <= "31") ||
    (mnd == "10" && dag >= "00" && dag <= "31") ||
    (mnd == "12" && dag >= "00" && dag <= "31") ||
    (mnd == "04" && dag >= "00" && dag <= "30") ||
    (mnd == "06" && dag >= "00" && dag <= "30") ||
    (mnd == "09" && dag >= "00" && dag <= "30") ||
    (mnd == "11" && dag >= "00" && dag <= "30") ||
    (mnd == "02" &&
      dag >= "00" &&
      dag <= "29" &&
      year % "4" == 0 &&
      year % 100 != 0) ||
    year % 400 == 0 ||
    (mnd == "02" && dag >= "00" && dag <= "28")
  )
    return true;
  else return false;
}
