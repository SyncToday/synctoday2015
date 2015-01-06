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
<crossDockName></crossDockName>
<deliveryToDC></deliveryToDC>
<carNumber></carNumber>
<packagePickUpType></packagePickUpType>
<sendName>Jan Novák</sendName>
<sendStreet>Adresní</sendStreet>
<sendStreetNumOri>456</sendStreetNumOri>
<sendStreetNumDesc>123</sendStreetNumDesc>
<sendCity>Plzeň</sendCity>
<sendZipCode>32600</sendZipCode>
<sendCountry>CZ</sendCountry>
<sendContactName></sendContactName>
<sendContactEmail></sendContactEmail>
<sendContactPhone></sendContactPhone>
<usePrintSend>0</usePrintSend>
<recContactName></recContactName>
<recName>Geis</recName>
<recStreet>Zemská</recStreet>
<recStreetNumOri>I</recStreetNumOri>
<recStreetNumDesc>211</recStreetNumDesc>
<recCity>Ejpovice</recCity>
<recZipCode>33701</recZipCode>
<recCountry>CZ</recCountry>
<recNote></recNote>
<driverNote></driverNote>
<addrCode>60046672</addrCode>
<recContactPhone></recContactPhone>
<recContactEmail></recContactEmail>
<rows>
<row>
<note></note>
<LPacTyp>FP</LPacTyp>
<count>1</count>
<weight>10</weight>
<volume>1</volume>
</row>
</rows>
</Package>
<Package>
<isCargo>0</isCargo>
<back>0</back>
<number>2</number>
<customerReference>Dodávka 2</customerReference>
<documentNumber>Dokument Balík</documentNumber>  
<crossDockName></crossDockName>
<deliveryToDC></deliveryToDC>
<carNumber></carNumber>
<packagePickUpType></packagePickUpType>
<sendName>Jan Novák</sendName>
<sendStreet>Adresní</sendStreet>
<sendStreetNumOri>456</sendStreetNumOri>
<sendStreetNumDesc>123</sendStreetNumDesc>
<sendCity>Plzeň</sendCity>
<sendZipCode>32600</sendZipCode>
<sendCountry>CZ</sendCountry>
<sendContactName></sendContactName>
<sendContactEmail></sendContactEmail>
<sendContactPhone></sendContactPhone>
<usePrintSend>0</usePrintSend>
<recContactName></recContactName>
<recName>Geis</recName>
<recStreet>Zemská</recStreet>
<recStreetNumOri>I</recStreetNumOri>
<recStreetNumDesc>211</recStreetNumDesc>
<recCity>Ejpovice</recCity>
<recZipCode>33701</recZipCode>
<recCountry>CZ</recCountry>
<recNote></recNote>
<driverNote></driverNote>
<addrCode>60046672</addrCode>
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
<dpCode>8901</dpCode> 
<notFillRecDP>0</notFillRecDP>
<crossDockName></crossDockName>
<deliveryToDC></deliveryToDC>
<carNumber></carNumber>
<packagePickUpType></packagePickUpType>
<sendName>Jan Novák</sendName>
<sendStreet>Adresní</sendStreet>
<sendStreetNumOri>456</sendStreetNumOri>
<sendStreetNumDesc>123</sendStreetNumDesc>
<sendCity>Plzeň</sendCity>
<sendZipCode>32600</sendZipCode>
<sendCountry>CZ</sendCountry>
<sendContactName></sendContactName>
<sendContactEmail></sendContactEmail>
<sendContactPhone></sendContactPhone>
<usePrintSend>0</usePrintSend>
<recContactName>Pavel Novák</recContactName>
<recName>Geis</recName>
<recStreet>Zemská</recStreet>
<recStreetNumOri>I</recStreetNumOri>
<recStreetNumDesc>211</recStreetNumDesc>
<recCity>Ejpovice</recCity>
<recZipCode>33701</recZipCode>
<recCountry>CZ</recCountry>
<recNote></recNote>
<driverNote></driverNote>
<addrCode>60046672</addrCode>
<recContactPhone>+420777666555</recContactPhone>
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
<dpCode>8901</dpCode> 
<notFillRecDP>1</notFillRecDP>
<crossDockName></crossDockName>
<deliveryToDC></deliveryToDC>
<carNumber></carNumber>
<packagePickUpType></packagePickUpType>
<sendName>Jan Novák</sendName>
<sendStreet>Adresní</sendStreet>
<sendStreetNumOri>456</sendStreetNumOri>
<sendStreetNumDesc>123</sendStreetNumDesc>
<sendCity>Plzeň</sendCity>
<sendZipCode>32600</sendZipCode>
<sendCountry>CZ</sendCountry>
<sendContactName></sendContactName>
<sendContactEmail></sendContactEmail>
<sendContactPhone></sendContactPhone>
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
<addrCode>60046672</addrCode>
<recContactPhone>+420777666555</recContactPhone>
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

let Fakturace_FakturaVydana =  query {
                        for fakturace_FakturaVydana in contextMoney.Fakturace_FakturaVydana do
                        select fakturace_FakturaVydana
                    }              

let output =
    ExpediceXml.ArrayOfPackage [| for expedition in activeExpeditions do
                                    yield ExpediceXml.Package( isCargo(expedition), 0, number(expedition), customerReference(expedition ), documentNumber(expedition),
                                                                null, null, null, null, sendName(expedition), sendStreet(expedition), sendStreetNumOri(expedition),
                                                                sendStreetNumDesc(expedition), sendCity(expedition), sentZipCode(expedition), sendCountry(expedition), sendContactName(expedition),
                                                                sendContactEmail(expedition), sendContactPhone(expedition), 0, recContactName(expedition), recName(expedition), recStreet(expedition), recStreetNumOri(expedition), 
                                                                recStreetNumDesc(expedition), recCity(expedition), recZipCode(expedition), recCountry(expedition), recNote(expedition), driverNote(expedition), addrCode(expedition),
                                                                recContactPhone(expedition), recContactEmail(expedition), rows(expedition)
                                                                  ) |]
