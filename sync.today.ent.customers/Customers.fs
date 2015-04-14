module Customers

open Common
open FSharp.Data

type CustomersQuery = SqlCommandProvider<"Customers.sql", ConnectionStringName>
