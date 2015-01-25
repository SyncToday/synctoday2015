module Common

module Seq =
    let tryHead xs = xs |> Seq.tryPick Some
