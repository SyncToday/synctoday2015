module ObjednavkyPrijate

open System
open FSharp.Data
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders

type ObjPXml = XmlProvider<"""<?xml version="1.0" encoding="windows-1250"?>
<S5Data>
  <ObjednavkaPrijataList>
    <ObjednavkaPrijata ObjectName="ObjednavkaPrijata" ObjectType="Object" ID="8515740f-0b17-439c-9b66-c1ddd24b1f46">
      <AdresaKoncovehoPrijemceEmailSpojeni_ID>573ae688-eb67-43b5-bb34-ce4a3a7ffa76</AdresaKoncovehoPrijemceEmailSpojeni_ID>
      <AdresaKoncovehoPrijemceKontaktniOsoba_ID />
      <AdresaKoncovehoPrijemceStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaKoncovehoPrijemceStat_ID>
      <AdresaKoncovehoPrijemceTelefonSpojeni_ID>8e88b8a6-15c1-4e1b-a0a3-d5652c77e427</AdresaKoncovehoPrijemceTelefonSpojeni_ID>
      <AdresaKontaktniOsoba_ID />
      <DatumVystaveni>2015-01-07T00:00:00</DatumVystaveni>
      <DodaciAdresaFirma_ID>925C90F9-02BC-4B2E-B4F7-F4AC52D4FA63</DodaciAdresaFirma_ID>
      <DomaciMena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</DomaciMena_ID>
      <DruhDokladu_ID>8ba81511-9cb2-45b8-9278-558647b8d310</DruhDokladu_ID>
      <FakturacniAdresaFirma_ID>925C90F9-02BC-4B2E-B4F7-F4AC52D4FA63</FakturacniAdresaFirma_ID>
      <Firma_ID>925C90F9-02BC-4B2E-B4F7-F4AC52D4FA63</Firma_ID>
      <Mena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</Mena_ID>
      <Nazev>Hraška na obalování 1 kg</Nazev>
      <ZpusobDopravy_ID>a46ef167-6913-4b2f-b68f-d974e80981d2</ZpusobDopravy_ID>
      <ZpusobPlatby_ID>d3b43f46-2cdd-413f-b51c-ad9096771980</ZpusobPlatby_ID>
      <AdresaKoncovehoPrijemce>
        <Email>j.janca@biogena.cz</Email>
        <KontaktniOsobaNazev />
        <Misto>Valašské Meziříčí</Misto>
        <Nazev>Jaromír Janča</Nazev>
        <PSC>75701</PSC>
        <Stat>Česká republika</Stat>
        <Telefon>571 613 226</Telefon>
        <Ulice>Podlesí 276</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <EmailSpojeni ObjectName="Spojeni" ObjectType="Object" ID="573ae688-eb67-43b5-bb34-ce4a3a7ffa76" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="925C90F9-02BC-4B2E-B4F7-F4AC52D4FA63" />
        <TelefonSpojeni ObjectName="Spojeni" ObjectType="Object" ID="8e88b8a6-15c1-4e1b-a0a3-d5652c77e427" />
      </AdresaKoncovehoPrijemce>
      <Texty>
        <PredCenami />
        <ZaCenami>Cena dopravy v ceně zboží je 769 Kč bez DPH. Cena Hrašky bez dopravy je 70,4 Kč za Kg bez DPH.</ZaCenami>
      </Texty>
      <DomaciMena ObjectName="Mena" ObjectType="Object" ID="00f9adb2-d300-42c3-9240-ae1320b019cc" />
      <DruhDokladu ObjectName="DruhDokladu" ObjectType="Object" ID="8ba81511-9cb2-45b8-9278-558647b8d310" />
      <Polozky ObjectName="PolozkaObjednavkyPrijate" ObjectType="List">
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="9bbae86f-ded8-445c-8f0d-b22de0e647e1">
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <JednCena>73.1000</JednCena>
          <Jednotka>ks</Jednotka>
          <Mnozstvi>50.0000</Mnozstvi>
          <Nazev>Hraška na obalování 1 kg</Nazev>
          <ObsahPolozky_ID>5907cdd4-af53-47fc-836e-fecbc43ef468</ObsahPolozky_ID>
          <Poradi>1</Poradi>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="5907cdd4-af53-47fc-836e-fecbc43ef468">
            <Artikl_ID>187D16B2-1E61-475F-900E-74F1C7C9C631</Artikl_ID>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="187D16B2-1E61-475F-900E-74F1C7C9C631" />
            <Sklad_ID>71E5B006-0FC5-466E-8316-A371629BD4FD</Sklad_ID>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="71E5B006-0FC5-466E-8316-A371629BD4FD" />
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
          </ObsahPolozky>
        </PolozkaObjednavkyPrijate>
      </Polozky>
      <ZpusobDopravy ObjectName="ZpusobDopravy" ObjectType="Object" ID="a46ef167-6913-4b2f-b68f-d974e80981d2">
        <Kod>PP</Kod>
        <Nazev>Přepravní služna Paleta</Nazev>
        <Poznamka />
      </ZpusobDopravy>
      <ZpusobPlatby ObjectName="ZpusobPlatby" ObjectType="Object" ID="d3b43f46-2cdd-413f-b51c-ad9096771980">
        <Kod>B</Kod>
        <Nazev>Bankovním převodem</Nazev>
        <Poznamka />
      </ZpusobPlatby>
    </ObjednavkaPrijata>
  </ObjednavkaPrijataList>
</S5Data>""">
