open S22.Imap
let mutable client = null

[<EntryPoint>]
let main argv = 
    //printfn "%A" argv
    client <- new ImapClient("imap.gmail.com", 993, 
      "@gmail.com", "", AuthMethod.Login, true)    
    let uids = client.Search( SearchCondition.All() )
    for uid in uids do
        printfn "%A" uid
        let message = client.GetMessage(uid)
        printfn "%A" message.From 
    0 // return an integer exit code
