module Artikl


open System
open FSharp.Data
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders

type ObjPXml = XmlProvider<"""<?xml version="1.0" encoding="windows-1250"?>
<S5Data>
  <ArtiklList>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="fcde02d6-ba7e-4303-b9d2-6f5f06ad7aba">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>19</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>cf4a4a91-c4d9-4c1e-be3f-23dc5cd30c12</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00019</Kod>
      <KodCislo>19</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Badyán celý</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>225.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Badyán celý</Zkratka12>
      <Zkratka20>Badyán celý</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="cf4a4a91-c4d9-4c1e-be3f-23dc5cd30c12" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="cf4a4a91-c4d9-4c1e-be3f-23dc5cd30c12">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="17987d5b-8fb8-4ba6-ba2d-c62669eb7a06">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="c0825218-a1c9-40cf-8619-53cb34829c1d">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>17</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>3976ec67-3789-4fce-b49b-033d24cb324a</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00017</Kod>
      <KodCislo>17</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Bobkový list celý</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>179.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Bobkový list</Zkratka12>
      <Zkratka20>Bobkový list celý</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="3976ec67-3789-4fce-b49b-033d24cb324a" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="3976ec67-3789-4fce-b49b-033d24cb324a">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="7272c474-35c1-4a79-8852-e262f022ed8b">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="71252531-0192-404f-b259-5452397b7590">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>71</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>21e9075f-2582-4432-89a9-15a04bf14553</HlavniJednotka_ID>
      <Hmostnost_ID>2b9ba8fe-2102-4b92-94b8-104dd9ddb459</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00071</Kod>
      <KodCislo>71</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Ceria 1 kg vychucená směs z pšeničné bílkoviny</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>62.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-05T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>1.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Ceria 1 kg</Zkratka12>
      <Zkratka20>Ceria 1 kg</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="21e9075f-2582-4432-89a9-15a04bf14553" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="21e9075f-2582-4432-89a9-15a04bf14553">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="2b9ba8fe-2102-4b92-94b8-104dd9ddb459" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="2b9ba8fe-2102-4b92-94b8-104dd9ddb459">
            <Hodnota>1.0000</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="d4cdc9a7-e1b3-4759-82e2-a6287ba5c009">
          <PovahaSazbyVstup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVstup_ID>
          <PovahaSazbyVystup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVystup_ID>
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
          <PovahaSazbyVstup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
          <PovahaSazbyVystup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="54203275-7a38-46cc-a5fc-981ccec1e251">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>72</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>4bca6418-183d-4651-8034-2349deecaa10</HlavniJednotka_ID>
      <Hmostnost_ID>b9d6c427-18e7-4b59-8c79-e1f6311011f6</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00072</Kod>
      <KodCislo>72</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Ceria 25 kg vychucená směs z pšeničné bílkoviny</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>1250.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-05T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>25.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Ceria 25 kg</Zkratka12>
      <Zkratka20>Ceria 25 kg</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="4bca6418-183d-4651-8034-2349deecaa10" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="4bca6418-183d-4651-8034-2349deecaa10">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="b9d6c427-18e7-4b59-8c79-e1f6311011f6" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="b9d6c427-18e7-4b59-8c79-e1f6311011f6">
            <Hodnota>25.0000</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="031a0508-511d-44c2-acf1-8be91547c393">
          <PovahaSazbyVstup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVstup_ID>
          <PovahaSazbyVystup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVystup_ID>
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
          <PovahaSazbyVstup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
          <PovahaSazbyVystup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="ee426686-0e86-413c-af1e-17ddb0ef448e">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>70</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>a26e0f94-d6f9-4911-8316-828214162181</HlavniJednotka_ID>
      <Hmostnost_ID>349be4e7-464a-4eee-a722-515090cb1baa</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00070</Kod>
      <KodCislo>70</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Ceria 500 g - vychucená směs z pšeničné bílkoviny</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>35.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-05T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.500000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Ceria 500 g</Zkratka12>
      <Zkratka20>Ceria 500 g</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="a26e0f94-d6f9-4911-8316-828214162181" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="a26e0f94-d6f9-4911-8316-828214162181">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="349be4e7-464a-4eee-a722-515090cb1baa" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="349be4e7-464a-4eee-a722-515090cb1baa">
            <Hodnota>0.5000</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="ab08bc8b-240f-4bea-8641-a1db1995734f">
          <PovahaSazbyVstup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVstup_ID>
          <PovahaSazbyVystup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVystup_ID>
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
          <PovahaSazbyVstup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
          <PovahaSazbyVystup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="577b1a62-ce9f-41d5-a081-4a3c14315676">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>76</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>65b4d5dd-a748-4dc5-8149-a86a5f649ec7</HlavniJednotka_ID>
      <Hmostnost_ID>488cd2a7-2bd6-4a64-9d1b-957631d54b60</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00076</Kod>
      <KodCislo>71</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Ceria 8 kg vychucená směs z pšeničné bílkoviny</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>480.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-05T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>8.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Ceria 8 kg</Zkratka12>
      <Zkratka20>Ceria 8 kg vychucená</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="65b4d5dd-a748-4dc5-8149-a86a5f649ec7" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="65b4d5dd-a748-4dc5-8149-a86a5f649ec7">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="488cd2a7-2bd6-4a64-9d1b-957631d54b60" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="488cd2a7-2bd6-4a64-9d1b-957631d54b60">
            <Hodnota>8.0000</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="b8cc28a8-4ad9-46c5-b7ab-ad29247c6daf">
          <PovahaSazbyVstup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVstup_ID>
          <PovahaSazbyVystup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVystup_ID>
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
          <PovahaSazbyVstup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
          <PovahaSazbyVystup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="656c5b82-155a-4b23-8127-501342d34a51">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>16</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>fdf8cdb1-9030-4929-b857-2946bd1d5864</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00016</Kod>
      <KodCislo>16</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Cibule sušená -  plátky</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>90.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Cibule-plátk</Zkratka12>
      <Zkratka20>Cibule-plátky</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="fdf8cdb1-9030-4929-b857-2946bd1d5864" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="fdf8cdb1-9030-4929-b857-2946bd1d5864">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="38f52bf0-af03-4785-92d0-89f9a90303f2">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="21991fe7-54d9-4d9d-97f9-b0595c67e475">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>10</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>1275d48c-3da9-4e01-a18f-e9facaa871eb</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00010</Kod>
      <KodCislo>10</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Cukr kystal řepný</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>14.8800</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Cukr kystal</Zkratka12>
      <Zkratka20>Cukr kystal řepný</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="1275d48c-3da9-4e01-a18f-e9facaa871eb" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="1275d48c-3da9-4e01-a18f-e9facaa871eb">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="ad776392-3281-4838-b774-bfae0458d0c7">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="04c4c1bb-852f-40e3-b4f4-f6628c97b043">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>11</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>23d6ef3f-e663-4710-8648-ec9a7b3a1fb4</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00011</Kod>
      <KodCislo>11</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Česnek sušený plátky</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>85.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Česnek plátk</Zkratka12>
      <Zkratka20>Česnek sušený plátky</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="23d6ef3f-e663-4710-8648-ec9a7b3a1fb4" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="23d6ef3f-e663-4710-8648-ec9a7b3a1fb4">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="5b26dbe0-7007-430c-9e67-95ac1f9dee7f">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="e9e6aeac-6634-4f67-9175-add98c55efe2">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>74</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>78db2306-129d-44be-841a-99036401418c</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>b0b389eb-1535-4445-8d73-09bad4b27b04</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00074</Kod>
      <KodCislo>0</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Dobírka</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>1753-01-01T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Sluzba">1</TypArtiklu>
      <TypEvidence EnumValueName="Neni">0</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Dobírka</Zkratka12>
      <Zkratka20>Dobírka</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="b0b389eb-1535-4445-8d73-09bad4b27b04" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="b0b389eb-1535-4445-8d73-09bad4b27b04">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="78db2306-129d-44be-841a-99036401418c">
        <Kod>SLU</Kod>
        <Nazev>služba</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="b474ba25-31ff-4988-b0df-f51f37928c58">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="fb1b1024-917f-4124-b39b-a35b6c714f0c">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>73</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>78db2306-129d-44be-841a-99036401418c</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>ae6f0f3d-4b68-4f39-96ff-38852e79a5cb</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00073</Kod>
      <KodCislo>0</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Dopravné</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>1753-01-01T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Sluzba">1</TypArtiklu>
      <TypEvidence EnumValueName="Neni">0</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Dopravné</Zkratka12>
      <Zkratka20>Dopravné</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="ae6f0f3d-4b68-4f39-96ff-38852e79a5cb" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="ae6f0f3d-4b68-4f39-96ff-38852e79a5cb">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="78db2306-129d-44be-841a-99036401418c">
        <Kod>SLU</Kod>
        <Nazev>služba</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="c19c9646-ca5b-4c83-98fc-c45f2795e520">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="9579c0af-2be2-4bfa-b266-df0e9af654b0">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>75</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>78db2306-129d-44be-841a-99036401418c</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>533e51a6-d50a-4993-8294-f6b39b6e190a</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00075</Kod>
      <KodCislo>0</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Dopravné+Dobírka</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>1753-01-01T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Sluzba">1</TypArtiklu>
      <TypEvidence EnumValueName="Neni">0</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Dopravné+Dob</Zkratka12>
      <Zkratka20>Dopravné+Dobírka</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="533e51a6-d50a-4993-8294-f6b39b6e190a" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="533e51a6-d50a-4993-8294-f6b39b6e190a">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="78db2306-129d-44be-841a-99036401418c">
        <Kod>SLU</Kod>
        <Nazev>služba</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="8070f0e2-0c8d-4d85-970f-b31ec1f0ad8e">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="f91466e4-ff37-4918-8973-e4b43a0d9d13">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>35</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>3ea89f36-beb4-4f80-abbc-eec31c2844d6</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00035</Kod>
      <KodCislo>35</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Etiketa Hv1 </Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.7500</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Etiketa Hv1</Zkratka12>
      <Zkratka20>Etiketa Hv1</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="3ea89f36-beb4-4f80-abbc-eec31c2844d6" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="3ea89f36-beb4-4f80-abbc-eec31c2844d6">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="def8a82b-742e-46d3-9c65-8609eb3fd077">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="36427097-4125-41a4-878b-2c4fb8a55e5a">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>36</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>59d05d59-e2b5-442d-a328-7cf80ddbb8dd</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00036</Kod>
      <KodCislo>36</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Etiketa Hv2 </Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.7500</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Etiketa Hv2</Zkratka12>
      <Zkratka20>Etiketa Hv2</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="59d05d59-e2b5-442d-a328-7cf80ddbb8dd" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="59d05d59-e2b5-442d-a328-7cf80ddbb8dd">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="7949a965-5a0d-42b1-8e9d-c2e3ce297d17">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="e2bfb325-0e5e-4e91-993c-d83af561b10c">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>37</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>80336528-a8cb-4eab-88aa-6aa2610eccc1</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00037</Kod>
      <KodCislo>37</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Etiketa Mahá100g</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.7500</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Etik Mahá100</Zkratka12>
      <Zkratka20>Etiketa Mahá1</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="80336528-a8cb-4eab-88aa-6aa2610eccc1" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="80336528-a8cb-4eab-88aa-6aa2610eccc1">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="c9a6d6ad-c49b-415d-b29a-3e0269f12c36">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="bbb12d2a-42cc-4cb7-acbd-428f6151ea3e">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>34</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>4ad062aa-6d76-4c6d-80aa-6166cfee0b71</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00034</Kod>
      <KodCislo>34</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Etiketa na kartony 70x80</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.3700</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Etik karton</Zkratka12>
      <Zkratka20>Etiketa na kartony</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="4ad062aa-6d76-4c6d-80aa-6166cfee0b71" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="4ad062aa-6d76-4c6d-80aa-6166cfee0b71">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="3d92446c-8004-4fc6-b6c4-d1d67d59ce29">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="7d4f7bff-714b-403e-bdc4-cfdb9ff9a7eb">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>28</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>2ae72fe6-49ce-4f53-9032-99ad4a1b604a</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00028</Kod>
      <KodCislo>28</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Folie HJ1 10g/ks 435 mm celobarevna</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>202.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Folie HJ1 10</Zkratka12>
      <Zkratka20>Folie HJ1 10g/ks 435</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="2ae72fe6-49ce-4f53-9032-99ad4a1b604a" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="2ae72fe6-49ce-4f53-9032-99ad4a1b604a">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy>
        <Popis0 />
        <Popis1>
          <Popis>PET 12/PET12 metal/PE 60 mic bílá 435 mm, výtěžnost 35 bm/kg, 10g/sáček</Popis>
          <Poznamka />
        </Popis1>
        <Popis2 />
        <Popis3 />
      </RozsirenePopisy>
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="0d51efdd-0ae5-42aa-9fd0-011d618bad19">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="63d13f4e-b840-4908-9660-2a8aa0bd1a88">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>30</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>69805720-a3ab-4509-976a-220a739d18e0</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00030</Kod>
      <KodCislo>30</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Folie HJ14 5g/ks 320 mm celobarevná</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>202.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Folie HJ14 5</Zkratka12>
      <Zkratka20>Folie HJ14 5g/ks 320</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="69805720-a3ab-4509-976a-220a739d18e0" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="69805720-a3ab-4509-976a-220a739d18e0">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="2fc85600-6dc6-43a9-90d2-8cd32e6f9d5c">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="ce421fb2-3bfc-4737-9b24-c16b438114a9">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>29</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>415e6e03-b5bb-46b0-a43f-dffe3e99d406</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00029</Kod>
      <KodCislo>29</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Folie HJ2 7g/ks 435 mm celobarevná</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>202.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-06T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Folie HJ2 7g</Zkratka12>
      <Zkratka20>Folie HJ2 7g/ks 435</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele>
        <SeznamDodavatelu ObjectName="ArtiklDodavatel" ObjectType="List">
          <ArtiklDodavatel ObjectName="ArtiklDodavatel" ObjectType="Object" ID="4298f561-ed41-42ca-9935-cb42a6d0a5d6">
            <ArtiklJednotka_ID>415e6e03-b5bb-46b0-a43f-dffe3e99d406</ArtiklJednotka_ID>
            <CarovyKod_ID />
            <Firma_ID>cc974e65-e064-4b49-8aef-a91f25a95803</Firma_ID>
            <Jednotka_ID />
            <MinimalniObjednavka>0.0000</MinimalniObjednavka>
            <NazevFirmy>VEPAK, s.r.o.</NazevFirmy>
            <PosledniCena>202.0000</PosledniCena>
            <PosledniCenaCM>0.0000</PosledniCenaCM>
            <PosledniDodavka>2015-01-06T00:00:00</PosledniDodavka>
            <PosledniMena_ID />
            <PovinnyNasobek>0.0000</PovinnyNasobek>
            <DodaciLhuta>
              <Doba>0</Doba>
              <Typ EnumValueName="Neurceno">0</Typ>
            </DodaciLhuta>
            <DodavatelskeOznaceni />
            <Zaruka>
              <Doba>0</Doba>
              <Typ EnumValueName="Zadna">0</Typ>
            </Zaruka>
            <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="415e6e03-b5bb-46b0-a43f-dffe3e99d406" />
            <Firma ObjectName="Firma" ObjectType="Object" ID="cc974e65-e064-4b49-8aef-a91f25a95803" />
          </ArtiklDodavatel>
        </SeznamDodavatelu>
      </Dodavatele>
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="415e6e03-b5bb-46b0-a43f-dffe3e99d406" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="415e6e03-b5bb-46b0-a43f-dffe3e99d406">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy>
        <Popis0 />
        <Popis1>
          <Popis>PET 12/PET12 metal/PE 60 mic bílá 435 mm, výtěžnost 35 bm/kg, 7g/sáček</Popis>
          <Poznamka />
        </Popis1>
        <Popis2 />
        <Popis3 />
      </RozsirenePopisy>
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="c49b00f4-b99e-4c73-b0b8-1fb4c2803a89">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="b373d137-c1ba-4576-9e1f-d9aa1897f25e">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>25</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>231f13c8-306c-427c-ae9f-e5e55b4e5358</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00025</Kod>
      <KodCislo>25</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Folie HP1 10g/ks 435 mm celobarevna</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>202.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Folie HP1-10</Zkratka12>
      <Zkratka20>Folie HP1 10g/ks</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="231f13c8-306c-427c-ae9f-e5e55b4e5358" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="231f13c8-306c-427c-ae9f-e5e55b4e5358">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy>
        <Popis0 />
        <Popis1>
          <Popis>PET 12/PET12 metal/PE 60 mic bílá 435 mm, výtěžnost 35 bm/kg, 10g/sáček</Popis>
          <Poznamka />
        </Popis1>
        <Popis2 />
        <Popis3 />
      </RozsirenePopisy>
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="366d97f5-7bad-458f-a873-7049be401ada">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="38e22792-7b17-4c7e-8408-35eb70d9ebde">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>27</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>89ebb770-0b05-415b-a1c4-c5a1e67b6a95</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00027</Kod>
      <KodCislo>27</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Folie HP14 5g/ks 320 mm celobarevná</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>202.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Folie HP14 5</Zkratka12>
      <Zkratka20>Folie HP14 5g/ks 320</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="89ebb770-0b05-415b-a1c4-c5a1e67b6a95" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="89ebb770-0b05-415b-a1c4-c5a1e67b6a95">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="651bc95a-5928-417e-863d-baf66a9dd6e8">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="7bc1507e-571d-41b4-8da0-54b89a7f5036">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>26</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>43c0bfe8-4ca1-4ab4-ba98-220e9afad717</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00026</Kod>
      <KodCislo>26</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Folie HP2 7g/ks 435 mm celobarevná</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>202.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-06T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Folie Hp2 10</Zkratka12>
      <Zkratka20>Folie Hp2 10g/ks 435</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele>
        <SeznamDodavatelu ObjectName="ArtiklDodavatel" ObjectType="List">
          <ArtiklDodavatel ObjectName="ArtiklDodavatel" ObjectType="Object" ID="84bd826a-de19-402b-be3c-de9b76d5b71e">
            <ArtiklJednotka_ID>43c0bfe8-4ca1-4ab4-ba98-220e9afad717</ArtiklJednotka_ID>
            <CarovyKod_ID />
            <Firma_ID>cc974e65-e064-4b49-8aef-a91f25a95803</Firma_ID>
            <Jednotka_ID />
            <MinimalniObjednavka>0.0000</MinimalniObjednavka>
            <NazevFirmy>VEPAK, s.r.o.</NazevFirmy>
            <PosledniCena>202.0000</PosledniCena>
            <PosledniCenaCM>0.0000</PosledniCenaCM>
            <PosledniDodavka>2015-01-06T00:00:00</PosledniDodavka>
            <PosledniMena_ID />
            <PovinnyNasobek>0.0000</PovinnyNasobek>
            <DodaciLhuta>
              <Doba>0</Doba>
              <Typ EnumValueName="Neurceno">0</Typ>
            </DodaciLhuta>
            <DodavatelskeOznaceni />
            <Zaruka>
              <Doba>0</Doba>
              <Typ EnumValueName="Zadna">0</Typ>
            </Zaruka>
            <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="43c0bfe8-4ca1-4ab4-ba98-220e9afad717" />
            <Firma ObjectName="Firma" ObjectType="Object" ID="cc974e65-e064-4b49-8aef-a91f25a95803" />
          </ArtiklDodavatel>
        </SeznamDodavatelu>
      </Dodavatele>
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="43c0bfe8-4ca1-4ab4-ba98-220e9afad717" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="43c0bfe8-4ca1-4ab4-ba98-220e9afad717">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy>
        <Popis0 />
        <Popis1>
          <Popis>PET 12/PET12 metal/PE 60 mic bílá 435 mm, výtěžnost 35 bm/kg, 7g/sáček</Popis>
          <Poznamka />
        </Popis1>
        <Popis2 />
        <Popis3 />
      </RozsirenePopisy>
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="6dfe8c98-8ebd-4e78-89ae-3bc172e92494">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="2d9a408b-d80f-4eea-8347-d7843006f554">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>33</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>00f370f4-1038-49f8-9ab8-cf9147dcbe5a</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00033</Kod>
      <KodCislo>33</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Folie stříbro 435</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>150.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Folie stříbr</Zkratka12>
      <Zkratka20>Folie stříbro 435</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="00f370f4-1038-49f8-9ab8-cf9147dcbe5a" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="00f370f4-1038-49f8-9ab8-cf9147dcbe5a">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="66976d8a-aada-4d4a-9aaf-0a695bd43e7c">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="f817cfb5-392e-4c53-9bfb-02656d7b623d">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>32</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>192e8849-663e-4468-98f1-83b8b1c653e3</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00032</Kod>
      <KodCislo>32</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Folie zlatá 320</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>150.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Folie zlatá</Zkratka12>
      <Zkratka20>Folie zlatá 320</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="192e8849-663e-4468-98f1-83b8b1c653e3" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="192e8849-663e-4468-98f1-83b8b1c653e3">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="ecf37a6a-8610-432f-8bc1-b8241df83afb">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="b53e2845-74a9-4d4d-9dfb-470cfc2c3a14">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>31</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>18ca51f6-6693-4807-8fd2-2a0c0d849bab</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00031</Kod>
      <KodCislo>31</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Folie zlatá 435</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>150.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Folie zl-435</Zkratka12>
      <Zkratka20>Folie zlatá 435</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="18ca51f6-6693-4807-8fd2-2a0c0d849bab" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="18ca51f6-6693-4807-8fd2-2a0c0d849bab">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="56b0369f-e27f-4877-8dfc-67853a2b0da5">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="7ef6eca4-f453-45cd-91cb-ec6835a220a4">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>23</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>40eed3cb-7aac-4b31-94c2-ec1a208a2637</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00023</Kod>
      <KodCislo>23</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hořčice žlutá celá</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>12.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Hořčice žlut</Zkratka12>
      <Zkratka20>Hořčice žlutá celá</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="40eed3cb-7aac-4b31-94c2-ec1a208a2637" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="40eed3cb-7aac-4b31-94c2-ec1a208a2637">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="5fe1870a-609b-47c6-a9c0-b8dd671c3bc7">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="32326ec3-bc46-4da7-a577-8a6950f915c9">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>1</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>274b4816-7a0b-4d9e-8e5b-ac1a23c5e0ba</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00001</Kod>
      <KodCislo>1</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hrách půlený</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>11.6000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID>55ea8b91-7109-4456-9439-0229cd1f8515</SKP_ID>
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID>7503fef6-8eda-4d97-82dc-fcb9ece79cfe</Vyrobce_Firma_ID>
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Hrach-pul</Zkratka12>
      <Zkratka20>Hrach-půlený</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="274b4816-7a0b-4d9e-8e5b-ac1a23c5e0ba" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="274b4816-7a0b-4d9e-8e5b-ac1a23c5e0ba">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>1.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce>
        <Nazev>CERIA,s.r.o.</Nazev>
        <Firma ObjectName="Firma" ObjectType="Object" ID="7503fef6-8eda-4d97-82dc-fcb9ece79cfe" />
      </Vyrobce>
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="4f4d733d-becb-48fa-a68f-0378a73e5963">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <SKP ObjectName="SKP" ObjectType="Object" ID="55ea8b91-7109-4456-9439-0229cd1f8515">
        <Kod>01.11.75</Kod>
        <Nazev>Hrách, sušený</Nazev>
        <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
        <PlatnostOd>2008-01-01T00:00:00</PlatnostOd>
        <Poznamka />
      </SKP>
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="7c67bd49-9ff6-4018-b201-54848936e160">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>53</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>a28cedf0-cf72-46a3-bcba-84a0438ec15e</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>8c79b6ba-d352-43e0-a120-3f48eacf90b0</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00053</Kod>
      <KodCislo>53</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hrachová mouka</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>11.6000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-05T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Hrach mouka</Zkratka12>
      <Zkratka20>Hrachová mouka</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="8c79b6ba-d352-43e0-a120-3f48eacf90b0" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="8c79b6ba-d352-43e0-a120-3f48eacf90b0">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID />
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="a28cedf0-cf72-46a3-bcba-84a0438ec15e">
        <Kod>POL</Kod>
        <Nazev>polotovar vlastní výroby</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="1b615e55-6db6-4c75-9d6d-c88d3cb8990f">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List">
        <ArtiklSlozeni ObjectName="ArtiklSlozeni" ObjectType="Object" ID="1389f8cf-b040-4f81-8d8b-07172de3fecd">
          <Celek_ID>7c67bd49-9ff6-4018-b201-54848936e160</Celek_ID>
          <IgnorovatPomer>False</IgnorovatPomer>
          <Inverze>False</Inverze>
          <NazevPrvku>Hrách půlený</NazevPrvku>
          <PocetCelek>1.0000</PocetCelek>
          <PocetPrvek>1.0000</PocetPrvek>
          <Poradi>1</Poradi>
          <Prvek_ID>32326ec3-bc46-4da7-a577-8a6950f915c9</Prvek_ID>
          <TypVazby EnumValueName="Slozeni">0</TypVazby>
          <VlastniCenik_ID />
          <VlastniSklad_ID />
          <ZobrazovatNaVystupu>False</ZobrazovatNaVystupu>
          <Celek ObjectName="Artikl" ObjectType="Object" ID="7c67bd49-9ff6-4018-b201-54848936e160" />
          <Prvek ObjectName="Artikl" ObjectType="Object" ID="32326ec3-bc46-4da7-a577-8a6950f915c9" />
        </ArtiklSlozeni>
      </Slozeni>
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="04b91d10-944e-4b9e-908f-f117cd41bb05">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>57</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>2b587105-39c0-4918-b92b-d312935a015f</HlavniJednotka_ID>
      <Hmostnost_ID>88167435-b8d4-4657-8a8e-dc97b673af1a</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00057</Kod>
      <KodCislo>57</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hraška na obalování 1 kg</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>62.8700</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-07T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>1.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>HP - 1 kg</Zkratka12>
      <Zkratka20>HP - 1 kg</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="2b587105-39c0-4918-b92b-d312935a015f" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="2b587105-39c0-4918-b92b-d312935a015f">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="88167435-b8d4-4657-8a8e-dc97b673af1a" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="88167435-b8d4-4657-8a8e-dc97b673af1a">
            <Hodnota>1.0000</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="adb63cec-891c-4a73-97ff-a53565c6f8bf">
          <PovahaSazbyVstup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVstup_ID>
          <PovahaSazbyVystup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVystup_ID>
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
          <PovahaSazbyVstup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
          <PovahaSazbyVystup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="16312d6b-86d9-447f-aa01-2e1896dc6f0c">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>62</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>e830dab9-e85c-4b4a-aed2-b772a7890820</HlavniJednotka_ID>
      <Hmostnost_ID>962502da-4716-425a-92af-594b23cd0510</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00062</Kod>
      <KodCislo>62</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hraška na obalování 140 g</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>11.2000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-05T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.140000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>HP-140g</Zkratka12>
      <Zkratka20>HP-140g</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="e830dab9-e85c-4b4a-aed2-b772a7890820" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="e830dab9-e85c-4b4a-aed2-b772a7890820">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="962502da-4716-425a-92af-594b23cd0510" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="962502da-4716-425a-92af-594b23cd0510">
            <Hodnota>0.1400</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="de62e379-eaf6-44ad-a99e-5a30c7926aa5">
          <PovahaSazbyVstup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVstup_ID>
          <PovahaSazbyVystup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVystup_ID>
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
          <PovahaSazbyVstup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
          <PovahaSazbyVystup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="80dd9bb7-c1c0-4dac-b6b4-1639f4194537">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>58</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>d53f4446-5fc7-4b81-af9c-84a5cb55b506</HlavniJednotka_ID>
      <Hmostnost_ID>d702e327-a114-4ccf-abf3-a3ac97e45e1c</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00058</Kod>
      <KodCislo>58</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hraška na obalování 250 g</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>16.3400</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-07T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.250000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>HP-250 g</Zkratka12>
      <Zkratka20>HP-250 g</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="d53f4446-5fc7-4b81-af9c-84a5cb55b506" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="d53f4446-5fc7-4b81-af9c-84a5cb55b506">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="d702e327-a114-4ccf-abf3-a3ac97e45e1c" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="d702e327-a114-4ccf-abf3-a3ac97e45e1c">
            <Hodnota>0.2500</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="96daad46-fc7b-470f-b835-139c1c910665">
          <PovahaSazbyVstup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVstup_ID>
          <PovahaSazbyVystup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVystup_ID>
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
          <PovahaSazbyVstup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
          <PovahaSazbyVystup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="4339e67c-2325-4775-b363-af74014adaa0">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>54</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>a28cedf0-cf72-46a3-bcba-84a0438ec15e</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>b165417c-f237-479a-8c77-46ae15aac83c</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00054</Kod>
      <KodCislo>54</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hraška na obalování v BigBagu</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>1753-01-01T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>True</ZapornaCastka>
      <Zkratka12>HP - Big</Zkratka12>
      <Zkratka20>HP - Big</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="b165417c-f237-479a-8c77-46ae15aac83c" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="b165417c-f237-479a-8c77-46ae15aac83c">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID />
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="a28cedf0-cf72-46a3-bcba-84a0438ec15e">
        <Kod>POL</Kod>
        <Nazev>polotovar vlastní výroby</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="25498eb2-a1eb-4f45-8a52-50c52d252b69">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="e4e710d5-a0ac-4e70-8f08-46f06fe6ab93">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>55</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>a28cedf0-cf72-46a3-bcba-84a0438ec15e</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>53f3dc32-5859-444c-9a75-0387dc7c4a6a</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00055</Kod>
      <KodCislo>55</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hraška na zahušťováné v BigBagu</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>1753-01-01T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>HJ - Big</Zkratka12>
      <Zkratka20>HJ - Big</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="53f3dc32-5859-444c-9a75-0387dc7c4a6a" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="53f3dc32-5859-444c-9a75-0387dc7c4a6a">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID />
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="a28cedf0-cf72-46a3-bcba-84a0438ec15e">
        <Kod>POL</Kod>
        <Nazev>polotovar vlastní výroby</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="b6125933-84e3-41d5-a5d2-22aae817f349">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="04c8292f-a1ee-46aa-86d0-04f6ae65eb2a">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>63</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>5805bef8-91e5-4435-b23f-376e347033f7</HlavniJednotka_ID>
      <Hmostnost_ID>359608ee-9aa3-4e8d-9cc2-0f799bf7874d</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00063</Kod>
      <KodCislo>63</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hraška na zahušťování 1 kg</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>62.1000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-08T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>1.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>HJ - 1 kg</Zkratka12>
      <Zkratka20>HJ - 1 kg</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="5805bef8-91e5-4435-b23f-376e347033f7" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="5805bef8-91e5-4435-b23f-376e347033f7">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="359608ee-9aa3-4e8d-9cc2-0f799bf7874d" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="359608ee-9aa3-4e8d-9cc2-0f799bf7874d">
            <Hodnota>1.0000</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="311fabe9-0859-43f0-804d-6a2d1b11f2d3">
          <PovahaSazbyVstup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVstup_ID>
          <PovahaSazbyVystup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVystup_ID>
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
          <PovahaSazbyVstup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
          <PovahaSazbyVystup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="abc0e5e5-d13b-4250-8093-d0bf93383d77">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>65</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>b6503435-19d4-4ee5-aa60-78389831dd32</HlavniJednotka_ID>
      <Hmostnost_ID>c1b277f1-4b8c-4fe5-ae51-32e8ccf87db6</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00065</Kod>
      <KodCislo>65</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hraška na zahušťování 140 g</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>11.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-05T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID>55ea8b91-7109-4456-9439-0229cd1f8515</SKP_ID>
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.140000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>HJ - 140 g</Zkratka12>
      <Zkratka20>HJ - 140 g</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="b6503435-19d4-4ee5-aa60-78389831dd32" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="b6503435-19d4-4ee5-aa60-78389831dd32">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="c1b277f1-4b8c-4fe5-ae51-32e8ccf87db6" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="c1b277f1-4b8c-4fe5-ae51-32e8ccf87db6">
            <Hodnota>0.1400</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="58d10bb8-edb1-43ae-8bb2-0ac90ca0cbac">
          <PovahaSazbyVstup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVstup_ID>
          <PovahaSazbyVystup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVystup_ID>
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
          <PovahaSazbyVstup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
          <PovahaSazbyVystup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <SKP ObjectName="SKP" ObjectType="Object" ID="55ea8b91-7109-4456-9439-0229cd1f8515">
        <Kod>01.11.75</Kod>
        <Nazev>Hrách, sušený</Nazev>
        <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
        <PlatnostOd>2008-01-01T00:00:00</PlatnostOd>
        <Poznamka />
      </SKP>
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="9f0834cf-c14c-4967-b1f4-41e2e3171cae">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>64</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>e9543ba3-3d09-4156-97a8-6ed31cf8fda6</HlavniJednotka_ID>
      <Hmostnost_ID>c599a998-975b-464f-99a1-abcfea1173bb</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00064</Kod>
      <KodCislo>64</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hraška na zahušťování 250 g</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>16.1400</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-08T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.250000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>HJ - 250 g</Zkratka12>
      <Zkratka20>HJ - 250 g</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="e9543ba3-3d09-4156-97a8-6ed31cf8fda6" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="e9543ba3-3d09-4156-97a8-6ed31cf8fda6">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="c599a998-975b-464f-99a1-abcfea1173bb" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="c599a998-975b-464f-99a1-abcfea1173bb">
            <Hodnota>0.2500</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="2f93342a-b465-4f60-bf64-81331ef2bd27">
          <PovahaSazbyVstup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVstup_ID>
          <PovahaSazbyVystup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVystup_ID>
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
          <PovahaSazbyVstup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
          <PovahaSazbyVystup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="b76d2729-99b1-4dc8-83ed-cefb8a393bbc">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>56</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>a28cedf0-cf72-46a3-bcba-84a0438ec15e</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>ba81505b-4995-4200-b21c-86bb15a3d7bd</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00056</Kod>
      <KodCislo>56</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hraška vanilka v BigBagu</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>1753-01-01T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Hv - Big</Zkratka12>
      <Zkratka20>Hv - Big</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="ba81505b-4995-4200-b21c-86bb15a3d7bd" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="ba81505b-4995-4200-b21c-86bb15a3d7bd">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="a28cedf0-cf72-46a3-bcba-84a0438ec15e">
        <Kod>POL</Kod>
        <Nazev>polotovar vlastní výroby</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="54141c29-c9bc-4bc3-9703-f7f68e96de91">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="c888ef1d-78c5-48cf-825e-c93665b04235">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>66</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>34645cc6-8104-486a-8096-504d95789df0</HlavniJednotka_ID>
      <Hmostnost_ID>13f08e27-2a00-4d6d-afc5-3660f2142d08</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00066</Kod>
      <KodCislo>66</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hraška vanilka1 kg</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>65.3700</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-07T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>1.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Hv 1 kg</Zkratka12>
      <Zkratka20>Hv 1 kg</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="34645cc6-8104-486a-8096-504d95789df0" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="34645cc6-8104-486a-8096-504d95789df0">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="13f08e27-2a00-4d6d-afc5-3660f2142d08" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="13f08e27-2a00-4d6d-afc5-3660f2142d08">
            <Hodnota>1.0000</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="b0df06c1-e771-4495-87e3-af473e0dedc3">
          <PovahaSazbyVstup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVstup_ID>
          <PovahaSazbyVystup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVystup_ID>
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
          <PovahaSazbyVstup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
          <PovahaSazbyVystup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="b16c87b2-58f9-4e40-baf7-9dd9eb635f9c">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>67</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>93cabb0a-b14f-4c4a-ad5d-586c1eedadf1</HlavniJednotka_ID>
      <Hmostnost_ID>8c1b7f52-4082-417f-a5c7-30af2307f411</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00067</Kod>
      <KodCislo>67</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Hraška vanilkaí 250 g</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>17.3400</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-07T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.250000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Hv 250 g</Zkratka12>
      <Zkratka20>Hv 250 g</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="93cabb0a-b14f-4c4a-ad5d-586c1eedadf1" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="93cabb0a-b14f-4c4a-ad5d-586c1eedadf1">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="8c1b7f52-4082-417f-a5c7-30af2307f411" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="8c1b7f52-4082-417f-a5c7-30af2307f411">
            <Hodnota>0.2500</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="4f0b5144-538a-4560-a0b8-ada60aa900a7">
          <PovahaSazbyVstup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVstup_ID>
          <PovahaSazbyVystup_ID>f67fc64e-f5f1-4f65-aef3-6bc69f0951aa</PovahaSazbyVystup_ID>
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
          <PovahaSazbyVstup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
          <PovahaSazbyVystup ObjectName="PovahaSazbyDPH" ObjectType="Object" ID="f67fc64e-f5f1-4f65-aef3-6bc69f0951aa" />
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="2450f535-c68d-48ec-944c-3576293fd963">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>41</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>0702de2f-0385-4b02-8ee6-bfa15ceb57ee</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00041</Kod>
      <KodCislo>41</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Chilli mleté</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>50.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Chilli mleté</Zkratka12>
      <Zkratka20>Chilli mleté</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="0702de2f-0385-4b02-8ee6-bfa15ceb57ee" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="0702de2f-0385-4b02-8ee6-bfa15ceb57ee">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="0bab9a89-e272-4c11-8daa-b008e4355371">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="39f0537b-bbda-4540-978f-464ad7a670b3">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>5</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>f6b9167d-9d2b-49e4-bda3-44776f927701</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00005</Kod>
      <KodCislo>5</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Ječmen - kroupy 10</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>10.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Ječmen - kro</Zkratka12>
      <Zkratka20>Ječmen - kroupy 10</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="f6b9167d-9d2b-49e4-bda3-44776f927701" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="f6b9167d-9d2b-49e4-bda3-44776f927701">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID />
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="f919848e-62da-429f-a9bf-b3883e2c6cc5">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="30b3fcae-1c3c-4d4c-87eb-73909668eebe">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>38</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>8970b590-bc14-46ec-92f9-ce67d402a095</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00038</Kod>
      <KodCislo>38</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Karton HR-10kg</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>1.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Karton HR-10</Zkratka12>
      <Zkratka20>Karton HR-10kg</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="8970b590-bc14-46ec-92f9-ce67d402a095" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="8970b590-bc14-46ec-92f9-ce67d402a095">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="ccf4ddc0-b1b9-4df1-8371-a318d56a6158">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="6b79f579-785c-491f-83a1-74d99d69b2ed">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>39</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>9cfed1b0-3bb7-4c04-96f2-d9bc9dff9873</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00039</Kod>
      <KodCislo>39</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Karton HR-2kg Supermarkety</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>5.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Karton HR-2k</Zkratka12>
      <Zkratka20>Karton HR-2kg Superm</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="9cfed1b0-3bb7-4c04-96f2-d9bc9dff9873" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="9cfed1b0-3bb7-4c04-96f2-d9bc9dff9873">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="40b7a223-81e2-47f6-b254-43f60d7b8e32">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="0ad82a0d-f2b7-430b-af05-30d54708fc3a">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>40</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>640f1af6-82b4-4575-8767-111163790995</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>6e6cdf14-fa65-4ecb-956d-1b1b213b54cf</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00040</Kod>
      <KodCislo>40</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Karton Maha 2kg</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>1.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Karton Maha</Zkratka12>
      <Zkratka20>Karton Maha 2kg</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="6e6cdf14-fa65-4ecb-956d-1b1b213b54cf" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="6e6cdf14-fa65-4ecb-956d-1b1b213b54cf">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="640f1af6-82b4-4575-8767-111163790995">
        <Kod>OBA</Kod>
        <Nazev>obaly</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="83986cf0-4dac-4913-9202-a204b8f117ab">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="288de974-1606-4124-8412-71ede6dcee21">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>22</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>af042706-4d37-405a-9c9e-4345238ac5fb</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00022</Kod>
      <KodCislo>22</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Kmín celý</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>45.5500</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Kmín celý</Zkratka12>
      <Zkratka20>Kmín celý</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="af042706-4d37-405a-9c9e-4345238ac5fb" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="af042706-4d37-405a-9c9e-4345238ac5fb">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="3818344b-1f8e-4161-a0ad-512809cdd3e4">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="093a483a-37da-4b02-9a48-e7964c182c0d">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>24</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>0b812fc9-029b-4eed-aade-04d9c3caa73a</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00024</Kod>
      <KodCislo>24</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Koriadr celý</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>32.2000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Koriadr celý</Zkratka12>
      <Zkratka20>Koriadr celý</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="0b812fc9-029b-4eed-aade-04d9c3caa73a" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="0b812fc9-029b-4eed-aade-04d9c3caa73a">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="16d93ac5-e7c7-4b09-9223-2f1d2604129a">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="5c0e97ec-9791-4a09-945a-14c65e6368d5">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>3</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>72b63850-6184-496b-975c-3a79189e0772</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00003</Kod>
      <KodCislo>3</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Kukuřičná mouka bílá</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>16.5000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID>f093ad0a-0ee7-42a8-b857-2ca211e056a5</SKP_ID>
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Kuk-mo-bila</Zkratka12>
      <Zkratka20>Kukuřičná mouka bílá</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="72b63850-6184-496b-975c-3a79189e0772" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="72b63850-6184-496b-975c-3a79189e0772">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="f07b9c37-a887-401c-b9d2-1ad6706d71fe">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <SKP ObjectName="SKP" ObjectType="Object" ID="f093ad0a-0ee7-42a8-b857-2ca211e056a5">
        <Group ID="2ccbb3fa-9a8f-4ab9-bfb2-b3894a0eba04" Kod="01" />
        <Kod>11.08.12.00</Kod>
        <Nazev>Kukuřičný škrob</Nazev>
        <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
        <PlatnostOd>1753-01-01T00:00:00</PlatnostOd>
        <Poznamka />
      </SKP>
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="1c5a81ba-bcdb-466c-a23b-fbf78c1c9310">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>2</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>8aa54033-ca76-42a3-b31f-19c5b465b239</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00002</Kod>
      <KodCislo>2</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Kukuřičná mouka žlutá</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>30.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID>5ee5d9fb-13cf-47b6-b78c-57fa0ea6b261</SKP_ID>
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Kukur-m-zlut</Zkratka12>
      <Zkratka20>Kukuřič. mouka žlutá</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="8aa54033-ca76-42a3-b31f-19c5b465b239" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="8aa54033-ca76-42a3-b31f-19c5b465b239">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="ee07f508-9803-4b02-9ca1-f0c7df0672d4">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <SKP ObjectName="SKP" ObjectType="Object" ID="5ee5d9fb-13cf-47b6-b78c-57fa0ea6b261">
        <Kod>01.11.2</Kod>
        <Nazev>Kukuřice</Nazev>
        <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
        <PlatnostOd>2008-01-01T00:00:00</PlatnostOd>
        <Poznamka />
      </SKP>
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="9090b91a-2594-4658-9e55-46081b28e0bd">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>12</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>5b909445-7ccc-4641-adf9-a163f8582bac</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00012</Kod>
      <KodCislo>12</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Kurkuma</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>62.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Kurkuma</Zkratka12>
      <Zkratka20>Kurkuma</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="5b909445-7ccc-4641-adf9-a163f8582bac" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="5b909445-7ccc-4641-adf9-a163f8582bac">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="d94c5e32-7ac3-436e-8ce0-94dd6ca2895b">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="626ff398-4061-401d-ac9f-08d2bae756c3">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>48</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>5baea9f9-6175-45ae-9d9a-e483be64ef89</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>9f52cbca-b5d7-4ca1-a209-2560eb79ee6c</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00048</Kod>
      <KodCislo>48</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Leták Být či nebýt vegetariánem</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>10.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Leták Být či</Zkratka12>
      <Zkratka20>Leták Být či nebýt</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="9f52cbca-b5d7-4ca1-a209-2560eb79ee6c" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="9f52cbca-b5d7-4ca1-a209-2560eb79ee6c">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="5baea9f9-6175-45ae-9d9a-e483be64ef89">
        <Kod>KNI</Kod>
        <Nazev>Knihy</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="600d43d9-174d-4540-8106-f0cba7fe6757">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="d1a49f52-6bab-439a-9699-1d00dc89d1ca">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>44</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>65a06aea-5834-4955-8f71-38d73bb42a93</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>c731a43f-0bb7-4964-b08c-334b3a226071</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00044</Kod>
      <KodCislo>44</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Leták Hraška AJ</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.9000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Leták Hr-AJ</Zkratka12>
      <Zkratka20>Leták Hraška AJ</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="c731a43f-0bb7-4964-b08c-334b3a226071" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="c731a43f-0bb7-4964-b08c-334b3a226071">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="65a06aea-5834-4955-8f71-38d73bb42a93">
        <Kod>LET</Kod>
        <Nazev>Letáky</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="e57b6e19-7d15-4fc1-944b-c0afdc7749a7">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="05c105b2-80e3-4cc6-b56b-dd2312c1df2a">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>43</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>65a06aea-5834-4955-8f71-38d73bb42a93</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>2ddb2c84-4a47-41dc-bb1f-69a6d3427464</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00043</Kod>
      <KodCislo>43</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Leták Hraška CZ</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.7000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Leták Hr-CZ</Zkratka12>
      <Zkratka20>Leták Hraška CZ</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="2ddb2c84-4a47-41dc-bb1f-69a6d3427464" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="2ddb2c84-4a47-41dc-bb1f-69a6d3427464">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="65a06aea-5834-4955-8f71-38d73bb42a93">
        <Kod>LET</Kod>
        <Nazev>Letáky</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="2e76d052-a869-4751-9053-b850c6fa49aa">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="7923b68d-4212-4253-87c8-6955b83bdfaa">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>45</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>65a06aea-5834-4955-8f71-38d73bb42a93</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>e2527bfa-742d-4f27-af7a-260771c70ccf</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00045</Kod>
      <KodCislo>45</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Leták Hraška DE</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.9000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Leták Hr-DE</Zkratka12>
      <Zkratka20>Leták Hraška DE</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="e2527bfa-742d-4f27-af7a-260771c70ccf" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="e2527bfa-742d-4f27-af7a-260771c70ccf">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="65a06aea-5834-4955-8f71-38d73bb42a93">
        <Kod>LET</Kod>
        <Nazev>Letáky</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="8dd8b633-b190-4e87-bde0-529c118f8ceb">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="8b6ab465-5b84-4c57-bcc4-a7e3a0ec6095">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>46</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>65a06aea-5834-4955-8f71-38d73bb42a93</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>c0e60323-2f03-4326-8674-d7cf591f89e5</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00046</Kod>
      <KodCislo>46</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Leták Hraška IT</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.9000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Leták Hr-IT</Zkratka12>
      <Zkratka20>Leták Hraška IT</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="c0e60323-2f03-4326-8674-d7cf591f89e5" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="c0e60323-2f03-4326-8674-d7cf591f89e5">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="65a06aea-5834-4955-8f71-38d73bb42a93">
        <Kod>LET</Kod>
        <Nazev>Letáky</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="0317f8ff-1212-4303-badd-1831c66b36d6">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="844e8b64-ea76-4bc7-a46d-4cb768b2b793">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>47</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>65a06aea-5834-4955-8f71-38d73bb42a93</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>3d4d2927-5b71-437d-adfb-7a9d00a48bca</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00047</Kod>
      <KodCislo>47</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Leták Hraška PL</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.9000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Leták Hr-PL</Zkratka12>
      <Zkratka20>Leták Hraška PL</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="3d4d2927-5b71-437d-adfb-7a9d00a48bca" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="3d4d2927-5b71-437d-adfb-7a9d00a48bca">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="65a06aea-5834-4955-8f71-38d73bb42a93">
        <Kod>LET</Kod>
        <Nazev>Letáky</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="fe8c169f-4a00-45ee-8009-6fa210250d94">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="4dd808bc-e86a-4100-ab3c-5df3fe096aed">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>68</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>acea3b28-8d37-4aa5-8485-befb12c11f3e</HlavniJednotka_ID>
      <Hmostnost_ID>3c933d26-6daa-472b-9234-97138fae6cb2</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00068</Kod>
      <KodCislo>68</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Mahá koření 100 g</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>13.6400</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-07T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.100000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Mahá100 g</Zkratka12>
      <Zkratka20>Mahá koření 100 g</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="acea3b28-8d37-4aa5-8485-befb12c11f3e" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="acea3b28-8d37-4aa5-8485-befb12c11f3e">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="3c933d26-6daa-472b-9234-97138fae6cb2" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="3c933d26-6daa-472b-9234-97138fae6cb2">
            <Hodnota>0.1000</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="2b4b29ea-9554-47ea-9fc5-af7bc0f0689d">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="7a3fc2d9-e414-4bb5-bb92-9f378a362530">
      <Group ID="9726e3df-6dec-4574-b193-c5bdc61a918b" Kod="VYROBKY" />
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>69</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>56950eaa-2c54-4530-a7b1-38692d92659f</HlavniJednotka_ID>
      <Hmostnost_ID>21dd7746-2973-4a88-be6a-dc8cbe65456f</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>b75d391e-a22b-42cb-903c-45c609f98aa3</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00069</Kod>
      <KodCislo>69</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Mahá koření 500 g</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>49.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-05T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.500000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Mahá koření</Zkratka12>
      <Zkratka20>Mahá koření 500 g</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="56950eaa-2c54-4530-a7b1-38692d92659f" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="56950eaa-2c54-4530-a7b1-38692d92659f">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="21dd7746-2973-4a88-be6a-dc8cbe65456f" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="21dd7746-2973-4a88-be6a-dc8cbe65456f">
            <Hodnota>0.5000</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04">
        <Kod>VYR</Kod>
        <Nazev>výrobek vlastní</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="7fe8c4fe-fccc-4d1b-b4fb-23d9408015c5">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="abfc4118-ec60-426d-8aa6-57c8a37677e3">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>20</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>fda263d3-a1ee-4b83-9bc8-03ad51900d63</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00020</Kod>
      <KodCislo>20</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Nové koření celé</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>167.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Nové koření</Zkratka12>
      <Zkratka20>Nové koření celé</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="fda263d3-a1ee-4b83-9bc8-03ad51900d63" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="fda263d3-a1ee-4b83-9bc8-03ad51900d63">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="af683273-5be2-4449-b4d6-7287ab19b584">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="78d02913-bf5b-4eaa-8653-d94252dfaa12">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>18</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>b5f7083e-ebe8-4fe6-bf84-8e39b3dcb261</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00018</Kod>
      <KodCislo>18</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Oregáno</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>115.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Oregáno</Zkratka12>
      <Zkratka20>Oregáno</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="b5f7083e-ebe8-4fe6-bf84-8e39b3dcb261" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="b5f7083e-ebe8-4fe6-bf84-8e39b3dcb261">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="39ad67d2-8625-4a8c-ad92-ca5eab2dd71b">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="fbb81f19-9ebd-4156-bf57-5f89ca74a57e">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>7</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>0bd0031b-d210-4c6a-b4c9-bd73a36ac5e3</HlavniJednotka_ID>
      <Hmostnost_ID>649ab26e-5663-4232-bbde-3f8b2f014d09</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00007</Kod>
      <KodCislo>7</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Palmový olej 10 l</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>32.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>9.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Palmový olej</Zkratka12>
      <Zkratka20>Palmový olej</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="0bd0031b-d210-4c6a-b4c9-bd73a36ac5e3" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="0bd0031b-d210-4c6a-b4c9-bd73a36ac5e3">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e16e715a-bc93-4e52-9451-83fd92001074</Jednotka_ID>
            <Kod>l</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e16e715a-bc93-4e52-9451-83fd92001074">
              <Group ID="c55af5a4-a243-451e-9df0-ba3158c46e44" Kod="V" />
              <DesMisto>3</DesMisto>
              <Kod>l</Kod>
              <Nazev>litr</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="092f5bca-ce73-45d6-82eb-237d1e43730d">
                  <Cil_ID>e16e715a-bc93-4e52-9451-83fd92001074</Cil_ID>
                  <CilPocet>158.987300</CilPocet>
                  <Zdroj_ID>ce86500c-4bdb-4077-9749-eee7136d27aa</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="e16e715a-bc93-4e52-9451-83fd92001074" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="ce86500c-4bdb-4077-9749-eee7136d27aa" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c999d870-cc6c-43ca-a0e7-2bb72c366302">
                  <Cil_ID>e16e715a-bc93-4e52-9451-83fd92001074</Cil_ID>
                  <CilPocet>4.546100</CilPocet>
                  <Zdroj_ID>5d5b1b7a-37aa-4e4d-8d79-001f420140b4</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="e16e715a-bc93-4e52-9451-83fd92001074" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="5d5b1b7a-37aa-4e4d-8d79-001f420140b4" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="d2dcd85b-4de4-4dba-8dc1-68d16a286c08">
                  <Cil_ID>e16e715a-bc93-4e52-9451-83fd92001074</Cil_ID>
                  <CilPocet>3.785400</CilPocet>
                  <Zdroj_ID>df078fd5-41ee-41e2-bebd-f65ddb7497e3</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="e16e715a-bc93-4e52-9451-83fd92001074" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="df078fd5-41ee-41e2-bebd-f65ddb7497e3" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="5905edc2-7764-4b95-859c-dc84e2ed42bf">
                  <Cil_ID>e16e715a-bc93-4e52-9451-83fd92001074</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>fab29c9b-70fd-4227-bb07-926e429694d5</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="e16e715a-bc93-4e52-9451-83fd92001074" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="fab29c9b-70fd-4227-bb07-926e429694d5" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="f9c7bf1e-d01f-4c28-b01b-8d41b4d0acfa">
                  <Cil_ID>b4b78872-5aa8-4d03-8413-da4f840a1fc9</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>e16e715a-bc93-4e52-9451-83fd92001074</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b4b78872-5aa8-4d03-8413-da4f840a1fc9" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="e16e715a-bc93-4e52-9451-83fd92001074" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="555a8d65-1c80-4360-86c8-9b3de55684a9">
                  <Cil_ID>f244209f-840e-42e6-8bce-b6cb14f0c0bd</Cil_ID>
                  <CilPocet>10.000000</CilPocet>
                  <Zdroj_ID>e16e715a-bc93-4e52-9451-83fd92001074</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="f244209f-840e-42e6-8bce-b6cb14f0c0bd" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="e16e715a-bc93-4e52-9451-83fd92001074" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="649ab26e-5663-4232-bbde-3f8b2f014d09" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="649ab26e-5663-4232-bbde-3f8b2f014d09">
            <Hodnota>0.9000</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="a9c03b9f-6d09-4f2f-a2b8-88e3f7b01cc6">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Snizena">0</SazbaVstup>
          <SazbaVystup EnumValueName="Snizena">0</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="a5319a0a-2c72-4a77-b579-1c184a80a698">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>14</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>53301719-3d52-4e69-9f65-13c4851a9a8c</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00014</Kod>
      <KodCislo>14</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Paprika p-50.000-WS</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>890.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Paprika p-50</Zkratka12>
      <Zkratka20>Paprika p-50.000-WS</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="53301719-3d52-4e69-9f65-13c4851a9a8c" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="53301719-3d52-4e69-9f65-13c4851a9a8c">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID />
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="d6582df3-f41c-4ef2-94d6-8be18fc088a3">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="b213f596-d70b-4e85-9ef6-01f9bc5a09ef">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>13</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>6dea3ed8-7edf-46c0-8a98-a6416f782374</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00013</Kod>
      <KodCislo>13</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Paprika sladká</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>110.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Paprika slad</Zkratka12>
      <Zkratka20>Paprika sladká</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="6dea3ed8-7edf-46c0-8a98-a6416f782374" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="6dea3ed8-7edf-46c0-8a98-a6416f782374">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="ea3df3f5-4f3a-4899-b1ef-a5b613d1b7a3">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="66f32438-2a16-4ee0-90b2-46894192274f">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>42</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>b8d423ff-c7ff-4a5e-89d3-38d955e44e44</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00042</Kod>
      <KodCislo>42</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Pepř celý</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>150.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Pepř celý</Zkratka12>
      <Zkratka20>Pepř celý</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="b8d423ff-c7ff-4a5e-89d3-38d955e44e44" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="b8d423ff-c7ff-4a5e-89d3-38d955e44e44">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="87b2eabc-22b2-487e-92b3-0538dc056139">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="494d4cd8-e4ff-40e2-95f8-5ae9d8f49f79">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>4</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>0da9bf87-4d8d-4e88-82cb-6940daa47afd</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00004</Kod>
      <KodCislo>4</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Pšenice</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>4.2000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID>b6145983-666a-4e6d-a64f-f78fe9809351</SKP_ID>
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Pšenice</Zkratka12>
      <Zkratka20>Pšenice</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="0da9bf87-4d8d-4e88-82cb-6940daa47afd" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="0da9bf87-4d8d-4e88-82cb-6940daa47afd">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="521a430c-e951-493e-8b78-4333c8707500">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <SKP ObjectName="SKP" ObjectType="Object" ID="b6145983-666a-4e6d-a64f-f78fe9809351">
        <Kod>01.11.1</Kod>
        <Nazev>Pšenice</Nazev>
        <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
        <PlatnostOd>2008-01-01T00:00:00</PlatnostOd>
        <Poznamka>01.11.1</Poznamka>
      </SKP>
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="6ced151b-a3e0-4867-8570-c1d6c9b7a0fd">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>6</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>6e5335e5-667c-4bb7-952a-e7dd820c9a4f</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00006</Kod>
      <KodCislo>6</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Pšeničná bílkovina vitální</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>35.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID>07a1cb9b-edcd-4a66-94fd-e889b263eb5f</SKP_ID>
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Lepek vitáln</Zkratka12>
      <Zkratka20>Lepek vitální</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="6e5335e5-667c-4bb7-952a-e7dd820c9a4f" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="6e5335e5-667c-4bb7-952a-e7dd820c9a4f">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="daff3d8e-565e-49c6-b212-a1ed499f5c39">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <SKP ObjectName="SKP" ObjectType="Object" ID="07a1cb9b-edcd-4a66-94fd-e889b263eb5f">
        <Kod>10.62.11</Kod>
        <Nazev>Škroby; inulin; pšeničný lepek; dextriny a jiné modifikované škroby</Nazev>
        <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
        <PlatnostOd>2008-01-01T00:00:00</PlatnostOd>
        <Poznamka>15.62.22</Poznamka>
      </SKP>
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="001022c4-fb57-4187-aff5-65549247b3f3">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>59</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>a28cedf0-cf72-46a3-bcba-84a0438ec15e</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>51e634b9-3667-4650-94e6-18def21336ae</HlavniJednotka_ID>
      <Hmostnost_ID>956e88cb-7dfc-4b61-8699-7aa0c7e080d1</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00059</Kod>
      <KodCislo>59</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Směs B - HP+HJ</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>1.9180</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-05T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Směs B-HP+HJ</Zkratka12>
      <Zkratka20>Směs B - HP+HJ</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="51e634b9-3667-4650-94e6-18def21336ae" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="51e634b9-3667-4650-94e6-18def21336ae">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>70013bed-77eb-4c80-9e37-9e0f2ea0050b</Jednotka_ID>
            <Kod>na_kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="70013bed-77eb-4c80-9e37-9e0f2ea0050b">
              <Group ID="350843fa-1e97-4d75-a86d-27f43850b549" Kod="S" />
              <DesMisto>0</DesMisto>
              <Kod>na_kg</Kod>
              <Nazev>na_kg </Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="956e88cb-7dfc-4b61-8699-7aa0c7e080d1" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="956e88cb-7dfc-4b61-8699-7aa0c7e080d1">
            <Hodnota>0.1230</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="a28cedf0-cf72-46a3-bcba-84a0438ec15e">
        <Kod>POL</Kod>
        <Nazev>polotovar vlastní výroby</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="0f7c5599-a7b3-4d3b-b146-d58b707b1eaa">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="647f94cb-5de9-4897-a33f-d7c8d39c38e0">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>60</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>a28cedf0-cf72-46a3-bcba-84a0438ec15e</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>fa4af8da-9edf-46a1-b4e8-d263276c5edb</HlavniJednotka_ID>
      <Hmostnost_ID>1686eb7c-f58e-44bc-9d23-494291f31f3c</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00060</Kod>
      <KodCislo>60</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Směs B - Hv</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>2.5380</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-05T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Směs B - Hv</Zkratka12>
      <Zkratka20>Směs B - Hv</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="fa4af8da-9edf-46a1-b4e8-d263276c5edb" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="fa4af8da-9edf-46a1-b4e8-d263276c5edb">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>70013bed-77eb-4c80-9e37-9e0f2ea0050b</Jednotka_ID>
            <Kod>na_kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="70013bed-77eb-4c80-9e37-9e0f2ea0050b">
              <Group ID="350843fa-1e97-4d75-a86d-27f43850b549" Kod="S" />
              <DesMisto>0</DesMisto>
              <Kod>na_kg</Kod>
              <Nazev>na_kg </Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="1686eb7c-f58e-44bc-9d23-494291f31f3c" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="1686eb7c-f58e-44bc-9d23-494291f31f3c">
            <Hodnota>0.1620</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="a28cedf0-cf72-46a3-bcba-84a0438ec15e">
        <Kod>POL</Kod>
        <Nazev>polotovar vlastní výroby</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="8dbe69fa-0282-41f0-8870-9913b7132c39">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="254dcfa3-10cc-41e2-b94a-9767734ff7c6">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>61</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>a28cedf0-cf72-46a3-bcba-84a0438ec15e</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>3fcc1f84-9547-4850-a681-5742b4718220</HlavniJednotka_ID>
      <Hmostnost_ID>87d6a1d1-52e0-4732-8b98-026c0bf932c7</Hmostnost_ID>
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00061</Kod>
      <KodCislo>61</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Směs K - HP</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>1.5740</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-05T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Směs K - HP</Zkratka12>
      <Zkratka20>Směs K - HP</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="3fcc1f84-9547-4850-a681-5742b4718220" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="3fcc1f84-9547-4850-a681-5742b4718220">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>70013bed-77eb-4c80-9e37-9e0f2ea0050b</Jednotka_ID>
            <Kod>na_kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="70013bed-77eb-4c80-9e37-9e0f2ea0050b">
              <Group ID="350843fa-1e97-4d75-a86d-27f43850b549" Kod="S" />
              <DesMisto>0</DesMisto>
              <Kod>na_kg</Kod>
              <Nazev>na_kg </Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery>
        <Hmotnost ObjectName="ArtiklRozmer" ObjectType="Object" ID="87d6a1d1-52e0-4732-8b98-026c0bf932c7" />
        <SeznamRozmeru ObjectName="ArtiklRozmer" ObjectType="List">
          <ArtiklRozmer ObjectName="ArtiklRozmer" ObjectType="Object" ID="87d6a1d1-52e0-4732-8b98-026c0bf932c7">
            <Hodnota>0.0198</Hodnota>
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Velicina_ID>76abc699-1574-48ef-acca-b070b3665279</Velicina_ID>
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <Velicina ObjectName="Velicina" ObjectType="Object" ID="76abc699-1574-48ef-acca-b070b3665279">
              <Kod>m</Kod>
              <Nazev>hmotnost</Nazev>
              <Poznamka />
              <JednotkyList ObjectName="VelicinaJednotkaVazba" ObjectType="List" />
            </Velicina>
          </ArtiklRozmer>
        </SeznamRozmeru>
      </Rozmery>
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="a28cedf0-cf72-46a3-bcba-84a0438ec15e">
        <Kod>POL</Kod>
        <Nazev>polotovar vlastní výroby</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="14702400-ba2b-4876-bd89-82e1f78946a6">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="db2ee0c9-2503-428d-bf90-6f685ba69826">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>9</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>8b85bb05-7f50-4765-ba92-d951af3b9433</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00009</Kod>
      <KodCislo>9</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Sůl KCl</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>29.7000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Sůl KCl</Zkratka12>
      <Zkratka20>Sůl KCl</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="8b85bb05-7f50-4765-ba92-d951af3b9433" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="8b85bb05-7f50-4765-ba92-d951af3b9433">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="05ed8189-7214-4912-8be8-e5bf58f64cbc">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="51cc51f0-ff3d-42ba-a341-62f9bb8a3397">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>8</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>d8ff4098-0d86-4017-b91e-5dbaa8650467</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00008</Kod>
      <KodCislo>8</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Sůl NaCl</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>2.8800</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Sůl NaCl</Zkratka12>
      <Zkratka20>Sůl NaCl</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="d8ff4098-0d86-4017-b91e-5dbaa8650467" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="d8ff4098-0d86-4017-b91e-5dbaa8650467">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="8ba41b92-c1e7-4aad-a16f-f19f43ee1a3c">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="111ea696-89db-4b93-acf7-a72dad5d986f">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>50</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>43ec9118-6968-4ed2-9e77-9571bd271316</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>b1bb455d-0027-45c0-a4d6-b95d2d1fc1d2</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00050</Kod>
      <KodCislo>50</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Ubrousky</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>1753-01-01T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Ubrousky</Zkratka12>
      <Zkratka20>Ubrousky</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="b1bb455d-0027-45c0-a4d6-b95d2d1fc1d2" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="b1bb455d-0027-45c0-a4d6-b95d2d1fc1d2">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="43ec9118-6968-4ed2-9e77-9571bd271316">
        <Kod>HYG</Kod>
        <Nazev>Hygienické potřeby</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="6f523e46-37c0-4b4a-a62e-cc3f2f8d5063">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="745b88da-a22e-4090-9778-25d1776406a3">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>49</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>43ec9118-6968-4ed2-9e77-9571bd271316</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>False</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>04a5f9b3-12c1-4786-92a5-dc2541c05759</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie />
      <KategorieEEZ_ID />
      <Kod>ART00049</Kod>
      <KodCislo>49</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Utěrky </Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>0.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>1753-01-01T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="VyrobniSerie">2</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Utěrky</Zkratka12>
      <Zkratka20>Utěrky</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="04a5f9b3-12c1-4786-92a5-dc2541c05759" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="04a5f9b3-12c1-4786-92a5-dc2541c05759">
            <DesetinnaMista>0</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>e604a0fa-c14a-40ca-97ab-c92b2ce618ef</Jednotka_ID>
            <Kod>ks</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Logisticka">0</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef">
              <DesMisto>0</DesMisto>
              <Kod>ks</Kod>
              <Nazev>kus</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="LogiJednotka">4</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List" />
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="43ec9118-6968-4ed2-9e77-9571bd271316">
        <Kod>HYG</Kod>
        <Nazev>Hygienické potřeby</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="57b4401c-31b3-4dd4-8051-6f17c2c7dacd">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="4df64f96-ec6f-4bb5-afc1-88e2a1c18b9c">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>15</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>a04e2968-5f43-4562-8767-dc750273d496</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00015</Kod>
      <KodCislo>15</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Vanilka přírodní - chuť</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>1461.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Vanilka přír</Zkratka12>
      <Zkratka20>Vanilka přírodní - c</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="a04e2968-5f43-4562-8767-dc750273d496" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="a04e2968-5f43-4562-8767-dc750273d496">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="0fd9852c-7ad7-4706-8381-96f356017659">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
    <Artikl ObjectName="Artikl" ObjectType="Object" ID="c30597d4-d408-4ba8-9f2b-b9f862af2577">
      <Attachment_ID />
      <Baleni />
      <CarovyKod />
      <CarovyKodCislo>0</CarovyKodCislo>
      <CarovyKodTyp EnumValueName="Netisknout">0</CarovyKodTyp>
      <CisloS3>21</CisloS3>
      <Delka_ID />
      <DodaciPodminkyOdeslani_ID />
      <DodaciPodminkyPrijeti_ID />
      <DoplnkovaJednotka_ID />
      <DruhArtiklu_ID>9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1</DruhArtiklu_ID>
      <DruhBaleni_ID />
      <DruhDopravyOdeslani_ID />
      <DruhDopravyPrijeti_ID />
      <DruhObalu_ID />
      <DruhPrislusenstvi_ID />
      <ExistujeKategorie>True</ExistujeKategorie>
      <HlavniDodavatel_ID />
      <HlavniJednotka_ID>70bfe983-e0e1-40cb-9a7e-46a07525dc15</HlavniJednotka_ID>
      <Hmostnost_ID />
      <IntrastatNeslucovat>False</IntrastatNeslucovat>
      <Katalog />
      <KatalogCislo>0</KatalogCislo>
      <Kategorie>bf73bc4e-1703-47b2-b99d-9f67940cf426</Kategorie>
      <KategorieEEZ_ID />
      <Kod>ART00021</Kod>
      <KodCislo>21</KodCislo>
      <KombinovanaNomenklatura_ID />
      <KrajPuvodu_ID />
      <KrajUrceni_ID />
      <MinimalniObjednavka>0.0000</MinimalniObjednavka>
      <MnozstviVDoplnkove>0.0000</MnozstviVDoplnkove>
      <NadrazenyArtikl_ID />
      <NakupniJednotka_ID />
      <Nazev>Zázvor mletý</Nazev>
      <NepodlehaDPH>False</NepodlehaDPH>
      <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
      <NoveVygenerovanaVarianta>False</NoveVygenerovanaVarianta>
      <ObchodniNazev />
      <Objem_ID />
      <OddelovacParametruVKoduVariant />
      <Plocha_ID />
      <PLU />
      <PLUCislo>0</PLUCislo>
      <Popis />
      <PosledniCena>155.0000</PosledniCena>
      <PosledniCenaCM>0.0000</PosledniCenaCM>
      <PosledniDodavka>2015-01-02T00:00:00</PosledniDodavka>
      <PosledniMena_ID />
      <PovahaTransakceOdeslani_ID />
      <PovahaTransakcePrijeti_ID />
      <PovinnyNasobek>0.0000</PovinnyNasobek>
      <Poznamka />
      <PreneseniDane_ID />
      <PreneseniDaneKN />
      <PreneseniDaneMnozstvi>0.0000</PreneseniDaneMnozstvi>
      <PrilepovatKodZaKodKarty>False</PrilepovatKodZaKodKarty>
      <PripojitParametryKBaleni>False</PripojitParametryKBaleni>
      <PripojitParametryKeKatalogu>False</PripojitParametryKeKatalogu>
      <PripojitParametryKeZkratka12>False</PripojitParametryKeZkratka12>
      <PripojitParametryKeZkratka20>False</PripojitParametryKeZkratka20>
      <PripojitParametryKeZnacce>False</PripojitParametryKeZnacce>
      <PripojitParametryKNazvu>False</PripojitParametryKNazvu>
      <PripojitParametryKObchJmenu>False</PripojitParametryKObchJmenu>
      <PripojitParametryKPopisu>False</PripojitParametryKPopisu>
      <PripojitParametryKVariante>False</PripojitParametryKVariante>
      <ProdejniJednotka_ID />
      <PuvodemMajetek>False</PuvodemMajetek>
      <RadaCarovyKod_ID />
      <RadaDetail_ID />
      <RadaKatalog_ID />
      <RadaKod_ID>033783cf-fb11-444c-9342-438b1ba69548</RadaKod_ID>
      <RadaPLU_ID />
      <RETELA>False</RETELA>
      <Sirka_ID />
      <SKP_ID />
      <SmazatOstatniCinnosti>False</SmazatOstatniCinnosti>
      <SmazatOstatniDodavatele>False</SmazatOstatniDodavatele>
      <SmazatOstatniJednotky>False</SmazatOstatniJednotky>
      <SmazatOstatniKategorie>False</SmazatOstatniKategorie>
      <SmazatOstatniKody>False</SmazatOstatniKody>
      <SmazatOstatniOdberatele>False</SmazatOstatniOdberatele>
      <SmazatOstatniParametry>False</SmazatOstatniParametry>
      <SmazatOstatniProduktoveKlice>False</SmazatOstatniProduktoveKlice>
      <SmazatOstatniRozmery>False</SmazatOstatniRozmery>
      <SmazatOstatniSazbyDPH>False</SmazatOstatniSazbyDPH>
      <StatistickyZnak_ID />
      <StatOdeslani_ID />
      <StatPuvodu_ID />
      <StatUrceni_ID />
      <TypArtiklu EnumValueName="Jednoduchy">0</TypArtiklu>
      <TypEvidence EnumValueName="Exspirace">3</TypEvidence>
      <Varianta />
      <VlastniHmotnost>0.000000</VlastniHmotnost>
      <Vyrobce_Firma_ID />
      <Vyska_ID />
      <ZapornaCastka>False</ZapornaCastka>
      <Zkratka12>Zázvor mletý</Zkratka12>
      <Zkratka20>Zázvor mletý</Zkratka20>
      <Znacka />
      <ZvlastniPohyb_ID />
      <CiselneRady />
      <DodaciLhuta>
        <Doba>0</Doba>
        <Typ EnumValueName="Neurceno">0</Typ>
      </DodaciLhuta>
      <Dodavatele />
      <Jednotky>
        <HlavniJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="70bfe983-e0e1-40cb-9a7e-46a07525dc15" />
        <SeznamJednotek ObjectName="ArtiklJednotka" ObjectType="List">
          <ArtiklJednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="70bfe983-e0e1-40cb-9a7e-46a07525dc15">
            <DesetinnaMista>3</DesetinnaMista>
            <DruhBaleni_ID />
            <DruhObalu_ID />
            <Jednotka_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Jednotka_ID>
            <Kod>kg</Kod>
            <KodProTisk_ID />
            <MaterialObalu_ID />
            <Mnozstvi>1.0000</Mnozstvi>
            <NedelitelneMnozstvi>0.0000</NedelitelneMnozstvi>
            <ParentJednotka_ID />
            <TypJednotky EnumValueName="Fyzikalni">1</TypJednotky>
            <VychoziMnozstvi>1.0000</VychoziMnozstvi>
            <Baleni ObjectName="ArtiklBaleni" ObjectType="List" />
            <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed">
              <Group ID="65172eca-035d-43a6-a68b-757589f46d8d" Kod="m" />
              <DesMisto>3</DesMisto>
              <Kod>kg</Kod>
              <Nazev>kilogram</Nazev>
              <Poznamka />
              <TypJednotky EnumValueName="FyziJednotka">3</TypJednotky>
              <PrevodyList ObjectName="PrevodJednotek" ObjectType="List">
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="9162cb41-0dd4-4a8f-bd02-5be1060c7f3c">
                  <Cil_ID>5e692209-c358-48a8-b025-0e8738f4de35</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="5e692209-c358-48a8-b025-0e8738f4de35" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="c7e96ef5-0899-41ea-b4ed-746a36d79f64">
                  <Cil_ID>aa44a8f1-3d7a-4620-8e6f-53475ae76906</Cil_ID>
                  <CilPocet>35.274000</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="aa44a8f1-3d7a-4620-8e6f-53475ae76906" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="186b289d-5ab7-4616-b6ca-910d6f585231">
                  <Cil_ID>b10c424d-a6a9-415b-ab86-a1aaddfba328</Cil_ID>
                  <CilPocet>2.204600</CilPocet>
                  <Zdroj_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="b10c424d-a6a9-415b-ab86-a1aaddfba328" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="922ffd7b-0d3b-4511-9518-e3978ab32273">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>100.000000</CilPocet>
                  <Zdroj_ID>36cc9da0-96be-40af-9f73-c3665c350373</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="36cc9da0-96be-40af-9f73-c3665c350373" />
                </PrevodJednotek>
                <PrevodJednotek ObjectName="PrevodJednotek" ObjectType="Object" ID="0708367f-f0f1-4b10-9ece-23672c16c20c">
                  <Cil_ID>c604bc2d-dd55-413b-b21c-fbfa82b0faed</Cil_ID>
                  <CilPocet>1000.000000</CilPocet>
                  <Zdroj_ID>02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184</Zdroj_ID>
                  <ZdrojPocet>1.000000</ZdrojPocet>
                  <JednotkaCil ObjectName="Jednotka" ObjectType="Object" ID="c604bc2d-dd55-413b-b21c-fbfa82b0faed" />
                  <JednotkaZdroj ObjectName="Jednotka" ObjectType="Object" ID="02d99cc3-4bb2-446f-9e6a-c1cbfd6c8184" />
                </PrevodJednotek>
              </PrevodyList>
            </Jednotka>
            <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
          </ArtiklJednotka>
        </SeznamJednotek>
      </Jednotky>
      <NadrazenyArtikl />
      <Odberatele />
      <Rozmery />
      <RozsirenePopisy />
      <Vykazy>
        <EvidenceLihu EnumValueName="Neni">0</EvidenceLihu>
        <ObjemoveProcentoLihu>0.00</ObjemoveProcentoLihu>
        <ObjemSpotrebitelskehoBaleni>0</ObjemSpotrebitelskehoBaleni>
        <PocetKontrolnichPasek>1</PocetKontrolnichPasek>
      </Vykazy>
      <Vyrobce />
      <Zaruka>
        <Doba>0</Doba>
        <Typ EnumValueName="Zadna">0</Typ>
      </Zaruka>
      <Cinnosti ObjectName="ArtiklCinnost" ObjectType="List" />
      <DruhArtiklu ObjectName="DruhArtiklu" ObjectType="Object" ID="9999e1b5-7a3d-4a20-bf11-69c9e1d9edc1">
        <Kod>SUR</Kod>
        <Nazev>Surovina</Nazev>
        <Poznamka />
      </DruhArtiklu>
      <Identifikace ObjectName="ArtiklIdentifikace" ObjectType="List" />
      <Parametry ObjectName="ArtiklHodnotaParametru" ObjectType="List" />
      <Prislusenstvi ObjectName="ArtiklPrislusenstvi" ObjectType="List" />
      <ProduktoveKlice ObjectName="ArtiklProduktovyKlic" ObjectType="List" />
      <SazbyDPH ObjectName="ArtiklDPH" ObjectType="List">
        <ArtiklDPH ObjectName="ArtiklDPH" ObjectType="Object" ID="d251d30e-949e-4471-9df9-1565889a596d">
          <PovahaSazbyVstup_ID />
          <PovahaSazbyVystup_ID />
          <SazbaVstup EnumValueName="Zakladni">1</SazbaVstup>
          <SazbaVystup EnumValueName="Zakladni">1</SazbaVystup>
          <Stat_ID />
          <Zacatek>1753-01-01T00:00:00</Zacatek>
        </ArtiklDPH>
      </SazbyDPH>
      <Serie ObjectName="ArtiklSerie" ObjectType="List" />
      <SeznamAlternativ ObjectName="ArtiklAlternativa" ObjectType="List" />
      <Slozeni ObjectName="ArtiklSlozeni" ObjectType="List" />
    </Artikl>
  </ArtiklList>
</S5Data>""">
