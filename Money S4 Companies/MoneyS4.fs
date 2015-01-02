module MoneyS4

open System
open FSharp.Data
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders

type FirmaXml = XmlProvider<"""<?xml version="1.0" encoding="windows-1250"?>
<S5Data>
  <FirmaList>
    <Firma ObjectName="Firma" ObjectType="Object" ID="1ae920b3-36ff-4c11-93c3-bef4d1d7c669">
      <DIC>CZ24180149</DIC>
      <EmailSpojeni_ID>66c2ef4f-2fae-409a-be4d-c774c135b7d2</EmailSpojeni_ID>
      <FaktPsc_ID>5b27cef8-80bb-4ab7-8c07-73c28711dc38</FaktPsc_ID>
      <FaktStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</FaktStat_ID>
      <ICO>AAA24180149</ICO>
      <Nazev>NašeÚkoly.CZ s.r.o.</Nazev>
      <ObchPsc_ID>5b27cef8-80bb-4ab7-8c07-73c28711dc38</ObchPsc_ID>
      <ObchStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</ObchStat_ID>
      <PlatceDPH>True</PlatceDPH>
      <Poznamka>Dodavatel CRM a Sync.Today</Poznamka>
      <ProvPsc_ID>5b27cef8-80bb-4ab7-8c07-73c28711dc38</ProvPsc_ID>
      <ProvStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</ProvStat_ID>
      <TelefonSpojeni1_ID>ac3a64e5-17c8-47f3-bbda-a62d41a39aa5</TelefonSpojeni1_ID>
      <TelefonSpojeni2_ID>ac3a64e5-17c8-47f3-bbda-a62d41a39aa5</TelefonSpojeni2_ID>
      <TelefonSpojeni3_ID>ac3a64e5-17c8-47f3-bbda-a62d41a39aa5</TelefonSpojeni3_ID>
      <TelefonSpojeni4_ID>ac3a64e5-17c8-47f3-bbda-a62d41a39aa5</TelefonSpojeni4_ID>
      <WWWSpojeni_ID>ac3a64e5-17c8-47f3-bbda-a62d41a39aa5</WWWSpojeni_ID>
      <Adresy>
        <OdlisnaAdresaProvozovny>True</OdlisnaAdresaProvozovny>
        <OdlisnaFakturacniAdresa>False</OdlisnaFakturacniAdresa>
        <FakturacniAdresa>
          <KodPsc>13000</KodPsc>
          <Misto>Praha 3</Misto>
          <Nazev>NašeÚkoly.CZ s.r.o.</Nazev>
          <NazevStatu>Česká republika</NazevStatu>
          <Ulice>Jagellonská 1498/29</Ulice>
          <Psc ObjectName="PSC" ObjectType="Object" ID="5b27cef8-80bb-4ab7-8c07-73c28711dc38" />
          <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f">
            <EU>True</EU>
            <Kod>CZ</Kod>
            <KodDIC>CZ</KodDIC>
            <KodISO>203</KodISO>
            <KodISO3>CZE</KodISO3>
            <Nazev>Česká republika</Nazev>
            <NazevEN>Czech Republic</NazevEN>
            <Poznamka />
            <SepaPlatby>True</SepaPlatby>
            <TelPred>+420</TelPred>
          </Stat>
        </FakturacniAdresa>
        <ObchodniAdresa>
          <KodPsc>13000</KodPsc>
          <Misto>Praha 3</Misto>
          <Nazev>NašeÚkoly.CZ s.r.o.</Nazev>
          <NazevStatu>Česká republika</NazevStatu>
          <Ulice>Jagellonská 1498/29</Ulice>
          <Psc ObjectName="PSC" ObjectType="Object" ID="5b27cef8-80bb-4ab7-8c07-73c28711dc38" />
          <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f">
            <EU>True</EU>
            <Kod>CZ</Kod>
            <KodDIC>CZ</KodDIC>
            <KodISO>203</KodISO>
            <KodISO3>CZE</KodISO3>
            <Nazev>Česká republika</Nazev>
            <NazevEN>Czech Republic</NazevEN>
            <Poznamka />
            <SepaPlatby>True</SepaPlatby>
            <TelPred>+420</TelPred>
          </Stat>
        </ObchodniAdresa>
        <Provozovna>
          <KodPsc>13000</KodPsc>
          <Misto>Praha 3</Misto>
          <Nazev>NašeÚkoly.CZ s.r.o.</Nazev>
          <NazevStatu>Česká republika</NazevStatu>
          <Ulice>Koněvova 54</Ulice>
          <Psc ObjectName="PSC" ObjectType="Object" ID="5b27cef8-80bb-4ab7-8c07-73c28711dc38" />
          <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f">
            <EU>True</EU>
            <Kod>CZ</Kod>
            <KodDIC>CZ</KodDIC>
            <KodISO>203</KodISO>
            <KodISO3>CZE</KodISO3>
            <Nazev>Česká republika</Nazev>
            <NazevEN>Czech Republic</NazevEN>
            <Poznamka />
            <SepaPlatby>True</SepaPlatby>
            <TelPred>+420</TelPred>
          </Stat>
        </Provozovna>
      </Adresy>
      <Kontakty>
        <Email>info@naseukoly.cz</Email>
        <Spojeni />
        <WWW />
        <DatovaSchranka />
        <Fax />
        <Telefon1>
          <Cislo>277 277 031</Cislo>
          <Klapka />
          <MistniCislo />
          <Predvolba />
          <PredvolbaStat />
          <StatID />
          <Typ EnumValueName="Telefon">0</Typ>
        </Telefon1>
        <Telefon2>
          <Cislo />
          <Klapka />
          <MistniCislo />
          <Predvolba />
          <PredvolbaStat />
          <StatID />
          <Typ EnumValueName="Telefon">0</Typ>
        </Telefon2>
        <Telefon3>
          <Cislo />
          <Klapka />
          <MistniCislo />
          <Predvolba />
          <PredvolbaStat />
          <StatID />
          <Typ EnumValueName="Telefon">0</Typ>
        </Telefon3>
        <Telefon4>
          <Cislo />
          <Klapka />
          <MistniCislo />
          <Predvolba />
          <PredvolbaStat />
          <StatID />
          <Typ EnumValueName="Telefon">0</Typ>
        </Telefon4>
        <EmailSpojeni ObjectName="Spojeni" ObjectType="Object" ID="66c2ef4f-2fae-409a-be4d-c774c135b7d2" />
        <TelefonSpojeni1 ObjectName="Spojeni" ObjectType="Object" ID="ac3a64e5-17c8-47f3-bbda-a62d41a39aa5" />
      </Kontakty>
      <Ucty>
        <HlavniUcet ObjectName="BankovniSpojeni" ObjectType="Object" ID="7334221f-2db8-4635-8d2e-bde99eab9c12" />
        <SeznamUctu ObjectName="BankovniSpojeni" ObjectType="List">
          <BankovniSpojeni ObjectName="BankovniSpojeni" ObjectType="Object" ID="7334221f-2db8-4635-8d2e-bde99eab9c12">
            <Banka_ID>4733d9bb-a741-452b-aa93-9c1680469f14</Banka_ID>
            <CisloUctu>2600387156</CisloUctu>
            <DatumPosledniKontrolyUctuWS>1753-01-01T00:00:00</DatumPosledniKontrolyUctuWS>
            <IBAN>CZ4820100000002600387156</IBAN>
            <PosledniOvereniZHistorie_ID />
            <Poznamka />
            <SpecSymbol />
            <StavUctuPlatceDPHComputed>0</StavUctuPlatceDPHComputed>
            <StavUctuPlatceDPHVracenyWS_Stav>0</StavUctuPlatceDPHVracenyWS_Stav>
            <SWIFTText>FIOBCZPP</SWIFTText>
            <ZahranicniBankaPSC_ID />
            <ZahranicniBankaStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</ZahranicniBankaStat_ID>
            <ZahranicniBankaText>Fio banka, a.s.</ZahranicniBankaText>
            <ZahranicniUcet>False</ZahranicniUcet>
            <ZahranicniBanka>
              <Misto />
              <PSCText />
              <StatNazevText>Česká republika</StatNazevText>
              <StatText>CZ</StatText>
              <Ulice />
              <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f">
                <EU>True</EU>
                <Kod>CZ</Kod>
                <KodDIC>CZ</KodDIC>
                <KodISO>203</KodISO>
                <KodISO3>CZE</KodISO3>
                <Nazev>Česká republika</Nazev>
                <NazevEN>Czech Republic</NazevEN>
                <Poznamka />
                <SepaPlatby>True</SepaPlatby>
                <TelPred>+420</TelPred>
              </Stat>
            </ZahranicniBanka>
            <Banka ObjectName="Banka" ObjectType="Object" ID="4733d9bb-a741-452b-aa93-9c1680469f14">
              <Group ID="ef04d885-1a39-4c48-a7a8-eb797000fd62" Kod="BAN" />
              <CiselnyKod>2010</CiselnyKod>
              <Kod>FIOZ</Kod>
              <KonfiguraceKL_ID />
              <Nazev>Fio banka, a.s.</Nazev>
              <Poznamka />
              <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
              <SWIFT>FIOBCZPP</SWIFT>
              <SeznamKonfiguraciKL ObjectName="BankaKonfiguraceKL" ObjectType="List" />
              <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
            </Banka>
            <HistorieOvereniUctuVRegistu ObjectName="BankovniSpojeniRegistrPlatcuDphCZ" ObjectType="List" />
          </BankovniSpojeni>
        </SeznamUctu>
      </Ucty>
    </Firma>
    <Firma ID="1ae920b3-36ff-4c11-93c3-bef4d1d7c668" />
  </FirmaList>
</S5Data>""">


[<Literal>]
let connectionString = "Data Source=(localdb)\ProjectsV12; Initial Catalog=SyncToday2015; Integrated Security=True;"

type internal EntityConnection = SqlEntityConnection<ConnectionStringName="sync-today-mssql",
                                                        Pluralize = true>


let private context = EntityConnection.GetDataContext()

let private fullContext = context.DataContext

[<Literal>]
let faktStatId = "3d3f235c-df25-42ad-9cce-1b460e3a3c5f"

let private emailSpojeniid(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<Guid> = 
    ( if account.Email = null then None else Some(account.AccountId) )
let private faktPscId(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<Guid> = 
    ( Some(account.AccountId) )
let private obchPscId(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<Guid> = 
    ( Some(account.AccountId) )
let private platceDph(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<bool> = 
    ( Some(account.DIC <> null) )
let private provPscId(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<Guid> = 
    ( Some(account.AccountId) )
let private telefonSpojeni1id(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<Guid> = 
    ( if account.PrimaryPhonenumber = null then None else Some(Guid.NewGuid()) )
let private telefonSpojeni2id(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<Guid> = 
    ( if account.Telephone2 = null then None else Some(Guid.NewGuid()) )
let private telefonSpojeni3id(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<Guid> = 
    ( if account.Telephone3 = null then None else Some(Guid.NewGuid()) )
let private telefonSpojeni4id(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<Guid> = 
    ( None )
let private wwwSpojeniId(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<Guid> = 
    ( None )
let private adresy(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<FirmaXml.Adresy> =
    ( None )
let private kontakty(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<FirmaXml.Kontakty> =
    ( None )
let private ucty(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<FirmaXml.Ucty> =
    ( None )
let private string2option(par1 : string ) : Option<string> =
    match par1 with
    | null -> None
    | _ -> Some par1

let private dic(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<string> =
    ( string2option account.DIC )
let private ic(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<string> =
    ( string2option account.IC )
let private name(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<string> =
    ( string2option account.Name )
let private note(account : EntityConnection.ServiceTypes.entities_Accounts ) : Option<string> =
    ( string2option account.Note )

let output =
    FirmaXml.SData [| for account in context.entities_Accounts do
                        yield FirmaXml.Firma(Some("Firma"), Some("Object"), account.AccountId, dic(account), emailSpojeniid(account), faktPscId(account), Some(Guid.Parse(faktStatId)),
                                                ic(account), name(account), obchPscId(account), Some(Guid.Parse(faktStatId)), platceDph(account), note(account), 
                                                provPscId(account), Some(Guid.Parse(faktStatId)), telefonSpojeni1id(account), telefonSpojeni2id(account), telefonSpojeni3id(account),
                                                telefonSpojeni4id(account), wwwSpojeniId(account), adresy(account), kontakty(account), ucty(account) ) |]

