module CustomerCategories

open Common
open FSharp.Data

type CustomerCategoriesQuery = SqlCommandProvider<"CustomerCategories.sql", ConnectionStringName>
