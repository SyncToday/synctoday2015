module Products

open Common
open FSharp.Data
open sync.today.Models

type private EnsureProductQuery = SqlCommandProvider<"EnsureProduct.sql", ConnectionStringName>
type private GetProductQuery = SqlCommandProvider<"GetProduct.sql", ConnectionStringName>

let private convert2( r : EnsureProductQuery.Record ) : ProductDTO  =
    {
        Id = r.Id;
        InternalId = r.InternalId;
        LastModified = r.LastModified;
        Category = r.Category;
        Name = r.Name;
        Description = r.Description;
        Code = r.Code
    }

let private convert3( r : GetProductQuery.Record ) : ProductDTO  =
    {
        Id = r.Id;
        InternalId = r.InternalId;
        LastModified = r.LastModified;
        Category = r.Category;
        Name = r.Name;
        Description = r.Description;
        Code = r.Code
    }

let ensureProduct( name : string, code : string ) : ProductDTO =
    ( new EnsureProductQuery() ).AsyncExecute(name, code) |> Async.RunSynchronously |> Seq.head |> convert2

let getProduct( id : int ) : ProductDTO =
    ( new GetProductQuery() ).AsyncExecute(id) |> Async.RunSynchronously |> Seq.head |> convert3
