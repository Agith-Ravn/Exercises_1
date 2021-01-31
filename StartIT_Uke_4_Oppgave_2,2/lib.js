function sjekkEpost(epost) {
    let alfaKrøll = epost.indexOf('@');
    let førstePunktum = epost.indexOf('.');
    let andrePunktum = epost.substring(alfaKrøll).indexOf('.');

    if (epost.includes('@') && !epost.includes(' ')){
        if (førstePunktum < andrePunktum){
            return true
        }
        else return false
    }
    else return false
}