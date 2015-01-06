module GeisExpedice

open System
open FSharp.Data
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders

type ExpediceXml = XmlProvider<"""<?xml version="1.0" encoding="utf-8"?>
<ArrayOfPackage>
<Package>
<isCargo>1</isCargo>
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
<isCargo>0</isCargo>
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
<rows>
<row>
<note></note>
<count>1</count>
<weight>10</weight>  
</row>
</rows>
</Package>
<Package>
<isCargo>0</isCargo>
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
<rows>
<row>
<note></note>
<count>1</count>
<weight>10</weight>  
</row>
</rows>
</Package>
<Package>
<isCargo>0</isCargo>
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
                            expedition.ExportId = Nullable<Guid>()
                        ) 
                        select expedition
                    }                        

let internal Fakturace_FakturaVydana =  query {
                        for fakturace_FakturaVydana in contextMoney.Fakturace_FakturaVydana do
                        select fakturace_FakturaVydana
                    }              
(* 
let internal customerReference(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions  ) =
    ( expedition.customerReference )
let internal documentNumber(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( expedition.customerReference )
let internal recContactName(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( Some(expedition.recName) )
let internal recName(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions )  =
    ( Some( expedition.recName ) )
let internal recStreet(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( Some( expedition.recStreet ) )
let internal recStreetNumOri(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( Some( expedition.recStreetNumOri ) )
let internal recStreetNumDesc(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( Some( expedition.recStreetNumDesc ) )
let internal recCity(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( Some( expedition.recCity ) )
let internal recZipCode(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( Some( expedition.recZipCode ) )
let internal recCountry(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( Some( expedition.recCountry ) )
let internal recNote(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( Some( expedition.recNote ) )
let internal driverNote(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( Some("") )
let internal addrCode(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ("60046672")
let internal recContactPhone(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( Some( expedition.recContactPhone ) )
let internal recContactEmail(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( Some( expedition.recContactEmail) )

//let internal rows(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
//    ( 
//     ExpediceXml.Row(ExpediceXml.Note(), Some(""), Int32.Parse( expedition.row_count ), Int32.Parse( expedition.row_weight ), Some(0) ) 
//    )
*)

let SomeS( par : string ) : Option<String> =
    (if par = null then None else Some(par) )     

(* 
let isCargo(expedition) =
    ( false )
let number(expedition) =
    ( 123 )
let customerReference(expedition ) =
    ( "custRef" )
let documentNumber(expedition) =
    ( "docNum" )
let recContactName(expedition) =
    ( Some("recContactName" ) )
let recName(expedition)  =
    ( Some("recContactName" ) )

let recStreet(expedition) =
    ( Some("recContactName" ) )
let recStreetNumOri(expedition) =
    ( Some("recContactName" ) )
let recStreetNumDesc(expedition) =
    ( Some( "desc" ) )
let recCity(expedition) =
    ( Some("recContactName" ) )
let recZipCode(expedition) =
    ( Some("recContactName" ) )
let recCountry(expedition) =
    ( Some("recContactName" ) )
let recNote(expedition) =
    ( Some("recContactName" ) )

*)
let internal isCargo(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( expedition.isCargo.Value )
let internal number(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( expedition.number )
let internal customerReference(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions  ) =
    ( expedition.customerReference )
let internal documentNumber(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( expedition.customerReference )
let internal recContactName(expedition : EntityConnection.ServiceTypes.adapters_geis_Expeditions ) =
    ( SomeS(expedition.recName) )
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
    ( Some("recContactName" ) )
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

let output =
    ExpediceXml.ArrayOfPackage [| for expedition in activeExpeditions do
                                    yield 
                                        ExpediceXml.Package( isCargo(expedition), 0, number(expedition), customerReference(expedition ), documentNumber(expedition),
                                                                0, recContactName(expedition), recName(expedition), recStreet(expedition), recStreetNumOri(expedition), 
                                                                recStreetNumDesc(expedition), recCity(expedition), recZipCode(expedition), recCountry(expedition), recNote(expedition), driverNote(expedition), addrCode(expedition),
                                                                recContactPhone(expedition), recContactEmail(expedition)
                                                                , rows(expedition)
                                                                  ) 
                                                                  |]
