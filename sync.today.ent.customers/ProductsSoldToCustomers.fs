module ProductsSoldToCustomers

open System
open Common
open FSharp.Data
open sync.today.Models

type private ProductsSoldToCustomersQuery = SqlCommandProvider<"ProductsSoldToCustomers.sql", ConnectionStringName>
type private EnsureProductSoldToCustomerQuery = SqlCommandProvider<"EnsureProductSoldToCustomer.sql", ConnectionStringName>


let ensureProductSoldToCustomer( product : ProductDTO, customer : CustomerDTO, soldWhen : DateTime, unitPrice : decimal, units : decimal) : ProductSoldToCustomerDTO =
    ( new EnsureProductSoldToCustomerQuery() ).AsyncExecute(product.Id, customer.Id, soldWhen, unitPrice, units) |> Async.RunSynchronously |> Seq.head |> convert2
