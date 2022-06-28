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
With all this pro-refugee movement recently, it’s no surprise that tensions have increased to be honest. 
But to go this far… publicly humiliating someone just because of what? Where their from? It’s disgusting…
-> END

=== PublicOp_Highest ===
What’s the need for all this fighting? Conditions for refugees are improving slowly but surely but I’m not understanding why all this fighting is on-going. 
People will just always find a reason to hate one another I suppose.
-> END

=== PublicUnrest_Highest ===
With all this pro-refugee this and no refugee that, it’s no surprise that tensions have increased to be honest. But to go this far… publicly humiliating someone just because of what? 
Where their from? This is exactly why these riots and protests are happening nearly every other week.
-> END