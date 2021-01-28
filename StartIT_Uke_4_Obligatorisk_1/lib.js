function agithRavnSjekkDato(dato) {
  if (
    sjekkLengde(dato) &&
    sjekkPunktum(dato) &&
    sjekkÅrLengde(dato) &&
    sjekkMnd1(dato) &&
    sjekkMnd2(dato) &&
    sjekkDag1(dato) &&
    sjekkDag2(dato) &&
    sjekkDag3(dato)
  )
    return true;
  else return false;
}

//Hvis lengden ikke er 10
function sjekkLengde(dato) {
  if (dato.length == 10) return true;
  else return false;
}

//Skal ha punktumer i riktig posisjon
function sjekkPunktum(dato) {
  let punktum1 = dato.substr(2, 1);
  let punktum2 = dato.substr(5, 1);

  if (punktum1 == "." && punktum2 == ".") return true;
  else return false;
}

//Året skal ha 4 siffer.
function sjekkÅrLengde(dato) {
  /*let datoLengde = dato.substr(0,2)
    let punktum1 = dato.substr(2,1)
    let mndLengde = dato.ssubstr(3,2)
    let punktum2 = dato.substr(5,1)*/
  let årLengde = dato.substr(6);

  if (årLengde.length === 4 && årLengde >= "0000" && årLengde <= "9999")
    return true;
  else return false;
}

//Mnd skal ha 2 siffer
function sjekkMnd1(dato) {
  let punktum1 = dato.substr(2, 1);
  let mndLengde = dato.substr(3, 2);
  let punktum2 = dato.substr(5, 1);

  if (punktum1 == "." && punktum2 == "." && mndLengde.length === 2) return true;
  else return false;
}

//Mnd skal ha være mellom 01-12
function sjekkMnd2(dato) {
  let mnd1 = dato.substr(3, 2);

  if (mnd1 >= "00" && mnd1 <= "12") return true;
  else return false;
}

//Dag skal være mellom 01-31 | januar 01 | mars 03 | mai 05 | juli 07 | august 08 | oktober 10 | desember 12
function sjekkDag1(dato) {
  let dag1 = dato.substr(0, 2);

  if (dag1 >= "00" && dag1 <= "31") return true;
  else return false;
}

//Noen mnd har 30 dager = april 04 | juni 06 | september 09 | november 11
function sjekkDag2(dato) {
  let dag2 = dato.substr(0, 2);
  let mnd2 = dato.substr(3, 2);

  if (
    (mnd2 == "01" && dag2 >= "00" && dag2 <= "31") ||
    (mnd2 == "02" && dag2 >= "00" && dag2 <= "31") ||
    (mnd2 == "03" && dag2 >= "00" && dag2 <= "31") ||
    (mnd2 == "04" && dag2 >= "00" && dag2 <= "30") ||
    (mnd2 == "05" && dag2 >= "00" && dag2 <= "31") ||
    (mnd2 == "06" && dag2 >= "00" && dag2 <= "30") ||
    (mnd2 == "07" && dag2 >= "00" && dag2 <= "31") ||
    (mnd2 == "08" && dag2 >= "00" && dag2 <= "31") ||
    (mnd2 == "09" && dag2 >= "00" && dag2 <= "30") ||
    (mnd2 == "10" && dag2 >= "00" && dag2 <= "31") ||
    (mnd2 == "11" && dag2 >= "00" && dag2 <= "30") ||
    (mnd2 == "12" && dag2 >= "00" && dag2 <= "31")
  )
    return true;
  else return false;
}

//Februar har 28 dager (utenom skuddår)
function sjekkDag3(dato) {
  let dag3 = dato.substr(0, 2);
  let mnd3 = dato.substr(3, 2);
  let year = dato.substr(6, 4);

  if (
    (mnd3 == "01" && dag3 >= "00" && dag3 <= "31") ||
    (mnd3 == "03" && dag3 >= "00" && dag3 <= "31") ||
    (mnd3 == "05" && dag3 >= "00" && dag3 <= "31") ||
    (mnd3 == "07" && dag3 >= "00" && dag3 <= "31") ||
    (mnd3 == "08" && dag3 >= "00" && dag3 <= "31") ||
    (mnd3 == "10" && dag3 >= "00" && dag3 <= "31") ||
    (mnd3 == "12" && dag3 >= "00" && dag3 <= "31") ||
    (mnd3 == "04" && dag3 >= "00" && dag3 <= "30") ||
    (mnd3 == "06" && dag3 >= "00" && dag3 <= "30") ||
    (mnd3 == "09" && dag3 >= "00" && dag3 <= "30") ||
    (mnd3 == "11" && dag3 >= "00" && dag3 <= "30") ||
    (mnd3 == "02" &&
      dag3 >= "00" &&
      dag3 <= "29" &&
      year % "4" == 0 &&
      year % 100 != 0) ||
    year % 400 == 0 ||
    (mnd3 == "02" && dag3 >= "00" && dag3 <= "28")
  )
    return true;
  else return false;
}
