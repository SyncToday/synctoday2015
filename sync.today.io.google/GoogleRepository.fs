module GoogleRepository

open System
open Google.GData.Contacts
open Google.GData.Extensions
open Google.GData.Client
open GoogleContactsSQL

let saveContactEntry(contact : ContactEntry, rowId : int) =
    let adapterId = 0
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

    saveContact( contact.Id.Uri.Content, contact.Updated, contactContent, contactTitle, contactPrimaryEmailAddress, 
                            contactName.GivenName, 
                            contactName.FamilyName, contactOrg.Department, contactOrg.JobDescription, contactOrg.Name, 
                            contactOrg.Title, contactPrimaryPhonenumber,
                            contactPrimaryPostalAddressCity, contactPrimaryPostalAddressStreet, contactPrimaryPostalAddressRegion,
                            contactPrimaryPostalAddressPostcode, contactPrimaryPostalAddressCountry, contactPrimaryPostalAddressFormattedAddress,
                            adapterId, contact, rowId ) |> ignore

let upload( clientId :string, clientSecret : string, refreshToken : string ) =
    let parameters = new OAuth2Parameters(
                            ClientId = clientId, 
                            ClientSecret = clientSecret, 
                            RedirectUri = "urn:ietf:wg:oauth:2.0:oob",
                            Scope = "https://www.google.com/m8/feeds/ https://apps-apis.google.com/a/feeds/groups/",
                            RefreshToken = refreshToken
                        );

    OAuthUtil.RefreshAccessToken(parameters) 
    let requestFactory = new GOAuth2RequestFactory("apps", "applicationName", parameters)
    
    let _service = new ContactsService("applicationName")
    _service.RequestFactory <- requestFactory
    _service.ProtocolMajor <- 3
    _service.ProtocolMinor <- 3

    //let groupMembership = new GroupMembership( HRef = sprintf "http://www.google.com/m8/feeds/groups/%A/base/6" ( "vsvjjag29@gmail.com".Replace("@", "%40") ) )
    let groupMembership = new GroupMembership( HRef = "http://www.google.com/m8/feeds/groups/vsvjjag29%40gmail.com/base/6" )
    let uri = Uri(ContactsQuery.CreateContactsUri("default"))
    for contact in getContactsForUpload() do
        let entry : ContactEntry = ContactEntry() 
        entry.GroupMembership.Add(groupMembership)|> ignore
        if not (String.IsNullOrWhiteSpace(contact.OrgTitle)) || not (String.IsNullOrWhiteSpace(contact.OrgName)) then
            entry.Organizations.Add( Organization( Title = contact.OrgTitle, Name = contact.OrgName ) )  |> ignore
        entry.Name <- Name( GivenName = contact.GivenName, FamilyName = contact.FamilyName )
        if not (String.IsNullOrWhiteSpace(contact.Email)) then
            entry.Emails.Add( EMail( contact.Email, ContactsRelationships.IsWork ) ) |> ignore
        if not (String.IsNullOrWhiteSpace(contact.PrimaryPhonenumber)) then
            entry.Phonenumbers.Add( PhoneNumber ( contact.PrimaryPhonenumber ) ) |> ignore
        try
            let insertedEntry = _service.Insert(uri, entry)        
            saveContactEntry( insertedEntry, contact.Id )
        with
            | ex -> raise ( ArgumentException( "service.Insert failed", ex ) )

let download( clientId :string, clientSecret : string, refreshToken : string ) =
        let adapterId = 0
        let parameters = new OAuth2Parameters(
                                ClientId = clientId, 
                                ClientSecret = clientSecret, 
                                RedirectUri = "urn:ietf:wg:oauth:2.0:oob",
                                Scope = "https://www.google.com/m8/feeds/ https://apps-apis.google.com/a/feeds/groups/",
                                RefreshToken = refreshToken
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
            saveGroup( group.Id.Uri.Content, group.Updated, group.Title.Text, adapterId ) |> ignore

        let myQuery = new GroupsQuery("https://www.google.com/m8/feeds/groups/default/full")
        myQuery.StartDate <- DateTime.Now.AddYears(-10)
        myQuery.NumberToRetrieve <- 1000
        let myResultsFeed = _service.Query(myQuery)
        for entry in myResultsFeed.Entries do
            let group = entry :?> GroupEntry
            printfn "%A" group.Title.Text
            let group = getGroupById( group.Id.Uri.Content).Value

            let myQuery2 = new ContactsQuery("https://www.google.com/m8/feeds/contacts/default/full")
            myQuery2.Group <- group.ExternalId
            myQuery2.StartDate <- DateTime.Now.AddYears(-10)
            myQuery2.NumberToRetrieve <- 1000
            let myResultsFeed2 = _service.Query(myQuery2)
            for entry2 in myResultsFeed2.Entries do
                let contact = entry2 :?> ContactEntry
                printfn "\t%A" ( if contact.Name = null then "" else contact.Name.FullName )
                saveContactEntry( contact, 0 )
                saveGroupMembership( contact)


        printfn "%A" "<<No group>>"
        let groupId = saveGroup( "", DateTime.Now, "", adapterId )

        let myQuery2 = new ContactsQuery("https://www.google.com/m8/feeds/contacts/default/full")
        myQuery2.StartDate <- DateTime.Now.AddYears(-10)
        myQuery2.NumberToRetrieve <- 1000
        let myResultsFeed2 = _service.Query(myQuery2)
        for entry2 in myResultsFeed2.Entries do
            let contact = entry2 :?> ContactEntry
            printfn "\t%A"  ( if contact.Name = null then "" else contact.Name.FullName )
            saveContactEntry( contact, 0 )
