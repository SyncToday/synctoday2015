module GeisExpedice

open System
open FSharp.Data
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders

type ExpediceXml = XmlProvider<"""<?xml version="1.0" encoding="utf-8"?>
<ArrayOfPackage>
<Package>
<isCargo>A1</isCargo>
<back>0</back>
<number>1</number>
<customerReference>Dodávka 1</customerReference>
<documentNumber>Dokument Cargo</documentNumber>  
<usePrintSend>0</usePrintSend>
<recContactName></recContactName>
<recName>Geis</recName>
<recStreet>Zemská</recStreet>
<recStreetNumOri>I</recStreetNumOri>
<recStreetNumDesc>A211</recStreetNumDesc>
<recCity>Ejpovice</recCity>
<recZipCode>A33701</recZipCode>
<recCountry>CZ</recCountry>
<recNote>Note</recNote>
<driverNote>DriverNote</driverNote>
<addrCode>fff60046672</addrCode>
<recContactPhone></recContactPhone>
<recContactEmail>ddd</recContactEmail>
<services>
<COD>
<codValue>Cena dobírky</codValue>
<codValueCur>Kód měny dobírky (ISO 4217)</codValueCur>
<varCode>Variabilní symbol</varCode>
</COD>
<EMA>aaa@bbb.cz</EMA>
</services>
<rows>
<row>
<note></note>
<LPacTyp>FP</LPacTyp>
<count>1</count>
<weight>10</weight>
<volume>1</volume>
<!-- numbers>
<number>
<packRowNumber>Číslo kusu 1</packRowNumber>
</number>
<number>
<packRowNumber>Číslo kusu 2</packRowNumber>
</number>
<number>
<packRowNumber>Číslo kusu 3</packRowNumber>
</number>
</numbers -->
</row>
</rows>
</Package>
<Package>
<isCargo>B0</isCargo>
<back>0</back>
<number>2</number>
<customerReference>Dodávka 2</customerReference>
<documentNumber>Dokument Balík</documentNumber>  
<usePrintSend>0</usePrintSend>
<recContactName></recContactName>
<recName>Geis</recName>
<recStreet>Zemská</recStreet>
<recStreetNumOri>I</recStreetNumOri>
<recStreetNumDesc>A211</recStreetNumDesc>
<recCity>Ejpovice</recCity>
<recZipCode>A33701</recZipCode>
<recCountry>CZ</recCountry>
<recNote></recNote>
<driverNote></driverNote>
<addrCode>fff60046672</addrCode>
<recContactPhone></recContactPhone>
<recContactEmail></recContactEmail>
<services>
<EMA>aaa@bbb.cz</EMA>
</services>
<rows>
<row>
<note></note>
<count>1</count>
<weight>10</weight>  
</row>
</rows>
</Package>
<Package>
<isCargo>C0</isCargo>
<back>0</back>
<number>3</number>
<customerReference>Dodávka 3</customerReference>
<documentNumber>Dokument VM</documentNumber>
<usePrintSend>0</usePrintSend>
<recContactName>Pavel Novák</recContactName>
<recName>Geis</recName>
<recStreet>Zemská</recStreet>
<recStreetNumOri>I</recStreetNumOri>
<recStreetNumDesc>A211</recStreetNumDesc>
<recCity>Ejpovice</recCity>
<recZipCode>A33701</recZipCode>
<recCountry>CZ</recCountry>
<recNote></recNote>
<driverNote></driverNote>
<addrCode>fff60046672</addrCode>
<recContactPhone>AAA420777666555</recContactPhone>
<recContactEmail></recContactEmail>
<services>
<EMA>aaa@bbb.cz</EMA>
</services>
<rows>
<row>
<note></note>
<count>1</count>
<weight>10</weight>  
</row>
</rows>
</Package>
<Package>
<isCargo>D0</isCargo>
<back>0</back>
<number>4</number>
<customerReference>Dodávka 4</customerReference>
<documentNumber>Dokument VM 2</documentNumber>
<usePrintSend>0</usePrintSend>
<recContactName>Pavel Novák</recContactName>
<recName></recName>
<recStreet></recStreet>
<recStreetNumOri></recStreetNumOri>
<recStreetNumDesc></recStreetNumDesc>
<recCity></recCity>
<recZipCode></recZipCode>
<recCountry></recCountry>
<recNote></recNote>
<driverNote></driverNote>
<addrCode>ddd60046672</addrCode>
<recContactPhone>BBB420777666555</recContactPhone>
<recContactEmail></recContactEmail>
<services>
<EMA>aaa@bbb.cz</EMA>
</services>
<rows>
<row>
<note></note>
<count>1</count>
<weight>10</weight>  
</row>
</rows>
</Package>
</ArrayOfPackage>
""">

module Seq =
    let tryHead xs = xs |> Seq.tryPick Some

[<Literal>]
let connectionString = "Data Source=(localdb)\ProjectsV12; Initial Catalog=SyncToday2015; Integrated Security=True;"

[<Literal>]
let connectionStringMoney = "Data Source=(localdb)\ProjectsV12; Initial Catalog=S4_Agenda_TEST_dev; Integrated Security=True;"

type internal EntityConnection = SqlEntityConnection<ConnectionStringName="sync-today-mssql",
                                                        Pluralize = true>
let private context = EntityConnection.GetDataContext()
let private fullContext = context.DataContext


type internal EntityConnectionMoney = SqlEntityConnection<ConnectionStringName="moneys4",
                                                               Pluralize = true>
let private contextMoney = EntityConnectionMoney.GetDataContext()
let private fullContextMoney = contextMoney.DataContext

let private activeExpeditions = query {
                        for expedition in context.adapters_geis_Expeditions do
                        where (
                            not(expedition.ExportId.HasValue)
                        ) 
                        select expedition
                    }                        

let internal zpusobPlatbyDobirkaId = Guid.Parse("5B035689-496C-4F5F-A48A-4418A7D041AE")
let internal zpusobDopravyPaletaId = Guid.Parse("A46EF167-6913-4B2F-B68F-D974E80981D2")

let internal getExpeditionByFakturaId( id ) =
    query {
        for expedition in context.adapters_geis_Expeditions do
        where ( expedition.Fakturace_FakturaVydana_ID = id )        
    } |> Seq.tryHead


let internal activeFakturace_FakturaVydana =  query {
                        for fakturace_FakturaVydana in contextMoney.Fakturace_FakturaVydana do
//                        join firma in contextMoney.Adresar_Firma on 
                            //( fakturace_FakturaVydana.Firma_ID = Nullable<Guid>(firma.ID) )
                        where (
                            not(fakturace_FakturaVydana.Deleted)
                        ) 
                        select fakturace_FakturaVydana
                    }              

let SomeS( par : string ) : Option<String> =
    (if par = null then None else Some(par) )     

let internal isCargo(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( ( if ( expedition.isCargo.Value ) then 1 else 0 ).ToString() )
let internal number(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( expedition.number )
let internal customerReference(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions  ) =
    ( expedition.customerReference )
let internal documentNumber(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( expedition.customerReference )
let internal recContactName(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( SomeS(expedition.recContactName) )
let internal recName(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions )  =
    ( SomeS( expedition.recName ) )
let internal recStreet(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( SomeS( expedition.recStreet ) )
let internal recStreetNumOri(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( SomeS( expedition.recStreetNumOri ) )
let internal recStreetNumDesc(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( SomeS( expedition.recStreetNumDesc ) )
let internal recCity(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( SomeS( expedition.recCity ) )
let internal recZipCode(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( SomeS( expedition.recZipCode ) )
let internal recCountry(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( SomeS( (*expedition.recCountry*) "CZ" ) )
let internal recNote(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( SomeS( expedition.recNote ) )
let driverNote(expedition) =
    ( Some("" ) )
let addrCode(expedition) =
    ("60046672")
let internal recContactPhone(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( SomeS( expedition.recContactPhone ) )
let internal recContactEmail(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( SomeS( expedition.recContactEmail) )
(* Na řádku 36 znakem 9 začíná element "numbers", který nebyl zpracován. 
let internal numbers(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
      Some( ExpediceXml.Numbers(Array.init (Int32.Parse( expedition.row_count )) (fun index -> ExpediceXml.Number(expedition.number.ToString() + "." + (index + 1).ToString()))) )
*)
let internal rows(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( 
     ExpediceXml.Row(ExpediceXml.Note(), Some(""), Int32.Parse( expedition.row_count ), Int32.Parse( expedition.row_weight ), Some(1)
     //, numbers(expedition) 
     ) 
    )

let internal cod(expedition: EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    (
        if ( expedition.ZpusobPlatby_ID.HasValue && expedition.ZpusobPlatby_ID = Nullable<Guid>(zpusobPlatbyDobirkaId) ) then
            Some( ExpediceXml.Cod(expedition.SumaCelkem.ToString(), "CZK", expedition.VariabilniSymbol ) )
        else
            None
    )


let internal services(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    (
        ExpediceXml.Services(cod(expedition), "")
    )

let output =
    ExpediceXml.ArrayOfPackage [| for expedition in activeExpeditions do
                                    yield 
                                        ExpediceXml.Package( isCargo(expedition), 0, number(expedition), customerReference(expedition ), documentNumber(expedition),
                                                                0, recContactName(expedition), recName(expedition), recStreet(expedition), recStreetNumOri(expedition), 
                                                                recStreetNumDesc(expedition), recCity(expedition), recZipCode(expedition), recCountry(expedition), recNote(expedition), driverNote(expedition), addrCode(expedition),
                                                                recContactPhone(expedition), recContactEmail(expedition), services(expedition)
                                                                , rows(expedition)
                                                                  ) 
                                                                  |]

let markAsExported(fileName : string) =
    let newExport = new EntityConnection.ServiceTypes.adapters_geis_Export()
    let exportId = Guid.NewGuid()
    newExport.ExportId <- exportId
    newExport.FileName <- fileName
    fullContext.AddObject("adapters_geis_Export", newExport)
    fullContext.SaveChanges() |> ignore
    for expedition in activeExpeditions do
        expedition.ExportId <- Nullable<Guid>(exportId)
    fullContext.SaveChanges() |> ignore

type UserDataXml = XmlProvider<"""<UserData>
  <PocetBaliku_UserData>4</PocetBaliku_UserData>
  <DatumSvozu_UserData>42009</DatumSvozu_UserData>
  <CisloZasilky_UserData />
</UserData>
""">

let adapterId = Guid.Parse("74C5145B-AC16-4572-977D-3686C22C22E5")

let internal isCargoF(faktura : EntityConnectionMoney.ServiceTypes.Fakturace_FakturaVydana ) =
  ( 
      if ( faktura.ZpusobDopravy_ID = Nullable<Guid>(zpusobDopravyPaletaId) ) then 
        Nullable<bool>(true) 
    else
        Nullable<bool>(false) 
  )

let importFaktura() =
    for faktura in activeFakturace_FakturaVydana do
        printfn "%A" faktura.ID
        // http://fsharp.github.io/FSharp.Data/library/XmlProvider.html
        let possibleExpedition = getExpeditionByFakturaId( Nullable<Guid>(faktura.ID) )
        if ( box possibleExpedition = null ) then
            let userData = faktura.UserData
            let parsedUserData = UserDataXml.Parse(userData)
            if parsedUserData.PocetBalikuUserData > 0 then
                let newExpedition = new EntityConnection.ServiceTypes.adapters_geis_Expeditions()
                newExpedition.ExpeditionId <- Guid.NewGuid()
                newExpedition.AdapterId <- Nullable<Guid>(adapterId)
                newExpedition.CisloRady <- faktura.CisloRady
                newExpedition.Fakturace_FakturaVydana_ID <- Nullable<Guid>(faktura.ID)
                newExpedition.VariabilniSymbol <- faktura.VariabilniSymbol
                newExpedition.addrCode <- "60046672"
                newExpedition.customerReference <- "Faktura " + faktura.CisloDokladu
                newExpedition.isCargo <- isCargoF(faktura)
                newExpedition.pickUpDate <- (System.DateTime(1899, 12, 30).AddDays( float parsedUserData.DatumSvozuUserData ).ToString())
                newExpedition.recCity <- faktura.DodaciAdresaMisto
                newExpedition.recContactEmail <- faktura.AdresaKoncovehoPrijemceEmail
                newExpedition.recContactName <- faktura.AdresaKoncovehoPrijemceKontaktniOsobaNazev
                newExpedition.recContactPhone <- faktura.AdresaKoncovehoPrijemceTelefon
                newExpedition.recCountry <-
                    ( match faktura.DodaciAdresaStat with
                        | "Česká republika" -> "CZ"
                        | "Slovensko" -> "SK"
                        | _ -> ""
                    )
                newExpedition.recName <- faktura.DodaciAdresaNazev
                newExpedition.recNote <- ""
                newExpedition.recStreet <- faktura.DodaciAdresaUlice
                newExpedition.recStreetNumDesc <- ""
                newExpedition.recStreetNumOri <- ""
                newExpedition.recZipCode <- faktura.DodaciAdresaPSC
                newExpedition.row_count <- parsedUserData.PocetBalikuUserData.ToString()
                newExpedition.row_weight <- "0"
                newExpedition.ZpusobPlatby_ID <- faktura.ZpusobPlatby_ID
                newExpedition.SumaCelkem <- Nullable<decimal>(faktura.SumaCelkem)
                fullContext.AddObject("adapters_geis_Expeditions", newExpedition)
                fullContext.SaveChanges() |> ignore
                        