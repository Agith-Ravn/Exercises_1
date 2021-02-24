function fixText(text) {
let removeSpace = text.trim()
let ferdigFormatertTekst = removeSpace.toUpperCase().charAt(0) + removeSpace.toLowerCase().slice(1)
//Stor bokstav på første bokstav + gjør om resten til små

return ferdigFormatertTekst
}