module Program

open System
open Google.GData.Client
open Google.GData.Contacts
open Google.GData.Extensions

let saveContact(contact : ContactEntry, groupId) =
    let contactName = ( if contact.Name = null then new Name() else contact.Name )
    let contactOrg = ( if contact.Organizations.Count > 0 then contact.Organizations.Item(0) else new Organization() ) 
    let contactContent = contact.Content.Content 
    let contactTitle = contact.Title.Text 
    let contactPrimaryEmailAddress = ( if contact.PrimaryEmail = null then "" else contact.PrimaryEmail.Address )
    Repository.saveContact( contact.Id.Uri.Content, contact.Updated, contactContent, contactTitle, contactPrimaryEmailAddress, contactName.GivenName, 
                            contactName.FamilyName, contactOrg.Department, contactOrg.JobDescription, contactOrg.Name, contactOrg.Title, groupId ) |> ignore

[<EntryPoint>]
let main argv = 
    //let refreshToken = Console.ReadLine()

    let parameters = new OAuth2Parameters(
                            ClientId = "", 
                            ClientSecret = "", 
                            RedirectUri = "urn:ietf:wg:oauth:2.0:oob",
                            Scope = "https://www.google.com/m8/feeds/ https://apps-apis.google.com/a/feeds/groups/",
                            RefreshToken = "" //refreshToken
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
        let groupId = Repository.saveGroup( group.Id.Uri.Content, group.Updated, group.Title.Text )

        let myQuery2 = new ContactsQuery("https://www.google.com/m8/feeds/contacts/default/full")
        myQuery2.Group <- group.Id.Uri.Content
        myQuery2.StartDate <- DateTime.Now.AddYears(-10)
        myQuery2.NumberToRetrieve <- 1000
        let myResultsFeed2 = _service.Query(myQuery2)
        for entry2 in myResultsFeed2.Entries do
            let contact = entry2 :?> ContactEntry
            printfn "\t%A" ( if contact.Name = null then "" else contact.Name.FullName )
            saveContact( contact, groupId )

    printfn "%A" "<<No group>>"
    let groupId = Repository.saveGroup( "", DateTime.Now, "" )

    let myQuery2 = new ContactsQuery("https://www.google.com/m8/feeds/contacts/default/full")
    myQuery2.StartDate <- DateTime.Now.AddYears(-10)
    myQuery2.NumberToRetrieve <- 1000
    let myResultsFeed2 = _service.Query(myQuery2)
    for entry2 in myResultsFeed2.Entries do
        let contact = entry2 :?> ContactEntry
        printfn "\t%A"  ( if contact.Name = null then "" else contact.Name.FullName )
        saveContact( contact, groupId )

    Console.ReadLine() |> ignore
    0 // return an integer exit code
