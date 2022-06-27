INCLUDE ..\globals.ink

{gov_distrust > public_unrest:
  {gov_distrust > public_opinion: ->Distrust_Highest}
}

{public_opinion > gov_distrust:
  {public_opinion > public_unrest: ->PublicOp_Highest}
}

{public_unrest > gov_distrust:
    test
  {public_unrest > public_opinion: ->PublicUnrest_Highest}
}
=== Distrust_Highest ===
Corruption is paid by the poor they said. 
The people in power just don’t seem to care at all, as long as the profits keep going up as people’s lives seem to flatline. 
It’s terrible, I’m ashamed to even mention I’m from here now whenever 
-> END

=== PublicOp_Highest ===
They just keep doing god’s work. Exposing the truth isn’t something you see nowadays too often at all.
It’s actually astonishing how they haven’t been prosecuted or an ‘accident’ occurred. 
However they manage, the ones behind this are heroes we don’t notice.
-> END

=== PublicUnrest_Highest ===
Let the chaos continue I say. 
Nobody can stand and watch while those at the top go free. 
It’s something no-one should go through, yet we all allowed it to fester for years. I say this is what we all shoud of expected.
-> END