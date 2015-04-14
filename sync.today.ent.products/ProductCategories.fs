module ProductCategories

open Common
open FSharp.Data
open sync.today.Models

type private EnsureProductCategoryQuery = SqlCommandProvider<"EnsureProductCategory.sql", ConnectionStringName>

let private convert2( r : EnsureProductCategoryQuery.Record ) : ProductCategoryDTO  =
    {
        Id = r.Id;
        InternalId = r.InternalId;
        LastModified = r.LastModified;
        Category = r.Category;
        Name = r.Name;
        Description = r.Description;
        Code = r.Code
    }

let ensureProductCategory( name : string ) : ProductCategoryDTO =
    ( new EnsureProductCategoryQuery() ).AsyncExecute(name) |> Async.RunSynchronously |> Seq.head |> convert2
