module MoneyS4

open System
open FSharp.Data
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders
open DB

type FirmaXml = XmlProvider<"""<?xml version="1.0" encoding="windows-1250"?>
<S5Data>
  <FirmaList>
    <Firma ObjectName="Firma" ObjectType="Object" ID="925c90f9-02bc-4b2e-b4f7-f4ac52d4fa63">
      <DIC>CZ24180149</DIC>
      <EmailSpojeni_ID>7ebab4f0-8397-45a6-91ec-1d19ced0bf94</EmailSpojeni_ID>
      <FaktPsc_ID>5b27cef8-80bb-4ab7-8c07-73c28711dc38</FaktPsc_ID>
      <FaktStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</FaktStat_ID>
      <ICO>AAA24180149</ICO>
      <Nazev>NašeÚkoly.CZ s.r.o.</Nazev>
      <ObchPsc_ID>5b27cef8-80bb-4ab7-8c07-73c28711dc38</ObchPsc_ID>
      <ObchStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</ObchStat_ID>
      <PlatceDPH>True</PlatceDPH>
      <Poznamka>David Podhola
NašeÚkoly.CZ s.r.o.
Koněvova 54, 130 00 Praha 3
T: 277 277 031
M: 603 233 944 
E: david.podhola@naseukoly.cz
W: http://www.naseukoly.cz
S: http://www.naseukoly.cz/home/kontakty</Poznamka>
      <ProvPsc_ID>5b27cef8-80bb-4ab7-8c07-73c28711dc38</ProvPsc_ID>
      <ProvStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</ProvStat_ID>
      <TelefonSpojeni1_ID>2fe01041-9583-45a2-ba43-7d21104b201c</TelefonSpojeni1_ID>
      <TelefonSpojeni2_ID>387c9c00-9809-42ff-a545-8516d77c6355</TelefonSpojeni2_ID>
      <TelefonSpojeni3_ID>387c9c00-9809-42ff-a545-8516d77c6355</TelefonSpojeni3_ID>
      <TelefonSpojeni4_ID>387c9c00-9809-42ff-a545-8516d77c6355</TelefonSpojeni4_ID>
      <WWWSpojeni_ID>387c9c00-9809-42ff-a545-8516d77c6355</WWWSpojeni_ID>
      <Adresy>
        <OdlisnaAdresaProvozovny>False</OdlisnaAdresaProvozovny>
        <OdlisnaFakturacniAdresa>False</OdlisnaFakturacniAdresa>
        <FakturacniAdresa>
          <KodPsc>AAA13000</KodPsc>
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
          <KodPsc>AAA13000</KodPsc>
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
          <KodPsc>AAA13000</KodPsc>
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
        </Provozovna>
      </Adresy>
      <Kontakty>
        <Email>info@naseukoly.cz</Email>
        <Spojeni />
        <WWW />
        <DatovaSchranka />
        <Fax />
        <Telefon1>
          <Cislo>AAA277277031</Cislo>
          <Klapka />
          <MistniCislo />
          <Predvolba />
          <PredvolbaStat />
          <StatID />
          <Typ EnumValueName="Telefon">0</Typ>
        </Telefon1>
        <Telefon2>
          <Cislo>AAA601233944</Cislo>
          <Klapka />
          <MistniCislo />
          <Predvolba />
          <PredvolbaStat />
          <StatID />
          <Typ EnumValueName="Telefon">0</Typ>
        </Telefon2>
        <Telefon3>
            <Cislo>BBB111 222 333</Cislo>
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
        <EmailSpojeni ObjectName="Spojeni" ObjectType="Object" ID="7ebab4f0-8397-45a6-91ec-1d19ced0bf94" />
        <TelefonSpojeni1 ObjectName="Spojeni" ObjectType="Object" ID="2fe01041-9583-45a2-ba43-7d21104b201c" />
        <TelefonSpojeni2 ObjectName="Spojeni" ObjectType="Object" ID="387c9c00-9809-42ff-a545-8516d77c6355" />
        <TelefonSpojeni3 ObjectName="Spojeni" ObjectType="Object" ID="387c9c00-9809-42ff-a545-8516d77c6355" />
      </Kontakty>
      <!-- Osoby>
        <SeznamOsob ObjectName="Osoba" ObjectType="List">
          <Osoba ObjectName="Osoba" ObjectType="Object" ID="af023827-497b-4a48-81c1-4bcd86bf33d5">
            <CisloOsoby>1</CisloOsoby>
            <EmailSpojeni_ID>d2b18e09-73e6-4d62-b2c8-95ec6f5ccee3</EmailSpojeni_ID>
            <FaxSpojeni_ID />
            <Funkce />
            <Jmeno>David</Jmeno>
            <KrestniJmeno />
            <Nazev>Podhola David</Nazev>
            <Poznamka>Poznámka</Poznamka>
            <Prijmeni>Podhola</Prijmeni>
            <TelefonSpojeni1_ID>387c9c00-9809-42ff-a545-8516d77c6355</TelefonSpojeni1_ID>
            <TelefonSpojeni2_ID />
            <TelefonSpojeni3_ID />
            <TelefonSpojeni4_ID />
            <TitulPred />
            <TitulZa />
            <Adresa>
              <KodPsc />
              <Misto />
              <Nazev>David Podhola</Nazev>
              <NazevStatu />
              <Ulice />
            </Adresa>
            <Kontakty>
              <Email>info@naseukoly.cz</Email>
              <Spojeni />
              <Fax />
              <Telefon1>
                <Cislo>CCC601233944</Cislo>
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
              <EmailSpojeni ObjectName="Spojeni" ObjectType="Object" ID="d2b18e09-73e6-4d62-b2c8-95ec6f5ccee3" />
              <TelefonSpojeni1 ObjectName="Spojeni" ObjectType="Object" ID="387c9c00-9809-42ff-a545-8516d77c6355" />
            </Kontakty>
          </Osoba>
        </SeznamOsob>
      </Osoby -->
      <Ucty>
        <HlavniUcet ObjectName="BankovniSpojeni" ObjectType="Object" ID="97d3587e-362b-4d36-af50-70046dc3a675" />
        <SeznamUctu ObjectName="BankovniSpojeni" ObjectType="List">
          <BankovniSpojeni ObjectName="BankovniSpojeni" ObjectType="Object" ID="97d3587e-362b-4d36-af50-70046dc3a675">
            <CisloUctu>AAA2600387156</CisloUctu>
            <Banka>
              <CiselnyKod>BBB2010</CiselnyKod>
            </Banka>
          </BankovniSpojeni>
        </SeznamUctu>
      </Ucty>
    </Firma>

    <Firma ID="1ae920b3-36ff-4c11-93c3-bef4d1d7c668" />
  </FirmaList>
</S5Data>""">

type FirmaOsobyXml = XmlProvider<"""<?xml version="1.0" encoding="windows-1250"?>
<S5Data>
  <FirmaList>
    <Firma ObjectName="Firma" ObjectType="Object" ID="925c90f9-02bc-4b2e-b4f7-f4ac52d4fa63">
      <Osoby>
        <SeznamOsob ObjectName="Osoba" ObjectType="List">
          <Osoba ObjectName="Osoba" ObjectType="Object" ID="fd72e3cb-bce7-4eaf-9390-fa7a0688fa08">
            <Jmeno>David</Jmeno>
            <Nazev>Podhola David</Nazev>
            <Prijmeni>Podhola</Prijmeni>
          </Osoba>
        </SeznamOsob>
      </Osoby>
    </Firma>
    <Firma ObjectName="Firma" ObjectType="Object" ID="925c90f9-02bc-4b2e-b4f7-f4ac52d4fa63">
      <Osoby>
        <SeznamOsob ObjectName="Osoba" ObjectType="List">
          <Osoba ObjectName="Osoba" ObjectType="Object" ID="fd72e3cb-bce7-4eaf-9390-fa7a0688fa08">
            <Jmeno>David</Jmeno>
            <Nazev>Podhola David</Nazev>
            <Prijmeni>Podhola</Prijmeni>
            <EmailSpojeni_ID>d2b18e09-73e6-4d62-b2c8-95ec6f5ccee3</EmailSpojeni_ID>
            <Funkce>AAABBB</Funkce>
            <TelefonSpojeni1_ID>387c9c00-9809-42ff-a545-8516d77c6355</TelefonSpojeni1_ID>
            <TelefonSpojeni2_ID>387c9c00-9809-42ff-a545-8516d77c6355</TelefonSpojeni2_ID>
            <TelefonSpojeni3_ID>387c9c00-9809-42ff-a545-8516d77c6355</TelefonSpojeni3_ID>
            <Kontakty>
              <Email>info@naseukoly.cz</Email>
              <Telefon1>
                <Cislo>CCC601233944</Cislo>
                <Typ EnumValueName="Telefon">0</Typ>
              </Telefon1>
              <Telefon2>
                <Cislo>CCC601233944</Cislo>
                <Typ EnumValueName="Telefon">0</Typ>
              </Telefon2>
              <Telefon3>
                <Cislo>CCC601233944</Cislo>
                <Typ EnumValueName="Telefon">0</Typ>
              </Telefon3>
              <EmailSpojeni ObjectName="Spojeni" ObjectType="Object" ID="d2b18e09-73e6-4d62-b2c8-95ec6f5ccee3" />
              <TelefonSpojeni1 ObjectName="Spojeni" ObjectType="Object" ID="387c9c00-9809-42ff-a545-8516d77c6355" />
              <TelefonSpojeni2 ObjectName="Spojeni" ObjectType="Object" ID="387c9c00-9809-42ff-a545-8516d77c6355" />
              <TelefonSpojeni3 ObjectName="Spojeni" ObjectType="Object" ID="387c9c00-9809-42ff-a545-8516d77c6355" />
            </Kontakty>
          </Osoba>
        </SeznamOsob>
      </Osoby>
      <SeznamSpojeni ObjectName="Spojeni" ObjectType="List">
        <Spojeni ObjectName="Spojeni" ObjectType="Object" ID="2fe01041-9583-45a2-ba43-7d21104b201c">
          <Osoba_ID />
          <SpojeniCislo>277277031</SpojeniCislo>
          <TypSpojeni_ID>999a45ed-7c85-425c-8230-d58ae08a21c6</TypSpojeni_ID>
          <TypSpojeni ObjectName="TypSpojeni" ObjectType="Object" ID="999a45ed-7c85-425c-8230-d58ae08a21c6" />
        </Spojeni>
        <Spojeni ObjectName="Spojeni" ObjectType="Object" ID="387c9c00-9809-42ff-a545-8516d77c6355">
          <Osoba_ID>af023827-497b-4a48-81c1-4bcd86bf33d5</Osoba_ID>
          <SpojeniCislo>603233944</SpojeniCislo>
          <TypSpojeni_ID>999a45ed-7c85-425c-8230-d58ae08a21c6</TypSpojeni_ID>
          <Osoba ObjectName="Osoba" ObjectType="Object" ID="af023827-497b-4a48-81c1-4bcd86bf33d5" />
          <TypSpojeni ObjectName="TypSpojeni" ObjectType="Object" ID="999a45ed-7c85-425c-8230-d58ae08a21c6" />
        </Spojeni>
        <Spojeni ObjectName="Spojeni" ObjectType="Object" ID="d2b18e09-73e6-4d62-b2c8-95ec6f5ccee3">
          <Osoba_ID>af023827-497b-4a48-81c1-4bcd86bf33d5</Osoba_ID>
          <SpojeniCislo>david.podhola@naseukoly.cz</SpojeniCislo>
          <TypSpojeni_ID>dc748a02-43ed-4cc5-8264-4994b56919d0</TypSpojeni_ID>
          <Osoba ObjectName="Osoba" ObjectType="Object" ID="af023827-497b-4a48-81c1-4bcd86bf33d5" />
          <TypSpojeni ObjectName="TypSpojeni" ObjectType="Object" ID="dc748a02-43ed-4cc5-8264-4994b56919d0" />
        </Spojeni>
        <Spojeni ObjectName="Spojeni" ObjectType="Object" ID="7ebab4f0-8397-45a6-91ec-1d19ced0bf94">
          <Osoba_ID />
          <SpojeniCislo>info@naseukoly.cz</SpojeniCislo>
          <TypSpojeni_ID>dc748a02-43ed-4cc5-8264-4994b56919d0</TypSpojeni_ID>
          <TypSpojeni ObjectName="TypSpojeni" ObjectType="Object" ID="dc748a02-43ed-4cc5-8264-4994b56919d0" />
        </Spojeni>
      </SeznamSpojeni>
    </Firma>
  </FirmaList>
</S5Data>""">


[<Literal>]
let faktStatIdCZ = "3d3f235c-df25-42ad-9cce-1b460e3a3c5f"
[<Literal>]
let faktStatIdSK = "ED67BBE0-F18E-48AB-A7E9-F0A30097B28D"
[<Literal>]
let faktStatIdDE = "41350F0F-514A-4C22-8366-5C25D6254AA4"
[<Literal>]
let faktStatIdFR = "DBD39ACF-D248-4A89-9FE0-EA9914139314"
[<Literal>]
let faktStatIdUK = "6A81B429-A584-44AB-B51F-CE6EAD4FA404"
[<Literal>]
let faktStatIdUSA = "B48978C1-03CD-4CC5-AE84-A8177B4552A3"
[<Literal>]
let typSpojeniEmailId = "dc748a02-43ed-4cc5-8264-4994b56919d0"
[<Literal>]
let typSpojeniTelefonId = "999a45ed-7c85-425c-8230-d58ae08a21c6"

let private faktStatId(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts) : Guid =
        match account.Country with
        |    "country_France_73" -> Guid.Parse(faktStatIdFR)
        |    "country_Germany_81" -> Guid.Parse(faktStatIdDE)
        |    "country_Montenegro_19668" -> Guid.Parse(faktStatIdSK)
        |    "country_Serbia_4503" -> Guid.Parse(faktStatIdSK)
        |    "country_Slovakia_189" -> Guid.Parse(faktStatIdSK)
        |    "country_United_Kingdom_222" -> Guid.Parse(faktStatIdUK)
        |    "country_United_States_of_America_223" -> Guid.Parse(faktStatIdUSA)
        |    "Německo" ->  Guid.Parse(faktStatIdDE)
        |    "Slovenská republika" -> Guid.Parse(faktStatIdSK)
        | _ -> Guid.Parse(faktStatIdCZ)
    
let private emailSpojeniid(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<Guid> = 
    ( if account.Email = null then None else Some(account.emailSpojeniId) )
let private emailSpojeni(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : FirmaXml.EmailSpojeni = 
    ( if account.PrimaryPhonenumber = null then null else FirmaXml.EmailSpojeni("Spojeni", "Object", emailSpojeniid(account).Value ) )

let private faktPscId(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<Guid> = 
    ( None )
let private obchPscId(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<Guid> = 
    ( None )
let private platceDph(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<bool> = 
    ( Some(account.DIC <> null) )
let private provPscId(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<Guid> = 
    ( None )

let private telefonSpojeni1id(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<Guid> = 
    ( if account.PrimaryPhonenumber = null then None else Some( account.telefonSpojeni1id ) )
let private telefonSpojeni1(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : FirmaXml.TelefonSpojeni1 = 
    ( if account.PrimaryPhonenumber = null then null else FirmaXml.TelefonSpojeni1("Spojeni", "Object", telefonSpojeni1id(account).Value ) )

let private telefonSpojeni2id(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<Guid> = 
    ( if account.Telephone2 = null then None else Some(account.telefonSpojeni2id) )
let private telefonSpojeni2(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : FirmaXml.TelefonSpojeni2 = 
    ( if account.Telephone2 = null then null else FirmaXml.TelefonSpojeni2("Spojeni", "Object", telefonSpojeni2id(account).Value ) )

let private telefonSpojeni3id(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<Guid> = 
    ( if account.Telephone3 = null then None else Some(account.telefonSpojeni3id) )
let private telefonSpojeni3(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : FirmaXml.TelefonSpojeni3 = 
    ( if account.Telephone3 = null then null else FirmaXml.TelefonSpojeni3("Spojeni", "Object", telefonSpojeni3id(account).Value ) )

let private telefonSpojeni4id(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<Guid> = 
    ( None ) // ok
let private wwwSpojeniId(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<Guid> = 
    ( None ) // ok
let private fakturacniAdresa(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : FirmaXml.FakturacniAdresa =
    FirmaXml.FakturacniAdresa(account.Postcode, account.City, account.Name, account.Country, account.Street, null, null)
let private obchodniAdresa(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : FirmaXml.ObchodniAdresa =
    (FirmaXml.ObchodniAdresa(account.Postcode, account.City, account.Name, account.Country, account.Street, null, null))
let private provozovna(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : FirmaXml.Provozovna =
    (FirmaXml.Provozovna(account.Postcode, account.City, account.Name, account.Country, account.Street, null, null))
let private adresy(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<FirmaXml.Adresy> =
    Some(FirmaXml.Adresy( false, false, fakturacniAdresa(account), obchodniAdresa(account), provozovna(account) ))
let private banka(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : FirmaXml.Banka =
    FirmaXml.Banka( 
        match account.new_banka with
        |    "BRE Bank S.A. (mBank)" -> "6210"
        |    "Citfin," -> "2060"
        |    "Citibank Europe plc, organizační složka" -> "2600"
        |    "Česká národní banka" -> "0710"
        |    "Česká spořitelna, a.s." -> "0800"
        |    "Československá obchodná banka, a.s., pobočka zahraničnej banky v SR" -> "7500"
        |    "ČSOB, a.s." -> "0300"
        |    "Fio banka, a.s." -> "2010"
        |    "GE Money Bank, a.s." -> "0600"
        |    "ING Bank N.V." -> "3500"
        |    "Komerční banka, a.s." -> "0100"
        |    "PPF banka a.s." -> "6000"
        |    "Raiffeisenbank a.s." -> "5500"
        |    "Sberbank CZ, a.s." -> "6800"
        |    "The Royal Bank of Scotland plc, organizační složka" -> "5400"
        |    "UniCredit Bank Czech Republic, a.s." -> "2700"
        | _ -> ""
    ) 

let private kontaktyAccount(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<FirmaXml.Kontakty> =
    Some( FirmaXml.Kontakty(account.Email, null, null, null, null, 
            FirmaXml.Telefon1(account.PrimaryPhonenumber, null, null, null, null, null, null), FirmaXml.Telefon2( account.Telephone2, null, null, null, null, null, null), 
            FirmaXml.Telefon3(account.Telephone3, null, null, null, null, null, null), null, emailSpojeni(account), telefonSpojeni1(account), telefonSpojeni2(account), telefonSpojeni3(account)) )
let private ucty(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<FirmaXml.Ucty> =
    ( if ( account.new_cislo_uctu <> null && account.new_cislo_uctu.Length >0 ) then 
            Some( FirmaXml.Ucty(null, FirmaXml.SeznamUctu("BankovniSpojeni", "List", FirmaXml.BankovniSpojeni("BankovniSpojeni", "Object", account.bankovniSpojeniId, account.new_cislo_uctu, banka(account))) ) )
        else
            None
    )

let private kontakty(contact : EntityConnection.ServiceTypes.adapters_moneys4_PartialContacts ) : Option<FirmaOsobyXml.Kontakty> =
    Some( FirmaOsobyXml.Kontakty(contact.EmailAddress1, FirmaOsobyXml.Telefon1( contact.Telephone1, FirmaOsobyXml.Typ("Telefon", 0 ) ), 
                                 FirmaOsobyXml.Telefon2( contact.Telephone2, FirmaOsobyXml.Typ2("Telefon", 0 )  ), FirmaOsobyXml.Telefon3( contact.Telephone3, FirmaOsobyXml.Typ3("Telefon", 0 )  ), 
                                 FirmaOsobyXml.EmailSpojeni( "Spojeni", "Object", contact.emailSpojeniId ),
                                 FirmaOsobyXml.TelefonSpojeni1( "Spojeni", "Object", contact.telefonSpojeni1id ), 
                                 FirmaOsobyXml.TelefonSpojeni2( "Spojeni", "Object", contact.telefonSpojeni2id ), 
                                 FirmaOsobyXml.TelefonSpojeni3( "Spojeni", "Object", contact.telefonSpojeni3id ) ) )

let private osoba(contact : EntityConnection.ServiceTypes.adapters_moneys4_PartialContacts ) : FirmaOsobyXml.Osoba =
    FirmaOsobyXml.Osoba("Osoba", "Object", contact.PartialContactId, contact.Firstname, contact.Firstname + " " + contact.LastName, contact.LastName, 
                            Some(contact.emailSpojeniId), Some(contact.JobTitle), Some(contact.telefonSpojeni1id), Some(contact.telefonSpojeni2id), Some(contact.telefonSpojeni3id ),
                            kontakty(contact) )

let private seznamOsob(contact : EntityConnection.ServiceTypes.adapters_moneys4_PartialContacts ) : FirmaOsobyXml.SeznamOsob =
    FirmaOsobyXml.SeznamOsob("Osoba", "List", osoba(contact) )

let private osoby(contact : EntityConnection.ServiceTypes.adapters_moneys4_PartialContacts ) : FirmaOsobyXml.Osoby =
    ( 
            FirmaOsobyXml.Osoby(seznamOsob(contact) )
    )

let private spojeniSeznam(contact : EntityConnection.ServiceTypes.adapters_moneys4_PartialContacts ) =
    [| FirmaOsobyXml.Spojeni( "Spojeni", "Object", contact.emailSpojeniId, Some(contact.PartialContactId), FirmaOsobyXml.SpojeniCislo(contact.EmailAddress1), 
                                Guid.Parse(typSpojeniEmailId),
                                FirmaOsobyXml.TypSpojeni("TypSpojeni", "Object", Guid.Parse(typSpojeniEmailId)), 
                                Some(FirmaOsobyXml.Osoba2( "Osoba", "Object", contact.PartialContactId ) ) );
       FirmaOsobyXml.Spojeni( "Spojeni", "Object", contact.telefonSpojeni1id, Some(contact.PartialContactId), FirmaOsobyXml.SpojeniCislo(contact.Telephone1), 
                                Guid.Parse(typSpojeniTelefonId),
                                FirmaOsobyXml.TypSpojeni("TypSpojeni", "Object", Guid.Parse(typSpojeniTelefonId)), 
                                Some(FirmaOsobyXml.Osoba2( "Osoba", "Object", contact.PartialContactId ) ) );                        
       FirmaOsobyXml.Spojeni( "Spojeni", "Object", contact.telefonSpojeni2id, Some(contact.PartialContactId), FirmaOsobyXml.SpojeniCislo(contact.Telephone2), 
                                Guid.Parse(typSpojeniTelefonId),
                                FirmaOsobyXml.TypSpojeni("TypSpojeni", "Object", Guid.Parse(typSpojeniTelefonId)), 
                                Some(FirmaOsobyXml.Osoba2( "Osoba", "Object", contact.PartialContactId ) ) );                        
       FirmaOsobyXml.Spojeni( "Spojeni", "Object", contact.telefonSpojeni3id, Some(contact.PartialContactId), FirmaOsobyXml.SpojeniCislo(contact.Telephone3), 
                                Guid.Parse(typSpojeniTelefonId),
                                FirmaOsobyXml.TypSpojeni("TypSpojeni", "Object", Guid.Parse(typSpojeniTelefonId)), 
                                Some(FirmaOsobyXml.Osoba2( "Osoba", "Object", contact.PartialContactId ) ) )                                
                                 |]

let private seznamSpojeni(contact : EntityConnection.ServiceTypes.adapters_moneys4_PartialContacts ) : Option<FirmaOsobyXml.SeznamSpojeni> =
    Some(FirmaOsobyXml.SeznamSpojeni("Spojeni", "List", spojeniSeznam(contact) ))

let private string2option(par1 : string ) : Option<string> =
    match par1 with
    | null -> None
    | _ -> Some par1

let private dic(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<string> =
    ( string2option account.DIC )
let private ic(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<string> =
    ( string2option account.IC )
let private name(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<string> =
    ( string2option account.Name )
let private note(account : EntityConnection.ServiceTypes.adapters_moneys4_PartialAccounts ) : Option<string> =
    ( string2option account.Note )

let private activeAccounts( from: DateTime ) = query {
                        for account in context.adapters_moneys4_PartialAccounts do
                        where ( account.CreatedOn > from )
                        select account
                    }                        

let private activeContacts = query {
                        for contact in context.adapters_moneys4_PartialContacts do
                        where contact.ParentAccountId.HasValue
                        select contact
                    }                        

let output =
    FirmaXml.SData [| for account in activeAccounts(DateTime.Now.Date.AddDays(float -1)) do
                        yield FirmaXml.Firma(Some("Firma"), Some("Object"), account.PartialAccountId, dic(account), emailSpojeniid(account), faktPscId(account), Some(faktStatId(account)),
                                                ic(account), name(account), obchPscId(account), Some(faktStatId(account)), platceDph(account), note(account), 
                                                provPscId(account), Some(faktStatId(account)), telefonSpojeni1id(account), telefonSpojeni2id(account), telefonSpojeni3id(account),
                                                telefonSpojeni4id(account), wwwSpojeniId(account), adresy(account), kontaktyAccount(account), (*osoby(account),*) ucty(account) ) |]

let outputContacts =
    FirmaOsobyXml.SData [| for contact in activeContacts do
                                yield FirmaOsobyXml.Firma( "Firma", "Object", contact.ParentAccountId.Value, osoby(contact), seznamSpojeni(contact) ) |]