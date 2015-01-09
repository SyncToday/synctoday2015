module Repository

open System
open System.Data.Linq
open System.Data.Entity
open Microsoft.FSharp.Data.TypeProviders

let adapterId = Guid.Parse("3A7E2EAC-3664-4404-9001-E40BA1CDFCC0")

type internal mysqlEntityConnection = SqlEntityConnection<ConnectionStringName="sync-today-hikashop", Provider="MySql.Data.MySqlClient",
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

///////////////////////////////////////

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

let internal getOrders =
    query {
        for order in mysqlContext.h962i_hikashop_order do 
        select order   
    } |> Seq.toList

let internal getProducts =
    query {
        for product in mysqlContext.h962i_hikashop_product do 
        select product   
    } |> Seq.toList

let internal getOrderProducts =
    query {
        for orderProduct in mysqlContext.h962i_hikashop_order_product do 
        select orderProduct   
    } |> Seq.toList

///////////////////////////////////////

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

let internal getOrderById( id : int64 ) =
    query {
        for order in context.adapters_hikashop_Order do
        where ( order.order_id  = int id)        
    } |> Seq.tryHead

let internal getProductById( id : int64 ) =
    query {
        for product in context.adapters_hikashop_Product do
        where ( product.product_id  = int id)        
    } |> Seq.tryHead

let internal getOrderProductById( id : int64 ) =
    query {
        for orderProduct in context.adapters_hikashop_OrderProduct do
        where ( orderProduct.order_product_id = int id)        
    } |> Seq.tryHead


///////////////////////////////////////

let internal copyUser( dbUser : EntityConnection.ServiceTypes.adapters_hikashop_User, user : mysqlEntityConnection.ServiceTypes.h962i_hikashop_user ) =
        dbUser.user_cms_id <- Nullable<int>(int user.user_cms_id)
        dbUser.user_created  <- Nullable<int>(int user.user_created )
        dbUser.user_created_ip  <- user.user_created_ip
        dbUser.user_currency_id   <- Nullable<int>(int user.user_currency_id)
        dbUser.user_email  <- user.user_email
        dbUser.user_id  <- int user.user_id
        dbUser.user_params  <- user.user_params
        dbUser.user_partner_activated  <- Nullable<int>(int user.user_partner_activated)
        dbUser.user_partner_currency_id  <- Nullable<int>(int user.user_partner_currency_id)
        dbUser.user_partner_email  <- user.user_partner_email
        dbUser.user_partner_id  <- Nullable<int>(int user.user_partner_id)
        dbUser.user_partner_paid  <- Nullable<int>(int user.user_partner_paid)
        dbUser.user_partner_price  <- Nullable<decimal>(user.user_partner_price)
        dbUser.user_unpaid_amount  <- Nullable<decimal>(user.user_unpaid_amount)
    
let internal copyAddress( dbAddress : EntityConnection.ServiceTypes.adapters_hikashop_Address, address : mysqlEntityConnection.ServiceTypes.h962i_hikashop_address ) =
        dbAddress.address_id <- int address.address_id
        dbAddress.address_city <- address.address_city
        dbAddress.address_company <- address.address_company 
        dbAddress.address_country  <- address.address_country
        dbAddress.address_default <- Nullable<int>(int address.address_default)
        dbAddress.address_fax <- address.address_fax
        dbAddress.address_firstname <- address.address_firstname 
        dbAddress.address_lastname  <- address.address_lastname
        dbAddress.address_middle_name  <- address.address_middle_name
        dbAddress.address_post_code  <- address.address_post_code
        dbAddress.address_published  <- Nullable<int>(int address.address_published)
        dbAddress.address_state  <- address.address_state
        dbAddress.address_street  <- address.address_street
        dbAddress.address_street2  <- address.address_street2
        dbAddress.address_telephone  <- address.address_telephone
        dbAddress.address_telephone2  <- address.address_telephone2
        dbAddress.address_title  <- address.address_title
        dbAddress.address_user_id  <- Nullable<int>(int address.address_user_id)
        dbAddress.address_vat  <- address.address_vat

let internal copyOrder( dbOrder : EntityConnection.ServiceTypes.adapters_hikashop_Order, order : mysqlEntityConnection.ServiceTypes.h962i_hikashop_order ) =
        dbOrder.order_billing_address_id <- int order.order_billing_address_id
        dbOrder.order_created <- int order.order_created
        dbOrder.order_currency_id <- int order.order_currency_id
        dbOrder.order_discount_code <- order.order_discount_code
        dbOrder.order_discount_price <- order.order_discount_price
        dbOrder.order_discount_tax <- order.order_discount_tax
        dbOrder.order_full_price <- order.order_full_price
        dbOrder.order_id <- int order.order_id
        dbOrder.order_invoice_created <- int order.order_invoice_created
        dbOrder.order_invoice_id <- order.order_invoice_id
        dbOrder.order_invoice_number <- order.order_invoice_number
        dbOrder.order_ip <- order.order_ip
        dbOrder.order_modified <- int order.order_modified
        dbOrder.order_number <- order.order_number
        dbOrder.order_partner_currency_id <- int order.order_partner_currency_id
        dbOrder.order_partner_id <- int order.order_partner_id
        dbOrder.order_partner_paid <- order.order_partner_paid
        dbOrder.order_partner_price <- order.order_partner_price
        dbOrder.order_payment_id <- order.order_payment_id
        dbOrder.order_payment_method <- order.order_payment_method
        dbOrder.order_payment_params <- order.order_payment_params
        dbOrder.order_payment_price <- order.order_payment_price
        dbOrder.order_shipping_address_id <- int order.order_shipping_address_id
        dbOrder.order_shipping_id <- order.order_shipping_id
        dbOrder.order_shipping_method <- order.order_shipping_method
        dbOrder.order_shipping_params <- order.order_shipping_params
        dbOrder.order_shipping_price <- order.order_shipping_price
        dbOrder.order_shipping_tax <- order.order_shipping_tax
        dbOrder.order_site_id <- order.order_site_id
        dbOrder.order_status <- order.order_status
        dbOrder.order_tax_info <- order.order_tax_info
        dbOrder.order_type <- order.order_type
        dbOrder.order_user_id <- int order.order_user_id

let nullableInt16ToInt( par: Nullable<int16> ) : Nullable<int> =
    if ( par.HasValue ) then
        Nullable( int par.Value )
    else
        Nullable()
let nullableInt64ToInt( par: Nullable<int64> ) : Nullable<int> =
    if ( par.HasValue ) then
        Nullable( int par.Value )
    else
        Nullable()

let internal copyProduct( dbProduct : EntityConnection.ServiceTypes.adapters_hikashop_Product, product : mysqlEntityConnection.ServiceTypes.h962i_hikashop_product ) =
        dbProduct.product_access <- product.product_access
        dbProduct.product_alias <- product.product_alias
        dbProduct.product_average_score <- float product.product_average_score
        dbProduct.product_canonical <- product.product_canonical
        dbProduct.product_code <- product.product_code
        dbProduct.product_contact <- product.product_contact
        dbProduct.product_created <- int product.product_created
        dbProduct.product_delay_id <- int product.product_delay_id
        dbProduct.product_description <- product.product_description
        dbProduct.product_dimension_unit <- product.product_dimension_unit
        dbProduct.product_display_quantity_field <- nullableInt16ToInt( product.product_display_quantity_field )
        dbProduct.product_group_after_purchase <- product.product_group_after_purchase
        dbProduct.product_height <- product.product_height
        dbProduct.product_hit <- int product.product_hit
        dbProduct.product_id <- int product.product_id
        dbProduct.product_keywords <- product.product_keywords
        dbProduct.product_last_seen_date <- nullableInt64ToInt(product.product_last_seen_date)
        dbProduct.product_layout <- product.product_layout
        dbProduct.product_length <- product.product_length
        dbProduct.product_manufacturer_id <- int product.product_manufacturer_id
        dbProduct.product_max_per_order <- nullableInt64ToInt(product.product_max_per_order)
        dbProduct.product_meta_description <- product.product_meta_description
        dbProduct.product_min_per_order <- nullableInt64ToInt(product.product_min_per_order)
        dbProduct.product_modified <- int product.product_modified
        dbProduct.product_msrp <- product.product_msrp
        dbProduct.product_name <- product.product_name
        dbProduct.product_page_title <- product.product_page_title
        dbProduct.product_parent_id <- int product.product_parent_id
        dbProduct.product_price_percentage <- product.product_price_percentage
        dbProduct.product_published <- int product.product_published
        dbProduct.product_quantity <- product.product_quantity
        dbProduct.product_quantity_layout <- product.product_quantity_layout
        dbProduct.product_sale_end <- int product.product_sale_end
        dbProduct.product_sale_start <- int product.product_sale_start
        dbProduct.product_sales <- nullableInt64ToInt( product.product_sales )
        dbProduct.product_tax_id <- int product.product_tax_id
        dbProduct.product_total_vote <- product.product_total_vote
        dbProduct.product_type <- product.product_type
        dbProduct.product_url <- product.product_url
        dbProduct.product_vendor_id <- int product.product_vendor_id
        dbProduct.product_waitlist <- product.product_waitlist
        dbProduct.product_warehouse_id <- int product.product_warehouse_id
        //dbProduct.product_weight <- product.
        dbProduct.product_weight_unit <- product.product_weight_unit
        dbProduct.product_width <- product.product_width

let internal copyOrderProduct( dbOrderProduct : EntityConnection.ServiceTypes.adapters_hikashop_OrderProduct, orderProduct : mysqlEntityConnection.ServiceTypes.h962i_hikashop_order_product ) =
        dbOrderProduct.order_id <- int orderProduct.order_id
        dbOrderProduct.order_product_code <- orderProduct.order_product_code
        dbOrderProduct.order_product_id <- int orderProduct.order_product_id
        dbOrderProduct.order_product_name <- orderProduct.order_product_name
        dbOrderProduct.order_product_option_parent_id <- nullableInt64ToInt orderProduct.order_product_option_parent_id
        dbOrderProduct.order_product_options <- orderProduct.order_product_options
        dbOrderProduct.order_product_price <- orderProduct.order_product_price
        dbOrderProduct.order_product_quantity <- int orderProduct.order_product_quantity
        dbOrderProduct.order_product_shipping_id <- orderProduct.order_product_shipping_id
        dbOrderProduct.order_product_shipping_method <- orderProduct.order_product_shipping_method
        dbOrderProduct.order_product_shipping_params <- orderProduct.order_product_shipping_params
        dbOrderProduct.order_product_shipping_price <- orderProduct.order_product_shipping_price
        dbOrderProduct.order_product_shipping_tax <- orderProduct.order_product_shipping_tax
        dbOrderProduct.order_product_tax <- orderProduct.order_product_tax
        dbOrderProduct.order_product_tax_info <- orderProduct.order_product_tax_info
        dbOrderProduct.order_product_wishlist_id <- orderProduct.order_product_wishlist_id
        dbOrderProduct.product_id <- int orderProduct.product_id


///////////////////////////////////////


let internal saveUser(user : mysqlEntityConnection.ServiceTypes.h962i_hikashop_user) =
    let possibleUser = getUserById( user.user_id )
    if ( box possibleUser = null ) then
        let newUser = new EntityConnection.ServiceTypes.adapters_hikashop_User()
        copyUser(newUser, user)
        fullContext.AddObject("adapters_hikashop_User", newUser)
    else
        let existingUser = possibleUser.Value 
        copyUser(existingUser, user)

    fullContext.SaveChanges() |> ignore


let internal saveAddress(address : mysqlEntityConnection.ServiceTypes.h962i_hikashop_address) =
    let possibleAddress = getAddressById( address.address_id )
    if ( box possibleAddress = null ) then
        let newAddress = new EntityConnection.ServiceTypes.adapters_hikashop_Address()
        copyAddress(newAddress, address)
        fullContext.AddObject("adapters_hikashop_Address", newAddress)
    else
        let existingAddress = possibleAddress.Value 
        copyAddress(existingAddress, address)

    fullContext.SaveChanges() |> ignore


let internal saveOrder(order : mysqlEntityConnection.ServiceTypes.h962i_hikashop_order) =
    let possibleOrder = getOrderById( order.order_id )
    if ( box possibleOrder = null ) then
        let newOrder = new EntityConnection.ServiceTypes.adapters_hikashop_Order()
        copyOrder(newOrder, order)
        fullContext.AddObject("adapters_hikashop_Order", newOrder)
    else
        let existingorder = possibleOrder.Value 
        copyOrder(existingorder, order)

    fullContext.SaveChanges() |> ignore

let internal saveProduct(product : mysqlEntityConnection.ServiceTypes.h962i_hikashop_product) =
    let possibleProduct = getProductById( product.product_id )
    if ( box possibleProduct = null ) then
        let newProduct = new EntityConnection.ServiceTypes.adapters_hikashop_Product()
        copyProduct(newProduct, product)
        fullContext.AddObject("adapters_hikashop_Product", newProduct)
    else
        let existingProduct = possibleProduct.Value 
        copyProduct(existingProduct, product)

    fullContext.SaveChanges() |> ignore

let internal saveOrderProduct(orderProduct : mysqlEntityConnection.ServiceTypes.h962i_hikashop_order_product) =
    let possibleOrderProduct = getOrderProductById( orderProduct.order_product_id )
    if ( box possibleOrderProduct = null ) then
        let newOrderProduct = new EntityConnection.ServiceTypes.adapters_hikashop_OrderProduct()
        copyOrderProduct(newOrderProduct, orderProduct)
        fullContext.AddObject("adapters_hikashop_OrderProduct", newOrderProduct)
    else
        let existingorderProduct = possibleOrderProduct.Value 
        copyOrderProduct(existingorderProduct, orderProduct)

    fullContext.SaveChanges() |> ignore
