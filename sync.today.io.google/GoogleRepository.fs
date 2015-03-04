module GoogleRepository

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

    GoogleContactsSQL.saveContact( contact.Id.Uri.Content, contact.Updated, contactContent, contactTitle, contactPrimaryEmailAddress, 
                            contactName.GivenName, 
                            contactName.FamilyName, contactOrg.Department, contactOrg.JobDescription, contactOrg.Name, 
                            contactOrg.Title, contactPrimaryPhonenumber,
                            contactPrimaryPostalAddressCity, contactPrimaryPostalAddressStreet, contactPrimaryPostalAddressRegion,
                            contactPrimaryPostalAddressPostcode, contactPrimaryPostalAddressCountry, contactPrimaryPostalAddressFormattedAddress,
                            adapterId, contact ) |> ignore
