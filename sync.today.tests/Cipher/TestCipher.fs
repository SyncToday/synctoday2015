module TestCipher

open NUnit.Framework
open FsUnit
open System.Threading.Tasks
open sync.today.cipher

[<TestFixture>] 
type ``encrypting and decrypting`` ()=
    //[<BeforeTest>] member x.

    let logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    [<TestFixtureSetUp>] member x.``Log Test At the beginning`` ()=         
        logger.Info("Test")

    [<Test>] 
    member x.``when I encrypt a string, it should not be null.`` ()=
        StringCipher.Encrypt("password", "username") |> should not' (be Null)

    [<Test>] 
    member x.``when I encrypt a string, it should not be same as one of the source strings.`` ()=
        let username = "username"
        let password = "password"
        let encrypted = StringCipher.Encrypt(password, username) 
        encrypted |> should not' (equal username)
        encrypted |> should not' (equal password)

    [<Test>] 
    member x.``when I encrypt a string, and decrypt it, it should be same as one of the source strings.`` ()=
        let username = "username"
        let password = "password"
        let encrypted = StringCipher.Encrypt(password, username) 
        let decrypted = StringCipher.Decrypt(encrypted, username)
        decrypted |> should equal password
