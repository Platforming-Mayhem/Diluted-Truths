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
The government sit behind their desks while we all destroy each other. It saddens me to think that my neighbour had to move country after all of this started.
They sit up in their offices without a care in the world as hate spreads rapidly. It's a crime that we even allowed them into office.
-> END

=== PublicOp_Highest ===
What’s the need for all this fighting? Conditions for refugees are improving slowly but surely but I’m not understanding why all this fighting is on-going. 
People will just always find a reason to hate one another I suppose.
-> END

=== PublicUnrest_Highest ===
These immigrants, all of them. They’ve caused us how much trouble? This is just one of the reported incidents. 
I heard from my friend just the other day about how one ‘em tried piping up to him about how he laughed at his face about needing donations. Smacked him he should have.
-> END