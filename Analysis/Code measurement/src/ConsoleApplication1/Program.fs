open System
open System.IO
open System.Text.RegularExpressions
open FSharp.Charting
open System.Windows.Forms

(*[omit:(SafeEnumerateFiles hidden for clarity)]*)
/// Enumerate files starting at a given path, having a given wildcard.
/// (Inaccessible directories are ignored.)
let SafeEnumerateFiles (path : string) (wildcard: string) =
    let safeEnumerate f path =
        try
            f(path)
        with
            | :? System.UnauthorizedAccessException -> Seq.empty

    let enumerateDirs = 
        safeEnumerate Directory.EnumerateDirectories

    let enumerateFiles =
        safeEnumerate (fun path -> Directory.EnumerateFiles(path, wildcard))

    let rec enumerate baseDir =
        seq {
            yield! enumerateFiles baseDir
        
            for dir in enumerateDirs baseDir do
                yield! enumerate dir
        }

    enumerate path
(*[/omit]*)

/// Return all the lines in files matching the given wildcard starting at the given path.
let FileLines path wildcard =
    SafeEnumerateFiles path wildcard
    |> Seq.map (fun fileName -> File.ReadAllLines(fileName))
    |> Seq.concat
    
/// Break down the sequence giving counts of lines matching each regex pattern.
let CountByPattern patterns lines =
    seq { for pattern in patterns do
              yield lines
                    |> Seq.filter (fun line -> Regex.IsMatch(line, pattern))
                    |> Seq.length
    }

/// Break down the given lines into counts by pattern, associating each count with a label.
let Analyze patternsLabels lines =
    let patterns, labels =
        patternsLabels |> Array.map fst,
        patternsLabels |> Array.map snd

    lines
    |> CountByPattern patterns
    |> Seq.zip labels

// Example:
// > AnalyzeCSharp @"D:\MyCode";;
// val it : (string * int) [] =
//   [|("{ or }", 25128); ("Blank", 18261); ("Null checks", 877);
//     ("Comments", 27103); ("Useful lines", 61343)|]
// > 

/// Analyze C# files starting at the given path, showing various forms of noise.
let AnalyzeCSharp path = 
    let lines = FileLines path "*.cs" |> Seq.cache
    let patternCounts = 
        lines
        |> Analyze [|
                       "(^([ \t]*)([{}])([ \t]*)$)",  "{ or }"
                       "(^[ \t]*$)",                  "Blank"
                       "(\=[ \t]*null)",              "Null checks"
                       "(^[ \t]*//)",                 "Comments"
                   |]
    let otherCount =  ["Useful lines", (lines |> Seq.length) - (patternCounts |> Seq.sumBy snd)]

    Seq.append patternCounts otherCount
    |> Array.ofSeq

[<EntryPoint>]
let main argv = 
    AnalyzeCSharp @"C:\Dev\univsync2sync.today" |> Seq.iter (fun x -> printf "%A " x)
    Console.ReadLine() |> ignore
    0