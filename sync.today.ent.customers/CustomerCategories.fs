module CustomerCategories

open Common
open FSharp.Data
open sync.today.Models

type CustomerCategoriesQuery = SqlCommandProvider<"CustomerCategories.sql", ConnectionStringName>

let convert( r : CustomerCategoriesQuery.Record ) : CustomerCategoryDTO  =
    { Id = r.Id; 
        InternalId  = r.InternalId;
        LastModified  = r.LastModified;
        Category = r.Category;
        Name = r.Name;
        Description = r.Description;
        Code = r.Code  }
