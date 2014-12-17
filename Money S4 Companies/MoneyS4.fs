module MoneyS4

open FSharp.Data

type Firma = XmlProvider<"""<?xml version="1.0" encoding="windows-1250"?>
<S5Data>
  <FirmaList>
    <Firma ObjectName="Firma" ObjectType="Object" ID="3544e6d1-304c-4920-9eb3-197ecf90c3f5">
      <CinnostUkoncena>False</CinnostUkoncena>
      <CiselnaRada_ID>7ef3f4a3-76cd-4dd0-90de-7a0870deef61</CiselnaRada_ID>
      <CisloS3>0</CisloS3>
      <CisloZRady>1</CisloZRady>
      <DatovaSchrankaSpojeni_ID />
      <DatumKontolyDIC>1753-01-01T00:00:00</DatumKontolyDIC>
      <DatumKontrolyDleIC>2014-10-10T00:00:00</DatumKontrolyDleIC>
      <DatumPosledniKontrolyPlatceDPH>1753-01-01T00:00:00</DatumPosledniKontrolyPlatceDPH>
      <DatumPosty>1753-01-01T00:00:00</DatumPosty>
      <DatumUkonceniCinnosti>1753-01-01T00:00:00</DatumUkonceniCinnosti>
      <DIC>CZ26294010</DIC>
      <EkoKomKlient>False</EkoKomKlient>
      <EmailSpojeni_ID />
      <FaktPsc_ID>e65d9ce1-4f73-460a-ac9b-90ccc67ab1f3</FaktPsc_ID>
      <FaktStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</FaktStat_ID>
      <FaxSpojeni_ID />
      <FyzickaOsoba>False</FyzickaOsoba>
      <GpsLat>0.000000</GpsLat>
      <GpsLong>0.000000</GpsLong>
      <HlavniOsoba_ID />
      <HlavniUcet_ID />
      <ICDPH />
      <ICO>26294010</ICO>
      <Kod>ADR00001</Kod>
      <KodDanovehoUradu />
      <Kraj_ID />
      <Logo_ID />
      <MojeFirmabankovniSpojeni_ID />
      <NadrazenaFirma_ID />
      <Nazev>CERIA,s.r.o.</Nazev>
      <ObchPsc_ID>e65d9ce1-4f73-460a-ac9b-90ccc67ab1f3</ObchPsc_ID>
      <ObchStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</ObchStat_ID>
      <PlatceDPH>True</PlatceDPH>
      <PosilatPostu>False</PosilatPostu>
      <PosledniCisloOsoby>0</PosledniCisloOsoby>
      <PosledniStavZHistorieRegistru_ID />
      <Poznamka />
      <PrenestNazev>False</PrenestNazev>
      <PrimarniUcetPohledavky_ID />
      <PrimarniUcetPoskytnutaZaloha_ID />
      <PrimarniUcetPrijataZaloha_ID />
      <PrimarniUcetZavazky_ID />
      <ProvPsc_ID>e65d9ce1-4f73-460a-ac9b-90ccc67ab1f3</ProvPsc_ID>
      <ProvStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</ProvStat_ID>
      <Region_ID />
      <SpecifickySymbol />
      <StavPlatceDPHComputed>0</StavPlatceDPHComputed>
      <StavPlatceDPHVracenyWS_Stav>0</StavPlatceDPHVracenyWS_Stav>
      <TelefonSpojeni1_ID />
      <TelefonSpojeni2_ID />
      <TelefonSpojeni3_ID />
      <TelefonSpojeni4_ID />
      <UctyNactenyZRegistruDPH>False</UctyNactenyZRegistruDPH>
      <VariabilniSymbol />
      <WWWSpojeni_ID />
      <Zprava />
      <ZpusobDopravy_ID />
      <ZpusobPlatby_ID />
      <Adresy>
        <OdlisnaAdresaProvozovny>False</OdlisnaAdresaProvozovny>
        <OdlisnaFakturacniAdresa>False</OdlisnaFakturacniAdresa>
        <FakturacniAdresa>
          <KodPsc>60200</KodPsc>
          <Misto>Brno-střed</Misto>
          <Nazev>CERIA,s.r.o.</Nazev>
          <NazevStatu>Česká republika</NazevStatu>
          <Ulice>Heinrichova 229/49</Ulice>
          <Psc ObjectName="PSC" ObjectType="Object" ID="e65d9ce1-4f73-460a-ac9b-90ccc67ab1f3" />
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
          <KodPsc>60200</KodPsc>
          <Misto>Brno-střed</Misto>
          <Nazev>CERIA,s.r.o.</Nazev>
          <NazevStatu>Česká republika</NazevStatu>
          <Ulice>Heinrichova 229/49</Ulice>
          <Psc ObjectName="PSC" ObjectType="Object" ID="e65d9ce1-4f73-460a-ac9b-90ccc67ab1f3" />
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
          <KodPsc>60200</KodPsc>
          <Misto>Brno-střed</Misto>
          <Nazev>CERIA,s.r.o.</Nazev>
          <NazevStatu>Česká republika</NazevStatu>
          <Ulice>Heinrichova 229/49</Ulice>
          <Psc ObjectName="PSC" ObjectType="Object" ID="e65d9ce1-4f73-460a-ac9b-90ccc67ab1f3" />
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
      <CRM />
      <Kontakty>
        <Email />
        <Spojeni />
        <WWW />
        <DatovaSchranka />
        <Fax />
        <Telefon1>
          <Cislo />
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
      </Kontakty>
      <Kredit>
        <Kredit>0.00</Kredit>
        <PouzivatKredit>False</PouzivatKredit>
        <VcetnePodrizenych>False</VcetnePodrizenych>
      </Kredit>
      <NadrazenaFirma>
        <PrevzitBankovniSpojeni>False</PrevzitBankovniSpojeni>
        <PrevzitObchodniPodminky>False</PrevzitObchodniPodminky>
        <PrevzitObchodniUdaje>False</PrevzitObchodniUdaje>
      </NadrazenaFirma>
      <ObchodniPodminky>
        <DistributorLihu>False</DistributorLihu>
        <RegistracniCisloDistributoraLihu />
        <ZpusobVyberuCeny EnumValueName="NejnizsiCena">0</ZpusobVyberuCeny>
        <SeznamCeniku ObjectName="FirmaCenik" ObjectType="List" />
        <SeznamHladin ObjectName="FirmaCenovaHladina" ObjectType="List" />
      </ObchodniPodminky>
      <Osoby>
        <UvadetNaDokladech>False</UvadetNaDokladech>
        <SeznamOsob ObjectName="Osoba" ObjectType="List" />
      </Osoby>
      <Pohledavky>
        <SplatnostPohledavek>0</SplatnostPohledavek>
        <VlastniSplatnostPohledavek>False</VlastniSplatnostPohledavek>
      </Pohledavky>
      <Sleva>
        <Sleva>0.00</Sleva>
        <VlastniSleva>False</VlastniSleva>
      </Sleva>
      <Ucty />
      <Zavazky>
        <SplatnostZavazku>0</SplatnostZavazku>
        <VlastniSplatnostZavazku>False</VlastniSplatnostZavazku>
      </Zavazky>
      <AdresniKlice ObjectName="FirmaAdresniKlic" ObjectType="List" />
      <Aktivity ObjectName="Aktivita" ObjectType="List" />
      <Cinnosti ObjectName="FirmaCinnost" ObjectType="List" />
      <CiselnaRada ObjectName="CiselnaRada" ObjectType="Object" ID="7ef3f4a3-76cd-4dd0-90de-7a0870deef61">
        <Kod>ADRES</Kod>
        <Nazev>Adresář</Nazev>
        <NevracetDoVolnychCisel>True</NevracetDoVolnychCisel>
        <Poznamka />
        <Prefix>ADR</Prefix>
        <SeznamObdobi ObjectName="ObdobiCiselneRady" ObjectType="List">
          <ObdobiCiselneRady ObjectName="ObdobiCiselneRady" ObjectType="Object" ID="2debb37f-5b2e-4103-b1a2-4a5ad9408c1f">
            <CiselnyPrefix />
            <Cislo>3</Cislo>
            <PocetMist>5</PocetMist>
            <Zacatek>1753-01-01T00:00:00</Zacatek>
            <ZobrazitNuly>True</ZobrazitNuly>
            <VolnaCisla ObjectName="VolneCislo" ObjectType="List" />
          </ObdobiCiselneRady>
        </SeznamObdobi>
      </CiselnaRada>
      <HistorieOvereniFirmyVRegistru ObjectName="FirmaRegistrPlatcuDPH" ObjectType="List" />
      <SeznamSpojeni ObjectName="Spojeni" ObjectType="List" />
      <Zakazky ObjectName="Zakazka" ObjectType="List" />
    </Firma>
    <Firma ObjectName="Firma" ObjectType="Object" ID="1ae920b3-36ff-4c11-93c3-bef4d1d7c669">
      <CinnostUkoncena>False</CinnostUkoncena>
      <CiselnaRada_ID>7ef3f4a3-76cd-4dd0-90de-7a0870deef61</CiselnaRada_ID>
      <CisloS3>0</CisloS3>
      <CisloZRady>2</CisloZRady>
      <DatovaSchrankaSpojeni_ID />
      <DatumKontolyDIC>2014-12-16T00:00:00</DatumKontolyDIC>
      <DatumKontrolyDleIC>2014-12-16T00:00:00</DatumKontrolyDleIC>
      <DatumPosledniKontrolyPlatceDPH>1753-01-01T00:00:00</DatumPosledniKontrolyPlatceDPH>
      <DatumPosty>1753-01-01T00:00:00</DatumPosty>
      <DatumUkonceniCinnosti>1753-01-01T00:00:00</DatumUkonceniCinnosti>
      <DIC>CZ24180149</DIC>
      <EkoKomKlient>False</EkoKomKlient>
      <EmailSpojeni_ID />
      <FaktPsc_ID>5b27cef8-80bb-4ab7-8c07-73c28711dc38</FaktPsc_ID>
      <FaktStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</FaktStat_ID>
      <FaxSpojeni_ID />
      <FyzickaOsoba>False</FyzickaOsoba>
      <GpsLat>0.000000</GpsLat>
      <GpsLong>0.000000</GpsLong>
      <HlavniOsoba_ID>fdabf1a3-10d8-47c1-9634-f5b69ad19b24</HlavniOsoba_ID>
      <HlavniUcet_ID />
      <ICDPH />
      <ICO>24180149</ICO>
      <Kod>ADR00002</Kod>
      <KodDanovehoUradu />
      <Kraj_ID />
      <Logo_ID>7aa9549e-3c0d-4779-bf23-97c7873b6312</Logo_ID>
      <MojeFirmabankovniSpojeni_ID />
      <NadrazenaFirma_ID />
      <Nazev>NašeÚkoly.CZ s.r.o.</Nazev>
      <ObchPsc_ID>5b27cef8-80bb-4ab7-8c07-73c28711dc38</ObchPsc_ID>
      <ObchStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</ObchStat_ID>
      <PlatceDPH>True</PlatceDPH>
      <PosilatPostu>False</PosilatPostu>
      <PosledniCisloOsoby>1</PosledniCisloOsoby>
      <PosledniStavZHistorieRegistru_ID />
      <Poznamka />
      <PrenestNazev>False</PrenestNazev>
      <PrimarniUcetPohledavky_ID />
      <PrimarniUcetPoskytnutaZaloha_ID />
      <PrimarniUcetPrijataZaloha_ID />
      <PrimarniUcetZavazky_ID />
      <ProvPsc_ID>5b27cef8-80bb-4ab7-8c07-73c28711dc38</ProvPsc_ID>
      <ProvStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</ProvStat_ID>
      <Region_ID />
      <SpecifickySymbol />
      <StavPlatceDPHComputed>0</StavPlatceDPHComputed>
      <StavPlatceDPHVracenyWS_Stav>0</StavPlatceDPHVracenyWS_Stav>
      <TelefonSpojeni1_ID />
      <TelefonSpojeni2_ID />
      <TelefonSpojeni3_ID />
      <TelefonSpojeni4_ID />
      <UctyNactenyZRegistruDPH>False</UctyNactenyZRegistruDPH>
      <VariabilniSymbol />
      <WWWSpojeni_ID />
      <Zprava />
      <ZpusobDopravy_ID />
      <ZpusobPlatby_ID />
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
      <CRM />
      <Kontakty>
        <Email />
        <Spojeni />
        <WWW />
        <DatovaSchranka />
        <Fax />
        <Telefon1>
          <Cislo />
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
      </Kontakty>
      <Kredit>
        <Kredit>0.00</Kredit>
        <PouzivatKredit>False</PouzivatKredit>
        <VcetnePodrizenych>False</VcetnePodrizenych>
      </Kredit>
      <NadrazenaFirma>
        <PrevzitBankovniSpojeni>False</PrevzitBankovniSpojeni>
        <PrevzitObchodniPodminky>False</PrevzitObchodniPodminky>
        <PrevzitObchodniUdaje>False</PrevzitObchodniUdaje>
      </NadrazenaFirma>
      <ObchodniPodminky>
        <DistributorLihu>False</DistributorLihu>
        <RegistracniCisloDistributoraLihu />
        <ZpusobVyberuCeny EnumValueName="NejnizsiCena">0</ZpusobVyberuCeny>
        <SeznamCeniku ObjectName="FirmaCenik" ObjectType="List" />
        <SeznamHladin ObjectName="FirmaCenovaHladina" ObjectType="List" />
      </ObchodniPodminky>
      <Osoby>
        <UvadetNaDokladech>False</UvadetNaDokladech>
        <HlavniOsoba ObjectName="Osoba" ObjectType="Object" ID="fdabf1a3-10d8-47c1-9634-f5b69ad19b24" />
        <SeznamOsob ObjectName="Osoba" ObjectType="List">
          <Osoba ObjectName="Osoba" ObjectType="Object" ID="fdabf1a3-10d8-47c1-9634-f5b69ad19b24">
            <AdresaPsc_ID />
            <AdresaStat_ID />
            <CisloOsoby>1</CisloOsoby>
            <CisloS3 />
            <DatumPosty>1753-01-01T00:00:00</DatumPosty>
            <EmailSpojeni_ID />
            <FaxSpojeni_ID />
            <Funkce />
            <Jmeno>David</Jmeno>
            <Kod>ADR00002.1</Kod>
            <KrestniJmeno />
            <Nazev>Podhola David</Nazev>
            <Osloveni>Pan</Osloveni>
            <Pohlavi EnumValueName="Muz">1</Pohlavi>
            <PosilatPostu>False</PosilatPostu>
            <Poznamka />
            <Prijmeni>Podhola</Prijmeni>
            <TelefonSpojeni1_ID />
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
              <Email />
              <Spojeni />
              <Fax />
              <Telefon1>
                <Cislo />
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
            </Kontakty>
          </Osoba>
        </SeznamOsob>
      </Osoby>
      <Pohledavky>
        <SplatnostPohledavek>0</SplatnostPohledavek>
        <VlastniSplatnostPohledavek>False</VlastniSplatnostPohledavek>
      </Pohledavky>
      <Sleva>
        <Sleva>0.00</Sleva>
        <VlastniSleva>False</VlastniSleva>
      </Sleva>
      <Ucty />
      <Zavazky>
        <SplatnostZavazku>0</SplatnostZavazku>
        <VlastniSplatnostZavazku>False</VlastniSplatnostZavazku>
      </Zavazky>
      <AdresniKlice ObjectName="FirmaAdresniKlic" ObjectType="List" />
      <Aktivity ObjectName="Aktivita" ObjectType="List" />
      <Cinnosti ObjectName="FirmaCinnost" ObjectType="List" />
      <CiselnaRada ObjectName="CiselnaRada" ObjectType="Object" ID="7ef3f4a3-76cd-4dd0-90de-7a0870deef61">
        <Kod>ADRES</Kod>
        <Nazev>Adresář</Nazev>
        <NevracetDoVolnychCisel>True</NevracetDoVolnychCisel>
        <Poznamka />
        <Prefix>ADR</Prefix>
        <SeznamObdobi ObjectName="ObdobiCiselneRady" ObjectType="List">
          <ObdobiCiselneRady ObjectName="ObdobiCiselneRady" ObjectType="Object" ID="2debb37f-5b2e-4103-b1a2-4a5ad9408c1f">
            <CiselnyPrefix />
            <Cislo>3</Cislo>
            <PocetMist>5</PocetMist>
            <Zacatek>1753-01-01T00:00:00</Zacatek>
            <ZobrazitNuly>True</ZobrazitNuly>
            <VolnaCisla ObjectName="VolneCislo" ObjectType="List" />
          </ObdobiCiselneRady>
        </SeznamObdobi>
      </CiselnaRada>
      <HistorieOvereniFirmyVRegistru ObjectName="FirmaRegistrPlatcuDPH" ObjectType="List" />
      <Logo ObjectName="Attachment" ObjectType="Object" ID="7aa9549e-3c0d-4779-bf23-97c7873b6312" />
      <SeznamSpojeni ObjectName="Spojeni" ObjectType="List" />
      <Zakazky ObjectName="Zakazka" ObjectType="List" />
    </Firma>
  </FirmaList>
</S5Data>""">

