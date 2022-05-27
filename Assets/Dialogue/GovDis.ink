INCLUDE globals.ink

{ 
    - gov_distrust <= 2: -> gov_distrust_low 
    
    - gov_distrust <= 7: -> gov_distrust_med
    
    - else: -> gov_distrust_high

}



=== gov_distrust_low ===
What did I tell you? Vote for Sabron. Look at the country now, it’s easily at least 3x better, no 4x.
-> END

=== gov_distrust_med
Mhm. Really? They really passed that act? That’s poor…. I can’t really see what they're thinking right now.
-> END

=== gov_distrust_high ===

Damn. I guess you were right after all Zoe. This country really does get worse by the minute. 
-> END

