module ProductsSoldToCustomers

open System
open Common
open FSharp.Data
open sync.today.Models

type private ProductsSoldToCustomersQuery = SqlCommandProvider<"ProductsSoldToCustomers.sql", ConnectionStringName>
type private EnsureProductSoldToCustomerQuery = SqlCommandProvider<"EnsureProductSoldToCustomer.sql", ConnectionStringName>
type private AddCustomerValueToProductSoldQuery = SqlCommandProvider<"AddCustomerValueToProductSold.sql", ConnectionStringName>

let private convert2( r : EnsureProductSoldToCustomerQuery.Record ) : ProductSoldToCustomerDTO =
    {
        Id = r.Id;
        InternalId = r.InternalId;
        LastModified = r.LastModified;
        Category = r.Category;
        ProductId = r.ProductId;
        CustomerId = r.CustomerId;
        SoldWhen = r.SoldWhen;
        UnitPrice = r.UnitPrice;
        Units = r.Units;
        UsageId = r.ProductUsageId
        UsageComment = r.ProductUsageComment;
        UsageSuccessLevel = r.ProductUsageSuccessLevel
    }
let private convert3( r : AddCustomerValueToProductSoldQuery.Record ) : ProductSoldToCustomerDTO =
    {
        Id = r.Id;
        InternalId = r.InternalId;
        LastModified = r.LastModified;
        Category = r.Category;
        ProductId = r.ProductId;
        CustomerId = r.CustomerId;
        SoldWhen = r.SoldWhen;
        UnitPrice = r.UnitPrice;
        Units = r.Units;
        UsageId = r.ProductUsageId
        UsageComment = r.ProductUsageComment;
        UsageSuccessLevel = r.ProductUsageSuccessLevel
    }

let ensureProductSoldToCustomer( product : ProductDTO, customer : CustomerDTO, soldWhen : DateTime, unitPrice : decimal, units : decimal) : ProductSoldToCustomerDTO =
    ( new EnsureProductSoldToCustomerQuery() ).AsyncExecute(product.Id, customer.Id, soldWhen, unitPrice, units) |> Async.RunSynchronously |> Seq.head |> convert2

let addCustomerValueToProductSold( productSold : ProductSoldToCustomerDTO, usage : ProductUsageDTO, comment : string, successLevel : decimal ) : ProductSoldToCustomerDTO =
    ( new AddCustomerValueToProductSoldQuery() ).AsyncExecute(productSold.Id, usage.Id, comment, successLevel) |> Async.RunSynchronously |> Seq.head |> convert3
