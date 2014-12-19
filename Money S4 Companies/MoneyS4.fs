module MoneyS4

open System
open FSharp.Data

type FirmaXml = XmlProvider<"""<?xml version="1.0" encoding="windows-1250"?>
<S5Data>
  <FirmaList>
    <Firma ObjectName="Firma" ObjectType="Object" ID="3544e6d1-304c-4920-9eb3-197ecf90c3f5">
      <DIC>CZ26294010</DIC>
      <FyzickaOsoba>False</FyzickaOsoba>
      <ICO>26294010</ICO>
      <Nazev>CERIA,s.r.o.</Nazev>
      <PlatceDPH>True</PlatceDPH>
    </Firma>
  </FirmaList>
</S5Data>
""">

let output =
    FirmaXml.SData( FirmaXml.Firma("Firma", "Object", Guid.NewGuid(), "DIC", false, 123456, "Test s.r.o.", true) )
