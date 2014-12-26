module Repository

open System
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders
open Google.GData.Client
open Google.GData.Contacts
open Google.GData.Extensions

// for technical see http://msdn.microsoft.com/en-us/library/hh361035.aspx
// note as this is a sample we do not follow recommendations from http://fsharpforfunandprofit.com/posts/recipe-part3/
[<Literal>]
let connectionString = "Data Source=(localdb)\ProjectsV12; Initial Catalog=SyncToday2015; Integrated Security=True;"

type internal EntityConnection = SqlEntityConnection<ConnectionStringName="sync-today-mssql",
                                                        Pluralize = true>

let private context = EntityConnection.GetDataContext()

let private fullContext = context.DataContext

// this should got to Common.fs
module Seq =
    let tryHead xs = xs |> Seq.tryPick Some

let internal getGroupById( id ) =
    query {
        for qroup in context.adapters_google_Groups do
        where ( qroup.ExternalId = id )     
    } |> Seq.tryHead

let internal getContactById( id ) =
    query {
        for contact in context.adapters_google_Contacts do
        where ( contact.ExternalId = id )        
    } |> Seq.tryHead

let public saveGroupMembership( contact : ContactEntry ) =
    let dbContact = getContactById( contact.Id.Uri.Content )
    fullContext.ExecuteStoreCommand( "DELETE [adapters.google.GroupMemberships] WHERE ContactId=" + dbContact.Value.ContactId.ToString() ) |> ignore    
    for groupMember in contact.GroupMembership do
        let group2 = getGroupById( groupMember.HRef)
        if group2.IsSome then
            let newMembership = new EntityConnection.ServiceTypes.adapters_google_GroupMemberships( ContactId = Nullable<int>(dbContact.Value.ContactId), 
                                                                                                    GroupId = Nullable<int>(group2.Value.GroupId) )
            fullContext.AddObject("adapters_google_GroupMemberships", newMembership)
            fullContext.SaveChanges() |> ignore

let public saveGroup( id, updated : DateTime, title, adapterId ) =
    let possibleGroup = getGroupById( id )
    // https://sergeytihon.wordpress.com/2013/04/10/f-null-trick/
    if ( box possibleGroup = null ) then
        let newGroup = new EntityConnection.ServiceTypes.adapters_google_Groups( ExternalId = id, Title = title, ChangedOn = new Nullable<DateTimeOffset>( DateTimeOffset( updated )  ), AdapterId = adapterId )
        fullContext.AddObject("adapters_google_Groups", newGroup)
        fullContext.SaveChanges() |> ignore
        newGroup.GroupId
    else
        let existingGroup = possibleGroup.Value 
        existingGroup.ChangedOn <- new Nullable<DateTimeOffset>( DateTimeOffset( updated ) )
        existingGroup.Title <- title
        fullContext.SaveChanges() |> ignore
        existingGroup.GroupId

let saveAddress(contact : ContactEntry, contactId) = 
        for i = 0 to contact.PostalAddresses.Count - 1 do
            let address = contact.PostalAddresses.Item(i)
            let newAddress = new EntityConnection.ServiceTypes.adapters_google_Addresses( City = address.City, Street = address.Street, Region = address.Region, 
                                                                                            Postcode = address.Postcode, Country = address.Country, 
                                                                                            Formatted = address.FormattedAddress, ContactId = contactId, Label = address.Label, Usage = address.Usage )
            fullContext.AddObject("adapters_google_Addresses", newAddress)

let saveEmail(contact : ContactEntry, contactId) = 
        for i = 0 to contact.Emails.Count - 1 do
            let address = contact.Emails.Item(i)
            let newAddress = new EntityConnection.ServiceTypes.adapters_google_Emails(  ContactId = contactId, Label = address.Label, Address = address.Address, Home = Nullable<bool>(address.Home),
                                                                                            Other = Nullable<bool>(address.Other), Work = Nullable<bool>(address.Work) )
            fullContext.AddObject("adapters_google_Emails", newAddress)

let savePhone(contact : ContactEntry, contactId) = 
        for i = 0 to contact.Phonenumbers.Count - 1 do
            let address = contact.Phonenumbers.Item(i)
            let newAddress = new EntityConnection.ServiceTypes.adapters_google_PhoneNumbers( ContactId = contactId, Label = address.Label, Value = address.Value, Home = Nullable<bool>(address.Home),
                                                                                            Other = Nullable<bool>(address.Other), Work = Nullable<bool>(address.Work) )
            fullContext.AddObject("adapters_google_PhoneNumbers", newAddress)

let public saveContact( id, updated : DateTime, content, title, email, givenName, familyName, orgDepartment, 
                        orgJobDescription, orgName, orgTitle, contactPrimaryPhonenumber, 
                        postalAddressCity, postalAddressStreet, postalAddressRegion,
                        postalAddressPostcode, postalAddressCountry, postalAddressFormattedAddress,                        
                        adapterId, contact : ContactEntry ) =
    let possibleContact = getContactById( id )
    // https://sergeytihon.wordpress.com/2013/04/10/f-null-trick/
    if ( box possibleContact = null ) then
        let newContact = new EntityConnection.ServiceTypes.adapters_google_Contacts( ExternalId = id, ChangedOn = new Nullable<DateTimeOffset>( DateTimeOffset( updated )  ), Title = title,
                            Content = content, Email = email, GivenName = givenName, FamilyName = familyName, OrgDepartment = orgDepartment, OrgJobDescription = orgJobDescription,
                            OrgName = orgName, OrgTitle = orgTitle, PrimaryPhonenumber = contactPrimaryPhonenumber, 
                            postalAddressCity = postalAddressCity, postalAddressStreet =  postalAddressStreet,
                            postalAddressRegion = postalAddressRegion, postalAddressPostcode = postalAddressPostcode,
                            postalAddressCountry = postalAddressCountry, postalAddressFormattedAddress = postalAddressFormattedAddress,
                            AdapterId = adapterId )
        fullContext.AddObject("adapters_google_Contacts", newContact)
        saveAddress(contact, Nullable<int>(newContact.ContactId))
        saveEmail(contact, Nullable<int>(newContact.ContactId))
        savePhone(contact, Nullable<int>(newContact.ContactId))
    else
        let existingContact = possibleContact.Value 
        existingContact.ChangedOn <- new Nullable<DateTimeOffset>( DateTimeOffset( updated ) )
        existingContact.Content <- content
        existingContact.Title <- title
        existingContact.Email <- email
        existingContact.GivenName <- givenName
        existingContact.FamilyName <- familyName
        existingContact.OrgDepartment <- orgDepartment
        existingContact.OrgJobDescription <- orgJobDescription
        existingContact.OrgName <- orgName
        existingContact.OrgTitle <- orgTitle
        existingContact.PrimaryPhonenumber <- contactPrimaryPhonenumber
        existingContact.postalAddressCity <- postalAddressCity
        existingContact.postalAddressStreet <-  postalAddressStreet
        existingContact.postalAddressRegion <- postalAddressRegion
        existingContact.postalAddressPostcode <- postalAddressPostcode
        existingContact.postalAddressCountry <- postalAddressCountry
        existingContact.postalAddressFormattedAddress <- postalAddressFormattedAddress
        fullContext.ExecuteStoreCommand( "DELETE [adapters.google.Addresses] WHERE ContactId=" + existingContact.ContactId.ToString() ) |> ignore
        saveAddress(contact, Nullable<int>(existingContact.ContactId))
        fullContext.ExecuteStoreCommand( "DELETE [adapters.google.Emails] WHERE ContactId=" + existingContact.ContactId.ToString() ) |> ignore
        saveEmail(contact, Nullable<int>(existingContact.ContactId))
        fullContext.ExecuteStoreCommand( "DELETE [adapters.google.PhoneNumbers] WHERE ContactId=" + existingContact.ContactId.ToString() ) |> ignore
        savePhone(contact, Nullable<int>(existingContact.ContactId))
    fullContext.SaveChanges() |> ignore
    id
