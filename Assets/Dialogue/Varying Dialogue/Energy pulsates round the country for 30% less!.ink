INCLUDE ..\globals.ink

{gov_distrust > public_unrest:
  {gov_distrust> public_opinion: -> Distrust_Highest}
}

{public_opinion > gov_distrust:
  {public_opinion>public_unrest: -> PublicOp_Highest}
}

{public_unrest > gov_distrust:
  {public_unrest>public_opinion: -> PublicUnrest_Highest}
}

-> Distrust_Highest

=== Distrust_Highest ===
This could be an advertisement column for the government. Really, it's amazing that they managed to suck up to the government this much to the point of which even the editor can tell he’s going to receive hell for this, especially during times like these. 
It’s a shame how money corrupts us, I guess. Nothing to be done about agencies like these.
-> END

=== PublicOp_Highest ===
I can actually have my electronics on in my house for more than 30 minutes at a time now AND not go bankrupt for it? 
This is something that shouldn’t have happened in the first place, but with how this country usually does things I’m surprised they managed to fix it in such a reasonable time frame. 
Congratulations to them I guess.
-> END

=== PublicUnrest_Highest ===
This could be an advertisement column for the government. Really, it's amazing that they managed to suck up to the government this much to the point of which even the editor can tell he’s going to receive hell for this, especially during times like these. 
It’s a shame how money corrupts us, I guess. Nothing to be done about agencies like these.
-> END