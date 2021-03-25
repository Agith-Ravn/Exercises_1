//Formaterer dato
function lagDatoTekstForVisning(dato) {

  //toLocaleString() gjør dato objekt til string (14.3.2021, 16:19:20 formatering)
    return dato.toLocaleString().replace(',', '').substr(0, 15);
  }
  
  //toISOString gjør dato objekt til string (2021-03-14T15:18:33.060Z formatering)
  function lagDatoTekstForLagring(dato) {
    return dato.toISOString().substr(0, 16).replace('T', ' ');
  }
  
  //funksjon som starter en annen funksjon som lage ny dato
  function lagDatoTekstNåForLagring() {
    return lagDatoTekstForLagring(new Date());
  }