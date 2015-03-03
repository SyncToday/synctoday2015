module GoogleContactsSQL

open Common
open System
open System.Data
open System.Data.Linq
open System.Data.SqlClient
open Microsoft.FSharp.Data.TypeProviders
open sync.today.Models
open MainDataConnection

let internal convert( r : SqlConnection.ServiceTypes.GoogleContacts ) : GoogleContactDTO =
    { Id = r.Id; InternalId = r.InternalId; ExternalId = r.ExternalId; ChangedOn = r.ChangedOn; Content = r.Content; Title = r.Title; Email = r.Email; GivenName = r.GivenName;
      FamilyName = r.FamilyName; OrgDepartment = r.OrgDepartment; OrgJobDescription = r.OrgJobDescription; OrgName = r.OrgName; OrgTitle = r.OrgTitle; PrimaryPhonenumber = r.PrimaryPhonenumber;
      postalAddressCity = r.PostalAddressCity; postalAddressStreet = r.PostalAddressStreet; postalAddressRegion = r.PostalAddressRegion; postalAddressPostcode = r.PostalAddressPostcode;
      postalAddressCountry = r.PostalAddressCountry; postalAddressFormattedAddress = r.PostalAddressFormattedAddress }

let internal getContactById( id ) =
    query {
        for contact in db().GoogleContacts do
        where ( contact.ExternalId = id )        
    } |> Seq.tryHead

