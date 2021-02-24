function fixText(text) {
  let tekstEn = text.substr(0,6)
  tekstEn = tekstEn.toUpperCase().charAt(0) + tekstEn.toLowerCase().slice(1)

  let tekstTo = text.substr(5,7)
  tekstTo = tekstTo.toUpperCase().charAt(1) + tekstTo.toLowerCase().slice(2)
  
  let tekstTre = text.substr(7,4
    )
  tekstTre = tekstTre.toUpperCase().charAt(3) + tekstTre.toLowerCase().slice()

  
  let resultat = tekstEn + tekstTo + tekstTre

  return resultat
}