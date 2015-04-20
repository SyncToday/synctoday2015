module ProductCategoryMemberships

open Common
open FSharp.Data
open sync.today.Models

type private EnsureProductCategoryMembershipQuery = SqlCommandProvider<"EnsureProductCategoryMembership.sql", ConnectionStringName>

let private convert2( r : EnsureProductCategoryMembershipQuery.Record ) : ProductCategoryMembershipDTO  =
    {
        Id = r.Id;
        InternalId = r.InternalId;
        LastModified = r.LastModified;
        Category = r.Category;
        ProductId = r.ProductId;
        ProductCategoryId = r.ProductCategoryId;
    }

let ensureProductCategoryMembership( product : ProductDTO, category : ProductCategoryDTO ) : ProductCategoryMembershipDTO =
    ( new EnsureProductCategoryMembershipQuery() ).AsyncExecute(product.Id, category.Id) |> Async.RunSynchronously |> Seq.head |> convert2
