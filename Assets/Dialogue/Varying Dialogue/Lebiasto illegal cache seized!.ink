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
They’ve gone this far? I know for a fact that nothing even signalling anything like this has been reported or even mentioned by anyone, but with the dying embers of this war all of sudden an illegal storage is found? This is atrocious the lengths they’ll go to.
-> END

=== PublicOp_Highest ===
Wow. This is amazing. Think of all the damage that could have been done not just to us but any human. If they’re willing to go this far, it turns out that the PM was right to go to war.
-> END

=== PublicUnrest_Highest ===
Illegal weaponry. It's insane to think just how this war can go. The fact that either government is potentially thinking about the use of things such as chemical warfare on it's own is already disgusting enough. 
I pray for the day in which the future generations will learn that war brings nothing good to this world.
-> END

