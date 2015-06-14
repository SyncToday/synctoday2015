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

let private convert3 (r : CustomersQuery.Record ) : CustomerDTO =
    {
        Id = r.Id;
        InternalId = r.InternalId;
        LastModified = r.LastModified;
        Category = r.Category;
        Name = r.Name;
        Code = r.Code;
        CustomerCategoryId = r.CustomerCategoryId
    }

let private convert3option( r : CustomersQuery.Record  option ) : CustomerDTO option =
    match r with
        | Some p -> Some(convert3 (p))
        | None -> None


let ensureCustomer( name : string, category : CustomerCategoryDTO ) : CustomerDTO =
    ( new EnsureCustomerQuery() ).AsyncExecute(name, category.Id) |> Async.RunSynchronously |> Seq.head |> convert2

let findCustomer( name : string ) : CustomerDTO seq =
    ( new CustomersQuery() ).AsyncExecute(0, name) |> Async.RunSynchronously |> Seq.map( fun p -> convert3 p )


let getCustomer( id : int ) : CustomerDTO option =
    ( new CustomersQuery() ).AsyncExecute(id, null) |> Async.RunSynchronously |> Seq.tryHead |> convert3option
