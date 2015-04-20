module Products

open Common
open FSharp.Data
open sync.today.Models

type private EnsureProductQuery = SqlCommandProvider<"EnsureProduct.sql", ConnectionStringName>

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

let ensureProduct( name : string ) : ProductDTO =
    ( new EnsureProductQuery() ).AsyncExecute(name) |> Async.RunSynchronously |> Seq.head |> convert2
