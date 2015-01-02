module Repository

open System
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders


[<Literal>]
let mysqlConnectionString = "Server=185.25.184.152;Database=c25_2210;Uid=c25_2210;Pwd=12174246"

let adapterId = Guid.Parse("3A7E2EAC-3664-4404-9001-E40BA1CDFCC0")

type internal mysqlEntityConnection = SqlEntityConnection<ConnectionString=mysqlConnectionString, Provider="MySql.Data.MySqlClient",
                                                                        Pluralize = true>

type internal EntityConnection = SqlEntityConnection<ConnectionStringName="sync-today-mssql",
                                                        Pluralize = true>

let private context = EntityConnection.GetDataContext()

let private fullContext = context.DataContext


let private mysqlContext = mysqlEntityConnection.GetDataContext()

let private mysqlFullContext = mysqlContext.DataContext

// this should got to Common.fs
module Seq =
    let tryHead xs = xs |> Seq.tryPick Some

let internal getUsers =
    query {
        for user in mysqlContext.h962i_hikashop_user do 
        select user   
    } |> Seq.toList


let internal getAddresses =
    query {
        for address in mysqlContext.h962i_hikashop_address do 
        select address   
    } |> Seq.toList

let internal getUserById( id : int64 ) =
    query {
        for user in context.adapters_hikashop_User do
        where ( user.user_id  = int id)        
    } |> Seq.tryHead


let internal getAddressById( id : int64 ) =
    query {
        for address in context.adapters_hikashop_Address do
        where ( address.address_id  = int id)        
    } |> Seq.tryHead

let internal saveUser(user : mysqlEntityConnection.ServiceTypes.h962i_hikashop_user) =
    let possibleUser = getUserById( user.user_id )
    if ( box possibleUser = null ) then
        let newUser = new EntityConnection.ServiceTypes.adapters_hikashop_User()
        newUser.user_cms_id <- Nullable<int>(int user.user_cms_id)
        newUser.user_created  <- Nullable<int>(int user.user_created )
        newUser.user_created_ip  <- user.user_created_ip
        newUser.user_currency_id   <- Nullable<int>(int user.user_currency_id)
        newUser.user_email  <- user.user_email
        newUser.user_id  <- int user.user_id
        newUser.user_params  <- user.user_params
        newUser.user_partner_activated  <- Nullable<int>(int user.user_partner_activated)
        newUser.user_partner_currency_id  <- Nullable<int>(int user.user_partner_currency_id)
        newUser.user_partner_email  <- user.user_partner_email
        newUser.user_partner_id  <- Nullable<int>(int user.user_partner_id)
        newUser.user_partner_paid  <- Nullable<int>(int user.user_partner_paid)
        newUser.user_partner_price  <- Nullable<decimal>(user.user_partner_price)
        newUser.user_unpaid_amount  <- Nullable<decimal>(user.user_unpaid_amount)
        fullContext.AddObject("adapters_hikashop_User", newUser)
    else
        let existingUser = possibleUser.Value 
        existingUser.user_cms_id <- Nullable<int>(int user.user_cms_id)
        existingUser.user_created  <- Nullable<int>(int user.user_created )
        existingUser.user_created_ip  <- user.user_created_ip
        existingUser.user_currency_id   <- Nullable<int>(int user.user_currency_id)
        existingUser.user_email  <- user.user_email
        existingUser.user_params  <- user.user_params
        existingUser.user_partner_activated  <- Nullable<int>(int user.user_partner_activated)
        existingUser.user_partner_currency_id  <- Nullable<int>(int user.user_partner_currency_id)
        existingUser.user_partner_email  <- user.user_partner_email
        existingUser.user_partner_id  <- Nullable<int>(int user.user_partner_id)
        existingUser.user_partner_paid  <- Nullable<int>(int user.user_partner_paid)
        existingUser.user_partner_price  <- Nullable<decimal>(user.user_partner_price)
        existingUser.user_unpaid_amount  <- Nullable<decimal>(user.user_unpaid_amount)
    fullContext.SaveChanges() |> ignore


let internal saveAdress(address : mysqlEntityConnection.ServiceTypes.h962i_hikashop_address) =
    let possibleAddress = getAddressById( address.address_id )
    if ( box possibleAddress = null ) then
        let newAddress = new EntityConnection.ServiceTypes.adapters_hikashop_Address()
        newAddress.address_id <- int address.address_id
        newAddress.address_city <- address.address_city
        newAddress.address_company <- address.address_company 
        newAddress.address_country  <- address.address_country
        newAddress.address_default <- Nullable<int>(int address.address_default)
        newAddress.address_fax <- address.address_fax
        newAddress.address_firstname <- address.address_firstname 
        newAddress.address_lastname  <- address.address_lastname
        newAddress.address_middle_name  <- address.address_middle_name
        newAddress.address_post_code  <- address.address_post_code
        newAddress.address_published  <- Nullable<int>(int address.address_published)
        newAddress.address_state  <- address.address_state
        newAddress.address_street  <- address.address_street
        newAddress.address_street2  <- address.address_street2
        newAddress.address_telephone  <- address.address_telephone
        newAddress.address_telephone2  <- address.address_telephone2
        newAddress.address_title  <- address.address_title
        newAddress.address_user_id  <- Nullable<int>(int address.address_user_id)
        newAddress.address_vat  <- address.address_vat
        fullContext.AddObject("adapters_hikashop_Address", newAddress)
    else
        let existingAddress = possibleAddress.Value 
        existingAddress.address_city <- address.address_city
        existingAddress.address_company <- address.address_company 
        existingAddress.address_country  <- address.address_country
        existingAddress.address_default <- Nullable<int>(int address.address_default)
        existingAddress.address_fax <- address.address_fax
        existingAddress.address_firstname <- address.address_firstname 
        existingAddress.address_lastname  <- address.address_lastname
        existingAddress.address_middle_name  <- address.address_middle_name
        existingAddress.address_post_code  <- address.address_post_code
        existingAddress.address_published  <- Nullable<int>(int address.address_published)
        existingAddress.address_state  <- address.address_state
        existingAddress.address_street  <- address.address_street
        existingAddress.address_street2  <- address.address_street2
        existingAddress.address_telephone  <- address.address_telephone
        existingAddress.address_telephone2  <- address.address_telephone2
        existingAddress.address_title  <- address.address_title
        existingAddress.address_user_id  <- Nullable<int>(int address.address_user_id)
        existingAddress.address_vat  <- address.address_vat

    fullContext.SaveChanges() |> ignore
