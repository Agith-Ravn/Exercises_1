const model = {
    currentPage: 0, //Notat index

    notatMenu: false,

    toDoListMenu: false, 

    notatEditMode: false,

    notater: [
        {notatNavn: 'Notat A', innhold: 'Hva er Lorem Ipsum? Lorem Ipsum er rett og slett dummytekst fra og for trykkeindustrien. Lorem Ipsum har vært bransjens standard for dummytekst helt siden 1500-tallet, da en ukjent boktrykker stokket en mengde bokstaver for å lage et prøveeksemplar av en bok. Lorem Ipsum har tålt tidens tann usedvanlig godt, og har i tillegg til å bestå gjennom fem århundrer også tålt spranget over til elektronisk typografi uten vesentlige endringer. Lorem Ipsum ble gjort allment kjent i 1960-årene ved lanseringen av Letraset-ark med avsnitt fra Lorem Ipsum, og senere med sideombrekkingsprogrammet Aldus PageMaker som tok i bruk nettopp Lorem Ipsum for dummytekst.'},
        {notatNavn: 'Notat B', innhold: 'Covid-19 er navnet på sykdommen som forårsakes av viruset sars-CoV-2, som er et koronavirus. Sykdommen rammer først og fremst luftveiene. I desember 2020 startet vaksinering i flere land. I Norge ble de første vaksinedosene satt 27. desember 2020. For å hindre spredning av viruset anbefales det god håndhygiene, munnbind og tilstrekkelig ventilasjon.'},
        {notatNavn: 'Notat C', innhold: 'I begynnelsen var Mars mer lik jorden. Mars hadde trolig en tykkere atmosfære. Det var varmt nok til at flytende vann dannet innsjøer og elver.'},
    ],

    toDoList: [
        {oppgave: 'Oppgave 1', kryssetAv: true},
        {oppgave: 'Oppgave 2', kryssetAv: false},
        {oppgave: 'Oppgave 3', kryssetAv: false},
        {oppgave: 'Oppgave 4', kryssetAv: false},
    ],
    
    toDoListkryssetAv: '',

    nyOppgaveInput: '',
    

};

