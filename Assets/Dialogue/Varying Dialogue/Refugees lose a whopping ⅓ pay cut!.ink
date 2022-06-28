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
Hmm. A 1/3? For what? For them to put into their own bank accounts? 
Maybe they need it for bribes again. It’s been happening for years and people just act as if they’re using it for real reasons. 
I just can’t understand why nobody speaks out. 
A third. I can’t get that number out of my head for how much they’ve already taken from refugees here.
-> END

=== PublicOp_Highest ===
Well deserved! Selling drugs, theft, murder and such. 
That’s what their money gets invested into. I’ll agree for the slightest minority of them that do contribute to this country, it’ll hurt but in the long run this is easily the best option. 
Teach them how we do things around here.
-> END

=== PublicUnrest_Highest ===
Surely not. There’s no possible way in hell. 
Take is all they can do. But if I decide to take back, I’m labelled a terrorist, a criminal, a danger to society? 
All this hate, it's something that will plague not only my life but my kids and their kids. 
The day this cycle ends will be the day I can finally cry but for now, I have work to do
-> END