open Google.Apis.Auth.OAuth2.Responses
open Google.Apis.Auth.OAuth2
open Google.Apis.Auth.OAuth2.Flows
open Google.Apis.Calendar.v3
open Google.Apis.Services
open System
open System.IO

[<Literal>] 
let client_secret = "";
[<Literal>] 
let client_id = "";
[<Literal>] 
let Cred = "";

let generateStreamFromString (s:string) =
    let stream = new MemoryStream()
    let writer = new StreamWriter(stream)
    writer.Write(s)
    writer.Flush()
    stream.Seek( 0L, SeekOrigin.Begin ) |> ignore
    stream

[<EntryPoint>]
let main argv = 
    let refreshToken = Console.ReadLine()

    let token = new TokenResponse ( RefreshToken = refreshToken, Scope = CalendarService.Scope.Calendar )
    let credentials = new UserCredential(
                        new GoogleAuthorizationCodeFlow(
                            new GoogleAuthorizationCodeFlow.Initializer
                                (
                                    ClientSecrets = GoogleClientSecrets.Load(generateStreamFromString(Cred)).Secrets
                                )),
                        "user",
                        token
                      );
    let service = new CalendarService(new BaseClientService.Initializer(
                                            HttpClientInitializer = credentials,
                                            ApplicationName = ""
                                        ));
    let calendars = service.CalendarList.List().Execute().Items
    for calendar in calendars do
       printfn "%A" calendar.Summary
    Console.ReadLine() |> ignore
    0 // return an integer exit code

