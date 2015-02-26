module ObjednavkyPrijate

open System
open FSharp.Data
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders
open DB

type ObjPXml = XmlProvider<"""<?xml version="1.0" encoding="windows-1250"?>
<S5Data>
  <ObjednavkaPrijataList>
    <ObjednavkaPrijata ObjectName="ObjednavkaPrijata" ObjectType="Object" ID="ba9436b3-f87e-4417-bd4e-63d23d27f857">
      <AdresaKoncovehoPrijemceEmailSpojeni_ID>b4042355-181d-40de-aaa6-cfc3b6c5d0fb</AdresaKoncovehoPrijemceEmailSpojeni_ID>
      <AdresaKoncovehoPrijemceStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaKoncovehoPrijemceStat_ID>
      <AdresaKoncovehoPrijemceTelefonSpojeni_ID>ba9436b3-f87e-4417-bd4e-63d23d27f857</AdresaKoncovehoPrijemceTelefonSpojeni_ID>
      <DatumVystaveni>02/15/2015 14:49:28</DatumVystaveni>
      <DodaciAdresaFirma_ID>dbc3b352-0a0b-4bb9-a6d3-d9ad37ee5408</DodaciAdresaFirma_ID>
      <DruhDokladu_ID>8ba81511-9cb2-45b8-9278-558647b8d310</DruhDokladu_ID>
      <FakturacniAdresaFirma_ID>dbc3b352-0a0b-4bb9-a6d3-d9ad37ee5408</FakturacniAdresaFirma_ID>
      <Firma_ID>dbc3b352-0a0b-4bb9-a6d3-d9ad37ee5408</Firma_ID>
      <Mena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</Mena_ID>
      <Nazev>SSS1100219</Nazev>
      <Odkaz>SSS1100219</Odkaz>
      <ZpusobDopravy_ID>987aa2ec-d6d2-459f-abfd-374b71116d88</ZpusobDopravy_ID>
      <ZpusobPlatby_ID>5b035689-496c-4f5f-a48a-4418a7d041ae</ZpusobPlatby_ID>
      <AdresaKoncovehoPrijemce>
        <Email>veselababuska@seznam.cz</Email>
        <KontaktniOsobaNazev />
        <Misto>DOMAŽLICE</Misto>
        <Nazev>TEST</Nazev>
        <PSC>BBB34401</PSC>
        <Stat>Česká Republika</Stat>
        <Telefon>UUU6012112</Telefon>
        <Ulice>DRAŽENOV 105</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <EmailSpojeni ObjectName="Spojeni" ObjectType="Object" ID="b4042355-181d-40de-aaa6-cfc3b6c5d0fb" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="dbc3b352-0a0b-4bb9-a6d3-d9ad37ee5408" />
        <TelefonSpojeni ObjectName="Spojeni" ObjectType="Object" ID="ba9436b3-f87e-4417-bd4e-63d23d27f857" />
      </AdresaKoncovehoPrijemce>
      <Texty>
        <ZaCenami>Cena dopravy v ceně zboží je 769 Kč bez DPH. Cena Hrašky bez dopravy je 70,4 Kč za Kg bez DPH.</ZaCenami>
      </Texty>
      <DruhDokladu ObjectName="DruhDokladu" ObjectType="Object" ID="8ba81511-9cb2-45b8-9278-558647b8d310" />
      <Polozky ObjectName="PolozkaObjednavkyPrijate" ObjectType="List">
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="7d705bb9-3ae4-4b10-9860-03bf4dcd06f7">
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <JednCena>114.55000</JednCena>
          <Jednotka>ks</Jednotka>
          <Mnozstvi>1</Mnozstvi>
          <ObsahPolozky_ID>45bd50b9-4cb5-4f38-9cb8-2e94266570d0</ObsahPolozky_ID>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="45bd50b9-4cb5-4f38-9cb8-2e94266570d0">
            <Artikl_ID>04c8292f-a1ee-46aa-86d0-04f6ae65eb2a</Artikl_ID>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="04c8292f-a1ee-46aa-86d0-04f6ae65eb2a" />
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Vazba>
              <IgnorovatPomer>false</IgnorovatPomer>
              <PocetNadrizene>1</PocetNadrizene>
              <PocetPodrizene>1</PocetPodrizene>
              <PricitatCenu>false</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>true</ZobrazovatNaVystupu>
            </Vazba>
          </ObsahPolozky>
           <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="9a40cc0c-83ac-44b2-839e-472ab296c530">
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <JednCena>114.55000</JednCena>
          <Jednotka>ks</Jednotka>
          <Mnozstvi>1</Mnozstvi>
          <ObsahPolozky_ID>f8c17fe9-de10-4bae-b03d-e9bc8a2b09df</ObsahPolozky_ID>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="f8c17fe9-de10-4bae-b03d-e9bc8a2b09df">
            <Artikl_ID>04b91d10-944e-4b9e-908f-f117cd41bb05</Artikl_ID>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="04b91d10-944e-4b9e-908f-f117cd41bb05" />
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Vazba>
              <IgnorovatPomer>false</IgnorovatPomer>
              <PocetNadrizene>1</PocetNadrizene>
              <PocetPodrizene>1</PocetPodrizene>
              <PricitatCenu>false</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>true</ZobrazovatNaVystupu>
            </Vazba>
          </ObsahPolozky>
           <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="d22fb44f-8702-4c72-8dfe-57fe47c9aac3">
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <JednCena>25.22000</JednCena>
          <Jednotka>ks</Jednotka>
          <Mnozstvi>2</Mnozstvi>
          <ObsahPolozky_ID>411f8591-7f15-4278-a92e-fe7591f993e1</ObsahPolozky_ID>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="411f8591-7f15-4278-a92e-fe7591f993e1">
            <Artikl_ID>4dd808bc-e86a-4100-ab3c-5df3fe096aed</Artikl_ID>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="4dd808bc-e86a-4100-ab3c-5df3fe096aed" />
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Vazba>
              <IgnorovatPomer>false</IgnorovatPomer>
              <PocetNadrizene>1</PocetNadrizene>
              <PocetPodrizene>1</PocetPodrizene>
              <PricitatCenu>false</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>true</ZobrazovatNaVystupu>
            </Vazba>
          </ObsahPolozky>
           <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="3a0c836c-f9db-4a62-aadd-bc84221ec130">
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <JednCena>114.55000</JednCena>
          <Jednotka>ks</Jednotka>
          <Mnozstvi>1</Mnozstvi>
          <ObsahPolozky_ID>83622502-a1d6-4508-8f20-2a3a55aac026</ObsahPolozky_ID>
          <SazbaDPH_ID>df41c206-e744-4f39-8775-eb14ac8a0af2</SazbaDPH_ID>
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="83622502-a1d6-4508-8f20-2a3a55aac026">
            <Artikl_ID>c888ef1d-78c5-48cf-825e-c93665b04235</Artikl_ID>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="c888ef1d-78c5-48cf-825e-c93665b04235" />
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Vazba>
              <IgnorovatPomer>false</IgnorovatPomer>
              <PocetNadrizene>1</PocetNadrizene>
              <PocetPodrizene>1</PocetPodrizene>
              <PricitatCenu>false</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>true</ZobrazovatNaVystupu>
            </Vazba>
          </ObsahPolozky>
         <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
        </PolozkaObjednavkyPrijate>

      <!--
          <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="ba9436b3-f87e-4417-bd4e-63d23d27f857">
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <JednCena>148</JednCena>
          <Jednotka>ks</Jednotka>
          <Mnozstvi>1</Mnozstvi>
          <ObsahPolozky_ID>ba9436b3-f87e-4417-bd4e-63d23d27f858</ObsahPolozky_ID>
          <SazbaDPH_ID>B7D9BD88-BF7E-4C11-BE49-2044879C871C</SazbaDPH_ID>
          <TypCeny EnumValueName="BezDane">0</TypCeny>
          <TypObsahu EnumValueName="SObsahem">1</TypObsahu>
          <TypPolozky EnumValueName="Neurcena">0</TypPolozky>
          <ObsahPolozky ObjectName="ObsahPolozkySArtiklem" ObjectType="Object" ID="ba9436b3-f87e-4417-bd4e-63d23d27f858">
            <Artikl_ID>9579C0AF-2BE2-4BFA-B266-DF0E9AF654B0</Artikl_ID>
            <Artikl ObjectName="Artikl" ObjectType="Object" ID="9579C0AF-2BE2-4BFA-B266-DF0E9AF654B0" />
            <Sklad_ID>9d07c221-b163-4798-b5bc-1610ede4d4e9</Sklad_ID>
            <Sklad ObjectName="Sklad" ObjectType="Object" ID="9d07c221-b163-4798-b5bc-1610ede4d4e9" />
            <Vazba>
              <IgnorovatPomer>false</IgnorovatPomer>
              <PocetNadrizene>1</PocetNadrizene>
              <PocetPodrizene>1</PocetPodrizene>
              <PricitatCenu>false</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>true</ZobrazovatNaVystupu>
            </Vazba>
            <DruhPolozky ObjectName="DruhArtiklu" ObjectType="Object" ID="78db2306-129d-44be-841a-99036401418c" />
            <TypArtiklu EnumValueName="Sluzba">1</TypArtiklu>
          </ObsahPolozky>
           <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="B7D9BD88-BF7E-4C11-BE49-2044879C871C" />
        </PolozkaObjednavkyPrijate>
    -->
    
  </Polozky>
      <ZpusobDopravy ObjectName="ZpusobDopravy" ObjectType="Object" ID="987aa2ec-d6d2-459f-abfd-374b71116d88" />
      <ZpusobPlatby ObjectName="ZpusobPlatby" ObjectType="Object" ID="5b035689-496c-4f5f-a48a-4418a7d041ae" />
    </ObjednavkaPrijata>
    <ObjednavkaPrijata ObjectName="ObjednavkaPrijata" ObjectType="Object" ID="8515740f-0b17-439c-9b66-c1ddd24b1f46">
      <AdresaKoncovehoPrijemceEmailSpojeni_ID>573ae688-eb67-43b5-bb34-ce4a3a7ffa76</AdresaKoncovehoPrijemceEmailSpojeni_ID>
      <AdresaKoncovehoPrijemceStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaKoncovehoPrijemceStat_ID>
      <AdresaKoncovehoPrijemceTelefonSpojeni_ID>8e88b8a6-15c1-4e1b-a0a3-d5652c77e427</AdresaKoncovehoPrijemceTelefonSpojeni_ID>
      <DatumVystaveni>2015-01-07T00:00:00</DatumVystaveni>
      <DodaciAdresaFirma_ID>925C90F9-02BC-4B2E-B4F7-F4AC52D4FA63</DodaciAdresaFirma_ID>
      <DruhDokladu_ID>8ba81511-9cb2-45b8-9278-558647b8d310</DruhDokladu_ID>
      <FakturacniAdresaFirma_ID>925C90F9-02BC-4B2E-B4F7-F4AC52D4FA63</FakturacniAdresaFirma_ID>
      <Firma_ID>925C90F9-02BC-4B2E-B4F7-F4AC52D4FA63</Firma_ID>
      <Mena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</Mena_ID>
      <Nazev>Hraška na obalování 1 kg</Nazev>
      <Odkaz>SSS1100219</Odkaz>
      <ZpusobDopravy_ID>a46ef167-6913-4b2f-b68f-d974e80981d2</ZpusobDopravy_ID>
      <ZpusobPlatby_ID>d3b43f46-2cdd-413f-b51c-ad9096771980</ZpusobPlatby_ID>
      <AdresaKoncovehoPrijemce>
        <Email>j.janca@biogena.cz</Email>
        <KontaktniOsobaNazev />
        <Misto>Valašské Meziříčí</Misto>
        <Nazev>Jaromír Janča</Nazev>
        <PSC>AAA75701</PSC>
        <Stat>Česká republika</Stat>
        <Telefon>571 613 226</Telefon>
        <Ulice>Podlesí 276</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <EmailSpojeni ObjectName="Spojeni" ObjectType="Object" ID="573ae688-eb67-43b5-bb34-ce4a3a7ffa76" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="925C90F9-02BC-4B2E-B4F7-F4AC52D4FA63" />
        <TelefonSpojeni ObjectName="Spojeni" ObjectType="Object" ID="8e88b8a6-15c1-4e1b-a0a3-d5652c77e427" />
      </AdresaKoncovehoPrijemce>
      <Texty>
        <ZaCenami>Cena dopravy v ceně zboží je 769 Kč bez DPH. Cena Hrašky bez dopravy je 70,4 Kč za Kg bez DPH.</ZaCenami>
      </Texty>
      <DruhDokladu ObjectName="DruhDokladu" ObjectType="Object" ID="8ba81511-9cb2-45b8-9278-558647b8d310" />
      <Polozky ObjectName="PolozkaObjednavkyPrijate" ObjectType="List">
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="9bbae86f-ded8-445c-8f0d-b22de0e647e1">
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <JednCena>73.1000</JednCena>
          <Jednotka>ks</Jednotka>
          <Mnozstvi>50.0000</Mnozstvi>
          <ObsahPolozky_ID>5907cdd4-af53-47fc-836e-fecbc43ef468</ObsahPolozky_ID>          
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
              <IgnorovatPomer>false</IgnorovatPomer>
              <PocetNadrizene>1</PocetNadrizene>
              <PocetPodrizene>1</PocetPodrizene>
              <PricitatCenu>false</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>true</ZobrazovatNaVystupu>
           </Vazba>
          </ObsahPolozky>
           <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="9bbae86f-ded8-445c-8f0d-b22de0e647e1">
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <JednCena>73.1000</JednCena>
          <Jednotka>ks</Jednotka>
          <Mnozstvi>50.0000</Mnozstvi>
          <ObsahPolozky_ID>5907cdd4-af53-47fc-836e-fecbc43ef468</ObsahPolozky_ID>          
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
              <IgnorovatPomer>false</IgnorovatPomer>
              <PocetNadrizene>1</PocetNadrizene>
              <PocetPodrizene>1</PocetPodrizene>
              <PricitatCenu>false</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>true</ZobrazovatNaVystupu>
           </Vazba>
          </ObsahPolozky>
           <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
        </PolozkaObjednavkyPrijate>
      </Polozky>
      <ZpusobDopravy ObjectName="ZpusobDopravy" ObjectType="Object" ID="a46ef167-6913-4b2f-b68f-d974e80981d2">
      </ZpusobDopravy>
      <ZpusobPlatby ObjectName="ZpusobPlatby" ObjectType="Object" ID="d3b43f46-2cdd-413f-b51c-ad9096771980">
      </ZpusobPlatby>
    </ObjednavkaPrijata>
    <ObjednavkaPrijata ObjectName="ObjednavkaPrijata" ObjectType="Object" ID="8515740f-0b17-439c-9b66-c1ddd24b1f46">
      <AdresaKoncovehoPrijemceEmailSpojeni_ID>573ae688-eb67-43b5-bb34-ce4a3a7ffa76</AdresaKoncovehoPrijemceEmailSpojeni_ID>
      <AdresaKoncovehoPrijemceStat_ID>3d3f235c-df25-42ad-9cce-1b460e3a3c5f</AdresaKoncovehoPrijemceStat_ID>
      <AdresaKoncovehoPrijemceTelefonSpojeni_ID>8e88b8a6-15c1-4e1b-a0a3-d5652c77e427</AdresaKoncovehoPrijemceTelefonSpojeni_ID>
      <DatumVystaveni>2015-01-07T00:00:00</DatumVystaveni>
      <DodaciAdresaFirma_ID>925C90F9-02BC-4B2E-B4F7-F4AC52D4FA63</DodaciAdresaFirma_ID>
      <DruhDokladu_ID>8ba81511-9cb2-45b8-9278-558647b8d310</DruhDokladu_ID>
      <FakturacniAdresaFirma_ID>925C90F9-02BC-4B2E-B4F7-F4AC52D4FA63</FakturacniAdresaFirma_ID>
      <Firma_ID>925C90F9-02BC-4B2E-B4F7-F4AC52D4FA63</Firma_ID>
      <Mena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</Mena_ID>
      <Nazev>Hraška na obalování 1 kg</Nazev>
      <Odkaz>SSS1100219</Odkaz>
      <ZpusobDopravy_ID>a46ef167-6913-4b2f-b68f-d974e80981d2</ZpusobDopravy_ID>
      <ZpusobPlatby_ID>d3b43f46-2cdd-413f-b51c-ad9096771980</ZpusobPlatby_ID>
      <AdresaKoncovehoPrijemce>
        <Email>j.janca@biogena.cz</Email>
        <KontaktniOsobaNazev />
        <Misto>Valašské Meziříčí</Misto>
        <Nazev>Jaromír Janča</Nazev>
        <PSC>AAA75701</PSC>
        <Stat>Česká republika</Stat>
        <Telefon>571 613 226</Telefon>
        <Ulice>Podlesí 276</Ulice>
        <AdresaStat ObjectName="Stat" ObjectType="Object" ID="3d3f235c-df25-42ad-9cce-1b460e3a3c5f" />
        <EmailSpojeni ObjectName="Spojeni" ObjectType="Object" ID="573ae688-eb67-43b5-bb34-ce4a3a7ffa76" />
        <Firma ObjectName="Firma" ObjectType="Object" ID="925C90F9-02BC-4B2E-B4F7-F4AC52D4FA63" />
        <TelefonSpojeni ObjectName="Spojeni" ObjectType="Object" ID="8e88b8a6-15c1-4e1b-a0a3-d5652c77e427" />
      </AdresaKoncovehoPrijemce>
      <Texty>
        <ZaCenami>Cena dopravy v ceně zboží je 769 Kč bez DPH. Cena Hrašky bez dopravy je 70,4 Kč za Kg bez DPH.</ZaCenami>
      </Texty>
      <DruhDokladu ObjectName="DruhDokladu" ObjectType="Object" ID="8ba81511-9cb2-45b8-9278-558647b8d310" />
      <Polozky ObjectName="PolozkaObjednavkyPrijate" ObjectType="List">
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="9bbae86f-ded8-445c-8f0d-b22de0e647e1">
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <JednCena>73.1000</JednCena>
          <Jednotka>ks</Jednotka>
          <Mnozstvi>50.0000</Mnozstvi>
          <ObsahPolozky_ID>5907cdd4-af53-47fc-836e-fecbc43ef468</ObsahPolozky_ID>          
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
              <IgnorovatPomer>false</IgnorovatPomer>
              <PocetNadrizene>1</PocetNadrizene>
              <PocetPodrizene>1</PocetPodrizene>
              <PricitatCenu>false</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>true</ZobrazovatNaVystupu>
           </Vazba>
          </ObsahPolozky>
           <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
        </PolozkaObjednavkyPrijate>
        <PolozkaObjednavkyPrijate ObjectName="PolozkaObjednavkyPrijate" ObjectType="Object" ID="9bbae86f-ded8-445c-8f0d-b22de0e647e1">
          <DokladObjectName>ObjednavkaPrijata</DokladObjectName>
          <JednCena>73.1000</JednCena>
          <Jednotka>ks</Jednotka>
          <Mnozstvi>50.0000</Mnozstvi>
          <ObsahPolozky_ID>5907cdd4-af53-47fc-836e-fecbc43ef468</ObsahPolozky_ID>         
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
              <IgnorovatPomer>false</IgnorovatPomer>
              <PocetNadrizene>1</PocetNadrizene>
              <PocetPodrizene>1</PocetPodrizene>
              <PricitatCenu>false</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>true</ZobrazovatNaVystupu>
           </Vazba>
          </ObsahPolozky>
           <SazbaDPH ObjectName="SazbaDPH" ObjectType="Object" ID="df41c206-e744-4f39-8775-eb14ac8a0af2" />
        </PolozkaObjednavkyPrijate>
      </Polozky>
      <ZpusobDopravy ObjectName="ZpusobDopravy" ObjectType="Object" ID="a46ef167-6913-4b2f-b68f-d974e80981d2">
      </ZpusobDopravy>
      <ZpusobPlatby ObjectName="ZpusobPlatby" ObjectType="Object" ID="d3b43f46-2cdd-413f-b51c-ad9096771980">
      </ZpusobPlatby>
    </ObjednavkaPrijata>
  </ObjednavkaPrijataList>
</S5Data>
""">

let private OrderStatusCreatedId = Guid.Parse( "140249DF-763B-489C-A721-93657964CC1F" )

let private BankTransferZpusobPlatbyId = Guid.Parse( "1ECEAA4B-35CB-4200-8D7B-230E32086105" )
let private CollectOnDeliveryZpusobPlatbyId = Guid.Parse( "5BC03214-9470-4074-A13D-39ACED4E613F" )
let private ZpusobPlatbyDobirkouId = Guid.Parse( "5B035689-496C-4F5F-A48A-4418A7D041AE" )
let private ZpusobPlatbyBankouPredemId = Guid.Parse( "FD0E06D7-C88D-4163-8F19-2D399336CCD5" )
let private DruhDokladuId =  Guid.Parse("8ba81511-9cb2-45b8-9278-558647b8d310")
let private ZpusobDopravyId = Guid.Parse("987AA2EC-D6D2-459F-ABFD-374B71116D88")
let private SazbaDphId = Guid.Parse("DF41C206-E744-4F39-8775-EB14AC8A0AF2")
let private skladId = Guid.Parse("9D07C221-B163-4798-B5BC-1610EDE4D4E9")
let private artiklDopravneADobirka148Id = Guid.Parse("9579C0AF-2BE2-4BFA-B266-DF0E9AF654B0")
let private SazbaDph21Id = Guid.Parse("B7D9BD88-BF7E-4C11-BE49-2044879C871C")

let private activeOrders() = 
                    query {
                        for order in context.entities_Order do
                        where ( order.OrderStatusId = Nullable<Guid>(OrderStatusCreatedId)  && order.CreatedOn.Value.Year >= DateTime.Now.Year && order.CreatedOn.Value.Month >= DateTime.Now.Month && order.CreatedOn.Value.Day >= ( DateTime.Now.Day - 1 ) )
                        select order
                    } |> Seq.toList

[<Literal>]
let faktStatIdCZ = "3d3f235c-df25-42ad-9cce-1b460e3a3c5f"
[<Literal>]
let faktStatIdSK = "ED67BBE0-F18E-48AB-A7E9-F0A30097B28D"

let private adresaKoncovehoPrijemceStatId(order :EntityConnection.ServiceTypes.entities_Order ) = 
    ( if ( order.KoncovyPrijemce_Stat = "Slovensko" ) then Guid.Parse(faktStatIdSK) else Guid.Parse(faktStatIdCZ) )

let private adresaKoncovehoPrijemceStat(order :EntityConnection.ServiceTypes.entities_Order ) : ObjPXml.AdresaStat = 
    ObjPXml.AdresaStat("Stat", "Object", adresaKoncovehoPrijemceStatId(order) )

let private adresaKoncovehoPrijemceTelefonSpojeniId(order :EntityConnection.ServiceTypes.entities_Order ) = 
    ( order.OrderId )

let private zpusobPlatbyId(order :EntityConnection.ServiceTypes.entities_Order ) = 
    ( if order.PaymentMethodId = CollectOnDeliveryZpusobPlatbyId then ZpusobPlatbyDobirkouId else ZpusobPlatbyBankouPredemId )

let private adresaKoncovehoPrijemce(order :EntityConnection.ServiceTypes.entities_Order ) : ObjPXml.AdresaKoncovehoPrijemce = 
    ( ObjPXml.AdresaKoncovehoPrijemce(order.KoncovyPrijemce_Email, ObjPXml.KontaktniOsobaNazev(), order.KoncovyPrijemce_Misto, order.KoncovyPrijemce_Nazev, order.KoncovyPrijemce_PSC, 
                                        order.KoncovyPrijemce_Stat,
                                        order.KoncovyPrijemce_Telefon, order.KoncovyPrijemce_Ulice, adresaKoncovehoPrijemceStat(order), ObjPXml.EmailSpojeni("Spojeni", "Object", order.KoncovyPrijemce_AddressID), 
                                        ObjPXml.Firma( "Firma", "Object", order.AccountId ), ObjPXml.TelefonSpojeni ("Spojeni", "Object", order.OrderId) ) )

let private texty(order :EntityConnection.ServiceTypes.entities_Order ) : ObjPXml.Texty = 
    ( ObjPXml.Texty("Cena dopravy v ceně zboží je 769 Kč bez DPH. Cena Hrašky bez dopravy je 70,4 Kč za Kg bez DPH." ) )

let private druhDokladu(order :EntityConnection.ServiceTypes.entities_Order ) : ObjPXml.DruhDokladu = 
    ( ObjPXml.DruhDokladu("DruhDokladu", "Object", DruhDokladuId) )

let private artiklId(orderProduct : EntityConnection.ServiceTypes.entities_OrderProduct ) : Guid =
    ( let partProds = ( orderProduct.entities_Product.adapters_moneys4_PartialProduct |> Seq.toList )
      if partProds.IsEmpty then
        Guid.Empty
      else
        partProds.Head.PartialProductId
    )

let private artikl(orderProduct : EntityConnection.ServiceTypes.entities_OrderProduct )  : ObjPXml.Artikl = 
    ( ObjPXml.Artikl("Artikl", "Object", artiklId(orderProduct) ) )

let private sklad() : ObjPXml.Sklad = 
    ObjPXml.Sklad( "Sklad", "Object", skladId ) 

let private vazba() : ObjPXml.Vazba = 
    ObjPXml.Vazba( false, 1, 1, false, ObjPXml.TypVazby( "Slozeni", 1 ), true )

let private obsahPolozky(orderProduct : EntityConnection.ServiceTypes.entities_OrderProduct ) : ObjPXml.ObsahPolozky =
    ( ObjPXml.ObsahPolozky("ObsahPolozkySArtiklem", "Object", orderProduct.OrderProductId2, artiklId(orderProduct), artikl(orderProduct), skladId, sklad(), vazba() ) )
    
let private sazbaDPH(orderProduct : EntityConnection.ServiceTypes.entities_OrderProduct) : ObjPXml.SazbaDph =
    ( ObjPXml.SazbaDph("SazbaDPH", "Object", SazbaDphId)  )

let private polozkyObjednavkyPrijate(order :EntityConnection.ServiceTypes.entities_Order ) =
    [| 
        for orderProduct in ( context.entities_OrderProduct |> Seq.toList ) do
            if ( orderProduct.OrderId =  order.OrderId ) then
                yield ObjPXml.PolozkaObjednavkyPrijate( "PolozkaObjednavkyPrijate", "Object", orderProduct.OrderProductId, "ObjednavkaPrijata", orderProduct.UnitPrice.Value,
                                                        "ks", decimal orderProduct.Quantity.Value, orderProduct.OrderProductId2, SazbaDphId, ObjPXml.TypCeny("BezDane", 0), ObjPXml.TypObsahu("SObsahem", 1), 
                                                        ObjPXml.TypPolozky("Neurcena", 0),
                                                        obsahPolozky(orderProduct), sazbaDPH(orderProduct)
                )
    |]

let private polozky(order :EntityConnection.ServiceTypes.entities_Order ) : ObjPXml.Polozky = 
    ( ObjPXml.Polozky("PolozkaObjednavkyPrijate", "List", polozkyObjednavkyPrijate(order) ) )

let private zpusobDopravy(order :EntityConnection.ServiceTypes.entities_Order ) : ObjPXml.ZpusobDopravy = 
    ( ObjPXml.ZpusobDopravy("ZpusobDopravy", "Object", ZpusobDopravyId) )    

let private zpusobPlatby(order :EntityConnection.ServiceTypes.entities_Order ) : ObjPXml.ZpusobPlatby = 
    ( ObjPXml.ZpusobPlatby("ZpusobPlatby", "Object", zpusobPlatbyId(order)) )

let output = ObjPXml.SData [| for order in activeOrders() do
                                yield ObjPXml.ObjednavkaPrijata("ObjednavkaPrijata", "Object", order.OrderId, order.KoncovyPrijemce_AddressID, 
                                                                   adresaKoncovehoPrijemceStatId(order), adresaKoncovehoPrijemceTelefonSpojeniId(order), order.CreatedOn.Value.DateTime, 
                                                                   order.AccountId, DruhDokladuId,
                                                                   order.AccountId, order.AccountId, Guid.Parse("00f9adb2-d300-42c3-9240-ae1320b019cc"), order.Number, order.Number, ZpusobDopravyId, 
                                                                   zpusobPlatbyId(order), adresaKoncovehoPrijemce(order), texty(order), 
                                                                   druhDokladu(order), polozky(order), zpusobDopravy(order), zpusobPlatby(order))
                                |]

(*
      <DomaciMena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</DomaciMena_ID>
      <DruhDokladu_ID>8ba81511-9cb2-45b8-9278-558647b8d310</DruhDokladu_ID>
            <ZpusobDopravy_ID>a46ef167-6913-4b2f-b68f-d974e80981d2</ZpusobDopravy_ID>

*)