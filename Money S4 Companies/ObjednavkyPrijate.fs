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
        <PredCenami />
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
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
          </ObsahPolozky>
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
        <PredCenami />
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
              <IgnorovatPomer>False</IgnorovatPomer>
              <PocetNadrizene>1.0000</PocetNadrizene>
              <PocetPodrizene>1.0000</PocetPodrizene>
              <PricitatCenu>False</PricitatCenu>
              <TypVazby EnumValueName="Slozeni">1</TypVazby>
              <ZobrazovatNaVystupu>True</ZobrazovatNaVystupu>
            </Vazba>
          </ObsahPolozky>
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
let private ZpusobDopravyId = Guid.Parse("a46ef167-6913-4b2f-b68f-d974e80981d2")
let private SazbaDphId = Guid.Parse("df41c206-e744-4f39-8775-eb14ac8a0af2")
let private skladId = Guid.Parse("9D07C221-B163-4798-B5BC-1610EDE4D4E9")

let private activeOrders() = 
                    query {
                        for order in context.entities_Order do
                        where ( order.OrderStatusId = Nullable<Guid>(OrderStatusCreatedId)  && order.CreatedOn.Value.Year >= 2015 )
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
    ( ObjPXml.Texty(null, "Cena dopravy v ceně zboží je 769 Kč bez DPH. Cena Hrašky bez dopravy je 70,4 Kč za Kg bez DPH." ) )

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
    ObjPXml.Vazba( false, decimal 1, decimal 1, false, ObjPXml.TypVazby( "Slozeni", 1 ), true )

let private obsahPolozky(orderProduct : EntityConnection.ServiceTypes.entities_OrderProduct ) : ObjPXml.ObsahPolozky =
    ( ObjPXml.ObsahPolozky("ObsahPolozkySArtiklem", "Object", orderProduct.OrderProductId, artiklId(orderProduct), artikl(orderProduct), skladId, sklad(), vazba() ) )

let private polozkyObjednavkyPrijate(order :EntityConnection.ServiceTypes.entities_Order ) =
    [| 
        for orderProduct in ( context.entities_OrderProduct |> Seq.toList ) do
            if ( orderProduct.OrderId =  order.OrderId ) then
                yield ObjPXml.PolozkaObjednavkyPrijate( "PolozkaObjednavkyPrijate", "Object", orderProduct.OrderProductId, "ObjednavkaPrijata", orderProduct.UnitPrice.Value,
                                                        "ks", decimal orderProduct.Quantity.Value, orderProduct.OrderProductId, SazbaDphId, ObjPXml.TypCeny("BezDane", 0), ObjPXml.TypObsahu("SObsahem", 1), 
                                                        ObjPXml.TypPolozky("Neurcena", 0),
                                                        obsahPolozky(orderProduct)
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
                                                                   order.AccountId, order.AccountId, Guid.Parse("00f9adb2-d300-42c3-9240-ae1320b019cc"), order.Number, ZpusobDopravyId, 
                                                                   zpusobPlatbyId(order), adresaKoncovehoPrijemce(order), texty(order), 
                                                                   druhDokladu(order), polozky(order), zpusobDopravy(order), zpusobPlatby(order))
                                |]

(*
      <DomaciMena_ID>00f9adb2-d300-42c3-9240-ae1320b019cc</DomaciMena_ID>
      <DruhDokladu_ID>8ba81511-9cb2-45b8-9278-558647b8d310</DruhDokladu_ID>
            <ZpusobDopravy_ID>a46ef167-6913-4b2f-b68f-d974e80981d2</ZpusobDopravy_ID>

*)