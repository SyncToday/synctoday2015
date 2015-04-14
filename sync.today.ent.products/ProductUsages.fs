module ProductUsages

open Common
open FSharp.Data
open sync.today.Models

type private EnsureProductUsageQuery = SqlCommandProvider<"EnsureProductUsage.sql", ConnectionStringName>

let private convert2( r : EnsureProductUsageQuery.Record ) : ProductUsageDTO  =
    {
        Id = r.Id;
        InternalId = r.InternalId;
        LastModified = r.LastModified;
        Category = r.Category;
        Name = r.Name;
        Description = r.Description;
        Code = r.Code
    }

let ensureProductUsage( name : string ) : ProductUsageDTO =
    ( new EnsureProductUsageQuery() ).AsyncExecute(name) |> Async.RunSynchronously |> Seq.head |> convert2
