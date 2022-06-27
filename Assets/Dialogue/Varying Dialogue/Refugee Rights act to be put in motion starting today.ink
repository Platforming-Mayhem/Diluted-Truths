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
Finally, they’ve decided to actually get some good done in the country. Refugees are just supposed to magically survive on a day’s worth of pay for weeks at a time? 
Smart move, that should’ve been made earlier.
-> END

=== PublicOp_Highest ===
And this is why, I for one have faith in this place. 
Amazing act. Nothing really to say I guess, this should make living much easier for people.
-> END

=== PublicUnrest_Highest ===
They're starting to do some good?. Finally, it seems they finally listened to our cries.
Amazing act. Nothing really to say I guess, this should make living much easier for people.
-> END