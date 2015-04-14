module Customers

open Common
open FSharp.Data
open sync.today.Models

type private CustomersQuery = SqlCommandProvider<"Customers.sql", ConnectionStringName>
type private EnsureCustomerQuery = SqlCommandProvider<"EnsureCustomer.sql", ConnectionStringName>

let private convert2( r : EnsureCustomerQuery.Record ) : CustomerDTO  =
    {
        Id = r.Id;
        InternalId = r.InternalId;
        LastModified = r.LastModified;
        Category = r.Category;
        Name = r.Name;
        Code = r.Code;
        CustomerCategoryId = r.CustomerCategoryId
    }

let ensureCustomer( name : string, category : CustomerCategoryDTO ) : CustomerDTO =
    ( new EnsureCustomerQuery() ).AsyncExecute(name, category.Id) |> Async.RunSynchronously |> Seq.head |> convert2
