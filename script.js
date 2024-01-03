const Processzorok={
    1:{
        "név":"AMD Ryzen 3 4100 Processzor",
        "ár":"24 790 Ft",
        "fogyasztás":" (W): 65",
        "órajel":"(Mhz): 3800",
        "turbó-órajel":"(Mhz): 4000"

    },
    2:{
        "név":"AMD Ryzen 5 4500 processzor",
        "ár":"31 990 Ft",
        "fogyasztás":"(W): 65",
        "órajel":"(Mhz): 3600",
        "turbó-órajel":"(Mhz): 4100"
    },
    3:{
        "név":"AMD Ryzen 7 5800X processzor",
        "ár":"79 190 Ft",
        "fogyasztás":"(W): 105",
        "órajel":"(Mhz): 3800",
        "turbó-órajel":"(Mhz): 4700"
    },
    4:{
        "név":"AMD Ryzen 9 5900X processzor",
        "ár":"119 390 Ft",
        "fogyasztás":" (W): 105",
        "órajel":"(Mhz): 3700",
        "turbó-órajel":"(Mhz): 4800"
        
    },
    
}
function display_processor_details(id){
document.getElementById(`Processzor${id}`).innerHTML=`
fogyasztás:${Processzorok[id]["fogyasztás"]}<br>
órajel:${Processzorok[id]["órajel"]}<br>
turbó-órajel:${Processzorok[id]["turbó-órajel"]}<br>
<a onclick="document.getElementById('Processzor${id}').innerHTML=''" class="btn btn-primary">Bezárás</a>
`

}
let processzor=[]
function processor_compare(id){
    if (processzor.length===0)
    processzor.push(id)
    else {
        processzor.push(id)
        let div =document.getElementById("compare")
        div.innerHTML=`név:${Processzorok[processzor[0]]["név"]}
        név:${Processzorok[processzor[1]]["név"]}<br>
        ár:${Processzorok[processzor[0]]["ár"]}
        ár:${Processzorok[processzor[1]]["ár"]}<br>
        fogyasztás:${Processzorok[processzor[0]]["fogyasztás"]}
        fogyasztás:${Processzorok[processzor[1]]["fogyasztás"]}<br>
        órajel:${Processzorok[processzor[0]]["órajel"]}
        órajel:${Processzorok[processzor[1]]["órajel"]}<br>
        turbó-órajel:${Processzorok[processzor[0]]["turbó-órajel"]}
        turbó-órajel:${Processzorok[processzor[1]]["turbó-órajel"]}<br>`
        processzor=[]
    


    }
}

const Videokartyak={

    1:{
        "név":"RTX 3080",
        "ár":"312 290 Ft",
        "fogyasztás":" (W): 320",
        "Memória méret":" (GB): 10",
        "Chip Gyártó":"Nvidia"
    },
    2:{
        "név":"RTX 3060",
        "ár":"139 189 Ft",
        "fogyasztás":" (W): 170",
        "Memória méret":" (GB): 12",
        "Chip Gyártó":"Nvidia"
    },
    3:{
        "név":"RTX 4060",
        "ár":"144 490 Ft",
        "fogyasztás":" (W): 115",
        "Memória méret":" (GB): 8",
        "Chip Gyártó":"Nvidia"
    }
}

function Videokartya_details(id){
document.getElementById(`Videokartya${id}`).innerHTML=`
fogyasztás:${Videokartyak[id]["fogyasztás"]}<br>
Memória méret:${Videokartyak[id]["Memória méret"]}<br>
Chip Gyártó:${Videokartyak[id]["Chip Gyártó"]}<br>
<a onclick="document.getElementById('Videokartya${id}').innerHTML=''"  class="btn btn-primary">Bezárás</a>
`
}

let Videokartyalista=[]
function Videokartya_compare(id){

    if (Videokartyalista.length===0)
    Videokartyalista.push(id)
    else {
        Videokartyalista.push(id)
        let div =document.getElementById("compare")
        div.innerHTML=`név:${Videokartyak[Videokartyalista[0]]["név"]}
        név:${Videokartyak[Videokartyalista[1]]["név"]}<br>
        ár:${Videokartyak[Videokartyalista[0]]["ár"]}
        ár:${Videokartyak[Videokartyalista[1]]["ár"]}<br>
        fogyasztás:${Videokartyak[Videokartyalista[0]]["fogyasztás"]}
        fogyasztás:${Videokartyak[Videokartyalista[1]]["fogyasztás"]}<br>
        Memória méret:${Videokartyak[Videokartyalista[0]]["Memória méret"]}
        Memória méret:${Videokartyak[Videokartyalista[1]]["Memória méret"]}<br>
        Chip Gyártó:${Videokartyak[Videokartyalista[0]]["Chip Gyártó"]}
        Chip Gyártó:${Videokartyak[Videokartyalista[1]]["Chip Gyártó"]}<br>`
        Videokartyalista=[]
    


    }
}

const memoriak={
    1:{
        "név":"DIMM 2x8GB 3200MHz DDR4 memória",
        "ár":"17 090 Ft",
        "Memória méret":" (GB): 16",
        "Memória órajel" :"(MHz): 3200",
        "Típus" :": DDR4"

    },
    2:{
        "név":"2x16GB 4800MHz DDR5 memória",
        "ár":"46 090 Ft",
        "Memória méret":" (GB): 32",
        "Memória órajel" :"(MHz): 5600",
        "Típus" :": DDR5"
    },

}
function Memoria_details(id){
    document.getElementById(`memoria${id}`).innerHTML=`
    Memória méret:${memoriak[id]["Memória méret"]}<br>
    Memória órajel:${memoriak[id]["Memória órajel"]}<br>
    Típus:${memoriak[id]["Típus"]}<br>
    <a onclick="document.getElementById('memoria${id}').innerHTML=''" class="btn btn-primary">Bezárás</a>
    `
}

let Memorialista=[]
function Memoria_compare(id){

    if (Memorialista.length===0)
    Memorialista.push(id)
    else {
        Memorialista.push(id)
        let div =document.getElementById("compare")
        div.innerHTML=`név:${memoriak[Memorialista[0]]["név"]}
        név:${memoriak[Memorialista[1]]["név"]}<br>
        ár:${memoriak[Memorialista[0]]["ár"]}
        ár:${memoriak[Memorialista[1]]["ár"]}<br>
        Memória méret:${memoriak[Memorialista[0]]["Memória méret"]}
        Memória méret:${memoriak[Memorialista[1]]["Memória méret"]}<br>
        Memória órajel:${memoriak[Memorialista[0]]["Memória órajel"]}
        Memória órajel:${memoriak[Memorialista[1]]["Memória órajel"]}<br>
        Típus:${memoriak[Memorialista[0]]["Típus"]}
        Típus:${memoriak[Memorialista[1]]["Típus"]}<br>`
        Memorialista=[]
    


    }
}

const SSDk={
    1:{
        "név":"DIMM 2x8GB 3200MHz DDR4 memória",
        "ár":"17 090 Ft",
        "Kapacitás":" (GB): 1000",
        "Gyártó" :"  KINGSTON",
        "Csatolófelület" :": PCI Express 4.0"
    }
}
function SSD_details(id){
    document.getElementById(`SSD${id}`).innerHTML=`
    Kapacitás:${SSDk[id]["Kapacitás"]}<br>
    Gyártó:${SSDk[id]["Gyártó"]}<br>
    Csatolófelület:${SSDk[id]["Csatolófelület"]}<br>
    <a onclick="document.getElementById('SSD${id}').innerHTML=''" class="btn btn-primary">Bezárás</a>
    `
}

const tapegysegek={
    1:{
        "név":"Thermaltake SMART RGB",
        "ár":"31 590 Ft",
        "Teljesítmény ":"(W): 700",
        "Hatékonyság" :"  80 PLUS",
        "Moduláris kábelezés" :"nem"
    },
    2:{
        "név":"ASUS ROG-STRIX-850G",
        "ár":"61 090 Ft",
        "Teljesítmény ":"(W): 850",
        "Hatékonyság" :"  80 PLUS Gold",
        "Moduláris kábelezés" : "igen"
       
    },
    3:{
        "név":"Cooler Master Elite NEX W700",
        "ár":"38 990 Ft",
        "Teljesítmény ":"(W): 700",
        "Hatékonyság" :"  80 PLUS",
        "Moduláris kábelezés" :"nem"
    }
}
function tapegyseg_details(id){
    document.getElementById(`tapegyseg${id}`).innerHTML=`
    Teljesítmény:${tapegysegek[id]["Teljesítmény"]}<br>
    Hatékonyság:${tapegysegek[id]["Hatékonyság"]}<br>
    Moduláris kábelezés:${tapegysegek[id]["Moduláris kábelezés"]}<br>
    <a onclick="document.getElementById('tapegyseg${id}').innerHTML=''" class="btn btn-primary">Bezárás</a>
    `
}
let tapegyseglista=[]
function tapegyseg_compare(id){

    if (tapegyseglista.length===0)
    tapegyseglista.push(id)
    else {
        tapegyseglista.push(id)
        let div =document.getElementById("compare")
        div.innerHTML=`név:${tapegysegek[tapegyseglista[0]]["név"]}
        név:${tapegysegek[tapegyseglista[1]]["név"]}<br>
        ár:${tapegysegek[tapegyseglista[0]]["ár"]}
        ár:${tapegysegek[tapegyseglista[1]]["ár"]}<br>
        Teljesítmény:${tapegysegek[tapegyseglista[0]]["Teljesítmény"]}
        Teljesítmény:${tapegysegek[tapegyseglista[1]]["Teljesítmény"]}<br>
        Hatékonyság:${tapegysegek[tapegyseglista[0]]["Hatékonyság"]}
        Hatékonyság:${tapegysegek[tapegyseglista[1]]["Hatékonyság"]}<br>
        Moduláris kábelezés:${tapegysegek[tapegyseglista[0]]["Moduláris kábelezés"]}
        Moduláris kábelezés:${tapegysegek[tapegyseglista[1]]["Moduláris kábelezés"]}<br>`
        tapegyseglista=[]
    


    }
}

