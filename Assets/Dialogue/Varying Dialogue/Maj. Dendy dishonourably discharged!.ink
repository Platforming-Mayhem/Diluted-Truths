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
Everything’s being exposed from this war. Companies, the military, even the government. It seems at this point even if we do win the war, it’ll be for naught. 
If the riots don’t start now, they’ll surely start after.
-> END

=== PublicOp_Highest ===
Wow. That’s insane. I don’t really know much about the military’s internal affairs but this seems a bit much. 
Makes you think what else could be going on behind closed doors.
-> END

=== PublicUnrest_Highest ===
Everything’s being exposed from this war. Companies, the military, even the government. It seems at this point even if we do win the war, it’ll be for naught. There already seems to be riots or protests every other day.
I seriously doubt this country will last way longer.
-> END