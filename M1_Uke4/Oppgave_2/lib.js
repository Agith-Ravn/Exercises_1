function sjekkeMail(kanVæreEmail) {
 let alfaKrøll = kanVæreEmail.indexOf("@");
 let førstePunktum = kanVæreEmail.indexOf(".");
 let andrePunktum = kanVæreEmail.substring(alfaKrøll).indexOf(".");
 //andre punktum er etter verdi @ 
 if (kanVæreEmail.includes("@") && !kanVæreEmail.includes(" ")) {
    if (førstePunktum < andrePunktum) {
      return true;
  
    }
    else return false;

  }
  else return false;    
}