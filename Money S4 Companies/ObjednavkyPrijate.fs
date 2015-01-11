module ObjednavkyPrijate

open System
open FSharp.Data
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders

type ObjPXml = XmlProvider<"""<?xml version="1.0" encoding="windows-1250"?>
<S5Data>
  <ObjednavkaPrijataList>
    <ObjednavkaPrijata ObjectName="ObjednavkaPrijata" ObjectType="Object" ID="8515740f-0b17-439c-9b66-c1ddd24b1f45">
      <AdresaKoncovehoPrijemceEmailSpojeni_ID>573ae688-eb67-43b5-bb34-ce4a3a7ffa76</AdresaKoncovehoPrijemceEmailSpojeni_ID>
      <AdresaKoncovehoPrijemceKontaktniOsoba_ID />
      <AdresaKoncovehoPrijemceStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaKoncovehoPrijemceStat_ID>
      <AdresaKoncovehoPrijemceTelefonSpojeni_ID>8e88b8a6-15c1-4e1b-a0a3-d5652c77e427</AdresaKoncovehoPrijemceTelefonSpojeni_ID>
      <AdresaKontaktniOsoba_ID />
      <AdresaPrijemceFakturyKontaktniOsoba_ID />
      <AdresaPrijemceFakturyStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaPrijemceFakturyStat_ID>
      <AdresaStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaStat_ID>
      <AutoRow_ID>1</AutoRow_ID>
      <CelkovaCastka>16082.00</CelkovaCastka>
      <CelkovaCastkaCM>16082.00</CelkovaCastkaCM>
      <CelkovaCastkaDual>484486.33</CelkovaCastkaDual>
      <Cinnost_ID />
      <CiselnaRada_ID>7a1cacb6-1692-4683-818d-1a22caf2949e</CiselnaRada_ID>
      <CisloDokladu>OP00001</CisloDokladu>
      <CisloRady>1</CisloRady>
      <DatumVyrizeni>1753-01-01T00:00:00</DatumVyrizeni>
      <DatumVystaveni>2015-01-07T00:00:00</DatumVystaveni>
      <DIC>CZ6404302443</DIC>
      <DodaciAdresaFirma_ID>c8c843fd-3b7a-4c12-97fe-75ad1d753df4</DodaciAdresaFirma_ID>
      <DodaciPodminky_ID />
      <DomaciMena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</DomaciMena_ID>
      <DruhDokladu_ID>8ba81511-9cb2-45b8-9278-558647b8d310</DruhDokladu_ID>
      <DruhDopravy_ID />
      <FakturacniAdresaFirma_ID>c8c843fd-3b7a-4c12-97fe-75ad1d753df4</FakturacniAdresaFirma_ID>
      <Faze EnumValueName="Aktivni">1</Faze>
      <Firma_ID>c8c843fd-3b7a-4c12-97fe-75ad1d753df4</Firma_ID>
      <IC>61598216</IC>
      <ICDPH />
      <IDKrajPuvodu_ID />
      <IDPovahaTransakce_ID />
      <Jmeno />
      <KonecnyPrijemce_ID />
      <Mena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</Mena_ID>
      <MojeFirma_ID>7503fef6-8eda-4d97-82dc-fcb9ece79cfe</MojeFirma_ID>
      <MojeFirmaBanka_ID>1ba31972-cf0a-44a4-88fe-d0b212e13a84</MojeFirmaBanka_ID>
      <MojeFirmaBankovniSpojeni_ID>41acd46c-dac4-441e-a624-cf516ddeaf04</MojeFirmaBankovniSpojeni_ID>
      <MojeFirmaFirma_ID />
      <MojeFirmaKontaktniOsoba_ID />
      <MojeFirmaStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</MojeFirmaStat_ID>
      <Nazev>Hraška na obalování 1 kg</Nazev>
      <Odkaz />
      <Osoba_ID />
      <PevneCeny>False</PevneCeny>
      <PlatnostDo>2015-01-08T00:00:00</PlatnostDo>
      <PlatnostOd>2015-01-07T00:00:00</PlatnostOd>
      <PocetPolozek>2</PocetPolozek>
      <PovahaTransakce_ID />
      <Poznamka />
      <PrijemceFaktury_ID />
      <PriznakVyrizeno>False</PriznakVyrizeno>
      <ProcentniZisk>0.00</ProcentniZisk>
      <RegistraceDPH_ID>fc1e873a-ffe1-4095-a78d-bb2eed9c39f4</RegistraceDPH_ID>
      <SazbaDPH0_ID>4940de08-8927-4731-ac4a-88f5aec97093</SazbaDPH0_ID>
      <SazbaDPH1_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH1_ID>
      <SazbaDPH2_ID>b7d9bd88-bf7e-4c11-be49-2044879c871c</SazbaDPH2_ID>
      <Schvaleno>True</Schvaleno>
      <Sleva>0.00</Sleva>
      <Stat_ID />
      <StatPuvodu_ID />
      <StatUrceniOdeslani_ID />
      <Stav EnumValueName="Rozpracovano">0</Stav>
      <Storno EnumValueName="NeniStorno">0</Storno>
      <Stredisko_ID />
      <Systemovy>False</Systemovy>
      <TypDokladu EnumValueName="Neurceny">0</TypDokladu>
      <VariabilniSymbol />
      <Vyrizeno>0</Vyrizeno>
      <Vystavil>Jaroslav Škvařil</Vystavil>
      <Zakazka_ID />
      <ZaokrouhleniCelkovaCastka_ID />
      <ZaokrouhleniDPH_ID />
      <ZaokrouhleniSazbaDPH_ID>ab01bdbb-662b-422c-8835-a9270fb48eab</ZaokrouhleniSazbaDPH_ID>
      <ZapornyPohyb>False</ZapornyPohyb>
      <Zauctovano>False</Zauctovano>
      <Zaverkovy>False</Zaverkovy>
      <ZiskZaDoklad>0.00</ZiskZaDoklad>
      <ZpusobDopravy_ID>a46ef167-6913-4b2f-b68f-d974e80981d2</ZpusobDopravy_ID>
      <ZpusobPlatby_ID>d3b43f46-2cdd-413f-b51c-ad9096771980</ZpusobPlatby_ID>
      <ZvlastniPohyb_ID />
      <Adresa>
        <KontaktniOsobaJmeno />
        <KontaktniOsobaNazev />
        <KontaktniOsobaPrijmeni />
        <Misto>Valašské Meziříčí</Misto>
        <Nazev>Jaromír Kostelný</Nazev>
        <PSC>75701</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>Poličná 8</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="c8c843fd-3b7a-4c12-97fe-75ad1d753df4" />
      </Adresa>
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
        <Firma ObjectName="Firma" ObjectType="Object" ID="c8c843fd-3b7a-4c12-97fe-75ad1d753df4" />
        <TelefonSpojeni ObjectName="Spojeni" ObjectType="Object" ID="8e88b8a6-15c1-4e1b-a0a3-d5652c77e427" />
      </AdresaKoncovehoPrijemce>
      <AdresaPrijemceFaktury>
        <KontaktniOsobaNazev />
        <Misto>Valašské Meziříčí</Misto>
        <Nazev>Jaromír Kostelný</Nazev>
        <PSC>75701</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>Poličná 8</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="c8c843fd-3b7a-4c12-97fe-75ad1d753df4" />
      </AdresaPrijemceFaktury>
      <DPH0>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>0.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </DPH0>
      <DPH1>
        <Celkem>16082.00</Celkem>
        <CelkemCM>16082.00</CelkemCM>
        <Dan>1462.00</Dan>
        <DanCM>1462.00</DanCM>
        <Sazba>10.00</Sazba>
        <Zaklad>14620.00</Zaklad>
        <ZakladCM>14620.00</ZakladCM>
      </DPH1>
      <DPH2>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>21.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </DPH2>
      <IntrastatDoklad>
        <Datum>2015-01-07T00:00:00</Datum>
        <DopravaTuzemsko>0.00</DopravaTuzemsko>
        <DopravaZahranici>0.00</DopravaZahranici>
        <DopravniNaklady>0.00</DopravniNaklady>
        <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
        <RozpousteniNakladu EnumValueName="CenaZbozi">0</RozpousteniNakladu>
      </IntrastatDoklad>
      <Korekce0>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>0.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce0>
      <Korekce1>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>10.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce1>
      <Korekce2>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>21.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce2>
      <MojeFirma>
        <DIC>CZ26294010</DIC>
        <IC>26294010</IC>
        <ICDPH />
        <Misto>Brno-střed</Misto>
        <Nazev>CERIA,s.r.o.</Nazev>
        <PSC>60200</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>Heinrichova 229/49</Ulice>
        <BankovniSpojeni>
          <CiselnyKod>0300</CiselnyKod>
          <CisloUctu>178570860</CisloUctu>
          <IBAN>CZ5503000000000178570860</IBAN>
          <SpecifickySymbol />
          <SWIFT>CEKOCZPP</SWIFT>
          <Banka ObjectName="Banka" ObjectType="Object" ID="1ba31972-cf0a-44a4-88fe-d0b212e13a84">
            <Group ID="ef04d885-1a39-4c48-a7a8-eb797000fd62" Kod="BAN" />
            <CiselnyKod>0300</CiselnyKod>
            <Kod>CEKO</Kod>
            <KonfiguraceKL_ID>5eb85f31-fcb1-4d5a-a758-5b9c6ba678a6</KonfiguraceKL_ID>
            <Nazev>Československá obchodní banka, a.s.</Nazev>
            <Poznamka />
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <SWIFT>CEKOCZPP</SWIFT>
            <KonfiguraceKL ObjectName="KonfiguraceKurzovnichListku" ObjectType="Object" ID="5eb85f31-fcb1-4d5a-a758-5b9c6ba678a6" />
            <SeznamKonfiguraciKL ObjectName="BankaKonfiguraceKL" ObjectType="List" />
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </Banka>
          <BankovniSpojeni ObjectName="BankovniSpojeni" ObjectType="Object" ID="41acd46c-dac4-441e-a624-cf516ddeaf04" />
        </BankovniSpojeni>
        <Kontakty>
          <Email>info@ceria.cz</Email>
          <Telefon1>+420532308550</Telefon1>
          <Telefon2>+420511140390</Telefon2>
          <Telefon3>+420910089390</Telefon3>
          <WWW>ceria.cz</WWW>
        </Kontakty>
        <Osoba />
        <Firma ObjectName="Firma" ObjectType="Object" ID="7503fef6-8eda-4d97-82dc-fcb9ece79cfe" />
        <MojeFirmaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
      </MojeFirma>
      <Suma>
        <Celkem>16082.00</Celkem>
        <CelkemCM>16082.00</CelkemCM>
        <Dan>1462.00</Dan>
        <DanCM>1462.00</DanCM>
        <Zaklad>14620.00</Zaklad>
        <ZakladCM>14620.00</ZakladCM>
      </Suma>
      <Texty>
        <PredCenami />
        <ZaCenami>Cena dopravy v ceně zboží je 769 Kč bez DPH. Cena Hrašky bez dopravy je 70,4 Kč za Kg bez DPH.</ZaCenami>
      </Texty>
      <UcetniKurz>
        <Kurz>1.000000</Kurz>
        <Mnozstvi>1.000000</Mnozstvi>
      </UcetniKurz>
      <Zaokrouhleni>
        <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
        <PrevazujiciSazbaDPH>True</PrevazujiciSazbaDPH>
        <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="ab01bdbb-662b-422c-8835-a9270fb48eab">
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
          <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
          <Poradi>2</Poradi>
          <PovahaSazbyDPH_ID />
          <PrimarniUcetVstup_ID />
          <PrimarniUcetVystup_ID />
          <Priorita>19</Priorita>
          <Sazba>15.00</Sazba>
          <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
          <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        </SazbaDPH>
      </Zaokrouhleni>
      <CiselnaRada ObjectName="CiselnaRada" ObjectType="Object" ID="7a1cacb6-1692-4683-818d-1a22caf2949e">
        <Kod>OBJ_PRI</Kod>
        <Nazev>Objednávky přijaté</Nazev>
        <NevracetDoVolnychCisel>True</NevracetDoVolnychCisel>
        <Poznamka />
        <Prefix>OP</Prefix>
        <SeznamObdobi ObjectName="ObdobiCiselneRady" ObjectType="List">
          <ObdobiCiselneRady ObjectName="ObdobiCiselneRady" ObjectType="Object" ID="2cdd3cdb-ef24-480f-9d7b-859627caa171">
            <CiselnyPrefix />
            <Cislo>6</Cislo>
            <PocetMist>5</PocetMist>
            <Zacatek>1753-01-01T00:00:00</Zacatek>
            <ZobrazitNuly>True</ZobrazitNuly>
            <VolnaCisla ObjectName="VolneCislo" ObjectType="List" />
          </ObdobiCiselneRady>
        </SeznamObdobi>
      </CiselnaRada>
      <DokladInfo ObjectName="DokladInfo" ObjectType="List" />
      <DomaciMena ObjectName="Mena" ObjectType="Object" ID="00f9adb2-d300-42c3-9240-ae1320b019cc" />
      <DruhDokladu ObjectName="DruhDokladu" ObjectType="Object" ID="8ba81511-9cb2-45b8-9278-558647b8d310" />
      <Mena ObjectName="Mena" ObjectType="Object" ID="00f9adb2-d300-42c3-9240-ae1320b019cc">
        <Banka_ID />
        <DesMisto>0</DesMisto>
        <Kod>CZK</Kod>
        <Nazev>Koruna česká</Nazev>
        <Poznamka />
        <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
        <Symbol>Kč</Symbol>
        <TypJednotky EnumValueName="Mena">2</TypJednotky>
        <DenominaceList ObjectName="PrevodDenominace" ObjectType="List" />
        <PrevodyList ObjectName="PrevodMen" ObjectType="List" />
        <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
      </Mena>
      <Polozky ObjectName="PolozkaObjednavkyPrijate" ObjectType="List">
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="9bbae86f-ded8-445c-8f0d-b22de0e647e0">
          <AutoRow_ID>2</AutoRow_ID>
          <CelkovaCena>3655.00</CelkovaCena>
          <CelkovaCenaBezSlevy>3655.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>3655.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>3655.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>1</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>73.1000</JednCena>
          <JednCenaCM>73.1000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>73.1000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>73.1000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>50.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na obalování 1 kg</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>5907cdd4-af53-47fc-836e-fecbc43ef469</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-08T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>1</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>False</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>0.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>50.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>4020.50</Celkem>
            <CelkemCM>4020.50</CelkemCM>
            <Dan>365.50</Dan>
            <DanCM>365.50</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>3655.00</Zaklad>
            <ZakladCM>3655.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>1.000</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="5907cdd4-af53-47fc-836e-fecbc43ef469">
            <Artikl_ID>04b91d10-944e-4b9e-908f-f117cd41bb05</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>2b587105-39c0-4918-b92b-d312935a015f</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>211</AutoRow_ID>
            <BeznaCena>88.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>9e43369a-7dda-49f5-80ac-58fbe9259831</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>2b587105-39c0-4918-b92b-d312935a015f</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>50.0000</MinuleMnozstviRezervace>
            <Mnozstvi>50.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-16.93</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00057</PartnerskyKod>
            <PartnerskyNazev>Hraška na obalování 1 kg</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>7072499d-8ef4-4789-b8d9-b07ce030cf11</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="04b91d10-944e-4b9e-908f-f117cd41bb05" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="2b587105-39c0-4918-b92b-d312935a015f" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="9e43369a-7dda-49f5-80ac-58fbe9259831" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="2b587105-39c0-4918-b92b-d312935a015f">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="7072499d-8ef4-4789-b8d9-b07ce030cf11" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="e50d9a7d-9fbf-425f-9d22-448a15b7b0fd">
          <AutoRow_ID>1</AutoRow_ID>
          <CelkovaCena>10965.00</CelkovaCena>
          <CelkovaCenaBezSlevy>10965.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>10965.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>10965.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>2</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>73.1000</JednCena>
          <JednCenaCM>73.1000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>73.1000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>73.1000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>150.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na zahušťování 1 kg</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>8cc7cc2d-9514-4394-8323-0c19285af43e</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-08T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>2</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>150.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>12061.50</Celkem>
            <CelkemCM>12061.50</CelkemCM>
            <Dan>1096.50</Dan>
            <DanCM>1096.50</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>10965.00</Zaklad>
            <ZakladCM>10965.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>1.000</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="8cc7cc2d-9514-4394-8323-0c19285af43e">
            <Artikl_ID>04c8292f-a1ee-46aa-86d0-04f6ae65eb2a</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>5805bef8-91e5-4435-b23f-376e347033f7</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>210</AutoRow_ID>
            <BeznaCena>88.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>9e43369a-7dda-49f5-80ac-58fbe9259831</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>5805bef8-91e5-4435-b23f-376e347033f7</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>150.0000</MinuleMnozstviRezervace>
            <Mnozstvi>150.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-16.93</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00063</PartnerskyKod>
            <PartnerskyNazev>Hraška na zahušťování 1 kg</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>42ae98d9-ed4c-442e-8bb5-48bc72a67e38</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="04c8292f-a1ee-46aa-86d0-04f6ae65eb2a" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="5805bef8-91e5-4435-b23f-376e347033f7" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="9e43369a-7dda-49f5-80ac-58fbe9259831" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="5805bef8-91e5-4435-b23f-376e347033f7">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="42ae98d9-ed4c-442e-8bb5-48bc72a67e38" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
      </Polozky>
      <Poplatky ObjectName="PoplatekZaDoklad" ObjectType="List" />
      <RegistraceDPH ObjectName="DanovaRegistrace" ObjectType="Object" ID="fc1e873a-ffe1-4095-a78d-bb2eed9c39f4" />
      <SazbaDPH0 ObjectName="SazbaDPH" ObjectType="Object" ID="4940de08-8927-4731-ac4a-88f5aec97093" />
      <SazbaDPH1 ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
      <SazbaDPH2 ObjectName="SazbaDPH" ObjectType="Object" ID="b7d9bd88-bf7e-4c11-be49-2044879c871c" />
      <SazbyDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="List">
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="2f73a819-1323-4e37-983e-23b3f733ba3c">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <Pouzita>True</Pouzita>
          <RozpisDPH_ID>3d2a1ba8-9998-454d-bad1-b3c1bc6a539a</RozpisDPH_ID>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="3d2a1ba8-9998-454d-bad1-b3c1bc6a539a">
            <Sazba>10.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>16082.00</Celkem>
              <DPH>1462.00</DPH>
              <Zaklad>14620.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>16082.00</Celkem>
              <DPH>1462.00</DPH>
              <Zaklad>14620.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="87993bb3-f435-4e13-af42-04b0155f74e2">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>cce7a3d0-f93c-4b60-8ffd-889802fce590</RozpisDPH_ID>
          <SazbaDPH_ID>ab01bdbb-662b-422c-8835-a9270fb48eab</SazbaDPH_ID>
          <VybranaNaHlavicce>False</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="cce7a3d0-f93c-4b60-8ffd-889802fce590">
            <Sazba>15.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="ab01bdbb-662b-422c-8835-a9270fb48eab">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
            <Poradi>2</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>19</Priorita>
            <Sazba>15.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="a37e199a-b036-492e-8dd4-6304e11381db">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Zakladni">1</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>27942c17-fb8d-4b14-bb2c-64338364ab3d</RozpisDPH_ID>
          <SazbaDPH_ID>b7d9bd88-bf7e-4c11-be49-2044879c871c</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="27942c17-fb8d-4b14-bb2c-64338364ab3d">
            <Sazba>21.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="b7d9bd88-bf7e-4c11-be49-2044879c871c">
            <DruhSazby EnumValueName="Zakladni">1</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>20</Priorita>
            <Sazba>21.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="e99343ff-8139-4587-90d7-d138c20e69d5">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Nulova">2</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>fb3ecc9c-8753-4afc-b13d-fb1549624e97</RozpisDPH_ID>
          <SazbaDPH_ID>4940de08-8927-4731-ac4a-88f5aec97093</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="fb3ecc9c-8753-4afc-b13d-fb1549624e97">
            <Sazba>0.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="4940de08-8927-4731-ac4a-88f5aec97093">
            <DruhSazby EnumValueName="Nulova">2</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>1753-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>1</Priorita>
            <Sazba>0.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
      </SazbyDPHNaDoklade>
      <VazbyObjektu ObjectName="VazbaObjektu" ObjectType="List" />
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
    <ObjednavkaPrijata ObjectName="ObjednavkaPrijata" ObjectType="Object" ID="08585c2c-9d4e-400c-be3a-a9e6e56c0771">
      <AdresaKoncovehoPrijemceEmailSpojeni_ID>5a9df8ea-7784-4860-9dc9-bd74ec2bea15</AdresaKoncovehoPrijemceEmailSpojeni_ID>
      <AdresaKoncovehoPrijemceKontaktniOsoba_ID>143b53dc-411a-4cce-8964-670b822deb7c</AdresaKoncovehoPrijemceKontaktniOsoba_ID>
      <AdresaKoncovehoPrijemceStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaKoncovehoPrijemceStat_ID>
      <AdresaKoncovehoPrijemceTelefonSpojeni_ID>3d62ffab-97c9-4f3f-b165-2c30c4647025</AdresaKoncovehoPrijemceTelefonSpojeni_ID>
      <AdresaKontaktniOsoba_ID />
      <AdresaPrijemceFakturyKontaktniOsoba_ID />
      <AdresaPrijemceFakturyStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaPrijemceFakturyStat_ID>
      <AdresaStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaStat_ID>
      <AutoRow_ID>2</AutoRow_ID>
      <CelkovaCastka>4009.50</CelkovaCastka>
      <CelkovaCastkaCM>4009.50</CelkovaCastkaCM>
      <CelkovaCastkaDual>120790.20</CelkovaCastkaDual>
      <Cinnost_ID />
      <CiselnaRada_ID>7a1cacb6-1692-4683-818d-1a22caf2949e</CiselnaRada_ID>
      <CisloDokladu>OP00002</CisloDokladu>
      <CisloRady>2</CisloRady>
      <DatumVyrizeni>2015-01-08T00:00:00</DatumVyrizeni>
      <DatumVystaveni>2015-01-07T00:00:00</DatumVystaveni>
      <DIC>CZ29320488</DIC>
      <DodaciAdresaFirma_ID>4ffd40ba-e6dd-41cb-a7ba-3212632a12f8</DodaciAdresaFirma_ID>
      <DodaciPodminky_ID />
      <DomaciMena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</DomaciMena_ID>
      <DruhDokladu_ID>8ba81511-9cb2-45b8-9278-558647b8d310</DruhDokladu_ID>
      <DruhDopravy_ID />
      <FakturacniAdresaFirma_ID>4ffd40ba-e6dd-41cb-a7ba-3212632a12f8</FakturacniAdresaFirma_ID>
      <Faze EnumValueName="Aktivni">1</Faze>
      <Firma_ID>4ffd40ba-e6dd-41cb-a7ba-3212632a12f8</Firma_ID>
      <IC>29320488</IC>
      <ICDPH />
      <IDKrajPuvodu_ID />
      <IDPovahaTransakce_ID />
      <Jmeno />
      <KonecnyPrijemce_ID />
      <Mena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</Mena_ID>
      <MojeFirma_ID>7503fef6-8eda-4d97-82dc-fcb9ece79cfe</MojeFirma_ID>
      <MojeFirmaBanka_ID>1ba31972-cf0a-44a4-88fe-d0b212e13a84</MojeFirmaBanka_ID>
      <MojeFirmaBankovniSpojeni_ID>41acd46c-dac4-441e-a624-cf516ddeaf04</MojeFirmaBankovniSpojeni_ID>
      <MojeFirmaFirma_ID />
      <MojeFirmaKontaktniOsoba_ID />
      <MojeFirmaStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</MojeFirmaStat_ID>
      <Nazev>Hraška na obalování 250 g</Nazev>
      <Odkaz />
      <Osoba_ID />
      <PevneCeny>False</PevneCeny>
      <PlatnostDo>2015-01-08T00:00:00</PlatnostDo>
      <PlatnostOd>2015-01-07T00:00:00</PlatnostOd>
      <PocetPolozek>2</PocetPolozek>
      <PovahaTransakce_ID />
      <Poznamka />
      <PrijemceFaktury_ID />
      <PriznakVyrizeno>True</PriznakVyrizeno>
      <ProcentniZisk>0.00</ProcentniZisk>
      <RegistraceDPH_ID>fc1e873a-ffe1-4095-a78d-bb2eed9c39f4</RegistraceDPH_ID>
      <SazbaDPH0_ID>4940de08-8927-4731-ac4a-88f5aec97093</SazbaDPH0_ID>
      <SazbaDPH1_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH1_ID>
      <SazbaDPH2_ID>b7d9bd88-bf7e-4c11-be49-2044879c871c</SazbaDPH2_ID>
      <Schvaleno>True</Schvaleno>
      <Sleva>0.00</Sleva>
      <Stat_ID />
      <StatPuvodu_ID />
      <StatUrceniOdeslani_ID />
      <Stav EnumValueName="Rozpracovano">0</Stav>
      <Storno EnumValueName="NeniStorno">0</Storno>
      <Stredisko_ID />
      <Systemovy>False</Systemovy>
      <TypDokladu EnumValueName="Neurceny">0</TypDokladu>
      <VariabilniSymbol />
      <Vyrizeno>0</Vyrizeno>
      <Vystavil>Jaroslav Škvařil</Vystavil>
      <Zakazka_ID />
      <ZaokrouhleniCelkovaCastka_ID />
      <ZaokrouhleniDPH_ID />
      <ZaokrouhleniSazbaDPH_ID>ab01bdbb-662b-422c-8835-a9270fb48eab</ZaokrouhleniSazbaDPH_ID>
      <ZapornyPohyb>False</ZapornyPohyb>
      <Zauctovano>False</Zauctovano>
      <Zaverkovy>False</Zaverkovy>
      <ZiskZaDoklad>0.00</ZiskZaDoklad>
      <ZpusobDopravy_ID>987aa2ec-d6d2-459f-abfd-374b71116d88</ZpusobDopravy_ID>
      <ZpusobPlatby_ID>d3b43f46-2cdd-413f-b51c-ad9096771980</ZpusobPlatby_ID>
      <ZvlastniPohyb_ID />
      <Adresa>
        <KontaktniOsobaJmeno />
        <KontaktniOsobaNazev />
        <KontaktniOsobaPrijmeni />
        <Misto>Brno-střed</Misto>
        <Nazev>Sklizeno s.r.o.</Nazev>
        <PSC>60200</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>třída Kpt. Jaroše 1845/26</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="4ffd40ba-e6dd-41cb-a7ba-3212632a12f8" />
      </Adresa>
      <AdresaKoncovehoPrijemce>
        <Email>josefska@sklizeno.cz</Email>
        <KontaktniOsobaNazev>Martina Kaiprová</KontaktniOsobaNazev>
        <Misto>Brno-střed</Misto>
        <Nazev>Sklizeno - 003 Brno Josefská</Nazev>
        <PSC>60200</PSC>
        <Stat>Česká republika</Stat>
        <Telefon>731427972</Telefon>
        <Ulice>třída Kpt. Jaroše 1845/26</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <EmailSpojeni ObjectName="Spojeni" ObjectType="Object" ID="5a9df8ea-7784-4860-9dc9-bd74ec2bea15" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="4ffd40ba-e6dd-41cb-a7ba-3212632a12f8" />
        <KontaktniOsoba ObjectName="Osoba" ObjectType="Object" ID="143b53dc-411a-4cce-8964-670b822deb7c" />
        <TelefonSpojeni ObjectName="Spojeni" ObjectType="Object" ID="3d62ffab-97c9-4f3f-b165-2c30c4647025" />
      </AdresaKoncovehoPrijemce>
      <AdresaPrijemceFaktury>
        <KontaktniOsobaNazev />
        <Misto>Brno-střed</Misto>
        <Nazev>Sklizeno s.r.o.</Nazev>
        <PSC>60200</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>třída Kpt. Jaroše 1845/26</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="4ffd40ba-e6dd-41cb-a7ba-3212632a12f8" />
      </AdresaPrijemceFaktury>
      <DPH0>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>0.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </DPH0>
      <DPH1>
        <Celkem>4009.50</Celkem>
        <CelkemCM>4009.50</CelkemCM>
        <Dan>364.50</Dan>
        <DanCM>364.50</DanCM>
        <Sazba>10.00</Sazba>
        <Zaklad>3645.00</Zaklad>
        <ZakladCM>3645.00</ZakladCM>
      </DPH1>
      <DPH2>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>21.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </DPH2>
      <IntrastatDoklad>
        <Datum>2015-01-07T00:00:00</Datum>
        <DopravaTuzemsko>0.00</DopravaTuzemsko>
        <DopravaZahranici>0.00</DopravaZahranici>
        <DopravniNaklady>0.00</DopravniNaklady>
        <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
        <RozpousteniNakladu EnumValueName="CenaZbozi">0</RozpousteniNakladu>
      </IntrastatDoklad>
      <Korekce0>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>0.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce0>
      <Korekce1>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>10.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce1>
      <Korekce2>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>21.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce2>
      <MojeFirma>
        <DIC>CZ26294010</DIC>
        <IC>26294010</IC>
        <ICDPH />
        <Misto>Brno-střed</Misto>
        <Nazev>CERIA,s.r.o.</Nazev>
        <PSC>60200</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>Heinrichova 229/49</Ulice>
        <BankovniSpojeni>
          <CiselnyKod>0300</CiselnyKod>
          <CisloUctu>178570860</CisloUctu>
          <IBAN>CZ5503000000000178570860</IBAN>
          <SpecifickySymbol />
          <SWIFT>CEKOCZPP</SWIFT>
          <Banka ObjectName="Banka" ObjectType="Object" ID="1ba31972-cf0a-44a4-88fe-d0b212e13a84">
            <Group ID="ef04d885-1a39-4c48-a7a8-eb797000fd62" Kod="BAN" />
            <CiselnyKod>0300</CiselnyKod>
            <Kod>CEKO</Kod>
            <KonfiguraceKL_ID>5eb85f31-fcb1-4d5a-a758-5b9c6ba678a6</KonfiguraceKL_ID>
            <Nazev>Československá obchodní banka, a.s.</Nazev>
            <Poznamka />
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <SWIFT>CEKOCZPP</SWIFT>
            <KonfiguraceKL ObjectName="KonfiguraceKurzovnichListku" ObjectType="Object" ID="5eb85f31-fcb1-4d5a-a758-5b9c6ba678a6" />
            <SeznamKonfiguraciKL ObjectName="BankaKonfiguraceKL" ObjectType="List" />
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </Banka>
          <BankovniSpojeni ObjectName="BankovniSpojeni" ObjectType="Object" ID="41acd46c-dac4-441e-a624-cf516ddeaf04" />
        </BankovniSpojeni>
        <Kontakty>
          <Email>info@ceria.cz</Email>
          <Telefon1>+420532308550</Telefon1>
          <Telefon2>+420511140390</Telefon2>
          <Telefon3>+420910089390</Telefon3>
          <WWW>ceria.cz</WWW>
        </Kontakty>
        <Osoba />
        <Firma ObjectName="Firma" ObjectType="Object" ID="7503fef6-8eda-4d97-82dc-fcb9ece79cfe" />
        <MojeFirmaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
      </MojeFirma>
      <Suma>
        <Celkem>4009.50</Celkem>
        <CelkemCM>4009.50</CelkemCM>
        <Dan>364.50</Dan>
        <DanCM>364.50</DanCM>
        <Zaklad>3645.00</Zaklad>
        <ZakladCM>3645.00</ZakladCM>
      </Suma>
      <Texty />
      <UcetniKurz>
        <Kurz>1.000000</Kurz>
        <Mnozstvi>1.000000</Mnozstvi>
      </UcetniKurz>
      <Zaokrouhleni>
        <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
        <PrevazujiciSazbaDPH>True</PrevazujiciSazbaDPH>
        <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="ab01bdbb-662b-422c-8835-a9270fb48eab">
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
          <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
          <Poradi>2</Poradi>
          <PovahaSazbyDPH_ID />
          <PrimarniUcetVstup_ID />
          <PrimarniUcetVystup_ID />
          <Priorita>19</Priorita>
          <Sazba>15.00</Sazba>
          <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
          <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        </SazbaDPH>
      </Zaokrouhleni>
      <CiselnaRada ObjectName="CiselnaRada" ObjectType="Object" ID="7a1cacb6-1692-4683-818d-1a22caf2949e">
        <Kod>OBJ_PRI</Kod>
        <Nazev>Objednávky přijaté</Nazev>
        <NevracetDoVolnychCisel>True</NevracetDoVolnychCisel>
        <Poznamka />
        <Prefix>OP</Prefix>
        <SeznamObdobi ObjectName="ObdobiCiselneRady" ObjectType="List">
          <ObdobiCiselneRady ObjectName="ObdobiCiselneRady" ObjectType="Object" ID="2cdd3cdb-ef24-480f-9d7b-859627caa171">
            <CiselnyPrefix />
            <Cislo>6</Cislo>
            <PocetMist>5</PocetMist>
            <Zacatek>1753-01-01T00:00:00</Zacatek>
            <ZobrazitNuly>True</ZobrazitNuly>
            <VolnaCisla ObjectName="VolneCislo" ObjectType="List" />
          </ObdobiCiselneRady>
        </SeznamObdobi>
      </CiselnaRada>
      <DokladInfo ObjectName="DokladInfo" ObjectType="List" />
      <DomaciMena ObjectName="Mena" ObjectType="Object" ID="00f9adb2-d300-42c3-9240-ae1320b019cc" />
      <DruhDokladu ObjectName="DruhDokladu" ObjectType="Object" ID="8ba81511-9cb2-45b8-9278-558647b8d310" />
      <Mena ObjectName="Mena" ObjectType="Object" ID="00f9adb2-d300-42c3-9240-ae1320b019cc">
        <Banka_ID />
        <DesMisto>0</DesMisto>
        <Kod>CZK</Kod>
        <Nazev>Koruna česká</Nazev>
        <Poznamka />
        <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
        <Symbol>Kč</Symbol>
        <TypJednotky EnumValueName="Mena">2</TypJednotky>
        <DenominaceList ObjectName="PrevodDenominace" ObjectType="List" />
        <PrevodyList ObjectName="PrevodMen" ObjectType="List" />
        <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
      </Mena>
      <Polozky ObjectName="PolozkaObjednavkyPrijate" ObjectType="List">
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="449a36cf-3ac9-4614-9d6a-ac862f4353f2">
          <AutoRow_ID>4</AutoRow_ID>
          <CelkovaCena>1458.00</CelkovaCena>
          <CelkovaCenaBezSlevy>1458.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>1458.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>1458.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>1</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>24.3000</JednCena>
          <JednCenaCM>24.3000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>24.3000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>24.3000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>60.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na obalování 250 g</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>b416c118-a5c6-42e1-8a9e-114a079d41a2</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-08T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>1</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>60.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>1603.80</Celkem>
            <CelkemCM>1603.80</CelkemCM>
            <Dan>145.80</Dan>
            <DanCM>145.80</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>1458.00</Zaklad>
            <ZakladCM>1458.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>0.250</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="b416c118-a5c6-42e1-8a9e-114a079d41a2">
            <Artikl_ID>80dd9bb7-c1c0-4dac-b6b4-1639f4194537</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>d53f4446-5fc7-4b81-af9c-84a5cb55b506</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>213</AutoRow_ID>
            <BeznaCena>27.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>7804d7d9-3a3b-4574-b63f-91fa81fffd84</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>d53f4446-5fc7-4b81-af9c-84a5cb55b506</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>60.0000</MinuleMnozstviRezervace>
            <Mnozstvi>60.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-10.00</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00058</PartnerskyKod>
            <PartnerskyNazev>Hraška na obalování 250 g</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>c6e46461-779d-4730-bd21-c40a42d01d47</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="80dd9bb7-c1c0-4dac-b6b4-1639f4194537" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="d53f4446-5fc7-4b81-af9c-84a5cb55b506" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="7804d7d9-3a3b-4574-b63f-91fa81fffd84" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="d53f4446-5fc7-4b81-af9c-84a5cb55b506">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="c6e46461-779d-4730-bd21-c40a42d01d47" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="98ca1b69-8697-48f6-9a4d-8b4fa21b9e9b">
          <AutoRow_ID>3</AutoRow_ID>
          <CelkovaCena>2187.00</CelkovaCena>
          <CelkovaCenaBezSlevy>2187.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>2187.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>2187.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>2</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>24.3000</JednCena>
          <JednCenaCM>24.3000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>24.3000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>24.3000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>90.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na zahušťování 250 g</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>c352ae44-8de5-44a6-9eac-9e5aa9edaa15</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-08T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>2</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>90.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>2405.70</Celkem>
            <CelkemCM>2405.70</CelkemCM>
            <Dan>218.70</Dan>
            <DanCM>218.70</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>2187.00</Zaklad>
            <ZakladCM>2187.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>0.250</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="c352ae44-8de5-44a6-9eac-9e5aa9edaa15">
            <Artikl_ID>9f0834cf-c14c-4967-b1f4-41e2e3171cae</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>e9543ba3-3d09-4156-97a8-6ed31cf8fda6</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>212</AutoRow_ID>
            <BeznaCena>27.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>7804d7d9-3a3b-4574-b63f-91fa81fffd84</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>e9543ba3-3d09-4156-97a8-6ed31cf8fda6</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>90.0000</MinuleMnozstviRezervace>
            <Mnozstvi>90.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-10.00</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00064</PartnerskyKod>
            <PartnerskyNazev>Hraška na zahušťování 250 g</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>22990ff0-8265-4e6a-913f-308892411db9</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="9f0834cf-c14c-4967-b1f4-41e2e3171cae" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="e9543ba3-3d09-4156-97a8-6ed31cf8fda6" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="7804d7d9-3a3b-4574-b63f-91fa81fffd84" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="e9543ba3-3d09-4156-97a8-6ed31cf8fda6">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="22990ff0-8265-4e6a-913f-308892411db9" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
      </Polozky>
      <Poplatky ObjectName="PoplatekZaDoklad" ObjectType="List" />
      <RegistraceDPH ObjectName="DanovaRegistrace" ObjectType="Object" ID="fc1e873a-ffe1-4095-a78d-bb2eed9c39f4" />
      <SazbaDPH0 ObjectName="SazbaDPH" ObjectType="Object" ID="4940de08-8927-4731-ac4a-88f5aec97093" />
      <SazbaDPH1 ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
      <SazbaDPH2 ObjectName="SazbaDPH" ObjectType="Object" ID="b7d9bd88-bf7e-4c11-be49-2044879c871c" />
      <SazbyDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="List">
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="23cfe052-322d-4545-b07b-f39bf61913be">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <Pouzita>True</Pouzita>
          <RozpisDPH_ID>2d2a7c84-d7f5-4c18-a52a-54f40db8d4e6</RozpisDPH_ID>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="2d2a7c84-d7f5-4c18-a52a-54f40db8d4e6">
            <Sazba>10.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>4009.50</Celkem>
              <DPH>364.50</DPH>
              <Zaklad>3645.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>4009.50</Celkem>
              <DPH>364.50</DPH>
              <Zaklad>3645.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="51f1fde5-6d64-4101-8f7e-c852b3272ab4">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Zakladni">1</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>139814c3-cb83-4085-b083-6f6a51315e2f</RozpisDPH_ID>
          <SazbaDPH_ID>b7d9bd88-bf7e-4c11-be49-2044879c871c</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="139814c3-cb83-4085-b083-6f6a51315e2f">
            <Sazba>21.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="b7d9bd88-bf7e-4c11-be49-2044879c871c">
            <DruhSazby EnumValueName="Zakladni">1</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>20</Priorita>
            <Sazba>21.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="66adbb62-8612-465f-89b0-ac68db90a494">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Nulova">2</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>dbd882db-d6f2-4977-85b2-babdb53ae616</RozpisDPH_ID>
          <SazbaDPH_ID>4940de08-8927-4731-ac4a-88f5aec97093</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="dbd882db-d6f2-4977-85b2-babdb53ae616">
            <Sazba>0.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="4940de08-8927-4731-ac4a-88f5aec97093">
            <DruhSazby EnumValueName="Nulova">2</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>1753-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>1</Priorita>
            <Sazba>0.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="9a4dda0c-5114-44e1-bb37-6e64ec3625c8">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>bab32efe-95ab-443a-b502-eaddd7dfc888</RozpisDPH_ID>
          <SazbaDPH_ID>ab01bdbb-662b-422c-8835-a9270fb48eab</SazbaDPH_ID>
          <VybranaNaHlavicce>False</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="bab32efe-95ab-443a-b502-eaddd7dfc888">
            <Sazba>15.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="ab01bdbb-662b-422c-8835-a9270fb48eab">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
            <Poradi>2</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>19</Priorita>
            <Sazba>15.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
      </SazbyDPHNaDoklade>
      <VazbyObjektu ObjectName="VazbaObjektu" ObjectType="List" />
      <ZpusobDopravy ObjectName="ZpusobDopravy" ObjectType="Object" ID="987aa2ec-d6d2-459f-abfd-374b71116d88">
        <Kod>PB</Kod>
        <Nazev>Přepravní služba Balík</Nazev>
        <Poznamka />
      </ZpusobDopravy>
      <ZpusobPlatby ObjectName="ZpusobPlatby" ObjectType="Object" ID="d3b43f46-2cdd-413f-b51c-ad9096771980">
        <Kod>B</Kod>
        <Nazev>Bankovním převodem</Nazev>
        <Poznamka />
      </ZpusobPlatby>
    </ObjednavkaPrijata>
    <ObjednavkaPrijata ObjectName="ObjednavkaPrijata" ObjectType="Object" ID="b519d654-41f1-4fd3-97b2-9fe59a307b89">
      <AdresaKoncovehoPrijemceEmailSpojeni_ID>e16ca2d6-660c-4eda-aee9-7133d834b89d</AdresaKoncovehoPrijemceEmailSpojeni_ID>
      <AdresaKoncovehoPrijemceKontaktniOsoba_ID />
      <AdresaKoncovehoPrijemceStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaKoncovehoPrijemceStat_ID>
      <AdresaKoncovehoPrijemceTelefonSpojeni_ID>4cb87605-7363-4d54-92fb-14e24fdc054b</AdresaKoncovehoPrijemceTelefonSpojeni_ID>
      <AdresaKontaktniOsoba_ID />
      <AdresaPrijemceFakturyKontaktniOsoba_ID />
      <AdresaPrijemceFakturyStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaPrijemceFakturyStat_ID>
      <AdresaStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaStat_ID>
      <AutoRow_ID>3</AutoRow_ID>
      <CelkovaCastka>18396.40</CelkovaCastka>
      <CelkovaCastkaCM>18396.40</CelkovaCastkaCM>
      <CelkovaCastkaDual>554209.95</CelkovaCastkaDual>
      <Cinnost_ID />
      <CiselnaRada_ID>7a1cacb6-1692-4683-818d-1a22caf2949e</CiselnaRada_ID>
      <CisloDokladu>OP00003</CisloDokladu>
      <CisloRady>3</CisloRady>
      <DatumVyrizeni>2015-01-08T00:00:00</DatumVyrizeni>
      <DatumVystaveni>2015-01-07T00:00:00</DatumVystaveni>
      <DIC>CZ6903064135</DIC>
      <DodaciAdresaFirma_ID>df9d300b-e8ce-4d0e-bebf-567a1d1deebc</DodaciAdresaFirma_ID>
      <DodaciPodminky_ID />
      <DomaciMena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</DomaciMena_ID>
      <DruhDokladu_ID>8ba81511-9cb2-45b8-9278-558647b8d310</DruhDokladu_ID>
      <DruhDopravy_ID />
      <FakturacniAdresaFirma_ID>df9d300b-e8ce-4d0e-bebf-567a1d1deebc</FakturacniAdresaFirma_ID>
      <Faze EnumValueName="Aktivni">1</Faze>
      <Firma_ID>df9d300b-e8ce-4d0e-bebf-567a1d1deebc</Firma_ID>
      <IC>45680001</IC>
      <ICDPH />
      <IDKrajPuvodu_ID />
      <IDPovahaTransakce_ID />
      <Jmeno />
      <KonecnyPrijemce_ID />
      <Mena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</Mena_ID>
      <MojeFirma_ID>7503fef6-8eda-4d97-82dc-fcb9ece79cfe</MojeFirma_ID>
      <MojeFirmaBanka_ID>1ba31972-cf0a-44a4-88fe-d0b212e13a84</MojeFirmaBanka_ID>
      <MojeFirmaBankovniSpojeni_ID>41acd46c-dac4-441e-a624-cf516ddeaf04</MojeFirmaBankovniSpojeni_ID>
      <MojeFirmaFirma_ID />
      <MojeFirmaKontaktniOsoba_ID />
      <MojeFirmaStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</MojeFirmaStat_ID>
      <Nazev>Hraška na obalování 250 g</Nazev>
      <Odkaz />
      <Osoba_ID />
      <PevneCeny>False</PevneCeny>
      <PlatnostDo>2015-01-08T00:00:00</PlatnostDo>
      <PlatnostOd>2015-01-07T00:00:00</PlatnostOd>
      <PocetPolozek>5</PocetPolozek>
      <PovahaTransakce_ID />
      <Poznamka />
      <PrijemceFaktury_ID />
      <PriznakVyrizeno>True</PriznakVyrizeno>
      <ProcentniZisk>0.00</ProcentniZisk>
      <RegistraceDPH_ID>fc1e873a-ffe1-4095-a78d-bb2eed9c39f4</RegistraceDPH_ID>
      <SazbaDPH0_ID>4940de08-8927-4731-ac4a-88f5aec97093</SazbaDPH0_ID>
      <SazbaDPH1_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH1_ID>
      <SazbaDPH2_ID>b7d9bd88-bf7e-4c11-be49-2044879c871c</SazbaDPH2_ID>
      <Schvaleno>True</Schvaleno>
      <Sleva>0.00</Sleva>
      <Stat_ID />
      <StatPuvodu_ID />
      <StatUrceniOdeslani_ID />
      <Stav EnumValueName="Rozpracovano">0</Stav>
      <Storno EnumValueName="NeniStorno">0</Storno>
      <Stredisko_ID />
      <Systemovy>False</Systemovy>
      <TypDokladu EnumValueName="Neurceny">0</TypDokladu>
      <VariabilniSymbol />
      <Vyrizeno>0</Vyrizeno>
      <Vystavil>Jaroslav Škvařil</Vystavil>
      <Zakazka_ID />
      <ZaokrouhleniCelkovaCastka_ID />
      <ZaokrouhleniDPH_ID />
      <ZaokrouhleniSazbaDPH_ID>ab01bdbb-662b-422c-8835-a9270fb48eab</ZaokrouhleniSazbaDPH_ID>
      <ZapornyPohyb>False</ZapornyPohyb>
      <Zauctovano>False</Zauctovano>
      <Zaverkovy>False</Zaverkovy>
      <ZiskZaDoklad>0.00</ZiskZaDoklad>
      <ZpusobDopravy_ID>73cd5949-ceaa-4ed3-ace8-34710f724e9c</ZpusobDopravy_ID>
      <ZpusobPlatby_ID>fa207763-b9d0-4750-b394-2c20ad230336</ZpusobPlatby_ID>
      <ZvlastniPohyb_ID />
      <Adresa>
        <KontaktniOsobaJmeno />
        <KontaktniOsobaNazev />
        <KontaktniOsobaPrijmeni />
        <Misto>Zlín</Misto>
        <Nazev>Ing. Petr Jedek</Nazev>
        <PSC>76001</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>Chmelnická 194</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="df9d300b-e8ce-4d0e-bebf-567a1d1deebc" />
      </Adresa>
      <AdresaKoncovehoPrijemce>
        <Email>objednavky@zdravizprirody.cz</Email>
        <KontaktniOsobaNazev />
        <Misto>Zlín</Misto>
        <Nazev>Jedek  Petr,  Ing. </Nazev>
        <PSC>76001</PSC>
        <Stat>Česká republika</Stat>
        <Telefon>777900490</Telefon>
        <Ulice>Chmelnická 194</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <EmailSpojeni ObjectName="Spojeni" ObjectType="Object" ID="e16ca2d6-660c-4eda-aee9-7133d834b89d" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="df9d300b-e8ce-4d0e-bebf-567a1d1deebc" />
        <TelefonSpojeni ObjectName="Spojeni" ObjectType="Object" ID="4cb87605-7363-4d54-92fb-14e24fdc054b" />
      </AdresaKoncovehoPrijemce>
      <AdresaPrijemceFaktury>
        <KontaktniOsobaNazev />
        <Misto>Zlín</Misto>
        <Nazev>Ing. Petr Jedek</Nazev>
        <PSC>76001</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>Chmelnická 194</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="df9d300b-e8ce-4d0e-bebf-567a1d1deebc" />
      </AdresaPrijemceFaktury>
      <DPH0>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>0.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </DPH0>
      <DPH1>
        <Celkem>18396.40</Celkem>
        <CelkemCM>18396.40</CelkemCM>
        <Dan>1672.40</Dan>
        <DanCM>1672.40</DanCM>
        <Sazba>10.00</Sazba>
        <Zaklad>16724.00</Zaklad>
        <ZakladCM>16724.00</ZakladCM>
      </DPH1>
      <DPH2>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>21.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </DPH2>
      <IntrastatDoklad>
        <Datum>2015-01-07T00:00:00</Datum>
        <DopravaTuzemsko>0.00</DopravaTuzemsko>
        <DopravaZahranici>0.00</DopravaZahranici>
        <DopravniNaklady>0.00</DopravniNaklady>
        <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
        <RozpousteniNakladu EnumValueName="CenaZbozi">0</RozpousteniNakladu>
      </IntrastatDoklad>
      <Korekce0>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>0.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce0>
      <Korekce1>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>10.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce1>
      <Korekce2>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>21.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce2>
      <MojeFirma>
        <DIC>CZ26294010</DIC>
        <IC>26294010</IC>
        <ICDPH />
        <Misto>Brno-střed</Misto>
        <Nazev>CERIA,s.r.o.</Nazev>
        <PSC>60200</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>Heinrichova 229/49</Ulice>
        <BankovniSpojeni>
          <CiselnyKod>0300</CiselnyKod>
          <CisloUctu>178570860</CisloUctu>
          <IBAN>CZ5503000000000178570860</IBAN>
          <SpecifickySymbol />
          <SWIFT>CEKOCZPP</SWIFT>
          <Banka ObjectName="Banka" ObjectType="Object" ID="1ba31972-cf0a-44a4-88fe-d0b212e13a84">
            <Group ID="ef04d885-1a39-4c48-a7a8-eb797000fd62" Kod="BAN" />
            <CiselnyKod>0300</CiselnyKod>
            <Kod>CEKO</Kod>
            <KonfiguraceKL_ID>5eb85f31-fcb1-4d5a-a758-5b9c6ba678a6</KonfiguraceKL_ID>
            <Nazev>Československá obchodní banka, a.s.</Nazev>
            <Poznamka />
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <SWIFT>CEKOCZPP</SWIFT>
            <KonfiguraceKL ObjectName="KonfiguraceKurzovnichListku" ObjectType="Object" ID="5eb85f31-fcb1-4d5a-a758-5b9c6ba678a6" />
            <SeznamKonfiguraciKL ObjectName="BankaKonfiguraceKL" ObjectType="List" />
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </Banka>
          <BankovniSpojeni ObjectName="BankovniSpojeni" ObjectType="Object" ID="41acd46c-dac4-441e-a624-cf516ddeaf04" />
        </BankovniSpojeni>
        <Kontakty>
          <Email>info@ceria.cz</Email>
          <Telefon1>+420532308550</Telefon1>
          <Telefon2>+420511140390</Telefon2>
          <Telefon3>+420910089390</Telefon3>
          <WWW>ceria.cz</WWW>
        </Kontakty>
        <Osoba />
        <Firma ObjectName="Firma" ObjectType="Object" ID="7503fef6-8eda-4d97-82dc-fcb9ece79cfe" />
        <MojeFirmaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
      </MojeFirma>
      <Suma>
        <Celkem>18396.40</Celkem>
        <CelkemCM>18396.40</CelkemCM>
        <Dan>1672.40</Dan>
        <DanCM>1672.40</DanCM>
        <Zaklad>16724.00</Zaklad>
        <ZakladCM>16724.00</ZakladCM>
      </Suma>
      <Texty />
      <UcetniKurz>
        <Kurz>1.000000</Kurz>
        <Mnozstvi>1.000000</Mnozstvi>
      </UcetniKurz>
      <Zaokrouhleni>
        <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
        <PrevazujiciSazbaDPH>True</PrevazujiciSazbaDPH>
        <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="ab01bdbb-662b-422c-8835-a9270fb48eab">
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
          <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
          <Poradi>2</Poradi>
          <PovahaSazbyDPH_ID />
          <PrimarniUcetVstup_ID />
          <PrimarniUcetVystup_ID />
          <Priorita>19</Priorita>
          <Sazba>15.00</Sazba>
          <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
          <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        </SazbaDPH>
      </Zaokrouhleni>
      <CiselnaRada ObjectName="CiselnaRada" ObjectType="Object" ID="7a1cacb6-1692-4683-818d-1a22caf2949e">
        <Kod>OBJ_PRI</Kod>
        <Nazev>Objednávky přijaté</Nazev>
        <NevracetDoVolnychCisel>True</NevracetDoVolnychCisel>
        <Poznamka />
        <Prefix>OP</Prefix>
        <SeznamObdobi ObjectName="ObdobiCiselneRady" ObjectType="List">
          <ObdobiCiselneRady ObjectName="ObdobiCiselneRady" ObjectType="Object" ID="2cdd3cdb-ef24-480f-9d7b-859627caa171">
            <CiselnyPrefix />
            <Cislo>6</Cislo>
            <PocetMist>5</PocetMist>
            <Zacatek>1753-01-01T00:00:00</Zacatek>
            <ZobrazitNuly>True</ZobrazitNuly>
            <VolnaCisla ObjectName="VolneCislo" ObjectType="List" />
          </ObdobiCiselneRady>
        </SeznamObdobi>
      </CiselnaRada>
      <DokladInfo ObjectName="DokladInfo" ObjectType="List" />
      <DomaciMena ObjectName="Mena" ObjectType="Object" ID="00f9adb2-d300-42c3-9240-ae1320b019cc" />
      <DruhDokladu ObjectName="DruhDokladu" ObjectType="Object" ID="8ba81511-9cb2-45b8-9278-558647b8d310" />
      <Mena ObjectName="Mena" ObjectType="Object" ID="00f9adb2-d300-42c3-9240-ae1320b019cc">
        <Banka_ID />
        <DesMisto>0</DesMisto>
        <Kod>CZK</Kod>
        <Nazev>Koruna česká</Nazev>
        <Poznamka />
        <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
        <Symbol>Kč</Symbol>
        <TypJednotky EnumValueName="Mena">2</TypJednotky>
        <DenominaceList ObjectName="PrevodDenominace" ObjectType="List" />
        <PrevodyList ObjectName="PrevodMen" ObjectType="List" />
        <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
      </Mena>
      <Polozky ObjectName="PolozkaObjednavkyPrijate" ObjectType="List">
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="f4b50fa7-5928-4755-8ddd-8af55ad151fc">
          <AutoRow_ID>6</AutoRow_ID>
          <CelkovaCena>2760.00</CelkovaCena>
          <CelkovaCenaBezSlevy>2760.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>2760.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>2760.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>1</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>23.0000</JednCena>
          <JednCenaCM>23.0000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>23.0000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>23.0000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>120.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na obalování 250 g</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>0601a35d-4c1d-4d1f-ad01-23cdefb27b9e</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-08T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>1</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>120.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>3036.00</Celkem>
            <CelkemCM>3036.00</CelkemCM>
            <Dan>276.00</Dan>
            <DanCM>276.00</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>2760.00</Zaklad>
            <ZakladCM>2760.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>0.250</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="0601a35d-4c1d-4d1f-ad01-23cdefb27b9e">
            <Artikl_ID>80dd9bb7-c1c0-4dac-b6b4-1639f4194537</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>d53f4446-5fc7-4b81-af9c-84a5cb55b506</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>227</AutoRow_ID>
            <BeznaCena>27.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>1241f2cb-cb53-4fad-b19d-7545286caeb6</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>d53f4446-5fc7-4b81-af9c-84a5cb55b506</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>120.0000</MinuleMnozstviRezervace>
            <Mnozstvi>120.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-14.81</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00058</PartnerskyKod>
            <PartnerskyNazev>Hraška na obalování 250 g</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>c6e46461-779d-4730-bd21-c40a42d01d47</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="80dd9bb7-c1c0-4dac-b6b4-1639f4194537" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="d53f4446-5fc7-4b81-af9c-84a5cb55b506" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="1241f2cb-cb53-4fad-b19d-7545286caeb6" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="d53f4446-5fc7-4b81-af9c-84a5cb55b506">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="c6e46461-779d-4730-bd21-c40a42d01d47" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="19728746-8b13-482f-a9c1-78ffc1bf7a56">
          <AutoRow_ID>9</AutoRow_ID>
          <CelkovaCena>2244.00</CelkovaCena>
          <CelkovaCenaBezSlevy>2244.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>2244.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>2244.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>3</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>74.8000</JednCena>
          <JednCenaCM>74.8000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>74.8000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>74.8000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>30.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na zahušťování 1 kg</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>d0a4bf0d-c18a-4303-89d8-2cb34c87cdba</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-08T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>3</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>30.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>2468.40</Celkem>
            <CelkemCM>2468.40</CelkemCM>
            <Dan>224.40</Dan>
            <DanCM>224.40</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>2244.00</Zaklad>
            <ZakladCM>2244.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>1.000</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="d0a4bf0d-c18a-4303-89d8-2cb34c87cdba">
            <Artikl_ID>04c8292f-a1ee-46aa-86d0-04f6ae65eb2a</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>5805bef8-91e5-4435-b23f-376e347033f7</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>230</AutoRow_ID>
            <BeznaCena>88.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>1241f2cb-cb53-4fad-b19d-7545286caeb6</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>5805bef8-91e5-4435-b23f-376e347033f7</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>30.0000</MinuleMnozstviRezervace>
            <Mnozstvi>30.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-15.00</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00063</PartnerskyKod>
            <PartnerskyNazev>Hraška na zahušťování 1 kg</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>42ae98d9-ed4c-442e-8bb5-48bc72a67e38</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="04c8292f-a1ee-46aa-86d0-04f6ae65eb2a" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="5805bef8-91e5-4435-b23f-376e347033f7" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="1241f2cb-cb53-4fad-b19d-7545286caeb6" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="5805bef8-91e5-4435-b23f-376e347033f7">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="42ae98d9-ed4c-442e-8bb5-48bc72a67e38" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="084574e6-67fb-4565-99ce-f0b0c4d377ac">
          <AutoRow_ID>5</AutoRow_ID>
          <CelkovaCena>8970.00</CelkovaCena>
          <CelkovaCenaBezSlevy>8970.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>8970.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>8970.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>2</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>23.0000</JednCena>
          <JednCenaCM>23.0000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>23.0000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>23.0000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>390.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na zahušťování 250 g</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>660b6d80-16a8-464c-819c-3bc077a62277</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-08T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>2</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>390.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>9867.00</Celkem>
            <CelkemCM>9867.00</CelkemCM>
            <Dan>897.00</Dan>
            <DanCM>897.00</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>8970.00</Zaklad>
            <ZakladCM>8970.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>0.250</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="660b6d80-16a8-464c-819c-3bc077a62277">
            <Artikl_ID>9f0834cf-c14c-4967-b1f4-41e2e3171cae</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>e9543ba3-3d09-4156-97a8-6ed31cf8fda6</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>226</AutoRow_ID>
            <BeznaCena>27.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>1241f2cb-cb53-4fad-b19d-7545286caeb6</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>e9543ba3-3d09-4156-97a8-6ed31cf8fda6</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>390.0000</MinuleMnozstviRezervace>
            <Mnozstvi>390.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-14.81</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00064</PartnerskyKod>
            <PartnerskyNazev>Hraška na zahušťování 250 g</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>22990ff0-8265-4e6a-913f-308892411db9</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="9f0834cf-c14c-4967-b1f4-41e2e3171cae" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="e9543ba3-3d09-4156-97a8-6ed31cf8fda6" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="1241f2cb-cb53-4fad-b19d-7545286caeb6" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="e9543ba3-3d09-4156-97a8-6ed31cf8fda6">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="22990ff0-8265-4e6a-913f-308892411db9" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="1d057a55-975a-4f32-b114-5ac7ff81cd97">
          <AutoRow_ID>8</AutoRow_ID>
          <CelkovaCena>2070.00</CelkovaCena>
          <CelkovaCenaBezSlevy>2070.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>2070.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>2070.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>4</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>23.0000</JednCena>
          <JednCenaCM>23.0000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>23.0000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>23.0000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>90.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška vanilkaí 250 g</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>8f4a8140-1d4e-4fb0-8234-040937ddf890</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-08T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>4</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>90.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>2277.00</Celkem>
            <CelkemCM>2277.00</CelkemCM>
            <Dan>207.00</Dan>
            <DanCM>207.00</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>2070.00</Zaklad>
            <ZakladCM>2070.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>0.250</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="8f4a8140-1d4e-4fb0-8234-040937ddf890">
            <Artikl_ID>b16c87b2-58f9-4e40-baf7-9dd9eb635f9c</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>93cabb0a-b14f-4c4a-ad5d-586c1eedadf1</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>229</AutoRow_ID>
            <BeznaCena>27.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>1241f2cb-cb53-4fad-b19d-7545286caeb6</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>93cabb0a-b14f-4c4a-ad5d-586c1eedadf1</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>90.0000</MinuleMnozstviRezervace>
            <Mnozstvi>90.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-14.81</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00067</PartnerskyKod>
            <PartnerskyNazev>Hraška vanilkaí 250 g</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>7cbf7529-8696-4771-b016-9c835e0681cc</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="b16c87b2-58f9-4e40-baf7-9dd9eb635f9c" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="93cabb0a-b14f-4c4a-ad5d-586c1eedadf1" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="1241f2cb-cb53-4fad-b19d-7545286caeb6" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="93cabb0a-b14f-4c4a-ad5d-586c1eedadf1">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="7cbf7529-8696-4771-b016-9c835e0681cc" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="a546d384-b15b-4915-8845-3efcbf21d57b">
          <AutoRow_ID>7</AutoRow_ID>
          <CelkovaCena>680.00</CelkovaCena>
          <CelkovaCenaBezSlevy>680.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>680.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>680.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>5</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>17.0000</JednCena>
          <JednCenaCM>17.0000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>17.0000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>17.0000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>40.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Mahá koření 100 g</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>c97bfbf4-2b18-454d-a465-3ffd34880ef0</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-08T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>5</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>40.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>748.00</Celkem>
            <CelkemCM>748.00</CelkemCM>
            <Dan>68.00</Dan>
            <DanCM>68.00</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>680.00</Zaklad>
            <ZakladCM>680.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>0.100</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="c97bfbf4-2b18-454d-a465-3ffd34880ef0">
            <Artikl_ID>4dd808bc-e86a-4100-ab3c-5df3fe096aed</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>acea3b28-8d37-4aa5-8485-befb12c11f3e</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>228</AutoRow_ID>
            <BeznaCena>20.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>1241f2cb-cb53-4fad-b19d-7545286caeb6</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>acea3b28-8d37-4aa5-8485-befb12c11f3e</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>40.0000</MinuleMnozstviRezervace>
            <Mnozstvi>40.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-15.00</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00068</PartnerskyKod>
            <PartnerskyNazev>Mahá koření 100 g</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>b292effc-587c-44fc-afca-ad0be3d18bdc</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="4dd808bc-e86a-4100-ab3c-5df3fe096aed" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="acea3b28-8d37-4aa5-8485-befb12c11f3e" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="1241f2cb-cb53-4fad-b19d-7545286caeb6" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="acea3b28-8d37-4aa5-8485-befb12c11f3e">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="b292effc-587c-44fc-afca-ad0be3d18bdc" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
      </Polozky>
      <Poplatky ObjectName="PoplatekZaDoklad" ObjectType="List" />
      <RegistraceDPH ObjectName="DanovaRegistrace" ObjectType="Object" ID="fc1e873a-ffe1-4095-a78d-bb2eed9c39f4" />
      <SazbaDPH0 ObjectName="SazbaDPH" ObjectType="Object" ID="4940de08-8927-4731-ac4a-88f5aec97093" />
      <SazbaDPH1 ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
      <SazbaDPH2 ObjectName="SazbaDPH" ObjectType="Object" ID="b7d9bd88-bf7e-4c11-be49-2044879c871c" />
      <SazbyDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="List">
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="2351f5d9-2c0b-4646-b8a9-285f0f378505">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>1b46943a-490b-4ba2-989d-10477d1e8b72</RozpisDPH_ID>
          <SazbaDPH_ID>ab01bdbb-662b-422c-8835-a9270fb48eab</SazbaDPH_ID>
          <VybranaNaHlavicce>False</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="1b46943a-490b-4ba2-989d-10477d1e8b72">
            <Sazba>15.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="ab01bdbb-662b-422c-8835-a9270fb48eab">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
            <Poradi>2</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>19</Priorita>
            <Sazba>15.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="8e30c018-5556-4a47-9bf2-afbd6b3c45a7">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Nulova">2</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>9e99513c-a416-474b-8bf0-34aca797ed56</RozpisDPH_ID>
          <SazbaDPH_ID>4940de08-8927-4731-ac4a-88f5aec97093</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="9e99513c-a416-474b-8bf0-34aca797ed56">
            <Sazba>0.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="4940de08-8927-4731-ac4a-88f5aec97093">
            <DruhSazby EnumValueName="Nulova">2</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>1753-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>1</Priorita>
            <Sazba>0.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="c0b558a4-cbb1-4878-b160-55e251750089">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Zakladni">1</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>417ac902-7e35-4da0-a8bd-2b6a24a1529b</RozpisDPH_ID>
          <SazbaDPH_ID>b7d9bd88-bf7e-4c11-be49-2044879c871c</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="417ac902-7e35-4da0-a8bd-2b6a24a1529b">
            <Sazba>21.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="b7d9bd88-bf7e-4c11-be49-2044879c871c">
            <DruhSazby EnumValueName="Zakladni">1</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>20</Priorita>
            <Sazba>21.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="caed93ac-37a7-4023-a71e-965960412c8f">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <Pouzita>True</Pouzita>
          <RozpisDPH_ID>352ec2b5-8783-48d6-81cf-7198344d2d1e</RozpisDPH_ID>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="352ec2b5-8783-48d6-81cf-7198344d2d1e">
            <Sazba>10.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>18396.40</Celkem>
              <DPH>1672.40</DPH>
              <Zaklad>16724.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>18396.40</Celkem>
              <DPH>1672.40</DPH>
              <Zaklad>16724.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
      </SazbyDPHNaDoklade>
      <VazbyObjektu ObjectName="VazbaObjektu" ObjectType="List" />
      <ZpusobDopravy ObjectName="ZpusobDopravy" ObjectType="Object" ID="73cd5949-ceaa-4ed3-ace8-34710f724e9c">
        <Kod>O</Kod>
        <Nazev>Osobní odběr</Nazev>
        <Poznamka />
      </ZpusobDopravy>
      <ZpusobPlatby ObjectName="ZpusobPlatby" ObjectType="Object" ID="fa207763-b9d0-4750-b394-2c20ad230336">
        <Kod>H</Kod>
        <Nazev>Hotově</Nazev>
        <Poznamka />
      </ZpusobPlatby>
    </ObjednavkaPrijata>
    <ObjednavkaPrijata ObjectName="ObjednavkaPrijata" ObjectType="Object" ID="29c6b972-82e4-44ab-b8f2-249af0f36ee6">
      <AdresaKoncovehoPrijemceEmailSpojeni_ID />
      <AdresaKoncovehoPrijemceKontaktniOsoba_ID />
      <AdresaKoncovehoPrijemceStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaKoncovehoPrijemceStat_ID>
      <AdresaKoncovehoPrijemceTelefonSpojeni_ID />
      <AdresaKontaktniOsoba_ID />
      <AdresaPrijemceFakturyKontaktniOsoba_ID />
      <AdresaPrijemceFakturyStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaPrijemceFakturyStat_ID>
      <AdresaStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaStat_ID>
      <AutoRow_ID>4</AutoRow_ID>
      <CelkovaCastka>35274.80</CelkovaCastka>
      <CelkovaCastkaCM>35274.80</CelkovaCastkaCM>
      <CelkovaCastkaDual>1062688.62</CelkovaCastkaDual>
      <Cinnost_ID />
      <CiselnaRada_ID>7a1cacb6-1692-4683-818d-1a22caf2949e</CiselnaRada_ID>
      <CisloDokladu>OP00004</CisloDokladu>
      <CisloRady>4</CisloRady>
      <DatumVyrizeni>2015-01-08T00:00:00</DatumVyrizeni>
      <DatumVystaveni>2015-01-07T00:00:00</DatumVystaveni>
      <DIC>CZ45792585</DIC>
      <DodaciAdresaFirma_ID>9f917cab-a3c1-4513-96ae-958d4e28ba18</DodaciAdresaFirma_ID>
      <DodaciPodminky_ID />
      <DomaciMena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</DomaciMena_ID>
      <DruhDokladu_ID>8ba81511-9cb2-45b8-9278-558647b8d310</DruhDokladu_ID>
      <DruhDopravy_ID />
      <FakturacniAdresaFirma_ID>9f917cab-a3c1-4513-96ae-958d4e28ba18</FakturacniAdresaFirma_ID>
      <Faze EnumValueName="Aktivni">1</Faze>
      <Firma_ID>9f917cab-a3c1-4513-96ae-958d4e28ba18</Firma_ID>
      <IC>45792585</IC>
      <ICDPH />
      <IDKrajPuvodu_ID />
      <IDPovahaTransakce_ID />
      <Jmeno />
      <KonecnyPrijemce_ID />
      <Mena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</Mena_ID>
      <MojeFirma_ID>7503fef6-8eda-4d97-82dc-fcb9ece79cfe</MojeFirma_ID>
      <MojeFirmaBanka_ID>1ba31972-cf0a-44a4-88fe-d0b212e13a84</MojeFirmaBanka_ID>
      <MojeFirmaBankovniSpojeni_ID>41acd46c-dac4-441e-a624-cf516ddeaf04</MojeFirmaBankovniSpojeni_ID>
      <MojeFirmaFirma_ID />
      <MojeFirmaKontaktniOsoba_ID />
      <MojeFirmaStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</MojeFirmaStat_ID>
      <Nazev>Hraška na obalování 1 kg</Nazev>
      <Odkaz />
      <Osoba_ID />
      <PevneCeny>False</PevneCeny>
      <PlatnostDo>2015-01-09T00:00:00</PlatnostDo>
      <PlatnostOd>2015-01-07T00:00:00</PlatnostOd>
      <PocetPolozek>5</PocetPolozek>
      <PovahaTransakce_ID />
      <Poznamka />
      <PrijemceFaktury_ID />
      <PriznakVyrizeno>True</PriznakVyrizeno>
      <ProcentniZisk>0.00</ProcentniZisk>
      <RegistraceDPH_ID>fc1e873a-ffe1-4095-a78d-bb2eed9c39f4</RegistraceDPH_ID>
      <SazbaDPH0_ID>4940de08-8927-4731-ac4a-88f5aec97093</SazbaDPH0_ID>
      <SazbaDPH1_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH1_ID>
      <SazbaDPH2_ID>b7d9bd88-bf7e-4c11-be49-2044879c871c</SazbaDPH2_ID>
      <Schvaleno>True</Schvaleno>
      <Sleva>0.00</Sleva>
      <Stat_ID />
      <StatPuvodu_ID />
      <StatUrceniOdeslani_ID />
      <Stav EnumValueName="Rozpracovano">0</Stav>
      <Storno EnumValueName="NeniStorno">0</Storno>
      <Stredisko_ID />
      <Systemovy>False</Systemovy>
      <TypDokladu EnumValueName="Neurceny">0</TypDokladu>
      <VariabilniSymbol />
      <Vyrizeno>0</Vyrizeno>
      <Vystavil>Jaroslav Škvařil</Vystavil>
      <Zakazka_ID />
      <ZaokrouhleniCelkovaCastka_ID />
      <ZaokrouhleniDPH_ID />
      <ZaokrouhleniSazbaDPH_ID>ab01bdbb-662b-422c-8835-a9270fb48eab</ZaokrouhleniSazbaDPH_ID>
      <ZapornyPohyb>False</ZapornyPohyb>
      <Zauctovano>False</Zauctovano>
      <Zaverkovy>False</Zaverkovy>
      <ZiskZaDoklad>0.00</ZiskZaDoklad>
      <ZpusobDopravy_ID>73cd5949-ceaa-4ed3-ace8-34710f724e9c</ZpusobDopravy_ID>
      <ZpusobPlatby_ID>d3b43f46-2cdd-413f-b51c-ad9096771980</ZpusobPlatby_ID>
      <ZvlastniPohyb_ID />
      <Adresa>
        <KontaktniOsobaJmeno />
        <KontaktniOsobaNazev />
        <KontaktniOsobaPrijmeni />
        <Misto>Nenačovice</Misto>
        <Nazev>COUNTRY LIFE s.r.o.</Nazev>
        <PSC>26601</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>Nenačovice 87</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="9f917cab-a3c1-4513-96ae-958d4e28ba18" />
      </Adresa>
      <AdresaKoncovehoPrijemce>
        <Email />
        <KontaktniOsobaNazev />
        <Misto>Nenačovice</Misto>
        <Nazev>COUNTRY LIFE s.r.o.</Nazev>
        <PSC>26601</PSC>
        <Stat>Česká republika</Stat>
        <Telefon />
        <Ulice>Nenačovice 87</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="9f917cab-a3c1-4513-96ae-958d4e28ba18" />
      </AdresaKoncovehoPrijemce>
      <AdresaPrijemceFaktury>
        <KontaktniOsobaNazev />
        <Misto>Nenačovice</Misto>
        <Nazev>COUNTRY LIFE s.r.o.</Nazev>
        <PSC>26601</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>Nenačovice 87</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="9f917cab-a3c1-4513-96ae-958d4e28ba18" />
      </AdresaPrijemceFaktury>
      <DPH0>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>0.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </DPH0>
      <DPH1>
        <Celkem>35274.80</Celkem>
        <CelkemCM>35274.80</CelkemCM>
        <Dan>3206.80</Dan>
        <DanCM>3206.80</DanCM>
        <Sazba>10.00</Sazba>
        <Zaklad>32068.00</Zaklad>
        <ZakladCM>32068.00</ZakladCM>
      </DPH1>
      <DPH2>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>21.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </DPH2>
      <IntrastatDoklad>
        <Datum>2015-01-07T00:00:00</Datum>
        <DopravaTuzemsko>0.00</DopravaTuzemsko>
        <DopravaZahranici>0.00</DopravaZahranici>
        <DopravniNaklady>0.00</DopravniNaklady>
        <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
        <RozpousteniNakladu EnumValueName="CenaZbozi">0</RozpousteniNakladu>
      </IntrastatDoklad>
      <Korekce0>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>0.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce0>
      <Korekce1>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>10.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce1>
      <Korekce2>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>21.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce2>
      <MojeFirma>
        <DIC>CZ26294010</DIC>
        <IC>26294010</IC>
        <ICDPH />
        <Misto>Brno-střed</Misto>
        <Nazev>CERIA,s.r.o.</Nazev>
        <PSC>60200</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>Heinrichova 229/49</Ulice>
        <BankovniSpojeni>
          <CiselnyKod>0300</CiselnyKod>
          <CisloUctu>178570860</CisloUctu>
          <IBAN>CZ5503000000000178570860</IBAN>
          <SpecifickySymbol />
          <SWIFT>CEKOCZPP</SWIFT>
          <Banka ObjectName="Banka" ObjectType="Object" ID="1ba31972-cf0a-44a4-88fe-d0b212e13a84">
            <Group ID="ef04d885-1a39-4c48-a7a8-eb797000fd62" Kod="BAN" />
            <CiselnyKod>0300</CiselnyKod>
            <Kod>CEKO</Kod>
            <KonfiguraceKL_ID>5eb85f31-fcb1-4d5a-a758-5b9c6ba678a6</KonfiguraceKL_ID>
            <Nazev>Československá obchodní banka, a.s.</Nazev>
            <Poznamka />
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <SWIFT>CEKOCZPP</SWIFT>
            <KonfiguraceKL ObjectName="KonfiguraceKurzovnichListku" ObjectType="Object" ID="5eb85f31-fcb1-4d5a-a758-5b9c6ba678a6" />
            <SeznamKonfiguraciKL ObjectName="BankaKonfiguraceKL" ObjectType="List" />
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </Banka>
          <BankovniSpojeni ObjectName="BankovniSpojeni" ObjectType="Object" ID="41acd46c-dac4-441e-a624-cf516ddeaf04" />
        </BankovniSpojeni>
        <Kontakty>
          <Email>info@ceria.cz</Email>
          <Telefon1>+420532308550</Telefon1>
          <Telefon2>+420511140390</Telefon2>
          <Telefon3>+420910089390</Telefon3>
          <WWW>ceria.cz</WWW>
        </Kontakty>
        <Osoba />
        <Firma ObjectName="Firma" ObjectType="Object" ID="7503fef6-8eda-4d97-82dc-fcb9ece79cfe" />
        <MojeFirmaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
      </MojeFirma>
      <Suma>
        <Celkem>35274.80</Celkem>
        <CelkemCM>35274.80</CelkemCM>
        <Dan>3206.80</Dan>
        <DanCM>3206.80</DanCM>
        <Zaklad>32068.00</Zaklad>
        <ZakladCM>32068.00</ZakladCM>
      </Suma>
      <Texty />
      <UcetniKurz>
        <Kurz>1.000000</Kurz>
        <Mnozstvi>1.000000</Mnozstvi>
      </UcetniKurz>
      <Zaokrouhleni>
        <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
        <PrevazujiciSazbaDPH>True</PrevazujiciSazbaDPH>
        <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="ab01bdbb-662b-422c-8835-a9270fb48eab">
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
          <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
          <Poradi>2</Poradi>
          <PovahaSazbyDPH_ID />
          <PrimarniUcetVstup_ID />
          <PrimarniUcetVystup_ID />
          <Priorita>19</Priorita>
          <Sazba>15.00</Sazba>
          <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
          <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        </SazbaDPH>
      </Zaokrouhleni>
      <CiselnaRada ObjectName="CiselnaRada" ObjectType="Object" ID="7a1cacb6-1692-4683-818d-1a22caf2949e">
        <Kod>OBJ_PRI</Kod>
        <Nazev>Objednávky přijaté</Nazev>
        <NevracetDoVolnychCisel>True</NevracetDoVolnychCisel>
        <Poznamka />
        <Prefix>OP</Prefix>
        <SeznamObdobi ObjectName="ObdobiCiselneRady" ObjectType="List">
          <ObdobiCiselneRady ObjectName="ObdobiCiselneRady" ObjectType="Object" ID="2cdd3cdb-ef24-480f-9d7b-859627caa171">
            <CiselnyPrefix />
            <Cislo>6</Cislo>
            <PocetMist>5</PocetMist>
            <Zacatek>1753-01-01T00:00:00</Zacatek>
            <ZobrazitNuly>True</ZobrazitNuly>
            <VolnaCisla ObjectName="VolneCislo" ObjectType="List" />
          </ObdobiCiselneRady>
        </SeznamObdobi>
      </CiselnaRada>
      <DokladInfo ObjectName="DokladInfo" ObjectType="List" />
      <DomaciMena ObjectName="Mena" ObjectType="Object" ID="00f9adb2-d300-42c3-9240-ae1320b019cc" />
      <DruhDokladu ObjectName="DruhDokladu" ObjectType="Object" ID="8ba81511-9cb2-45b8-9278-558647b8d310" />
      <Mena ObjectName="Mena" ObjectType="Object" ID="00f9adb2-d300-42c3-9240-ae1320b019cc">
        <Banka_ID />
        <DesMisto>0</DesMisto>
        <Kod>CZK</Kod>
        <Nazev>Koruna česká</Nazev>
        <Poznamka />
        <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
        <Symbol>Kč</Symbol>
        <TypJednotky EnumValueName="Mena">2</TypJednotky>
        <DenominaceList ObjectName="PrevodDenominace" ObjectType="List" />
        <PrevodyList ObjectName="PrevodMen" ObjectType="List" />
        <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
      </Mena>
      <Polozky ObjectName="PolozkaObjednavkyPrijate" ObjectType="List">
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="ccd576e4-db1a-459f-82f4-16ddb4796d5d">
          <AutoRow_ID>14</AutoRow_ID>
          <CelkovaCena>2244.00</CelkovaCena>
          <CelkovaCenaBezSlevy>2244.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>2244.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>2244.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>1</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>74.8000</JednCena>
          <JednCenaCM>74.8000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>74.8000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>74.8000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>30.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na obalování 1 kg</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>0a49286b-4e30-4d0d-9c39-d4159e09b6e7</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-09T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>1</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>30.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>2468.40</Celkem>
            <CelkemCM>2468.40</CelkemCM>
            <Dan>224.40</Dan>
            <DanCM>224.40</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>2244.00</Zaklad>
            <ZakladCM>2244.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>1.000</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="0a49286b-4e30-4d0d-9c39-d4159e09b6e7">
            <Artikl_ID>04b91d10-944e-4b9e-908f-f117cd41bb05</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>2b587105-39c0-4918-b92b-d312935a015f</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>235</AutoRow_ID>
            <BeznaCena>88.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>1241f2cb-cb53-4fad-b19d-7545286caeb6</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>2b587105-39c0-4918-b92b-d312935a015f</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>30.0000</MinuleMnozstviRezervace>
            <Mnozstvi>30.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-15.00</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00057</PartnerskyKod>
            <PartnerskyNazev>Hraška na obalování 1 kg</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>7072499d-8ef4-4789-b8d9-b07ce030cf11</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="04b91d10-944e-4b9e-908f-f117cd41bb05" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="2b587105-39c0-4918-b92b-d312935a015f" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="1241f2cb-cb53-4fad-b19d-7545286caeb6" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="2b587105-39c0-4918-b92b-d312935a015f">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="7072499d-8ef4-4789-b8d9-b07ce030cf11" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="b1d0150e-006f-4be9-9bb6-23117ad57669">
          <AutoRow_ID>10</AutoRow_ID>
          <CelkovaCena>6880.00</CelkovaCena>
          <CelkovaCenaBezSlevy>6880.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>6880.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>6880.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>5</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>17.2000</JednCena>
          <JednCenaCM>17.2000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>17.2000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>17.2000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>400.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na obalování 140 g</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>9e7fa57c-d108-48ba-ac47-052ecd8cf097</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-09T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>5</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>400.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>7568.00</Celkem>
            <CelkemCM>7568.00</CelkemCM>
            <Dan>688.00</Dan>
            <DanCM>688.00</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>6880.00</Zaklad>
            <ZakladCM>6880.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>0.140</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="9e7fa57c-d108-48ba-ac47-052ecd8cf097">
            <Artikl_ID>16312d6b-86d9-447f-aa01-2e1896dc6f0c</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>e830dab9-e85c-4b4a-aed2-b772a7890820</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>231</AutoRow_ID>
            <BeznaCena>24.50</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>8f394744-c236-467f-be7a-6aefbf262097</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>e830dab9-e85c-4b4a-aed2-b772a7890820</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>400.0000</MinuleMnozstviRezervace>
            <Mnozstvi>400.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-29.80</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00062</PartnerskyKod>
            <PartnerskyNazev>Hraška na obalování 140 g</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>b04c96bf-a858-4de5-ae1e-e3ced2aa670b</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="16312d6b-86d9-447f-aa01-2e1896dc6f0c" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="e830dab9-e85c-4b4a-aed2-b772a7890820" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="8f394744-c236-467f-be7a-6aefbf262097" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="e830dab9-e85c-4b4a-aed2-b772a7890820">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="b04c96bf-a858-4de5-ae1e-e3ced2aa670b" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="7a63baf4-d207-432d-90a1-b12fcb7cc0f6">
          <AutoRow_ID>13</AutoRow_ID>
          <CelkovaCena>13800.00</CelkovaCena>
          <CelkovaCenaBezSlevy>13800.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>13800.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>13800.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>2</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>23.0000</JednCena>
          <JednCenaCM>23.0000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>23.0000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>23.0000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>600.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na obalování 250 g</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>c220c13a-62fd-4e8d-b9ae-e41eb7bde74e</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-09T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>2</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>600.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>15180.00</Celkem>
            <CelkemCM>15180.00</CelkemCM>
            <Dan>1380.00</Dan>
            <DanCM>1380.00</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>13800.00</Zaklad>
            <ZakladCM>13800.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>0.250</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="c220c13a-62fd-4e8d-b9ae-e41eb7bde74e">
            <Artikl_ID>80dd9bb7-c1c0-4dac-b6b4-1639f4194537</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>d53f4446-5fc7-4b81-af9c-84a5cb55b506</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>234</AutoRow_ID>
            <BeznaCena>27.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>1241f2cb-cb53-4fad-b19d-7545286caeb6</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>d53f4446-5fc7-4b81-af9c-84a5cb55b506</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>600.0000</MinuleMnozstviRezervace>
            <Mnozstvi>600.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-14.81</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00058</PartnerskyKod>
            <PartnerskyNazev>Hraška na obalování 250 g</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>c6e46461-779d-4730-bd21-c40a42d01d47</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="80dd9bb7-c1c0-4dac-b6b4-1639f4194537" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="d53f4446-5fc7-4b81-af9c-84a5cb55b506" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="1241f2cb-cb53-4fad-b19d-7545286caeb6" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="d53f4446-5fc7-4b81-af9c-84a5cb55b506">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="c6e46461-779d-4730-bd21-c40a42d01d47" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="aa913738-915f-445f-8e7e-842d036d39cd">
          <AutoRow_ID>12</AutoRow_ID>
          <CelkovaCena>2244.00</CelkovaCena>
          <CelkovaCenaBezSlevy>2244.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>2244.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>2244.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>3</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>74.8000</JednCena>
          <JednCenaCM>74.8000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>74.8000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>74.8000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>30.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na zahušťování 1 kg</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>23b2c3e9-2bf0-411f-97e6-c98dbf90987d</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-09T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>3</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>30.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>2468.40</Celkem>
            <CelkemCM>2468.40</CelkemCM>
            <Dan>224.40</Dan>
            <DanCM>224.40</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>2244.00</Zaklad>
            <ZakladCM>2244.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>1.000</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="23b2c3e9-2bf0-411f-97e6-c98dbf90987d">
            <Artikl_ID>04c8292f-a1ee-46aa-86d0-04f6ae65eb2a</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>5805bef8-91e5-4435-b23f-376e347033f7</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>233</AutoRow_ID>
            <BeznaCena>88.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>1241f2cb-cb53-4fad-b19d-7545286caeb6</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>5805bef8-91e5-4435-b23f-376e347033f7</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>30.0000</MinuleMnozstviRezervace>
            <Mnozstvi>30.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-15.00</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00063</PartnerskyKod>
            <PartnerskyNazev>Hraška na zahušťování 1 kg</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>42ae98d9-ed4c-442e-8bb5-48bc72a67e38</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="04c8292f-a1ee-46aa-86d0-04f6ae65eb2a" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="5805bef8-91e5-4435-b23f-376e347033f7" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="1241f2cb-cb53-4fad-b19d-7545286caeb6" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="5805bef8-91e5-4435-b23f-376e347033f7">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="42ae98d9-ed4c-442e-8bb5-48bc72a67e38" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="4e4f36f4-e78a-4ce7-a1cd-000d3a20f3bf">
          <AutoRow_ID>11</AutoRow_ID>
          <CelkovaCena>6900.00</CelkovaCena>
          <CelkovaCenaBezSlevy>6900.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>6900.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>6900.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>4</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>23.0000</JednCena>
          <JednCenaCM>23.0000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>23.0000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>23.0000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>300.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na zahušťování 250 g</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>a2f3f058-4c1e-43a1-951e-9d0234094544</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-09T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-07T00:00:00</PlatnaOd>
          <Poradi>4</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>300.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>7590.00</Celkem>
            <CelkemCM>7590.00</CelkemCM>
            <Dan>690.00</Dan>
            <DanCM>690.00</DanCM>
            <Sazba>10.00</Sazba>
            <Zaklad>6900.00</Zaklad>
            <ZakladCM>6900.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>0.250</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="a2f3f058-4c1e-43a1-951e-9d0234094544">
            <Artikl_ID>9f0834cf-c14c-4967-b1f4-41e2e3171cae</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>e9543ba3-3d09-4156-97a8-6ed31cf8fda6</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>232</AutoRow_ID>
            <BeznaCena>27.00</BeznaCena>
            <Cenik_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID>1241f2cb-cb53-4fad-b19d-7545286caeb6</CenovaHladina_ID>
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>e9543ba3-3d09-4156-97a8-6ed31cf8fda6</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>300.0000</MinuleMnozstviRezervace>
            <Mnozstvi>300.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-14.81</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00064</PartnerskyKod>
            <PartnerskyNazev>Hraška na zahušťování 250 g</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>22990ff0-8265-4e6a-913f-308892411db9</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="9f0834cf-c14c-4967-b1f4-41e2e3171cae" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="e9543ba3-3d09-4156-97a8-6ed31cf8fda6" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <CenovaHladina ObjectName="CenovaHladina" ObjectType="Object" ID="1241f2cb-cb53-4fad-b19d-7545286caeb6" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="e9543ba3-3d09-4156-97a8-6ed31cf8fda6">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="22990ff0-8265-4e6a-913f-308892411db9" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
      </Polozky>
      <Poplatky ObjectName="PoplatekZaDoklad" ObjectType="List" />
      <RegistraceDPH ObjectName="DanovaRegistrace" ObjectType="Object" ID="fc1e873a-ffe1-4095-a78d-bb2eed9c39f4" />
      <SazbaDPH0 ObjectName="SazbaDPH" ObjectType="Object" ID="4940de08-8927-4731-ac4a-88f5aec97093" />
      <SazbaDPH1 ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
      <SazbaDPH2 ObjectName="SazbaDPH" ObjectType="Object" ID="b7d9bd88-bf7e-4c11-be49-2044879c871c" />
      <SazbyDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="List">
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="826b5eaa-e6d5-44bc-9668-30cd036b9bca">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <Pouzita>True</Pouzita>
          <RozpisDPH_ID>85ac2075-a5d3-442e-93e0-122fb11e55d2</RozpisDPH_ID>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="85ac2075-a5d3-442e-93e0-122fb11e55d2">
            <Sazba>10.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>35274.80</Celkem>
              <DPH>3206.80</DPH>
              <Zaklad>32068.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>35274.80</Celkem>
              <DPH>3206.80</DPH>
              <Zaklad>32068.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="8c6eeaa3-b18f-437e-8b13-9755fa1a1852">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>225f130a-c05b-4c80-b87b-98d4a98a041c</RozpisDPH_ID>
          <SazbaDPH_ID>ab01bdbb-662b-422c-8835-a9270fb48eab</SazbaDPH_ID>
          <VybranaNaHlavicce>False</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="225f130a-c05b-4c80-b87b-98d4a98a041c">
            <Sazba>15.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="ab01bdbb-662b-422c-8835-a9270fb48eab">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
            <Poradi>2</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>19</Priorita>
            <Sazba>15.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="9fd5ff5b-9627-43dc-b082-5e041eb2459c">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Nulova">2</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>45a86519-1781-4034-a59c-6dc7c54a67f7</RozpisDPH_ID>
          <SazbaDPH_ID>4940de08-8927-4731-ac4a-88f5aec97093</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="45a86519-1781-4034-a59c-6dc7c54a67f7">
            <Sazba>0.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="4940de08-8927-4731-ac4a-88f5aec97093">
            <DruhSazby EnumValueName="Nulova">2</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>1753-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>1</Priorita>
            <Sazba>0.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="b32a483c-b48f-4ec5-9e06-15b0bf896426">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Zakladni">1</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>76205d43-ac3f-41f6-b216-69f672a2bda7</RozpisDPH_ID>
          <SazbaDPH_ID>b7d9bd88-bf7e-4c11-be49-2044879c871c</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="76205d43-ac3f-41f6-b216-69f672a2bda7">
            <Sazba>21.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="b7d9bd88-bf7e-4c11-be49-2044879c871c">
            <DruhSazby EnumValueName="Zakladni">1</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>20</Priorita>
            <Sazba>21.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
      </SazbyDPHNaDoklade>
      <VazbyObjektu ObjectName="VazbaObjektu" ObjectType="List" />
      <ZpusobDopravy ObjectName="ZpusobDopravy" ObjectType="Object" ID="73cd5949-ceaa-4ed3-ace8-34710f724e9c">
        <Kod>O</Kod>
        <Nazev>Osobní odběr</Nazev>
        <Poznamka />
      </ZpusobDopravy>
      <ZpusobPlatby ObjectName="ZpusobPlatby" ObjectType="Object" ID="d3b43f46-2cdd-413f-b51c-ad9096771980">
        <Kod>B</Kod>
        <Nazev>Bankovním převodem</Nazev>
        <Poznamka />
      </ZpusobPlatby>
    </ObjednavkaPrijata>
    <ObjednavkaPrijata ObjectName="ObjednavkaPrijata" ObjectType="Object" ID="3f900258-1b57-42d9-85bf-0e2934502700">
      <AdresaKoncovehoPrijemceEmailSpojeni_ID>d82d8a2b-e684-41f7-991b-6907e919749b</AdresaKoncovehoPrijemceEmailSpojeni_ID>
      <AdresaKoncovehoPrijemceKontaktniOsoba_ID />
      <AdresaKoncovehoPrijemceStat_ID>ed67bbe0-f18e-48ab-a7e9-f0a30097b28d</AdresaKoncovehoPrijemceStat_ID>
      <AdresaKoncovehoPrijemceTelefonSpojeni_ID>1dcf1705-2958-40e9-961c-b96644bce221</AdresaKoncovehoPrijemceTelefonSpojeni_ID>
      <AdresaKontaktniOsoba_ID />
      <AdresaPrijemceFakturyKontaktniOsoba_ID />
      <AdresaPrijemceFakturyStat_ID>ed67bbe0-f18e-48ab-a7e9-f0a30097b28d</AdresaPrijemceFakturyStat_ID>
      <AdresaStat_ID>ed67bbe0-f18e-48ab-a7e9-f0a30097b28d</AdresaStat_ID>
      <AutoRow_ID>5</AutoRow_ID>
      <CelkovaCastka>370.00</CelkovaCastka>
      <CelkovaCastkaCM>370.00</CelkovaCastkaCM>
      <CelkovaCastkaDual>11146.62</CelkovaCastkaDual>
      <Cinnost_ID />
      <CiselnaRada_ID>7a1cacb6-1692-4683-818d-1a22caf2949e</CiselnaRada_ID>
      <CisloDokladu>OP00005</CisloDokladu>
      <CisloRady>5</CisloRady>
      <DatumVyrizeni>2015-01-08T00:00:00</DatumVyrizeni>
      <DatumVystaveni>2015-01-09T00:00:00</DatumVystaveni>
      <DIC>SK1020143707</DIC>
      <DodaciAdresaFirma_ID>7d597482-83a1-4c77-af95-2f3fd2943998</DodaciAdresaFirma_ID>
      <DodaciPodminky_ID />
      <DomaciMena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</DomaciMena_ID>
      <DruhDokladu_ID>8ba81511-9cb2-45b8-9278-558647b8d310</DruhDokladu_ID>
      <DruhDopravy_ID />
      <FakturacniAdresaFirma_ID>7d597482-83a1-4c77-af95-2f3fd2943998</FakturacniAdresaFirma_ID>
      <Faze EnumValueName="Aktivni">1</Faze>
      <Firma_ID>7d597482-83a1-4c77-af95-2f3fd2943998</Firma_ID>
      <IC>40226565</IC>
      <ICDPH />
      <IDKrajPuvodu_ID />
      <IDPovahaTransakce_ID />
      <Jmeno />
      <KonecnyPrijemce_ID />
      <Mena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</Mena_ID>
      <MojeFirma_ID>7503fef6-8eda-4d97-82dc-fcb9ece79cfe</MojeFirma_ID>
      <MojeFirmaBanka_ID>1ba31972-cf0a-44a4-88fe-d0b212e13a84</MojeFirmaBanka_ID>
      <MojeFirmaBankovniSpojeni_ID>41acd46c-dac4-441e-a624-cf516ddeaf04</MojeFirmaBankovniSpojeni_ID>
      <MojeFirmaFirma_ID />
      <MojeFirmaKontaktniOsoba_ID />
      <MojeFirmaStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</MojeFirmaStat_ID>
      <Nazev>Hraška na zahušťování 1 kg</Nazev>
      <Odkaz />
      <Osoba_ID />
      <PevneCeny>False</PevneCeny>
      <PlatnostDo>2015-01-09T00:00:00</PlatnostDo>
      <PlatnostOd>2015-01-09T00:00:00</PlatnostOd>
      <PocetPolozek>1</PocetPolozek>
      <PovahaTransakce_ID />
      <Poznamka />
      <PrijemceFaktury_ID />
      <PriznakVyrizeno>True</PriznakVyrizeno>
      <ProcentniZisk>0.00</ProcentniZisk>
      <RegistraceDPH_ID>fc1e873a-ffe1-4095-a78d-bb2eed9c39f4</RegistraceDPH_ID>
      <SazbaDPH0_ID>4940de08-8927-4731-ac4a-88f5aec97093</SazbaDPH0_ID>
      <SazbaDPH1_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH1_ID>
      <SazbaDPH2_ID>b7d9bd88-bf7e-4c11-be49-2044879c871c</SazbaDPH2_ID>
      <Schvaleno>True</Schvaleno>
      <Sleva>0.00</Sleva>
      <Stat_ID />
      <StatPuvodu_ID />
      <StatUrceniOdeslani_ID />
      <Stav EnumValueName="Rozpracovano">0</Stav>
      <Storno EnumValueName="NeniStorno">0</Storno>
      <Stredisko_ID />
      <Systemovy>False</Systemovy>
      <TypDokladu EnumValueName="Neurceny">0</TypDokladu>
      <VariabilniSymbol />
      <Vyrizeno>0</Vyrizeno>
      <Vystavil>Jaroslav Škvařil</Vystavil>
      <Zakazka_ID />
      <ZaokrouhleniCelkovaCastka_ID />
      <ZaokrouhleniDPH_ID />
      <ZaokrouhleniSazbaDPH_ID>ab01bdbb-662b-422c-8835-a9270fb48eab</ZaokrouhleniSazbaDPH_ID>
      <ZapornyPohyb>False</ZapornyPohyb>
      <Zauctovano>False</Zauctovano>
      <Zaverkovy>False</Zaverkovy>
      <ZiskZaDoklad>0.00</ZiskZaDoklad>
      <ZpusobDopravy_ID />
      <ZpusobPlatby_ID>fa207763-b9d0-4750-b394-2c20ad230336</ZpusobPlatby_ID>
      <ZvlastniPohyb_ID />
      <Adresa>
        <KontaktniOsobaJmeno />
        <KontaktniOsobaNazev />
        <KontaktniOsobaPrijmeni />
        <Misto>Bratislava 5</Misto>
        <Nazev>Natacha Pacal</Nazev>
        <PSC>85107</PSC>
        <Stat>Slovensko</Stat>
        <Ulice>Žehrianska 2</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="ed67bbe0-f18e-48ab-a7e9-f0a30097b28d" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="7d597482-83a1-4c77-af95-2f3fd2943998" />
      </Adresa>
      <AdresaKoncovehoPrijemce>
        <Email>info@jedalenvert.sk</Email>
        <KontaktniOsobaNazev />
        <Misto>Bratislava 5</Misto>
        <Nazev>Natacha Pacal</Nazev>
        <PSC>85107</PSC>
        <Stat>Slovensko</Stat>
        <Telefon>+421 (907) 549 405</Telefon>
        <Ulice>Žehrianska 2</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="ed67bbe0-f18e-48ab-a7e9-f0a30097b28d" />
        <EmailSpojeni ObjectName="Spojeni" ObjectType="Object" ID="d82d8a2b-e684-41f7-991b-6907e919749b" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="7d597482-83a1-4c77-af95-2f3fd2943998" />
        <TelefonSpojeni ObjectName="Spojeni" ObjectType="Object" ID="1dcf1705-2958-40e9-961c-b96644bce221" />
      </AdresaKoncovehoPrijemce>
      <AdresaPrijemceFaktury>
        <KontaktniOsobaNazev />
        <Misto>Bratislava 5</Misto>
        <Nazev>Natacha Pacal</Nazev>
        <PSC>85107</PSC>
        <Stat>Slovensko</Stat>
        <Ulice>Žehrianska 2</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="ed67bbe0-f18e-48ab-a7e9-f0a30097b28d" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="7d597482-83a1-4c77-af95-2f3fd2943998" />
      </AdresaPrijemceFaktury>
      <DPH0>
        <Celkem>370.00</Celkem>
        <CelkemCM>370.00</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>0.00</Sazba>
        <Zaklad>370.00</Zaklad>
        <ZakladCM>370.00</ZakladCM>
      </DPH0>
      <DPH1>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>10.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </DPH1>
      <DPH2>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>21.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </DPH2>
      <IntrastatDoklad>
        <Datum>2015-01-08T00:00:00</Datum>
        <DopravaTuzemsko>0.00</DopravaTuzemsko>
        <DopravaZahranici>0.00</DopravaZahranici>
        <DopravniNaklady>0.00</DopravniNaklady>
        <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
        <RozpousteniNakladu EnumValueName="CenaZbozi">0</RozpousteniNakladu>
      </IntrastatDoklad>
      <Korekce0>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>0.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce0>
      <Korekce1>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>10.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce1>
      <Korekce2>
        <Celkem>0</Celkem>
        <CelkemCM>0</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Sazba>21.00</Sazba>
        <Zaklad>0</Zaklad>
        <ZakladCM>0</ZakladCM>
      </Korekce2>
      <MojeFirma>
        <DIC>CZ26294010</DIC>
        <IC>26294010</IC>
        <ICDPH />
        <Misto>Brno-střed</Misto>
        <Nazev>CERIA,s.r.o.</Nazev>
        <PSC>60200</PSC>
        <Stat>Česká republika</Stat>
        <Ulice>Heinrichova 229/49</Ulice>
        <BankovniSpojeni>
          <CiselnyKod>0300</CiselnyKod>
          <CisloUctu>178570860</CisloUctu>
          <IBAN>CZ5503000000000178570860</IBAN>
          <SpecifickySymbol />
          <SWIFT>CEKOCZPP</SWIFT>
          <Banka ObjectName="Banka" ObjectType="Object" ID="1ba31972-cf0a-44a4-88fe-d0b212e13a84">
            <Group ID="ef04d885-1a39-4c48-a7a8-eb797000fd62" Kod="BAN" />
            <CiselnyKod>0300</CiselnyKod>
            <Kod>CEKO</Kod>
            <KonfiguraceKL_ID>5eb85f31-fcb1-4d5a-a758-5b9c6ba678a6</KonfiguraceKL_ID>
            <Nazev>Československá obchodní banka, a.s.</Nazev>
            <Poznamka />
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <SWIFT>CEKOCZPP</SWIFT>
            <KonfiguraceKL ObjectName="KonfiguraceKurzovnichListku" ObjectType="Object" ID="5eb85f31-fcb1-4d5a-a758-5b9c6ba678a6" />
            <SeznamKonfiguraciKL ObjectName="BankaKonfiguraceKL" ObjectType="List" />
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </Banka>
          <BankovniSpojeni ObjectName="BankovniSpojeni" ObjectType="Object" ID="41acd46c-dac4-441e-a624-cf516ddeaf04" />
        </BankovniSpojeni>
        <Kontakty>
          <Email>info@ceria.cz</Email>
          <Telefon1>+420532308550</Telefon1>
          <Telefon2>+420511140390</Telefon2>
          <Telefon3>+420910089390</Telefon3>
          <WWW>ceria.cz</WWW>
        </Kontakty>
        <Osoba />
        <Firma ObjectName="Firma" ObjectType="Object" ID="7503fef6-8eda-4d97-82dc-fcb9ece79cfe" />
        <MojeFirmaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
      </MojeFirma>
      <Suma>
        <Celkem>370.00</Celkem>
        <CelkemCM>370.00</CelkemCM>
        <Dan>0</Dan>
        <DanCM>0</DanCM>
        <Zaklad>370.00</Zaklad>
        <ZakladCM>370.00</ZakladCM>
      </Suma>
      <Texty />
      <UcetniKurz>
        <Kurz>1.000000</Kurz>
        <Mnozstvi>1.000000</Mnozstvi>
      </UcetniKurz>
      <Zaokrouhleni>
        <DruhSazbyDPH EnumValueName="Snizena">0</DruhSazbyDPH>
        <PrevazujiciSazbaDPH>True</PrevazujiciSazbaDPH>
        <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="ab01bdbb-662b-422c-8835-a9270fb48eab">
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
          <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
          <Poradi>2</Poradi>
          <PovahaSazbyDPH_ID />
          <PrimarniUcetVstup_ID />
          <PrimarniUcetVystup_ID />
          <Priorita>19</Priorita>
          <Sazba>15.00</Sazba>
          <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
          <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        </SazbaDPH>
      </Zaokrouhleni>
      <CiselnaRada ObjectName="CiselnaRada" ObjectType="Object" ID="7a1cacb6-1692-4683-818d-1a22caf2949e">
        <Kod>OBJ_PRI</Kod>
        <Nazev>Objednávky přijaté</Nazev>
        <NevracetDoVolnychCisel>True</NevracetDoVolnychCisel>
        <Poznamka />
        <Prefix>OP</Prefix>
        <SeznamObdobi ObjectName="ObdobiCiselneRady" ObjectType="List">
          <ObdobiCiselneRady ObjectName="ObdobiCiselneRady" ObjectType="Object" ID="2cdd3cdb-ef24-480f-9d7b-859627caa171">
            <CiselnyPrefix />
            <Cislo>6</Cislo>
            <PocetMist>5</PocetMist>
            <Zacatek>1753-01-01T00:00:00</Zacatek>
            <ZobrazitNuly>True</ZobrazitNuly>
            <VolnaCisla ObjectName="VolneCislo" ObjectType="List" />
          </ObdobiCiselneRady>
        </SeznamObdobi>
      </CiselnaRada>
      <DokladInfo ObjectName="DokladInfo" ObjectType="List" />
      <DomaciMena ObjectName="Mena" ObjectType="Object" ID="00f9adb2-d300-42c3-9240-ae1320b019cc" />
      <DruhDokladu ObjectName="DruhDokladu" ObjectType="Object" ID="8ba81511-9cb2-45b8-9278-558647b8d310" />
      <Mena ObjectName="Mena" ObjectType="Object" ID="00f9adb2-d300-42c3-9240-ae1320b019cc">
        <Banka_ID />
        <DesMisto>0</DesMisto>
        <Kod>CZK</Kod>
        <Nazev>Koruna česká</Nazev>
        <Poznamka />
        <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
        <Symbol>Kč</Symbol>
        <TypJednotky EnumValueName="Mena">2</TypJednotky>
        <DenominaceList ObjectName="PrevodDenominace" ObjectType="List" />
        <PrevodyList ObjectName="PrevodMen" ObjectType="List" />
        <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
      </Mena>
      <Polozky ObjectName="PolozkaObjednavkyPrijate" ObjectType="List">
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="63a14882-98f6-4349-9c8b-e918e202fa61">
          <AutoRow_ID>15</AutoRow_ID>
          <CelkovaCena>370.00</CelkovaCena>
          <CelkovaCenaBezSlevy>370.00</CelkovaCenaBezSlevy>
          <CelkovaCenaBezSlevyCM>370.00</CelkovaCenaBezSlevyCM>
          <CelkovaCenaCM>370.00</CelkovaCenaCM>
          <Cinnost_ID />
          <CisloPolozky>1</CisloPolozky>
          <DodaciPodminky_ID />
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <DPHEditovanoRucne>False</DPHEditovanoRucne>
          <DruhDopravy_ID />
          <DruhPolozky_ID />
          <DruhSazbyDPH EnumValueName="Nulova">2</DruhSazbyDPH>
          <FormatPolozky EnumValueName="Normalni">0</FormatPolozky>
          <JednCena>3.7000</JednCena>
          <JednCenaCM>3.7000</JednCenaCM>
          <Jednotka>ks</Jednotka>
          <JednotkovaCenaBezSlevy>3.7000</JednotkovaCenaBezSlevy>
          <JednotkovaCenaBezSlevyCM>3.7000</JednotkovaCenaBezSlevyCM>
          <Katalog />
          <KombinovanaNomenklatura_ID />
          <KrajPuvodu_ID />
          <Mnozstvi>100.0000</Mnozstvi>
          <MnozstviKPreobjednani>0.0000</MnozstviKPreobjednani>
          <MnozstviKVyrizeni>0.0000</MnozstviKVyrizeni>
          <MnozstviVyrizeno>0.00</MnozstviVyrizeno>
          <MnozstviZbyva>0.00</MnozstviZbyva>
          <Nazev>Hraška na zahušťování 1 kg</Nazev>
          <NepodlehatSleveDokladu>False</NepodlehatSleveDokladu>
          <ObsahPolozky_ID>2f527fcd-befd-430f-aa97-00a503b21a53</ObsahPolozky_ID>
          <ParentObject_ID />
          <PlatnaDo>2015-01-09T00:00:00</PlatnaDo>
          <PlatnaOd>2015-01-09T00:00:00</PlatnaOd>
          <Poradi>1</Poradi>
          <PovahaTransakce_ID />
          <Poznamka />
          <PriznakVyrizeno>True</PriznakVyrizeno>
          <SazbaDPH_ID>4940de08-8927-4731-ac4a-88f5aec97093</SazbaDPH_ID>
          <Schvaleno>True</Schvaleno>
          <Sleva>0.00</Sleva>
          <StatistickyZnak_ID />
          <StatPuvodu_ID />
          <StatUrceniOdeslani_ID />
          <Stredisko_ID />
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <Vratka>False</Vratka>
          <Vyrizeno>100.0000</Vyrizeno>
          <Zakazka_ID />
          <Zbyva>0.0000</Zbyva>
          <ZdrojovaPolozkaKopirovani_ID />
          <ZvlastniPohyb_ID />
          <DPH>
            <Celkem>370.00</Celkem>
            <CelkemCM>370.00</CelkemCM>
            <Dan>0.00</Dan>
            <DanCM>0.00</DanCM>
            <Sazba>0.00</Sazba>
            <Zaklad>370.00</Zaklad>
            <ZakladCM>370.00</ZakladCM>
          </DPH>
          <IntrastatPolozka>
            <CisloZasilky />
            <DopravniNaklady>0.00</DopravniNaklady>
            <Hmotnost>1.000</Hmotnost>
            <Mnozstvi>0.0000</Mnozstvi>
            <Neslucovat>False</Neslucovat>
            <OvlivnujeIntrastat>False</OvlivnujeIntrastat>
          </IntrastatPolozka>
          <Zaruka>
            <TypZaruky EnumValueName="Zadna">0</TypZaruky>
            <ZarucniDoba>0</ZarucniDoba>
          </Zaruka>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="2f527fcd-befd-430f-aa97-00a503b21a53">
            <Artikl_ID>04c8292f-a1ee-46aa-86d0-04f6ae65eb2a</Artikl_ID>
            <ArtiklJednotkaBeznaCena_ID>5805bef8-91e5-4435-b23f-376e347033f7</ArtiklJednotkaBeznaCena_ID>
            <AutoRow_ID>383</AutoRow_ID>
            <BeznaCena>88.00</BeznaCena>
            <Cenik_ID>129b21ec-2660-4083-b553-6f01862b9758</Cenik_ID>
            <CenikBezneCeny_ID>04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8</CenikBezneCeny_ID>
            <CenovaHladina_ID />
            <DruhPolozky_ID>9512ff4f-2c70-4f79-968d-ca8406058d04</DruhPolozky_ID>
            <DruhPolozky2_ID />
            <DruhPrislusenstvi_ID />
            <Jednotka_ID>5805bef8-91e5-4435-b23f-376e347033f7</Jednotka_ID>
            <JednotkaZdroj_ID />
            <MinuleMnozstviRezervace>100.0000</MinuleMnozstviRezervace>
            <Mnozstvi>100.0000</Mnozstvi>
            <Objednano>0.0000</Objednano>
            <OdchyleniCeny>-95.80</OdchyleniCeny>
            <OvlivnujeObaloveKonto>True</OvlivnujeObaloveKonto>
            <PartnerskyKod>ART00063</PartnerskyKod>
            <PartnerskyNazev>Hraška na zahušťování 1 kg</PartnerskyNazev>
            <PocetJednotek>0.00</PocetJednotek>
            <PocetZakladnichJednotek>0.00</PocetZakladnichJednotek>
            <PocitatCenuZKomponent>False</PocitatCenuZKomponent>
            <PodrizenePrebiratSklad>False</PodrizenePrebiratSklad>
            <Rezervovano>0.00</Rezervovano>
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <SkladovaPozice_ID />
            <TypArtiklu EnumValueName="Vyrobek">4</TypArtiklu>
            <TypBezneCeny EnumValueName="BezDane">0</TypBezneCeny>
            <VyberDodavek>False</VyberDodavek>
            <Zasoba_ID>42ae98d9-ed4c-442e-8bb5-48bc72a67e38</Zasoba_ID>
            <Vazba>
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="04c8292f-a1ee-46aa-86d0-04f6ae65eb2a" />
            <ArtiklJednotkaBeznaCena ObjectName="ArtiklJednotka" ObjectType="Object" ID="5805bef8-91e5-4435-b23f-376e347033f7" />
            <Cenik ObjectName="Cenik" ObjectType="Object" ID="129b21ec-2660-4083-b553-6f01862b9758" />
            <CenikBezneCeny ObjectName="Cenik" ObjectType="Object" ID="04a769a0-3ed0-4bcb-8b0e-40d0401f4ab8" />
            <Detaily ObjectName="ObchodniPolozkaDetail" ObjectType="List" />
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="9512ff4f-2c70-4f79-968d-ca8406058d04" />
            <Jednotka ObjectName="ArtiklJednotka" ObjectType="Object" ID="5805bef8-91e5-4435-b23f-376e347033f7">
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
              <Jednotka ObjectName="Jednotka" ObjectType="Object" ID="e604a0fa-c14a-40ca-97ab-c92b2ce618ef" />
              <ParentJednotka ObjectName="ArtiklJednotka" ObjectType="Object" />
            </Jednotka>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Zasoba ObjectName="Zasoba" ObjectType="Object" ID="42ae98d9-ed4c-442e-8bb5-48bc72a67e38" />
          </ObsahPolozky>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="4940de08-8927-4731-ac4a-88f5aec97093">
            <DruhSazby EnumValueName="Nulova">2</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>1753-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>1</Priorita>
            <Sazba>0.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </PolozkaObjednavkyPrijate>
      </Polozky>
      <Poplatky ObjectName="PoplatekZaDoklad" ObjectType="List" />
      <RegistraceDPH ObjectName="DanovaRegistrace" ObjectType="Object" ID="fc1e873a-ffe1-4095-a78d-bb2eed9c39f4" />
      <SazbaDPH0 ObjectName="SazbaDPH" ObjectType="Object" ID="4940de08-8927-4731-ac4a-88f5aec97093" />
      <SazbaDPH1 ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
      <SazbaDPH2 ObjectName="SazbaDPH" ObjectType="Object" ID="b7d9bd88-bf7e-4c11-be49-2044879c871c" />
      <SazbyDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="List">
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="037dd2c0-b211-4954-a9eb-94e3eeb6968b">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>9b98f4f7-0205-4712-ad33-75680e0bad45</RozpisDPH_ID>
          <SazbaDPH_ID>ab01bdbb-662b-422c-8835-a9270fb48eab</SazbaDPH_ID>
          <VybranaNaHlavicce>False</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="9b98f4f7-0205-4712-ad33-75680e0bad45">
            <Sazba>15.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="ab01bdbb-662b-422c-8835-a9270fb48eab">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
            <Poradi>2</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>19</Priorita>
            <Sazba>15.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="0c8e78c0-e1a5-4f6b-8d24-f86b9ae56402">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Nulova">2</DruhSazby>
          <Pouzita>True</Pouzita>
          <RozpisDPH_ID>f3598b4d-3eef-4fea-b790-fe3310bbd5a7</RozpisDPH_ID>
          <SazbaDPH_ID>4940de08-8927-4731-ac4a-88f5aec97093</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="f3598b4d-3eef-4fea-b790-fe3310bbd5a7">
            <Sazba>0.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>370.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>370.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>370.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>370.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="4940de08-8927-4731-ac4a-88f5aec97093">
            <DruhSazby EnumValueName="Nulova">2</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>1753-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>1</Priorita>
            <Sazba>0.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="95da500e-0584-48f5-b659-bb59181efe87">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Snizena">0</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>5b7ba2d6-627b-4ae1-8fc9-ba27c7a3d3dc</RozpisDPH_ID>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="5b7ba2d6-627b-4ae1-8fc9-ba27c7a3d3dc">
            <Sazba>10.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2">
            <DruhSazby EnumValueName="Snizena">0</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2015-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>0</Priorita>
            <Sazba>10.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
        <SazbaDPHNaDoklade ObjectName="SazbaDPHNaDoklade" ObjectType="Object" ID="cf514f8a-802f-4ed5-a07f-e232bb58a1b4">
          <Aktivni>True</Aktivni>
          <DruhSazby EnumValueName="Zakladni">1</DruhSazby>
          <Pouzita>False</Pouzita>
          <RozpisDPH_ID>acf6e42b-810f-4362-8f4d-aef6460b7da0</RozpisDPH_ID>
          <SazbaDPH_ID>b7d9bd88-bf7e-4c11-be49-2044879c871c</SazbaDPH_ID>
          <VybranaNaHlavicce>True</VybranaNaHlavicce>
          <RozpisDPH ObjectName="RozpisDPH" ObjectType="Object" ID="acf6e42b-810f-4362-8f4d-aef6460b7da0">
            <Sazba>21.00</Sazba>
            <Korekce>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Korekce>
            <KorekceCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </KorekceCM>
            <Suma>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </Suma>
            <SumaCM>
              <Celkem>0.00</Celkem>
              <DPH>0.00</DPH>
              <Zaklad>0.00</Zaklad>
            </SumaCM>
          </RozpisDPH>
          <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="b7d9bd88-bf7e-4c11-be49-2044879c871c">
            <DruhSazby EnumValueName="Zakladni">1</DruhSazby>
            <PlatnostDo>9998-12-31T00:00:00</PlatnostDo>
            <PlatnostOd>2013-01-01T00:00:00</PlatnostOd>
            <Poradi>1</Poradi>
            <PovahaSazbyDPH_ID />
            <PrimarniUcetVstup_ID />
            <PrimarniUcetVystup_ID />
            <Priorita>20</Priorita>
            <Sazba>21.00</Sazba>
            <Stat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</Stat_ID>
            <Stat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
          </SazbaDPH>
        </SazbaDPHNaDoklade>
      </SazbyDPHNaDoklade>
      <VazbyObjektu ObjectName="VazbaObjektu" ObjectType="List" />
      <ZpusobPlatby ObjectName="ZpusobPlatby" ObjectType="Object" ID="fa207763-b9d0-4750-b394-2c20ad230336">
        <Kod>H</Kod>
        <Nazev>Hotově</Nazev>
        <Poznamka />
      </ZpusobPlatby>
    </ObjednavkaPrijata>
  </ObjednavkaPrijataList>
</S5Data>""">
