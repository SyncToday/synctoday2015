module ProductsSoldToCustomers

open Common
open FSharp.Data

type private ProductsSoldToCustomersQuery = SqlCommandProvider<"ProductsSoldToCustomers.sql", ConnectionStringName>
