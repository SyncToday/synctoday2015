module CustomerCategories

open Common
open FSharp.Data
open sync.today.Models

type private CustomerCategoriesQuery = SqlCommandProvider<"CustomerCategories.sql", ConnectionStringName>
type private EnsureCustomerCategoryQuery = SqlCommandProvider<"EnsureCustomerCategory.sql", ConnectionStringName>

let private convert( r : CustomerCategoriesQuery.Record ) : CustomerCategoryDTO  =
    { Id = r.Id; 
        InternalId  = r.InternalId;
        LastModified  = r.LastModified;
        Category = r.Category;
        Name = r.Name;
        Description = r.Description;
        Code = r.Code  }
let private convert2( r : EnsureCustomerCategoryQuery.Record ) : CustomerCategoryDTO  =
    { Id = r.Id; 
        InternalId  = r.InternalId;
        LastModified  = r.LastModified;
        Category = r.Category;
        Name = r.Name;
        Description = r.Description;
        Code = r.Code  }

let ensureCustomerCategory( name : string) : CustomerCategoryDTO =
    ( new EnsureCustomerCategoryQuery() ).AsyncExecute(name) |> Async.RunSynchronously |> Seq.head |> convert2

let getCustomerCategory( id : int) : CustomerCategoryDTO =
    ( new CustomerCategoriesQuery() ).AsyncExecute(id) |> Async.RunSynchronously |> Seq.head |> convert
