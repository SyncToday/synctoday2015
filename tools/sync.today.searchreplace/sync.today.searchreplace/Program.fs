open System.IO

let oldCnn = """Server=(localdb)\ProjectsV12; Database=SyncToday2015.new; Trusted_Connection=True;"""
let newCnn = """Server=xjawltgq7t.database.windows.net,1433;Database=travis;User ID=travis@xjawltgq7t;Password=pkvrzSeHp86KQktm;Trusted_Connection=False;Connection Timeout=30;"""

[<EntryPoint>]
let main argv = 
    let files = Directory.EnumerateFiles(".", "*.config", SearchOption.AllDirectories)
    for fileName in files do
        let content = File.ReadAllText( fileName )
        let replacedContent = content.Replace(oldCnn, newCnn)
        File.WriteAllText(fileName, replacedContent)
    0 // return an integer exit code
