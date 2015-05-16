open System.IO

let oldCnn1 = """Server=(localdb)\ProjectsV12; Database=SyncToday2015.new; Trusted_Connection=True;"""
let oldCnn2 = """Data Source=kc8q88iui6.database.windows.net;Initial Catalog=sync.today.db.test;Integrated Security=False;User ID=sync.today;Password=Betpum57;Connect Timeout=60;Encrypt=False"""
let oldCnn3 = """Data Source=kc8q88iui6.database.windows.net;Initial Catalog=sync.today.db.test;Integrated Security=False;User ID=sync.today;Password=LJYjG6xqYASdDJxV;Connect Timeout=60;Encrypt=False"""

let newCnn = """Server=xjawltgq7t.database.windows.net,1433;Database=travis;User ID=travis@xjawltgq7t;Password=pkvrzSeHp86KQktm;Trusted_Connection=False;Connection Timeout=30;"""

[<EntryPoint>]
let main argv = 
    let files = Directory.EnumerateFiles(".", "*.config", SearchOption.AllDirectories)
    for fileName in files do
        let content = File.ReadAllText( fileName )
        let replacedContent1 = content.Replace(oldCnn1, newCnn)
        let replacedContent2 = replacedContent1.Replace(oldCnn2, newCnn)
        let replacedContent2 = replacedContent1.Replace(oldCnn3, newCnn)
        File.WriteAllText(fileName, replacedContent2)
    0 // return an integer exit code
