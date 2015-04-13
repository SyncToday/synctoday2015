open System.IO

let oldCnn = """Server=(localdb)\ProjectsV12; Database=SyncToday2015.new; Trusted_Connection=True;"""
let newCnn = """Data Source=kc8q88iui6.database.windows.net;Initial Catalog=sync.today.db.test;Integrated Security=False;User ID=sync.today;Password=Betpum57;Connect Timeout=60;Encrypt=False"""

[<EntryPoint>]
let main argv = 
    let files = Directory.EnumerateFiles(".", "*.config", SearchOption.AllDirectories)
    for fileName in files do
        let content = File.ReadAllText( fileName )
        let replacedContent = content.Replace(oldCnn, newCnn)
        File.WriteAllText(fileName, replacedContent)
    0 // return an integer exit code
