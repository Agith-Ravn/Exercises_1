//CONTROLLER

function checkDate(dato) {
  if (checkDateLength(dato) && 
    checkDots(dato) && 
    checkMnd(dato) && 
    checkDays(dato)
    ) 
    return true;
  else return false; 
}

//Posisjon av punktumer
function checkDots(dato) {
  let punktum1 = dato.indexOf(".")
  let punktum2 = dato.lastIndexOf(".")
  
  if (punktum1 == 2 && punktum2 == 5) return true;
  else return false
}

//Lengde av tegn på hele datoen, år og mnd
function checkDateLength(dato) {
  let year = dato.substr(6); // alt etter x plassering
  let mnd = dato.substr(3,2);

  if ((year.length == 4) && (mnd.length == 2) && (dato.length == 10)) return true;
  else return false
}

//Mnd skal være innenfor verdi 01-12
function checkMnd(dato) {
  let mnd = dato.substr(3,2);
  if (mnd >= 01 && mnd <= 12) return true;
  else return false
}

//Dager kan være i 1 funksjon
  //Dager skal være 01-31 i disse mnd | Januar 01 | Mars 03 | Mai 05 | Juli 07 | August 08 | Okbtober 10 | Desember 12
  //Dager skal være 01-30 i disse mnd | April 04 | Juni 06 | September 09 | November 11
  //Dager skal være 01-28 i Februar (IKKE skuddår)
  //Dager skal være 01-29 i Februar (skuddår)
function checkDays(dato) {
  let year = dato.substr(6); // alt etter x plassering
  let mnd = dato.substr(3,2);
  let day = dato.substr(0,3);

  if (
    (day >= 01) && (day <= 31) && (mnd == 01) ||
    (day >= 01) && (day <= 28) && (mnd == 02) ||
    (day >= 01) && (day <= 29) && (mnd == 02) && (year % 4 == 0) && (year % 100 != 0) ||
    (day >= 01) && (day <= 31) && (mnd == 03) ||
    (day >= 01) && (day <= 30) && (mnd == 04) ||
    (day >= 01) && (day <= 31) && (mnd == 05) ||
    (day >= 01) && (day <= 30) && (mnd == 06) ||
    (day >= 01) && (day <= 31) && (mnd == 07) ||
    (day >= 01) && (day <= 31) && (mnd == 08) ||
    (day >= 01) && (day <= 30) && (mnd == 09) ||
    (day >= 01) && (day <= 31) && (mnd == 10) ||
    (day >= 01) && (day <= 30) && (mnd == 11) ||
    (day >= 01) && (day <= 31) && (mnd == 12)  
  ) return true;
  else return false
}


/* 
Skisse
""""""

  Huskeliste: 
  - Endre på navn på funksjoner som passer bedre


1 2 . 1 2 . 2 0 0 0 
0 1 2 3 4 5 6 7 8 9 10

*/