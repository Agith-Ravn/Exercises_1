function sjekkEpost(epost) {
  //finne plass på krøllalfa > hvis krøllalfa har verdi på større enn 0 > true
  let krøllalfaPlassering = epost.indexOf("@");

  //finne mellomrom på epost > hvis mellomrom har verdi mindre enn 0 > true
  let spacePlassering = epost.indexOf(" ");

  /*finne punktumer på epost før og etter @ > 
punktum 1 plassering's verdi er mindre enn @
punktum 2 plassering's verdi er større enn @   */
  let punktumEn = epost.indexOf(".");
  let punktumTo = epost.lastIndexOf(".");

  if (
    krøllalfaPlassering >= "0" &&
    spacePlassering <= "-1" &&
    punktumEn < krøllalfaPlassering &&
    punktumTo > krøllalfaPlassering
  )
    return true;
  else return false;
}

//Skal sjekke om epost adress har @ (indexOf()) | har @ = true
//Skal sjekke om epost adress har mellomrom     | har ingen mellomrom = true
//Skal sjekke om punktum før og etter @         | har punktuer = true
