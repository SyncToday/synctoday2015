module Program

open System
open Google.GData.Client
open Google.GData.Contacts
open Google.GData.Extensions

let saveContact(contact : ContactEntry, adapterId) =
    let contactName = ( if contact.Name = null then new Name() else contact.Name )
    let contactOrg = ( if contact.Organizations.Count > 0 then contact.Organizations.Item(0) else new Organization() ) 
    let contactContent = contact.Content.Content 
    let contactTitle = contact.Title.Text 
    let contactPrimaryEmailAddress = ( if contact.PrimaryEmail = null then "" else contact.PrimaryEmail.Address )
    let contactPrimaryPhonenumber = (if contact.PrimaryPhonenumber = null then "" else contact.PrimaryPhonenumber.Value )
    let contactPrimaryPostalAddressCity =  ( if contact.PrimaryPostalAddress = null then "" else contact.PrimaryPostalAddress.City )
    let contactPrimaryPostalAddressStreet =  ( if contact.PrimaryPostalAddress = null then "" else contact.PrimaryPostalAddress.Street )
    let contactPrimaryPostalAddressRegion =  ( if contact.PrimaryPostalAddress = null then "" else contact.PrimaryPostalAddress.Region )
    let contactPrimaryPostalAddressPostcode =  ( if contact.PrimaryPostalAddress = null then "" else contact.PrimaryPostalAddress.Postcode )
    let contactPrimaryPostalAddressCountry =  ( if contact.PrimaryPostalAddress = null then "" else contact.PrimaryPostalAddress.Country )
    let contactPrimaryPostalAddressFormattedAddress =  ( if contact.PrimaryPostalAddress = null then "" else contact.PrimaryPostalAddress.FormattedAddress )

    Repository.saveContact( contact.Id.Uri.Content, contact.Updated, contactContent, contactTitle, contactPrimaryEmailAddress, 
                            contactName.GivenName, 
                            contactName.FamilyName, contactOrg.Department, contactOrg.JobDescription, contactOrg.Name, 
                            contactOrg.Title, contactPrimaryPhonenumber,
                            contactPrimaryPostalAddressCity, contactPrimaryPostalAddressStreet, contactPrimaryPostalAddressRegion,
                            contactPrimaryPostalAddressPostcode, contactPrimaryPostalAddressCountry, contactPrimaryPostalAddressFormattedAddress,
                            adapterId, contact ) |> ignore

[<EntryPoint>]
let main argv = 
//    try

        let parameters = new OAuth2Parameters(
                                ClientId = "", 
                                ClientSecret = "", 
                                RedirectUri = "",
                                Scope = "https://www.google.com/m8/feeds/ https://apps-apis.google.com/a/feeds/groups/",
                                RefreshToken = ""
                            );

        OAuthUtil.RefreshAccessToken(parameters) 
        let requestFactory = new GOAuth2RequestFactory("apps", "applicationName", parameters)
    
        let _service = new ContactsService("applicationName")
        _service.RequestFactory <- requestFactory
        _service.ProtocolMajor <- 3
        _service.ProtocolMinor <- 3

        let myQuery = new GroupsQuery("https://www.google.com/m8/feeds/groups/default/full")
        myQuery.StartDate <- DateTime.Now.AddYears(-10)
        myQuery.NumberToRetrieve <- 1000
        let myResultsFeed = _service.Query(myQuery)
        for entry in myResultsFeed.Entries do
            let group = entry :?> GroupEntry
            printfn "%A" group.Title.Text
            Repository.saveGroup( group.Id.Uri.Content, group.Updated, group.Title.Text, 1 ) |> ignore

        let myQuery = new GroupsQuery("https://www.google.com/m8/feeds/groups/default/full")
        myQuery.StartDate <- DateTime.Now.AddYears(-10)
        myQuery.NumberToRetrieve <- 1000
        let myResultsFeed = _service.Query(myQuery)
        for entry in myResultsFeed.Entries do
            let group = entry :?> GroupEntry
            printfn "%A" group.Title.Text
            let group = Repository.getGroupById( group.Id.Uri.Content).Value

            let myQuery2 = new ContactsQuery("https://www.google.com/m8/feeds/contacts/default/full")
            myQuery2.Group <- group.ExternalId
            myQuery2.StartDate <- DateTime.Now.AddYears(-10)
            myQuery2.NumberToRetrieve <- 1000
            let myResultsFeed2 = _service.Query(myQuery2)
            for entry2 in myResultsFeed2.Entries do
                let contact = entry2 :?> ContactEntry
                printfn "\t%A" ( if contact.Name = null then "" else contact.Name.FullName )
                saveContact( contact, 1 )
                Repository.saveGroupMembership( contact)


        printfn "%A" "<<No group>>"
        let groupId = Repository.saveGroup( "", DateTime.Now, "", 1 )

        let myQuery2 = new ContactsQuery("https://www.google.com/m8/feeds/contacts/default/full")
        myQuery2.StartDate <- DateTime.Now.AddYears(-10)
        myQuery2.NumberToRetrieve <- 1000
        let myResultsFeed2 = _service.Query(myQuery2)
        for entry2 in myResultsFeed2.Entries do
            let contact = entry2 :?> ContactEntry
            printfn "\t%A"  ( if contact.Name = null then "" else contact.Name.FullName )
            saveContact( contact, 1 )

        Console.ReadLine() |> ignore
        0 // return an integer exit code
//    with
//        | ex -> 0
