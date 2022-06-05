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

=== Distrust_Highest ===
This is ridiculous….. U-21’s. This can’t be true. 
Even for this country, 50’000? They're still just kid’s at that point. How many parents have truly sent their pride and joy to a grinder? 
The government knows this yet willingly pumps out their propaganda. Tells us stories about “war heroes” all for this purpose. Our greed knows no bounds.
-> END

=== PublicOp_Highest ===
Goddamn…. Those stats are ridiculous I won’t deny it, but from what we’ve seen, it could be much worse and this is just U-21s to add, they’re extremely inexperienced to begin with. 
It’s sad to read but in all honesty, I think we’re doing extremely well with the resources we have.
-> END

=== PublicUnrest_Highest ===
Letting good young men die like this. Another stain on this country's history, but what does it matter when the carpets are drenched at this point? 
Nobody seems to listen to the common folk. 
They claimed to be doing this in our interests whenever they wanted our votes but at the end of the day we all know it's hollow, yet we do nothing about it. 
Nowadays, they don’t even need our votes to win an election, they could just rig it.
-> END