module GoogleContactsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection
open Google.GData.Contacts

let internal convert( r : SqlConnection.ServiceTypes.GoogleContacts ) : GoogleContactDTO =
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; ChangedOn = r.ChangedOn; Content = r.Content; Title = r.Title; Email = r.Email; GivenName = r.GivenName;
      FamilyName = r.FamilyName; OrgDepartment = r.OrgDepartment; OrgJobDescription = r.OrgJobDescription; OrgName = r.OrgName; OrgTitle = r.OrgTitle; PrimaryPhonenumber = r.PrimaryPhonenumber;
      postalAddressCity = r.PostalAddressCity; postalAddressStreet = r.PostalAddressStreet; postalAddressRegion = r.PostalAddressRegion; postalAddressPostcode = r.PostalAddressPostcode;
      postalAddressCountry = r.PostalAddressCountry; postalAddressFormattedAddress = r.PostalAddressFormattedAddress }

let internal getGroupById( id ) =
    let db = db()
    query {
        for qroup in db.GoogleGroups do
        where ( qroup.ExternalId = id )     
    } |> Seq.tryHead

let internal getContactById( id ) =
    query {
        for contact in db().GoogleContacts do
        where ( contact.ExternalId = id )        
    } |> Seq.tryHead

let public saveGroupMembership( contact : ContactEntry ) =
    let db = db()
    let dbContact = getContactById( contact.Id.Uri.Content )
    cnn().ExecuteCommand( "DELETE GoogleGroupMemberships WHERE ContactId=@ContactId", SqlParameter( "@ContactId", dbContact.Value.Id ) ) |> ignore    
    for groupMember in contact.GroupMembership do
        let group2 = getGroupById( groupMember.HRef)
        if group2.IsSome then
            let newMembership = 
                new SqlConnection.ServiceTypes.GoogleGroupMemberships( 
                    InternalId = Guid.NewGuid(),
                    ContactId = (dbContact.Value.Id), 
                    GroupId = (group2.Value.Id) 
                 )
            db.GoogleGroupMemberships.InsertOnSubmit newMembership
    db.DataContext.SubmitChanges()

let public saveGroup( id, updated : DateTime, title, adapterId ) =
    let db = db()
    try
        let possibleGroup = 
            query {
                for qroup in db.GoogleGroups do
                where ( qroup.ExternalId = id )     
            } |> Seq.tryHead
        if possibleGroup.IsNone then
            let newGroup = new SqlConnection.ServiceTypes.GoogleGroups( InternalId = Guid.NewGuid(), ExternalId = id, Title = title, ChangedOn = updated )
            db.GoogleGroups.InsertOnSubmit newGroup
            db.DataContext.SubmitChanges()
            newGroup.Id
        else
            let existingGroup = possibleGroup.Value 
            existingGroup.ChangedOn <- updated
            existingGroup.Title <- title
            db.DataContext.SubmitChanges()
            existingGroup.Id
    with
        | ex -> raise (System.ArgumentException("saveGroup failed", ex))

let saveAddress(contact : ContactEntry, contactId) = 
    let db = db()
    for i = 0 to contact.PostalAddresses.Count - 1 do
        let address = contact.PostalAddresses.Item(i)
        let newAddress = 
            new SqlConnection.ServiceTypes.GoogleAddresses( InternalId = Guid.NewGuid(), City = address.City, Street = address.Street, Region = address.Region, 
                Postcode = address.Postcode, Country = address.Country, 
                Formatted = address.FormattedAddress, ContactId = contactId, Label = address.Label, Usage = address.Usage )
        db.GoogleAddresses.InsertOnSubmit newAddress
    db.DataContext.SubmitChanges()

let saveEmail(contact : ContactEntry, contactId) = 
    let db = db()
    for i = 0 to contact.Emails.Count - 1 do
        let address = contact.Emails.Item(i)
        let newAddress = 
            new SqlConnection.ServiceTypes.GoogleEmails ( InternalId = Guid.NewGuid(), ContactId = contactId, Label = address.Label, Address = address.Address, 
                Home = Nullable<bool>(address.Home),
                Other = Nullable<bool>(address.Other), Work = Nullable<bool>(address.Work) )
        db.GoogleEmails.InsertOnSubmit newAddress
    db.DataContext.SubmitChanges()

let savePhone(contact : ContactEntry, contactId) = 
    let db = db()
    for i = 0 to contact.Phonenumbers.Count - 1 do
        let address = contact.Phonenumbers.Item(i)
        let newAddress = 
            new SqlConnection.ServiceTypes.GooglePhoneNumbers( ContactId = contactId, Label = address.Label, Value = address.Value, Home = Nullable<bool>(address.Home),
                Other = Nullable<bool>(address.Other), Work = Nullable<bool>(address.Work) )
        db.GooglePhoneNumbers.InsertOnSubmit newAddress
    db.DataContext.SubmitChanges()

let public saveContact( id, updated : DateTime, content, title, email, givenName, familyName, orgDepartment, 
                        orgJobDescription, orgName, orgTitle, contactPrimaryPhonenumber, 
                        postalAddressCity, postalAddressStreet, postalAddressRegion,
                        postalAddressPostcode, postalAddressCountry, postalAddressFormattedAddress,                        
                        adapterId, contact : ContactEntry ) =
    let db = db()
    let possibleContact = 
        query {
            for contact in db.GoogleContacts do
            where ( contact.ExternalId = id )        
        } |> Seq.tryHead
    if ( possibleContact.IsNone ) then
        let newContact = new SqlConnection.ServiceTypes.GoogleContacts( InternalId = Guid.NewGuid(), ExternalId = id, ChangedOn = updated, Title = title,
                            Content = content, Email = email, GivenName = givenName, FamilyName = familyName, OrgDepartment = orgDepartment, OrgJobDescription = orgJobDescription,
                            OrgName = orgName, OrgTitle = orgTitle, PrimaryPhonenumber = contactPrimaryPhonenumber, 
                            PostalAddressCity = postalAddressCity, PostalAddressStreet =  postalAddressStreet,
                            PostalAddressRegion = postalAddressRegion, PostalAddressPostcode = postalAddressPostcode,
                            PostalAddressCountry = postalAddressCountry, PostalAddressFormattedAddress = postalAddressFormattedAddress )
        db.GoogleContacts.InsertOnSubmit newContact
        db.DataContext.SubmitChanges()
        saveEmail(contact, newContact.Id )
        savePhone(contact, newContact.Id )
    else
        let existingContact = possibleContact.Value 
        existingContact.ChangedOn <- updated
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
        existingContact.PostalAddressCity <- postalAddressCity
        existingContact.PostalAddressStreet <-  postalAddressStreet
        existingContact.PostalAddressRegion <- postalAddressRegion
        existingContact.PostalAddressPostcode <- postalAddressPostcode
        existingContact.PostalAddressCountry <- postalAddressCountry
        existingContact.PostalAddressFormattedAddress <- postalAddressFormattedAddress
        let param1 = SqlParameter( "@ContactId", existingContact.Id )
        db.DataContext.ExecuteCommand( "DELETE GoogleAddresses WHERE ContactId=@ContactId", param1 ) |> ignore
        saveAddress(contact, existingContact.Id)
        let param2 = SqlParameter( "@ContactId", existingContact.Id )
        db.DataContext.ExecuteCommand( "DELETE GoogleEmails WHERE ContactId=@ContactId", param2 ) |> ignore
        saveEmail(contact, existingContact.Id)
        let param3 = SqlParameter( "@ContactId", existingContact.Id )
        db.DataContext.ExecuteCommand( "DELETE GooglePhoneNumbers WHERE ContactId=@ContactId", param3 ) |> ignore
        savePhone(contact, existingContact.Id)
    db.DataContext.SubmitChanges() |> ignore
    id
