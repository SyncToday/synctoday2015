
<a id="synctoday-1" > &nbsp; </a>
---

> Moving from C# to F# made us developing faster not only by typing less characters, but also by using great libraries
> available on GitHub e.g. type providers or Orleans. Also we removed `lock` completely so the app is faster.
> So to passphare Lightning McQueen: "Speed. I am speed." works for F# like a charm.

1. **Sync.Today**
2. [permalink](#synctoday-1)

At Kaggle we initially chose F# for our core data analysis algorithms because of its expressiveness. 
We've been so happy with the choice that we've found ourselves moving more and more of 
our application out of C# and into F#. The F# code is consistently shorter, easier to read, 
easier to refactor, and, because of the strong typing, contains far fewer bugs.

As our data analysis tools have developed, we've seen domain-specific constructs 
emerge very naturally; as our codebase gets larger, we become more productive. 

The fact that F# targets the CLR was also critical - even though we have a large existing 
code base in C#, getting started with F# was an easy decision because 
we knew we could use new modules right away. 

<div class="keywords">synchronization, integration, startup</div>
