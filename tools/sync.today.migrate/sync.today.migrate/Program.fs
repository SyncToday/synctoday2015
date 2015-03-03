module Main

[<EntryPoint>]
let main argv = 
    
    let oldUsers = OldDataConnection.users()
    let newUsers = ConsumerRepository.Consumers()

    0 // return an integer exit code
