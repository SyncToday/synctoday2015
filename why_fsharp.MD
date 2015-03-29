
<a id="synctoday-1" > &nbsp; </a>
---

> Moving from C# to F# made us developing faster not only by typing less characters, but also by using great libraries
> available on GitHub e.g. type providers or Orleans. Also we removed `lock` completely so the app is faster.
> So to passphare Lightning McQueen: "Speed. I am speed." works for F# like a charm.

1. **Sync.Today**
2. [permalink](#synctoday-1)

We felt our C# Sync.Today 2013 started to become a huge monster with all the C# scripting, hooks etc.
At the same time it was not really providing us with the flexibility we needed to fulfil our customers' requirements.
Instead of just another round of refactoring we decided to start moving to F#. Since both languages share the same
common CLR, we did not throw everything away. We just started to simplify more and more because the F# code 
has much less lines (we had 146831x "{ or }", 56555x "Blank", 2770x "Null checks", 56194x "Comments" and finally
223502 "Useful lines")

At Kaggle we initially chose F# for our core data analysis algorithms because of its expressiveness. 
We've been so happy with the choice that we've found ourselves moving more and more of 
our application out of C# and into F#. The F# code is consistently shorter, easier to read, 
easier to refactor, and, because of the strong typing, contains far fewer bugs.

As our data analysis tools have developed, we've seen domain-specific constructs 
emerge very naturally; as our codebase gets larger, we become more productive. 

<div class="keywords">synchronization, integration, startup</div>
