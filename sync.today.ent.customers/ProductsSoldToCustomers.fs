module ProductsSoldToCustomers

open Common
open FSharp.Data

type ProductsSoldToCustomersQuery = SqlCommandProvider<"ProductsSoldToCustomers.sql", ConnectionStringName>
