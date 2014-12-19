module MoneyS4

open System
open FSharp.Data
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders

type FirmaXml = XmlProvider<"""<?xml version="1.0" encoding="windows-1250"?>
<S5Data>
  <FirmaList>
    <Firma ObjectName="Firma" ObjectType="Object" ID="3544e6d1-304c-4920-9eb3-197ecf90c3f5">
      <DIC>CZ26294010</DIC>
      <FyzickaOsoba>False</FyzickaOsoba>
      <ICO>N26294010</ICO>
      <Nazev>CERIA,s.r.o.</Nazev>
      <PlatceDPH>True</PlatceDPH>
    </Firma>
    <Firma ObjectName="Firma" ObjectType="Object" ID="3544e6d1-304c-4920-9eb3-197ecf90c3f5">
      <DIC>CZ26294010</DIC>
      <FyzickaOsoba>False</FyzickaOsoba>
      <ICO>A26294010</ICO>
      <Nazev>CERIA,s.r.o.</Nazev>
      <PlatceDPH>True</PlatceDPH>
    </Firma>
  </FirmaList>
</S5Data>
""">

[<Literal>]
let connectionString = "Data Source=(localdb)\ProjectsV12; Initial Catalog=SyncToday2015; Integrated Security=True;"

type internal EntityConnection = SqlEntityConnection<ConnectionStringName="sync-today-mssql",
                                                        Pluralize = true>


let private context = EntityConnection.GetDataContext()

let private fullContext = context.DataContext


let output =
    FirmaXml.SData [| for account in context.Accounts do
                        yield FirmaXml.Firma("Firma", "Object", Guid.NewGuid(), account.dic, false, account.ico, account.name, true) |]
