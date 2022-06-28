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
LT. Johnson? I hear he’s the leader of a squad that burned down towns alone. He decided to abduct civilians and ransom them off for money. 
If anything, he's the last person in this world to be a “symbol” for this country. The only thing he fits is the description of a mercenary with frozen blood.
-> END

=== PublicOp_Highest ===
Crazy….. LT. Johnson. What a guy. Nearly 20 years of straight back to back service, that’s unprecedented. 
We need more youngsters to be like this truly I say. The people who serve this country aren’t treated with respect at all, it’s nice to see them being recognised for once outside an obituary.
-> END

=== PublicUnrest_Highest ===
LT. Johnson. Another target or even a hero. it seems like. Last 20 years? Doing nothing but oppressing and killing? What a wasted life. 
Nothing but war and death seems to have met this mind. No wonder people seem to simultaneously want this man dead or put in the country’s hall of fame. One of the most polarising figures to date it seems.
-> END