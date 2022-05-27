INCLUDE globals.ink

{ 
    - public_opinion <= 2: -> public_opinion_low 
    
    - public_opinion <= 7: -> public_opinion_med
    
    - else: -> public_opinion_high

}



=== public_opinion_low ===
Too many fraudulent companies nowadays. [News Company]? You’re right, that’s a perfect example. They are the cornerstone of corrupt media it seems like.
-> END

=== public_opinion_med
You heard of [News Company]? They’ve put out some decent stuff here and there. Nothing really too crazy but it’s still a 6/10 read I’d say.
-> END

=== public_opinion_high ===

[News Company] is great! The article today, last sunday, the one before that…….. This editor hasn’t missed it yet. Surely, they have to have some wizard in that office. 
-> END




